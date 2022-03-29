using Aplication.Http.Dto;
using Aplication.Http.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Helpers
{
    public interface IVisitas_Al_Medico_Service
    {
        Task<Response<Visitas_Al_Medico_Dto>> ListaCitas();
        Task<Response<Visitas_Al_Medico_Dto>> CrearCita(Visitas_Al_Medico_Dto model);
    }
}
