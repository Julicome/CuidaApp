using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Visitas_Al_Medico_Repository: GenericRepository<Tbl_Visitas_Al_Medico>, ITbl_Visitas_Al_Medico
    {
        public Tbl_Visitas_Al_Medico_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
