using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Documento_Repository: GenericRepository<Tbl_Documento>, ITbl_Documento
    {
        public Tbl_Documento_Repository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
