using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibFilmes.API.Model;
using LibFilmes.API.Repository.Interface;
using LibFilmes.API.Service.Interface;

namespace LibFilmes.API.Service
{
    public class FilmesService : IFilmesService
    {
        private readonly IFilmesRepository repository; 
        public FilmesService(IFilmesRepository repository){
            this.repository = repository;
        }

        public Filme cadastrarFilme(Filme obj)
        {
            try
            {
                var filme = repository.cadastrarFilme(obj);
                return filme;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public List<Filme> getFilmes()
        {
            try
            {
                var filmes = repository.getFilmes();
                return filmes;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
        public List<Roteiro> getRoteiros(){
            try{
                var obj = repository.getRoteiros();
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
        public Roteiro cadastrarRoteiro(string nome){
            try{
                var obj = repository.cadastrarRoteiro(nome);
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
        public List<Diretor> getDiretores(){
            try{
                var obj = repository.getDiretores();
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
        public Diretor cadastrarDiretor(string nome){
            try{
                var obj = repository.cadastrarDiretor(nome);
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
        public List<Produtora> getProdutoras(){
            try{
                var obj = repository.getProdutoras();
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
        public Produtora cadastrarProdutora(string nome){
            try{
                var obj = repository.cadastrarProdutora(nome);
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
        public List<Genero> getGeneros(){
            try{
                var obj = repository.getGeneros();
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
        public Genero cadastrarGenero(string nome){
            try{
                var obj = repository.cadastrarGenero(nome);
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
        public List<ClassificacaoIndicativa> GetClassificacao(){
            try{
                var obj = repository.GetClassificacao();
                return obj;
            }catch(Exception e){
                throw new Exception("Erro: " + e.Message);
            }
        }
    }
}