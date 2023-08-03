using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibFilmes.API.Model;

namespace LibFilmes.API.Repository.Interface
{
    public interface IGeneroRepository
    {
        List<dynamic> getGeneros();
        Genero cadastrarGenero(string nome);
    }
}