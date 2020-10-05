using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data.SQLite;
using System;
using AlveoManagementServer.SQLite;

namespace AlveoManagementServer.Services
{
    public class GanttDataService : IGanttDataService
    {
        private readonly ILogger<GanttDataService> logger;

        public GanttDataService(ILogger<GanttDataService> logger)
        {
            this.logger = logger;
        }

        Database databaseObject = new Database();

        public List<GanttData> GetAllGanttData()
        {
            logger.LogDebug("Getting all gantt data");
            List<GanttData> ganttData = new List<GanttData>();
            string selectData = "SELECT * FROM GanttData";
            SQLiteCommand selectCommand = new SQLiteCommand(selectData, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    ganttData.Add(new GanttData()
                    {
                        id = (int)(Int64)selectResult["id"],
                        text = (string)selectResult["text"],
                        start_date = (string)selectResult["startDate"],
                        duration = (int)(Int64)selectResult["duration"],
                        color = (string)selectResult["color"],
                        end_date = (string)selectResult["endDate"],
                        progress = (int)(double)selectResult["progress"],
                        parent = (int)(Int64)selectResult["parent"]
                    }
                    );
                    Console.WriteLine("done");
                }
            }
            databaseObject.CloseConnection();
            return ganttData;
        }

        public List<GanttLink> GetAllGanttLinks()
        {
            logger.LogDebug("Getting all gantt links");
            List<GanttLink> ganttLink = new List<GanttLink>();
            string selectLinks = "SELECT * FROM GanttData";
            SQLiteCommand selectCommand = new SQLiteCommand(selectLinks, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    ganttLink.Add(new GanttLink()
                    {
                        id = (int)(Int64)selectResult["id"],
                        //source = (int)(Int64)selectResult["source"],
                        //target = (int)(Int64)selectResult["target"],
                        //type = (string)selectResult["type"]
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
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


