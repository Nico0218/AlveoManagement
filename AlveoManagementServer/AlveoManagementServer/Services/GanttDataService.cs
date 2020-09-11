using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class GanttDataService : IGanttDataService
    {
        private readonly ILogger<GanttDataService> logger;

        public GanttDataService(ILogger<GanttDataService> logger)
        {
            this.logger = logger;
        }


        public List<GanttData> GetAllGanttData()
        {
            logger.LogDebug("Getting all gantt data");
            List<GanttData> ganttData = new List<GanttData>();
            ganttData.Add(new GanttData()
            {
                ID = 1,
                Text = "Zoar",
                Start_Date = "2020-09-04",
                Duration = 2,
                Progress = 0,
                Parent = 0,
                End_Date = "2020-09-06",
                Color = "pink"
            }
                  );
            ganttData.Add(new GanttData()
            {
                ID = 2,
                Text = "task 1",
                Start_Date = "2020-09-04",
                Duration = 1,
                Progress = 0,
                Parent = 1,
                End_Date = "2020-09-05",
                Color = "red"
            }
      );
            ganttData.Add(new GanttData()
            {
                ID = 1,
                Text = "Task 2",
                Start_Date = "2020-09-05",
                Duration = 1,
                Progress = 0,
                Parent = 1,
                End_Date = "2020-09-06",
                Color = "blue"
            }
      );
            return ganttData;
        }

        public List<GanttLink> GetAllGanttLinks()
        {
            logger.LogDebug("Getting all gantt links");
            List<GanttLink> ganttLink = new List<GanttLink>();
            ganttLink.Add(new GanttLink()
            {
                ID = 1,
                Source = 1,
                Target = 2,
                Type = "1",
            }
            );
            ganttLink.Add(new GanttLink()
            {
                ID = 2,
                Source = 2,
                Target = 3,
                Type = "0",
            }
);
            return ganttLink;
        }
        
    }
};