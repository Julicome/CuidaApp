using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Tipo_Sangre_Repository: GenericRepository<Tbl_Tipo_Sangre>, ITbl_Tipo_Sangre
    {
        public Tbl_Tipo_Sangre_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
