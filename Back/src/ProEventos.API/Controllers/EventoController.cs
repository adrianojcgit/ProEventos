using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e Dot.Net",
                Local = "Belo Horizonte",
                Lote = "1o. Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "2o. Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto1.png"
            }
        };        

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
        }
        [HttpPost]
        public string Post()
        {
           return "exemplo 2";
        }
    }
}
