using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Cliente : Entidad<int>
    {
        public string NombresCliente { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdGenero { get; set; }
        public string Edad { get; set; }
        public int? IdTipoSangre { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NombreEps { get; set; }
        public string RegimenEps { get; set; }
        public string Foto { get; set; }
    }
}
