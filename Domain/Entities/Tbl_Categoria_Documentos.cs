using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Categoria_Documentos: Entidad<int>
    {
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
    }
}
