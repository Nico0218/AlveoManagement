using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using DBProviderBase.Interfaces;
using DBProviderBase.Classes;
using System;
using System.Linq;

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

        private GanttData PersonToGanttProject(Personnel personnel, string startDate, string endDate) {
            return new GanttData() {
                id = personnel.ID,
                text = personnel.GetFullName(),
                start_date = startDate,
                duration = 0,
                color = personnel.Color,
                end_date = endDate,
                progress = 0, //TBC
                parent = "",
            };
        }

        public GanttObjWrapper CombineGanttDataPersonnel() {
            GanttObjWrapper ganttObjPersonnel = new GanttObjWrapper();

            List<IParameter> parameters = new List<IParameter>();
            parameters.Add(new Parameter() { ColumnName = "JobDescription", DataType = "System.String", Operator = DBProviderBase.Enums.ParamOperator.Equals, Value = "VloerBoy" });
            List<Personnel> personnel = dataService.GetObjectData<Personnel>(parameters);
            List<GanttData> ganttData = GetAllGanttData();

            foreach (Personnel person in personnel) {
                List<GanttData> tasks = ganttData.FindAll(ii => ii.personnel.Equals(person.ID, StringComparison.OrdinalIgnoreCase));
                tasks.Sort((firstDate, secondDate) => DateTime.Parse(firstDate.end_date).CompareTo(DateTime.Parse(secondDate.end_date)));
                string endDate = tasks.FirstOrDefault().end_date;
                tasks.Sort((firstDate, secondDate) => DateTime.Parse(firstDate.start_date).CompareTo(DateTime.Parse(secondDate.start_date)));
                string startDate = tasks.FirstOrDefault().start_date;                
                ganttObjPersonnel.data.Add(PersonToGanttProject(person, startDate, endDate));
                foreach (GanttData task in tasks) {
                    task.parent = person.ID;
                    task.color = person.Color;
                    ganttObjPersonnel.data.Add(task);
                }                
            }
            return ganttObjPersonnel;
        }
    }
};