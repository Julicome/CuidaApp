using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Familiar: Entidad<int>
    {
        public int? IdCliente { get; set; }
        public string NombresFamiliar { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
        public int? IdGenero { get; set; }
        public string Edad { get; set; }
        public int? IdTipoDeSangre { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string NombreEPS { get; set; }
        public string RegimenEPS { get; set; }
        public string Direccion { get; set; }
    }
}
