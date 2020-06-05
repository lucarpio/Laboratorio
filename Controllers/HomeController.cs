using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Laboratorio.Models;
using Laboratorio.Data;

namespace Laboratorio.Controllers
{
    public class HomeController : Controller
    {

        private readonly DatabaseContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DatabaseContext context )
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Empleado()
        {
            return View();
        }
        public IActionResult Sueldo()
        {
            return View();
        }

        public IActionResult EmpleadoCreate(Empleado objEmpleado)
        {
            if(ModelState.IsValid)
            {
                objEmpleado.mensaje="Hola! "+objEmpleado.Nombre+" "+objEmpleado.Apellido +"\n"+"Bienvenido a la USMP";
                _context.Add(objEmpleado);
                _context.SaveChanges();
                return View("Empleado",objEmpleado);
            }
            
            return View("Empleado");
        }
        public IActionResult SueldoCreate(Sueldo objSueldo)
        {
            objSueldo.resultado = Math.Round((objSueldo.sueldo*objSueldo.meses),2);
            objSueldo.mensaje = "Su sueldo: "+objSueldo.sueldo+" luego de "+objSueldo.meses+" meses"+"\n"+
            "Será de: S/."+objSueldo.resultado+" Nuevos soles";
            return View("Sueldo",objSueldo);
        }
        public IActionResult ListaEmpleados()
        {
            return View();
        }

        public IActionResult GetEmpleados()
        {
            var ListEmpleados = _context.Empleados.ToList();
            return View("ListaEmpleados",ListEmpleados);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
