using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Aplication;
using Aplication.Helpers;
using Aplication.Http.Dto;
using Aplication.Http.Request;
using Aplication.Service;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Site.Models;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _employeeService;
        private readonly ITbl_Cliente_Service _tbl_Cliente_Service;
        private readonly IVisitas_Al_Medico_Service _visitas_Al_Medico_Service;

        public HomeController(ILogger<HomeController> logger, IEmployeeService employeeService, ITbl_Cliente_Service tbl_Cliente_Service, IVisitas_Al_Medico_Service visitas_Al_Medico_Service)
        {
            _logger = logger;
            _employeeService = employeeService;
            _tbl_Cliente_Service = tbl_Cliente_Service;
            _visitas_Al_Medico_Service = visitas_Al_Medico_Service;
        }

        public async Task<ActionResult<Response<ClientDto>>> Index()
        {
            var response = await _tbl_Cliente_Service.ObtenerCliente();
            return View(response);
        }

        public async Task<ActionResult<Response<ClientDto>>> GuardarPerfil(ClientRequest clientRequest)
        {
            var response = await _tbl_Cliente_Service.ActualizarCliente(clientRequest);
            ViewData["mensaje"] = response.Message;
            return View("Index", response);
        }
        public async Task<ActionResult<Response<Visitas_Al_Medico_Dto>>> ListaCitas()
        {
            var response = await _visitas_Al_Medico_Service.ListaCitas();
            return View(response);
        }

        public async Task<ActionResult<Response<Visitas_Al_Medico_Dto>>> CrearCita(Visitas_Al_Medico_Dto clientRequest)
        {
            var response = await _visitas_Al_Medico_Service.CrearCita(clientRequest);
            response.Data = new Visitas_Al_Medico_Dto();
            ViewData["mensaje"] = response.Message;
            return View("Visitas_Al_Medico", response);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult<Response<Visitas_Al_Medico_Dto>> Visitas_Al_Medico()
        {
            var response = new Response<Visitas_Al_Medico_Dto>();
            response.Data = new Visitas_Al_Medico_Dto();
            return View(response);
        }
        public IActionResult Lista_Citas()
        {
            return View();
        }
        public IActionResult Inicio()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
