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
        [Route("GetFilmes")]
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
        [HttpGet]
        [Route("GetRoteiro")]
        public ActionResult GetRoteiros()
        {
            try{
                var roteiros = service.getRoteiros();
                return Ok(roteiros);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
        [HttpPost]
        [Route("CadastrarRoteiro/{nome}")]
        public ActionResult CadastrarRoteiros(string nome)
        {
            try{
                var roteiro = service.cadastrarRoteiro(nome);
                return Ok(roteiro);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
        [HttpGet]
        [Route("GetDiretores")]
        public ActionResult GetDiretores()
        {
            try{
                var diretores = service.getDiretores();
                return Ok(diretores);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
        [HttpPost]
        [Route("CadastrarDiretor/{nome}")]
        public ActionResult CadastrarDiretor(string nome)
        {
            try{
                var diretor = service.cadastrarDiretor(nome);
                return Ok(diretor);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
        [HttpGet]
        [Route("GetProdutoras")]
        public ActionResult GetProdutoras()
        {
            try{
                var produtoras = service.getProdutoras();
                return Ok(produtoras);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
        [HttpPost]
        [Route("CadastrarProdutora/{nome}")]
        public ActionResult CadastrarProdutora(string nome)
        {
            try{
                var produtora = service.cadastrarProdutora(nome);
                return Ok(produtora);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
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
        [Route("CadastrarGenero/{nome}")]
        public ActionResult CadastrarGeneros(string nome)
        {
            try{
                var genero = service.cadastrarGenero(nome);
                return Ok(genero);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
        [HttpGet]
        [Route("GetClassificacao")]
        public ActionResult GetClassificacao()
        {
            try{
                var classificacao = service.GetClassificacao();
                return Ok(classificacao);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
    }
}