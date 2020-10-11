using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface IGanttDataService
    {
        List<GanttData> GetAllGanttData();

        List<GanttLink> GetAllGanttLinks();

        GanttObjWrapper CombineGanttData();

        GanttObjWrapper CombineGanttDataPersonnel();

        void SaveProject(Project project);

        void SaveTask(Task task);
    }
}
