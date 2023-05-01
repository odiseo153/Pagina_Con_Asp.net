using Api.Contexto;
using CursoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CursoMvc.Controllers
{
    public class PelisController : Controller
    {
        public LasTablas tabla { get; }

        public PelisController(LasTablas taba) 
        {      
        
            this.tabla = taba;

        }


        public async Task<ActionResult> Index()
        {
            var data = new List<Pelis>();
            if (System.IO.File.Exists("datos/Pelis.json")) 
            {
                string existe = System.IO.File.ReadAllText("datos/Pelis.json");
             data = JsonConvert.DeserializeObject<List<Pelis>>(existe);

            }


            return View(data);
        }

        public async Task<ActionResult> Index1()
        {
            var data = new List<Pelis>();
            if (System.IO.File.Exists("datos/Pelis.json"))
            {
                string existe = System.IO.File.ReadAllText("datos/Pelis.json");
                data = JsonConvert.DeserializeObject<List<Pelis>>(existe);

            }


            return View(data);
        }


        public async Task<ActionResult> agregar(Pelis pelicula)
        {
            var pe = pelicula;



            return View();
        }



    }
}
