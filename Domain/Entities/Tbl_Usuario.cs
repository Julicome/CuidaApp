using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Usuario: Entidad<int>
    {
        public int? IdCliente { get; set; }
        public string Contraseña { get; set; }
        public string NombreUsuario { get; set; }
    }
}
