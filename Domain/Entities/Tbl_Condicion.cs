using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Tbl_Condicion : Entidad<int>
    {

        public string NombreCondicion { get; set; }
        public string DescripcionCondicion { get; set; }
    }
}
