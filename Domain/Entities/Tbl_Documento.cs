using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Documento: Entidad<int>
    {
        public int? IdCategoria { get; set; }
        public int? IdCliente { get; set; }
        public string NombreDocumento { get; set; }
        public string DescripcionDocumento { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public string IPS { get; set; }
        public string Foto { get; set; }
    }
}
