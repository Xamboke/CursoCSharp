using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoCSharp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CursoCSharp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    { 
        public IEnumerable<Evento> _evento = new Evento[] 
            {
                new Evento()
                {
                    EventoId= 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "João Pessoa",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                new Evento()
                {
                    EventoId= 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "João Pessoa",
                    Lote = "2º Lote",
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png"
                }                
            };
        public EventoController()
        {            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);            
        }

        [HttpPost]
        public string Post ()
        {
            return "exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        { 
            return $"exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        { 
            return $"exemplo de Delete com id = {id}";
        } 
    }
}
