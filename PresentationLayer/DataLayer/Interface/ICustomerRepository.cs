﻿using DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomerAsync();
    }
}
