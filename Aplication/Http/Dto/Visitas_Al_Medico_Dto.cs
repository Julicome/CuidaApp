using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Http.Dto
{
    public class Visitas_Al_Medico_Dto
    {
        public int? IdCliente { get; set; }
        public string NombreCita { get; set; }
        public string Doctor { get; set; }
        public string IPS { get; set; }
        public DateTime? FechaCita { get; set; }
        public string Observacion { get; set; }
    }
}
