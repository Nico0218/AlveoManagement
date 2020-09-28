using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> logger;

        public CustomerService(ILogger<CustomerService> logger)
        {
            this.logger = logger;
        }


        public List<Customer> GetAllCustomerData()
        {
            logger.LogDebug("Getting all Customer information");
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer()
            {
                id = 1,
                name = "Customer 1",
                addrLine1 = "test str 1",
                addrLine2 = "Strand, gantz plaza, 7140",
                taxNumber = "259845632574",
                contactNumber = "021 548 6589",
                email = "customer1@mail.com",
                customerID = "cust-id-01"
            }
                  );
            customer.Add(new Customer()
            {
                id = 2,
                name = "Customer 2",
                addrLine1 = "test str 2",
                addrLine2 = "Strand, gantz plaza, 7140",
                taxNumber = "25648572154",
                contactNumber = "021 548 4856",
                email = "customer2@mail.com",
                customerID = "cust-id-02"
            }
                  );
            customer.Add(new Customer()
            {
                id = 3,
                name = "Customer 3",
                addrLine1 = "test str 3",
                addrLine2 = "Strand, gantz plaza, 7140",
                taxNumber = "21548565895",
                contactNumber = "021 658 9512",
                email = "customer3@mail.com",
                customerID = "cust-id-03"
            }
                  );
            return customer;
        }
    }
}
