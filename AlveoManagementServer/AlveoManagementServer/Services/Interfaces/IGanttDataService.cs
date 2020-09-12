using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface IGanttDataService
    {
        List<GanttData> GetAllGanttData();

        List<GanttLink> GetAllGanttLinks();

    }
}
