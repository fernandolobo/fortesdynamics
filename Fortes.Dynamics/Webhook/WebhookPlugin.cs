using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

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
                    IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    var contexto = new OrganizationServiceContext(service);

                    string json = string.Empty;
                    if (context.InputParameters.Contains("OpportunityClose") &&
                        context.InputParameters["OpportunityClose"] is Entity)
                    {
                        Entity oppClose = (Entity)context.InputParameters["OpportunityClose"];
                        var opp = new OpportunityLocal();
                        var aco = new AccountLocal();
                        opp.accountlocal = aco;
                        opp.productopportunitylocal = new List<ProductOpportunityLocal>();
                        if (oppClose.Attributes.Contains("opportunityid"))
                        {
                            //Pega a referência da oportunidade que está sendo fechada            
                            var oppRef = (EntityReference)oppClose["opportunityid"];
                            //Recupera todos os campos da oportunidade            
                            var opportunityWin = service.Retrieve(oppRef.LogicalName, oppRef.Id, new ColumnSet(true));
                            //Atribuir os valores da oportunidade
                            opp.SetOpportunityLocal(opportunityWin);

                            if (opportunityWin.Attributes.ContainsKey("parentaccountid"))
                            {
                                //Pega a referência da conta
                                var acoRef = (EntityReference)opportunityWin["parentaccountid"];
                                //Recupera produtos da oportunidade
                                var opportunityWinAccount = service.Retrieve("account", acoRef.Id, new ColumnSet(true));
                                //Atribuir os valores da conta
                                aco.SetAccountLocal(opportunityWinAccount);

                                //Montar Oportunidade
                                opp.accountlocal = aco;
                            }

                            QueryExpression opportunityProductsQuery = new QueryExpression
                            {
                                EntityName = OpportunityProduct.EntityLogicalName,
                                ColumnSet = new ColumnSet(true),
                                Criteria = new FilterExpression
                                {
                                    Conditions =
                                {
                                    new ConditionExpression
                                    {
                                        AttributeName = "opportunityid",
                                        Operator = ConditionOperator.Equal,
                                        Values = { oppRef.Id }
                                    }
                                }
                                }
                            };

                            DataCollection<Entity> opportunityProducts = service.RetrieveMultiple(opportunityProductsQuery).Entities;
                            foreach (Entity entity in opportunityProducts)
                            {
                                OpportunityProduct opportunityProduct = (OpportunityProduct)entity;
                                var pop = new ProductOpportunityLocal();
                                pop.SetProductOpportunityLocal(opportunityProduct);
                                opp.productopportunitylocal.Add(pop);
                            }
                        }

                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(OpportunityLocal));
                            serializer.WriteObject(memoryStream, opp);
                            json = Encoding.UTF8.GetString(memoryStream.ToArray());
                        }


                        string URI = "http://posttestserver.com/post.php?dir=xiaoxiao";

                        using (WebClient wc = new WebClient())
                        {
                            string responseJson = string.Empty;
                            wc.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                            wc.Headers[HttpRequestHeader.Accept] = "application/json; charset=utf-8";

                            string HtmlResult = wc.UploadString(URI, json);
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
