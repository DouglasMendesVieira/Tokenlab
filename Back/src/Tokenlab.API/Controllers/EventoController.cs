using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tokenlab.API.Models;

namespace Tokenlab.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento() {
                    EventoId = 1,
                    Tema = "Web - Desafio Técnico",
                    Descricao = "Aaaaaa aaaaa aaaa",
                    Local = "Ipatinga",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    HoraInicio = "13:00",
                    HoraTermino = "15:00",
                    QtdPessoas = 250,
                    Lote = "1º Lote"
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Web - Desafio Técnico",
                    Descricao = "Aaaaaa aaaaa aaaa",
                    Local = "Ipatinga",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    HoraInicio = "13:00",
                    HoraTermino = "15:00",
                    QtdPessoas = 250,
                    Lote = "1º Lote"
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
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo de delete com id = {id}";
        }
    }
}
