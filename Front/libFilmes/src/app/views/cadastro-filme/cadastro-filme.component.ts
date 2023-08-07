import { Component, OnInit } from '@angular/core';
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
  diretorNome =  0;

  constructor(private service : FilmeService) {

  }
  ngOnInit(): void {
    this.cadastro();
    this.listar();
  }

  cadastro(){
    this.service.CadastrarFilme(this.filme).subscribe((resp: Filme) => {
      // this.filme = resp;
      // console.log(resp);
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
  }
  teste(){
    console.log(this.diretorNome);
  }
}
