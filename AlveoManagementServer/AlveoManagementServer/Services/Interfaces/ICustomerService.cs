using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomerData();

    }
}
