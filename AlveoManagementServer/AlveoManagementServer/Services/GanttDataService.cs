using AlveoManagementCommon.Classes;
using AlveoManagementCommon.Classes.Gantt_Classes;
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
                id = 1,
                text = "Zoar",
                start_date = "2020-09-04",
                duration = 2,
                color = "blue",
                end_date = "2020-09-06",
                progress = 0,
                parent = 0
            }
                  );
            ganttData.Add(new GanttData()
            {
                id = 2,
                text = "Finish Container Work",
                start_date = "2020-09-04",
                duration = 1,
                color = "yellow",
                parent = 1,
                end_date = "2020-09-05",
                progress = 0
            }
            );
            ganttData.Add(new GanttData()
            {
                id = 3,
                text = "Pack Items For Zoar",
                start_date = "2020-09-05",
                duration = 1,
                color = "red",
                parent = 1,
                end_date = "2020-09-06",
                progress = 0
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
                id = 1,
                source = 1,
                target = 2,
                type = "1"
            }
            );
            ganttLink.Add(new GanttLink()
            {
                id = 2,
                source = 2,
                target = 3,
                type = "0"
            }
            );
            return ganttLink;
        }
        public GanttObjWrapper CombineGanttData()
        {
            GanttObjWrapper ganttObjWrapper = new GanttObjWrapper();
            ganttObjWrapper.data = GetAllGanttData();
            ganttObjWrapper.links = GetAllGanttLinks();
            return ganttObjWrapper;
        }
    }


};