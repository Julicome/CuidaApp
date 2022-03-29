using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Indicadores_De_Salud_Repository: GenericRepository<Tbl_Indicadores_De_Salud>, ITbl_Indicadores_De_Salud
    {
        public Tbl_Indicadores_De_Salud_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
