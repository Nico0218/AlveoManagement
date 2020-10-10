using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using AlveoManagementServer.SQLite;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AlveoManagementServer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> logger;

        public CustomerService(ILogger<CustomerService> logger)
        {
            this.logger = logger;
        }


        Database databaseObject = new Database();

        public List<Customer> GetAllCustomerData()
        {
            logger.LogDebug("Getting all Customer information");
            List<Customer> customer = new List<Customer>();
            string selectQuery = "SELECT * FROM Customers";
            SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    Console.WriteLine("name: {0} - customerID: {1}", selectResult["name"], selectResult["custID"]);
                    customer.Add(new Customer()
                    {
                        ID = selectResult["id"].ToString(),
                        Name = (string)selectResult["name"],
                        addrLine1 = (string)selectResult["addr1"],
                        addrLine2 = (string)selectResult["addr2"],
                        taxNumber = (string)selectResult["taxNumber"],
                        contactNumber = (string)selectResult["contactNumber"],
                        email = (string)selectResult["email"],
                        customerID = (string)selectResult["custID"]
                    }
                    );
                    Console.WriteLine("done");
                }
            }
            databaseObject.CloseConnection();
            return customer;
        }
        
    }
}
