using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> logger;
        private readonly ICustomerService customerService;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService)
        {
            this.logger = logger;
            this.customerService = customerService;
        }

        [HttpGet("GetAllCustomerData")]
        public ActionResult GetAllCustomerData()
        {
            logger.LogInformation("Getting all Customer information");
            return new ObjectResult(customerService.GetAllCustomerData());
        }
    }
}
