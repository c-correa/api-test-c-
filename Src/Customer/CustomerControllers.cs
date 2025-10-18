using ApiTest.Src.Customer.Dto;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Src.Customer
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController(CustomerServices customerServices) : BaseController<CustomerModel, CreateCustomerDto, UpdateCustomerDto>(customerServices)
    {
        private readonly CustomerServices _customerServices = customerServices;

        [HttpPost("create")]
        public IActionResult CreateCustomer([FromBody] CreateCustomerDto dto)
        {
            var result = SafeExecutor.Execute(() => _customerServices.CreateCustomer(dto));
            return Ok(result);
        }
    }
}
