using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Seguimiento_Condicion_Repository: GenericRepository<Tbl_Seguimiento_Condicion>, ITbl_Seguimiento_Condicion
    {
        public Tbl_Seguimiento_Condicion_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
