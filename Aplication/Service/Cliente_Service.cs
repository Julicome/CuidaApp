using Aplication.Base;
using Aplication.Helpers;
using Aplication.Http.Dto;
using Aplication.Http.Request;
using AutoMapper;
using Domain.Common;
using Domain.Configuration;
using Domain.Entities;
using Domain.Repository;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public class Cliente_Service : CustomService<Tbl_Cliente>, ITbl_Cliente_Service
    {
        private readonly ITbl_Cliente _tbl_Cliente;
        public Cliente_Service(IUnitOfWorkRepository unitOfWorkRepository, IMapper mapper) : base(unitOfWorkRepository, mapper)
        {
            _tbl_Cliente = unitOfWorkRepository.Tbl_Cliente;
        }
            
        public async Task<Response<ClientDto>> ObtenerCliente()
        {
            Tbl_Cliente client = await _unitOfWork.Tbl_Cliente.GetById(1);
            ClientDto clientDto = _mapper.Map<ClientDto>(client);
            return Response<ClientDto>.CreateResponseSuccess(clientDto, HttpStatusCode.OK, "Cliente registrado correctamente");
        }


        public async Task<Response<ClientDto>> ActualizarCliente(ClientRequest model)
        {
            Tbl_Cliente tbl_Cliente = _mapper.Map<Tbl_Cliente>(model);

            try
            {
                _unitOfWork.BeginTransaction();
                await _tbl_Cliente.Edit(tbl_Cliente);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Commit();
            }
            catch (Exception e)
            {
                _unitOfWork.RollBack();
                return Response<ClientDto>.CreateResponseError(e, NameService, CallerMember.GetNameMethod(), HttpStatusCode.OK, "Cliente registrado correctamente");
            }


            ClientDto clientDto = _mapper.Map<ClientDto>(tbl_Cliente);
            return Response<ClientDto>.CreateResponseSuccess(clientDto, HttpStatusCode.OK, "Se guardaron los cambios correctamente");

        }

        //private async Task<Response<ClientDto>> GuardarCliente(ClientRequest model)
        //{
        //    Tbl_Cliente tbl_Cliente = _mapper.Map<Tbl_Cliente>(model);

        //    try
        //    {
        //        _unitOfWork.BeginTransaction();
        //        await _tbl_Cliente.Add(tbl_Cliente);
        //        await _unitOfWork.SaveChangesAsync();
        //        _unitOfWork.Commit();
        //    }
        //    catch (Exception)
        //    {
        //        _unitOfWork.RollBack();
        //    }

        //    return Response<ClientDto>.CreateResponseSuccess(tbl_Cliente, HttpStatusCode.OK, "Cliente registrado correctamente");
        //}

    }
}
