using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities.Common;
using ECommerceApi.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistance.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer> , ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceApiDbContext context) : base(context)
        {
        }
    }
}
