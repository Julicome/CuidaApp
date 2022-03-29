using Aplication.Http.Dto;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Base.Mapping
{
    public class Visitas_Al_Medico_Mapping: Profile
    {
        public Visitas_Al_Medico_Mapping()
        {
            CreateMap<Tbl_Visitas_Al_Medico, Visitas_Al_Medico_Dto>()
                .ReverseMap();
        }
    }
}
