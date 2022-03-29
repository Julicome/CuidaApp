using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Genero_Repository: GenericRepository<Tbl_Genero>, ITbl_Genero
    {
        public Tbl_Genero_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
