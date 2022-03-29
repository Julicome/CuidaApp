using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Tipo_Documento: Entidad<int>
    {
        public string Abreviatura { get; set; }
        public string NombreTipoDocumento { get; set; }
    }
}
