import { Component, OnInit } from '@angular/core';
import { CategoriaService } from 'src/app/service/categoria.service';

import { FilmeService } from 'src/app/service/filme.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  filmes? : any[];
  categorias? : any[];
  constructor(private service : FilmeService, private serviceCategoria : CategoriaService) {

  }
  ngOnInit(): void {
    this.listar();

  }
  listar(){
    this.service.ObterFilmes().subscribe((resp: any[]) => {
      this.filmes = resp;
      console.log(resp);
    });
    this.serviceCategoria.ObterCategorias().subscribe((resp: any[]) => {
      this.categorias = resp;
      console.log(resp);
    });
  }

}
