using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Cliente_Repository: GenericRepository<Tbl_Cliente>, ITbl_Cliente
    {
        public Tbl_Cliente_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
