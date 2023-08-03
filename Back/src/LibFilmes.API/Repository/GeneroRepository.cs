using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using LibFilmes.API.Model;
using LibFilmes.API.Repository.Interface;

namespace LibFilmes.API.Repository
{
    public class GeneroRepository : Conexao, IGeneroRepository
    {
        public Genero cadastrarGenero(string nome)
        {
            string query =  "INSERT INTO bancoprojetos.genero(nome) " + 
                           $"VALUES ('{nome}')";
            ConexaoBase.Execute(query);
            string retorno = "SELECT id, nome FROM  bancoprojetos.genero WHERE id = LAST_INSERT_ID();";
            return ConexaoBase.Query<Genero>(retorno).FirstOrDefault();
        }

        public List<dynamic> getGeneros()
        {
            string query = "SELECT * FROM bancoprojetos.genero";
            return ConexaoBase.Query<dynamic>(query).ToList();
        }
    }
}