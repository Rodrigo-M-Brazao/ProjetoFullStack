import { Component, OnInit } from '@angular/core';
import { ClassificacaoIndicativa } from 'src/app/models/ClassificacaoIndicativa';
import { Diretor } from 'src/app/models/Diretor';
import { Filme } from 'src/app/models/Filme';
import { FilmeCadastrar } from 'src/app/models/FilmeCadastro';
import { Genero } from 'src/app/models/Genero';
import { Produtora } from 'src/app/models/Produtora';
import { Roteiro } from 'src/app/models/Roteiro';

import { FilmeService } from 'src/app/service/filme.service';

@Component({
  selector: 'app-cadastro-filme',
  templateUrl: './cadastro-filme.component.html',
  styleUrls: ['./cadastro-filme.component.css']
})
export class CadastroFilmeComponent implements OnInit {
  filme : FilmeCadastrar = new FilmeCadastrar();
  generos? : Genero[];
  roteiros? : Roteiro[];
  diretores? : Diretor[];
  produtoras? : Produtora[];
  classificacoesIndicativa? : ClassificacaoIndicativa[];
  filmeNome = '';
  duracao = '';
  dataLancamento = '';
  diretorNome =  0;
  roteiroNome =  0;
  generoNome =  0;
  produtoraNome =  0;
  classificacaoIndicativa = 0;
  sinopse = '';
  posterUrl = '';
  constructor(private service : FilmeService) {

  }
  ngOnInit(): void {
    this.listar();
  }

  cadastro(){
    this.filme.titulo = this.filmeNome;
    this.filme.duracao = this.duracao;
    this.filme.genero_id = this.generoNome;
    this.filme.diretor_id = this.diretorNome;
    this.filme.roteiro_id = this.roteiroNome;
    this.filme.poster_url = this.posterUrl;
    this.filme.produtora_id = this.produtoraNome;
    this.filme.data_lancamento = this.dataLancamento;
    this.filme.sinopse = this.sinopse;
    this.filme.classificacao_id = this.classificacaoIndicativa;
    this.service.CadastrarFilme(this.filme).subscribe((resp: FilmeCadastrar) => {
    });
  }
  listar(){
    this.service.ObterGeneros().subscribe((resp: Genero[]) => {
      this.generos = resp;
    });
    this.service.ObterProdutoras().subscribe((resp: Produtora[]) => {
      this.produtoras = resp;
    });
    this.service.ObterRoteiros().subscribe((resp: Roteiro[]) => {
      this.roteiros = resp;
    });
    this.service.ObterDiretores().subscribe((resp: Diretor[]) => {
      this.diretores = resp;
    });
    this.service.ObterClassificacao().subscribe((resp: ClassificacaoIndicativa[]) => {
      this.classificacoesIndicativa = resp;
    });
  }
  teste(){
    console.log(this.diretorNome);
  }
}
