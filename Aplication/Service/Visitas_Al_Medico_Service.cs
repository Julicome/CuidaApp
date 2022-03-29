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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public class Visitas_Al_Medico_Service : CustomService<Tbl_Visitas_Al_Medico>, IVisitas_Al_Medico_Service
    {
        private readonly ITbl_Visitas_Al_Medico _Tbl_Visitas_Al_Medico;
        public Visitas_Al_Medico_Service(IUnitOfWorkRepository unitOfWorkRepository, IMapper mapper) : base(unitOfWorkRepository, mapper)
        {
            _Tbl_Visitas_Al_Medico = unitOfWorkRepository.Tbl_Visitas_Al_Medico;
        }

        public async Task<Response<Visitas_Al_Medico_Dto>> ListaCitas()
        {
            Tbl_Visitas_Al_Medico client = await _unitOfWork.Tbl_Visitas_Al_Medico.GetById(1);
            Visitas_Al_Medico_Dto Visitas_Al_Medico_Dto = _mapper.Map<Visitas_Al_Medico_Dto>(client);
            return Response<Visitas_Al_Medico_Dto>.CreateResponseSuccess(Visitas_Al_Medico_Dto, HttpStatusCode.OK, "Cliente registrado correctamente");
        }


        public async Task<Response<Visitas_Al_Medico_Dto>> CrearCita(Visitas_Al_Medico_Dto model)
        {
            Tbl_Visitas_Al_Medico Tbl_Visitas_Al_Medico = _mapper.Map<Tbl_Visitas_Al_Medico>(model);

            try
            {
                _unitOfWork.BeginTransaction();
                Tbl_Visitas_Al_Medico.Id = await GetLastId();
                await _Tbl_Visitas_Al_Medico.Add(Tbl_Visitas_Al_Medico);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Commit();
            }
            catch (Exception e)
            {
                _unitOfWork.RollBack();
                return Response<Visitas_Al_Medico_Dto>.CreateResponseError(e, NameService, CallerMember.GetNameMethod(), HttpStatusCode.OK, "Cita registrada correctamente");
            }


            Visitas_Al_Medico_Dto Visitas_Al_Medico_Dto = _mapper.Map<Visitas_Al_Medico_Dto>(Tbl_Visitas_Al_Medico);
            return Response<Visitas_Al_Medico_Dto>.CreateResponseSuccess(Visitas_Al_Medico_Dto, HttpStatusCode.OK, "Se guardaron los cambios correctamente");

        }


        private async Task<int> GetLastId()
        {
            int id = 1;
            try
            {
                Tbl_Visitas_Al_Medico tbl_Visitas = (await _Tbl_Visitas_Al_Medico.GetAll()).Last();
                id = tbl_Visitas.Id + 1;
            }
            catch (Exception)
            {
                return id;
            }

            return id;
        }

    }
}
