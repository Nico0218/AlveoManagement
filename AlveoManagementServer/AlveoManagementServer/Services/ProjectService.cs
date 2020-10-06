using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlveoManagementServer.SQLite;

namespace AlveoManagementServer.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ILogger<ProjectService> logger;

        public ProjectService(ILogger<ProjectService> logger)
        {
            this.logger = logger;
        }


        Database databaseObject = new Database();

        public List<Project> GetAllProjects()
        {
            logger.LogDebug("Getting all Projects");
            List<Project> project = new List<Project>();
            string selectProject = "SELECT * FROM GanttData WHERE type='project'";
            SQLiteCommand selectCommand = new SQLiteCommand(selectProject, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    project.Add(new Project()
                    {
                        ID = (int)(Int64)selectResult["id"],
                        Name = (string)selectResult["text"],
                        StartDate = (string)selectResult["startDate"],
                        Duration = (Int32)(Int64)selectResult["duration"],
                        EndDate = (string)selectResult["endDate"],
                        ProjectNumber = (string)selectResult["projectNumber"],
                        ProjectLeader = (string)selectResult["projectLeader"]
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return project;
        }
    }
}
