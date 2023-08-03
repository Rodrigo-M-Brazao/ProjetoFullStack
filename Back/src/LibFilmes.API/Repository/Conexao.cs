using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace LibFilmes.API.Repository
{
    public class Conexao : IDisposable
    {
        public IDbConnection ConexaoBase {get; }
        public Conexao()
        {
            try
            {                
                string server = "localhost";
                string port = "3306";
                string database = "bancoprojetos";
                string username = "root";
                string password = "123456";
                ConexaoBase = new MySqlConnection($"Server={server};Port={port};Database={database};Uid={username};Pwd={password};");
                ConexaoBase.Open();
            }
            catch(MySqlException ex){
                throw new Exception("Erro: " + ex.Message);
            }
            
        }

        public void Dispose() => ConexaoBase?.Dispose();
    }
}