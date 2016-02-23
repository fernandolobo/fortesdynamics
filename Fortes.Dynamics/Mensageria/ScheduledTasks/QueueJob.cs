using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mensageria.AGWebReferenceLocal;
using System.Text;

namespace Mensageria.ScheduledTasks
{
    public class QueueJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                IAGservice AGService = new IAGservice();
                var teste = AGService.Eco("Teste");
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}