using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Nivel_Indicador_Repository: GenericRepository<Tbl_Nivel_Indicador>, ITbl_Nivel_Indicador
    {
        public Tbl_Nivel_Indicador_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
