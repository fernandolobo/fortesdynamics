using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

namespace Webhook
{
    public sealed class WebhookPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService =
                (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            try
            {
                try
                {
                    Microsoft.Xrm.Sdk.IPluginExecutionContext context = (Microsoft.Xrm.Sdk.IPluginExecutionContext)
                        serviceProvider.GetService(typeof(Microsoft.Xrm.Sdk.IPluginExecutionContext));

                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    var contexto = new OrganizationServiceContext(service);
                    
                    string json = "";
                    if (context.InputParameters.Contains("OpportunityClose") &&
                        context.InputParameters["OpportunityClose"] is Entity)
                    {
                        Entity oppClose = (Entity)context.InputParameters["OpportunityClose"];
                        var opp = new OpportunityLocal();
                        if (oppClose.Attributes.Contains("opportunityid"))
                        {
                            //Pega a referência da oportunidade que está sendo fechada            
                            var oppRef = (EntityReference)oppClose["opportunityid"];
                            //Recupera todos os campos da oportunidade            
                            var opportunityWin = service.Retrieve(oppRef.LogicalName, oppRef.Id, new ColumnSet(true));
                            //Atribuir os valores da oportunidade
                            opp.SetOpportunityLocal(opportunityWin);
                        }

                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(OpportunityLocal));
                            serializer.WriteObject(memoryStream, opp);
                            json = Encoding.Default.GetString(memoryStream.ToArray());
                        }

                        string URI = "http://posttestserver.com/post.php?dir=xiaoxiao";

                        using (WebClient wc = new WebClient())
                        {
                            wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                            string HtmlResult = wc.UploadString(URI, json);
                            //throw new InvalidPluginExecutionException(HtmlResult);
                        }

                    }
                }

                catch (WebException exception)
                {
                    string str = string.Empty;
                    if (exception.Response != null)
                    {
                        using (StreamReader reader =
                            new StreamReader(exception.Response.GetResponseStream()))
                        {
                            str = reader.ReadToEnd();
                        }
                        exception.Response.Close();
                    }
                    if (exception.Status == WebExceptionStatus.Timeout)
                    {
                        throw new InvalidPluginExecutionException(
                            "The timeout elapsed while attempting to issue the request.", exception);
                    }
                    throw new InvalidPluginExecutionException(String.Format(CultureInfo.InvariantCulture,
                        "A Web exception occurred while attempting to issue the request. {0}: {1}",
                        exception.Message, str), exception);
                }
            }
            catch (Exception e)
            {
                tracingService.Trace("Exception: {0}", e.ToString());
                throw;
            }
        }
    }
}
