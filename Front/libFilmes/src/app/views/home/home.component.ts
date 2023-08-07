import { Component, OnInit } from '@angular/core';

import { FilmeService } from 'src/app/service/filme.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  filmes? : any[];

  constructor(private service : FilmeService) {

  }
  ngOnInit(): void {
    this.listar();

  }
  listar(){
    this.service.ObterFilmes().subscribe((resp: any[]) => {
      this.filmes = resp;
      console.log(resp);
    });
  }

}
