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

        public dynamic cadastrarFilme(Filme obj)
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

        public List<dynamic> getFilmes()
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
    }
}