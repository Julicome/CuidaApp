using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Condiciones_Usuario_Repository: GenericRepository<Tbl_Condiciones_Usuario>, ITbl_Condiciones_Usuario
    {
        public Tbl_Condiciones_Usuario_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
