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
        

        public Filme cadastrarFilme(Filme filme)
        {
            string query =  "INSERT INTO bancoprojetos.filmes(titulo, genero_id, diretor_id, roteiro_id, poster_url, produtora_id, data_lancamento, sinopse, classificacao_id, duracao) " + 
                           $"VALUES ('{filme.titulo}', {filme.genero_id}, {filme.diretor_id}, {filme.roteiro_id}, '{filme.poster_url}', {filme.produtora_id}, '{filme.data_lancamento}', '{filme.sinopse}', {filme.classificacao_id}, '{filme.duracao}')";
            ConexaoBase.Execute(query);
            string retorno = "SELECT * FROM  bancoprojetos.filmes WHERE id = LAST_INSERT_ID();";
            return ConexaoBase.Query<Filme>(retorno).FirstOrDefault();
        }
        
        public List<Filme> getFilmes()
        {
            string query = "SELECT * FROM bancoprojetos.filmes";
            return ConexaoBase.Query<Filme>(query).ToList();
        }

        public List<Roteiro> getRoteiros()
        {
            string query = "SELECT * FROM bancoprojetos.roteiro";
            return ConexaoBase.Query<Roteiro>(query).ToList();
        }
        
        public Roteiro cadastrarRoteiro(string nome)
        {
            string query =  "INSERT INTO bancoprojetos.roteiro(nome) " + 
                           $"VALUES ('{nome}')";
            ConexaoBase.Execute(query);
            string retorno = "SELECT * FROM  bancoprojetos.roteiro WHERE id = LAST_INSERT_ID();";
            return ConexaoBase.Query<Roteiro>(retorno).FirstOrDefault();
        }

        public Diretor cadastrarDiretor(string nome)
        {
            string query =  "INSERT INTO bancoprojetos.diretor(nome) " + 
                           $"VALUES ('{nome}')";
            ConexaoBase.Execute(query);
            string retorno = "SELECT * FROM  bancoprojetos.diretor WHERE id = LAST_INSERT_ID();";
            return ConexaoBase.Query<Diretor>(retorno).FirstOrDefault();
        }
        public List<Diretor> getDiretores()
        {
           string query = "SELECT * FROM bancoprojetos.diretor";
            return ConexaoBase.Query<Diretor>(query).ToList();
        }
        public Produtora cadastrarProdutora(string nome)
        {
            string query =  "INSERT INTO bancoprojetos.produtora(nome) " + 
                           $"VALUES ('{nome}')";
            ConexaoBase.Execute(query);
            string retorno = "SELECT * FROM  bancoprojetos.produtora WHERE id = LAST_INSERT_ID();";
            return ConexaoBase.Query<Produtora>(retorno).FirstOrDefault();
        }
        public List<Produtora> getProdutoras()
        {
           string query = "SELECT * FROM bancoprojetos.produtora";
            return ConexaoBase.Query<Produtora>(query).ToList();
        }
        public Genero cadastrarGenero(string nome)
        {
            string query =  "INSERT INTO bancoprojetos.genero(nome) " + 
                           $"VALUES ('{nome}')";
            ConexaoBase.Execute(query);
            string retorno = "SELECT * FROM  bancoprojetos.genero WHERE id = LAST_INSERT_ID();";
            return ConexaoBase.Query<Genero>(retorno).FirstOrDefault();
        }
        public List<Genero> getGeneros()
        {
           string query = "SELECT * FROM bancoprojetos.genero";
            return ConexaoBase.Query<Genero>(query).ToList();
        }
        public List<ClassificacaoIndicativa> GetClassificacao()
        {
            string query = "SELECT * FROM bancoprojetos.classificacao_indicativa";
            return ConexaoBase.Query<ClassificacaoIndicativa>(query).ToList();
        }
        
    }
}