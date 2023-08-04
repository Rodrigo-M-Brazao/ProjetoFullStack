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

        List<Roteiro> getRoteiros();
        Roteiro cadastrarRoteiro(string nome);
        List<Diretor> getDiretores();
        Diretor cadastrarDiretor(string nome);
        List<Produtora> getProdutoras();
        Produtora cadastrarProdutora(string nome);
        List<Genero> getGeneros();
        Genero cadastrarGenero(string nome);
        List<ClassificacaoIndicativa> GetClassificacao();
        
    }
}