using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibFilmes.API.Model;
using LibFilmes.API.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LibFilmes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmesService service; 
        public FilmesController(IFilmesService service){
            this.service = service;
        }
        [HttpGet]
        [Route("GetFilme")]
        public ActionResult GetFilmes()
        {
            try{
                var filmes = service.getFilmes();
                return Ok(filmes);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
        [HttpPost]
        [Route("CadastrarFilme")]
        public ActionResult CadastrarFilmes(Filme obj)
        {
            try{
                var filme = service.cadastrarFilme(obj);
                return Ok(filme);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
    }
}