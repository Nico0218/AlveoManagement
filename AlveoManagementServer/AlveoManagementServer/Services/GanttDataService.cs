using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using DBProviderBase.Interfaces;

namespace AlveoManagementServer.Services {
    public class GanttDataService : IGanttDataService {
        private readonly ILogger<GanttDataService> logger;
        private readonly IDataService dataService;

        public GanttDataService(ILogger<GanttDataService> logger, IDataService dataService) {
            this.logger = logger;
            this.dataService = dataService;
        }

        public List<GanttData> GetAllGanttData() {
            logger.LogDebug("Getting all gantt data");
            return dataService.GetObjectData<GanttData>();
        }

        public List<GanttLink> GetAllGanttLinks() {
            logger.LogDebug("Getting all gantt links");
            return dataService.GetObjectData<GanttLink>();
        }
        public GanttObjWrapper CombineGanttData() {
            GanttObjWrapper ganttObjWrapper = new GanttObjWrapper();
            ganttObjWrapper.data = GetAllGanttData();
            ganttObjWrapper.links = GetAllGanttLinks();
            return ganttObjWrapper;
        }

        public GanttObjWrapper CombineGanttDataPersonnel() {
            GanttObjWrapper ganttObjPersonnel = new GanttObjWrapper();
            List<GanttData> ganttData = GetAllGanttData();
            List<GanttData> newGanttData = new List<GanttData>();
            List<GanttLink> newGanttLink = new List<GanttLink>();
            var count = 1;
            for (var index = 0; index < ganttData.Count; index++) {
                if (ganttData[index].gantttype == "task") {
                    if (newGanttData.Count == 0) {
                        newGanttData.Add(new GanttData() {
                            id = count.ToString(),
                            text = ganttData[index].personnel,
                            start_date = ganttData[index].start_date,
                            duration = ganttData[index].duration,
                            color = ganttData[index].color,
                            end_date = ganttData[index].end_date,
                            progress = ganttData[index].progress,
                            parent = "",
                        }
                        );
                        count = count + 1;
                    } else {
                        for (var i = 0; i < newGanttData.Count; i++) {
                            if (ganttData[index].personnel != newGanttData[i].text) {
                                newGanttData.Add(new GanttData() {
                                    id = count.ToString(),
                                    text = ganttData[index].personnel,
                                    start_date = ganttData[index].start_date,
                                    duration = ganttData[index].duration,
                                    color = ganttData[index].color,
                                    end_date = ganttData[index].end_date,
                                    progress = ganttData[index].progress,
                                    parent = "",
                                }
                                );
                                count++;
                            }
                        }
                    }
                }

            }
            ganttObjPersonnel.data = newGanttData;
            ganttObjPersonnel.links = newGanttLink;
            return ganttObjPersonnel;
        }
    }
};