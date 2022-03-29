using Domain.Entities;
using Domain.Repository;
using Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class Tbl_Categoria_Documentos_Repository: GenericRepository<Tbl_Categoria_Documentos>, ITbl_Categoria_Documentos
    {
        public Tbl_Categoria_Documentos_Repository(IDbContext  dbContext):base(dbContext)
        {
        }
    }
}
