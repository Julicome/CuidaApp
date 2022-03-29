using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Tipo_Sangre: Entidad<int>
    {
        public string NombreTipoSangre { get; set; }
    }
}
