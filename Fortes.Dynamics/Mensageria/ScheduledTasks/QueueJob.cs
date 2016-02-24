using Quartz;
using System;
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
                Task.Run(() => AGService.getIAGService().Eco(new MicrosoftQueue().MessageReceiver()));
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}