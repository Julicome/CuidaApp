using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Condiciones_Usuario: Entidad<int>
    {
        public int? IdCliente { get; set; }
        public int? IdCondicion { get; set; }
        public string Sintoma { get; set; }
        public string Descripcion { get; set; }
    }
}
