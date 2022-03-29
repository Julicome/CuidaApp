using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Familiar_Repository: GenericRepository<Tbl_Familiar>, ITbl_Familiar
    {
        public Tbl_Familiar_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
