using ReOrg.Data;
using ReOrg.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReOrg.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly REDbContext _context;
        public CustomerService(REDbContext context)
        {
            _context = context;
        }
        public void UpdatetoDbAsync(string E)
        {

            var newemail = new Email()
            {
                Id = System.Guid.NewGuid(),
                email = E,
            };
            _context.EMAIL.Add(newemail);
            _context.SaveChanges();
        }
    }
}
