using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Seguimiento_Condicion: Entidad<int>
    {
        public int? IdCondicionUsuario { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? FechaSeguimiento { get; set; }
        public string Seguimiento { get; set; }
    }
}
