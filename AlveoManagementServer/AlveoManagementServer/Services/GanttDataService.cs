using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data.SQLite;
using System;
using AlveoManagementServer.SQLite;
using System.Linq;

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
                        ID = selectResult["id"].ToString(),
                        text = (string)selectResult["text"],
                        start_date = (string)selectResult["startDate"],
                        duration = (int)(Int64)selectResult["duration"],
                        color = (string)selectResult["color"],
                        end_date = (string)selectResult["endDate"],
                        progress = (int)(double)selectResult["progress"],
                        parent = (int)(Int64)selectResult["parent"],
                        personnel = (string)selectResult["personnel"],
                        gantttype = (string)selectResult["gantttype"]
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return ganttData;
        }

        public List<GanttLink> GetAllGanttLinks()
        {
            logger.LogDebug("Getting all gantt links");
            List<GanttLink> ganttLink = new List<GanttLink>();
            string selectLinks = "SELECT * FROM GanttLinks";
            SQLiteCommand selectCommand = new SQLiteCommand(selectLinks, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    ganttLink.Add(new GanttLink()
                    {
                        ID = selectResult["id"].ToString(),
                        source = (Int32)(Int64)selectResult["source"],
                        target = (Int32)(Int64)selectResult["target"],
                        type = (string)selectResult["type"],
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

        public GanttObjWrapper CombineGanttDataPersonnel()
        {
            GanttObjWrapper ganttObjPersonnel = new GanttObjWrapper();
            List<GanttData> ganttData = GetAllGanttData();
            List<GanttData> newGanttData = new List<GanttData>();
            List<GanttLink> newGanttLink = new List<GanttLink>();
            var count = 1;
            for (var index = 0; index < ganttData.Count; index++)
            {
                if (ganttData[index].gantttype == "task")
                {
                    if (newGanttData.Count == 0)
                    {
                        newGanttData.Add(new GanttData()
                        {
                            ID = count.ToString(),
                            text = ganttData[index].personnel,
                            start_date = ganttData[index].start_date,
                            duration = ganttData[index].duration,
                            color = ganttData[index].color,
                            end_date = ganttData[index].end_date,
                            progress = ganttData[index].progress,
                            parent = 0,
                        }
                        );
                        count = count + 1;
                    }
                    else
                    {
                        for (var i = 0; i < newGanttData.Count; i++)
                        {
                            if (ganttData[index].personnel != newGanttData[i].text)
                            {
                                newGanttData.Add(new GanttData()
                                {
                                    ID = count.ToString(),
                                    text = ganttData[index].personnel,
                                    start_date = ganttData[index].start_date,
                                    duration = ganttData[index].duration,
                                    color = ganttData[index].color,
                                    end_date = ganttData[index].end_date,
                                    progress = ganttData[index].progress,
                                    parent = 0,
                                }
                                );
                                count = count + 1;
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


