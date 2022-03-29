using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Nivel_Indicador: Entidad<int>
    {
        public string NombreIndicador { get; set; }
        public string DescripcionIndicador { get; set; }
    }
}
