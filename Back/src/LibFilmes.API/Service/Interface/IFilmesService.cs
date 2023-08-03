using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibFilmes.API.Model;

namespace LibFilmes.API.Service.Interface
{
    public interface IFilmesService
    {
        List<dynamic> getFilmes();
        dynamic cadastrarFilme(Filme filme);
        
    }
}