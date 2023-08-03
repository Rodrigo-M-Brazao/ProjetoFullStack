using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibFilmes.API.Model;
using LibFilmes.API.Repository.Interface;
using LibFilmes.API.Service.Interface;

namespace LibFilmes.API.Service
{
    public class GeneroService : IGeneroService
    {
        private readonly IGeneroRepository repository; 
        public GeneroService(IGeneroRepository repository){
            this.repository = repository;
        }

        public Genero cadastrarGenero(string nome)
        {
            try
            {
                var genero = repository.cadastrarGenero(nome);
                return genero;
                
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public List<dynamic> getGeneros()
        {
            try
            {
                var generos = repository.getGeneros();
                return generos;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
    }
}