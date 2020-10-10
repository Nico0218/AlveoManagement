using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Classes;
using DBProviderBase.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AlveoManagementServer.Services {
    public class ProjectService : IProjectService {
        private readonly ILogger<ProjectService> logger;
        private readonly IDataService dataService;

        public ProjectService(ILogger<ProjectService> logger, IDataService dataService) {
            this.logger = logger;
            this.dataService = dataService;
        }

        public List<Project> GetAllProjects() {
            logger.LogDebug("Getting all Projects");
            List<IParameter> parameters = new List<IParameter>();
            parameters.Add(new Parameter() { ColumnName = "gantttype", DataType = "System.String", Operator = DBProviderBase.Enums.ParamOperator.Equals, Value = "project" });
            List<GanttData> ganttData = dataService.GetObjectData<GanttData>(parameters);
            List<Project> projects = new List<Project>();
            foreach (var item in ganttData) {
                projects.Add(new Project() { 
                    ID = item.id.ToString(),
                    StartDate = item.start_date,
                    Duration = item.duration,
                    EndDate = item.end_date,
                    ProjectNumber = item.ProjectNumber,
                    ProjectLeader = item.ProjectLeader
                });
            }
            return projects;
        }
    }
}
