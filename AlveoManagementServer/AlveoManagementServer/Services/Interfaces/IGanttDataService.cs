using AlveoManagementCommon.Classes;
using AlveoManagementCommon.Classes.Gantt_Classes;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface IGanttDataService
    {
        List<GanttData> GetAllGanttData();

        List<GanttLink> GetAllGanttLinks();

        GanttObjWrapper CombineGanttData();

    }
}
