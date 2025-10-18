using ApiTest.Data;
using ApiTest.Src.Customer.Dto;
using ApiTest.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Src.Customer
{
    public class CustomerServices(ApplicationDbContext context, IMapper mapper) : Service<CustomerModel, CreateCustomerDto, UpdateCustomerDto>(context, mapper)
    {
        private readonly ApplicationDbContext _context = context;

        public OkResult CreateCustomer(CreateCustomerDto dto)
        {
            var existing = _context.Customers
                                .FirstOrDefault(c => c.DocumentNumber == dto.DocumentNumber);
            if (existing != null)
                throw new ArgumentException("Customer with the same document number already exists.");

            var entity = mapper.Map<CustomerModel>(dto);

            _context.Customers.Add(entity);
            _context.SaveChanges();

            return new OkResult { Ok = true };
        }

   
    }
}
