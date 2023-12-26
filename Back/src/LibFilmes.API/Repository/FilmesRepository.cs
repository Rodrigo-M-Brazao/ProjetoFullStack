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
            string query =  "INSERT INTO bancoprojetos.filmes(titulo, genero_id, diretor_id, roteiro_id, poster_url, produtora_id, data_lancamento, sinopse, classificacao_id, duracao) " + 
                           $"VALUES ('{filme.titulo}', {filme.genero_id}, {filme.diretor_id}, {filme.roteiro_id}, '{filme.poster_url}', {filme.produtora_id}, '{filme.data_lancamento}', '{filme.sinopse}', {filme.classificacao_id}, '{filme.duracao}')";
            ConexaoBase.Execute(query);
            string retorno = "SELECT " +
                            "    f.id," +
                            "    f.titulo," +
                            "    f.duracao," +
                            "    g.nome AS genero," +
                            "    d.nome AS diretor," +
                            "    r.nome AS roteiro," +
                            "    p.nome AS produtora," +
                            "    f.poster_url," +
                            "    f.data_lancamento," +
                            "    f.sinopse," +
                            "    ci.nome AS classificacao_indicativa " +
                            "FROM bancoprojetos.filmes f " +
                            "INNER JOIN bancoprojetos.genero g ON f.genero_id = g.id " +
                            "INNER JOIN bancoprojetos.diretor d ON f.diretor_id = d.id " +
                            "INNER JOIN bancoprojetos.roteiro r ON f.roteiro_id = r.id " +
                            "INNER JOIN bancoprojetos.produtora p ON f.produtora_id = p.id " +
                            "INNER JOIN bancoprojetos.classificacao_indicativa ci " + 
                            "ON f.classificacao_id = ci.id WHERE f.id = LAST_INSERT_ID();";
            return ConexaoBase.Query<dynamic>(retorno).FirstOrDefault();
        }
        
        public List<dynamic> getFilmes()
        {
            string query = "SELECT " +
                            "    f.titulo," +
                            "    f.duracao," +
                            "    g.nome AS genero," +
                            "    d.nome AS diretor," +
                            "    r.nome AS roteiro," +
                            "    p.nome AS produtora," +
                            "    f.poster_url," +
                            "    f.data_lancamento," +
                            "    f.sinopse," +
                            "    ci.nome AS classificacao_indicativa " +
                            "FROM bancoprojetos.filmes f " +
                            "INNER JOIN bancoprojetos.genero g ON f.genero_id = g.id " +
                            "INNER JOIN bancoprojetos.diretor d ON f.diretor_id = d.id " +
                            "INNER JOIN bancoprojetos.roteiro r ON f.roteiro_id = r.id " +
                            "INNER JOIN bancoprojetos.produtora p ON f.produtora_id = p.id " +
                            "INNER JOIN bancoprojetos.classificacao_indicativa ci " + 
                            "ON f.classificacao_id = ci.id;";
            return ConexaoBase.Query<dynamic>(query).ToList();
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