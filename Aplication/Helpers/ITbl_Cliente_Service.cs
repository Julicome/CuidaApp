using Aplication.Http.Dto;
using Aplication.Http.Request;
using System.Threading.Tasks;

namespace Aplication.Helpers
{
    public interface ITbl_Cliente_Service
    {
        Task<Response<ClientDto>> ObtenerCliente();
        Task<Response<ClientDto>> ActualizarCliente(ClientRequest model);
    }
}
