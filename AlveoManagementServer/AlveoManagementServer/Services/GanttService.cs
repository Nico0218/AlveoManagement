using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class GanttService : IGanttService
    {
        private readonly ILogger<GanttService> logger;

        public GanttService(ILogger<GanttService> logger)
        {
            this.logger = logger;
        }


        public List<Gantt> GetAllGanttData()
        {
            logger.LogDebug("Getting all gantt data");
            List<Gantt> gantt = new List<Gantt>();
            gantt.Add(new Gantt()
            {
                ID = 1,
                Text = "JIJI",
                Start_Date = "01/11/19",
                Duration = 2,
                Progress = 0,
                Parent = 0,
                Color = "pink"
            }
                  );
            return gantt;
        }
    }
}