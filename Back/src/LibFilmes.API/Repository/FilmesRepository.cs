using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using LibFilmes.API.Model;
using LibFilmes.API.Repository.Interface;

namespace LibFilmes.API.Repository
{
    public class FilmesRepository : Conexao, IFilmesRepository
    {
        public dynamic cadastrarFilme(Filme filme)
        {
            string query =  "INSERT INTO bancoprojetos.filmes(titulo, genero_id, diretor_id, roteiro_id, poster, produtora_id, data_de_lancamento, sinopse, classificacao_indicativa_id) " + 
                           $"VALUES ('{filme.titulo}', {filme.genero_id}, {filme.diretor_id}, {filme.roteiro_id}, '{filme.poster}', {filme.produtora_id}, '{filme.data_de_lancamento}', '{filme.sinopse}', {filme.classificacao_indicativa_id})";
            ConexaoBase.Execute(query);
            string retorno = "SELECT * FROM  bancoprojetos.filmes WHERE id = LAST_INSERT_ID();";
            return ConexaoBase.Query<dynamic>(retorno).FirstOrDefault();
        }

        public List<dynamic> getFilmes()
        {
            string query = "SELECT * FROM bancoprojetos.filmes";
            return ConexaoBase.Query<dynamic>(query).ToList();
        }
    }
}