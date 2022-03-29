using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Tbl_Genero: Entidad<int>
    {
        public int IdGenero { get; set; }
        public string Genero { get; set; }
    }
}
