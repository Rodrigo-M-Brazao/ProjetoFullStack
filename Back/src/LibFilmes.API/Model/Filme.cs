using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibFilmes.API.Model
{
    public class Filme
    { 
        public string titulo {get; set;}
        public int genero_id {get; set;}
        public int diretor_id {get; set;}
        public int roteiro_id {get; set;}
        public string poster {get; set;}
        public int produtora_id {get; set;}
        public string data_de_lancamento {get; set;}
        public string sinopse {get; set;}
        public int classificacao_indicativa_id {get; set;}

    }
}