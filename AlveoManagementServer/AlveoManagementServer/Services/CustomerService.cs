using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> logger;
        private readonly IDataService dataService;

        public CustomerService(ILogger<CustomerService> logger, IDataService dataService)
        {
            this.logger = logger;
            this.dataService = dataService;
        }

        public List<Customer> GetAllCustomerData()
        {
            logger.LogDebug("Getting all Customer information");
            return dataService.GetObjectData<Customer>();
        }
        
    }
}
