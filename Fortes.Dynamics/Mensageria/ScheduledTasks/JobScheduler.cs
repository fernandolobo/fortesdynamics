using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mensageria.ScheduledTasks
{
    public class JobScheduler
    {
        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<QueueJob>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithSimpleSchedule
                  (s =>
                     s.WithIntervalInSeconds(20)
                     .RepeatForever()
                  )
                .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}