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
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroService service; 
        public GeneroController(IGeneroService service){
            this.service = service;
        }
        [HttpGet]
        [Route("GetGenero")]
        public ActionResult GetGeneros()
        {
            try{
                var generos = service.getGeneros();
                return Ok(generos);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
        [HttpPost]
        [Route("CadastrarGenero")]
        public ActionResult CadastrarGeneros(string obj)
        {
            try{
                var genero = service.cadastrarGenero(obj);
                return Ok(genero);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
    }
}