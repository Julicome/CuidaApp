using Domain.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Tbl_Visitas_Al_Medico: Entidad<int>
    {
        public int? IdCliente { get; set; }
        public string NombreCita { get; set; }
        public string Doctor { get; set; }
        public string IPS { get; set; }
        public DateTime? FechaCita { get; set; }
        public string Observacion { get; set; }

        public Task Edit(Tbl_Visitas_Al_Medico tbl_Visitas_Al_Medico)
        {
            throw new NotImplementedException();
        }
    }
}
