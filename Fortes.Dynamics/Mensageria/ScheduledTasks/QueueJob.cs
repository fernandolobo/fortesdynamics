using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mensageria.AGWebReferenceLocal;
using Mensageria.Queue;
using Mensageria.FortesAG;
using System.Threading.Tasks;

namespace Mensageria.ScheduledTasks
{
    public class QueueJob : IJob
    {



        public void Execute(IJobExecutionContext context)
        {
            try
            {
                //string teste;
                //IAGservice AGService = new IAGservice();
                //Task.Run(() => teste = AGService.Eco(new MicrosoftQueue().MessageReceiver()));

                string teste;
                Task.Run(() => teste = AGService.getIAGService().Eco(new MicrosoftQueue().MessageReceiver()));
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}