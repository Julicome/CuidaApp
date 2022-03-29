using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Indicadores_De_Salud: Entidad<int>
    {
        public int? IdCondicion { get; set; }
        public int? IdCliente { get; set; }
        public string NombreIndicador { get; set; }
        public int? CantidadIndicador { get; set; }
        public int? IdNivelIndicador { get; set; }
    }
}
