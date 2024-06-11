using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public CustomerRepository(ApplicationDbContext dbContext) {
            _dbcontext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetCustomerAsync()
        {
            return await _dbcontext.customers.ToListAsync();
        }
    }
}
