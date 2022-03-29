using Aplication.Http.Dto;
using Aplication.Http.Request;
using AutoMapper;
using Domain.Entities;

namespace Aplication.Base.Mapping
{
    public class ClientMapping : Profile
    {
        public ClientMapping()
        {
            CreateMap<Tbl_Cliente, ClientDto>()
                .ReverseMap();

            CreateMap<ClientRequest, Tbl_Cliente>()
               .ReverseMap();
        }
    }
}
