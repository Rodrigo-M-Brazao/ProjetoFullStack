import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Filme } from '../models/Filme';
import { FilmeCadastrar } from '../models/FilmeCadastro';
import { Genero } from '../models/Genero';
import { Produtora } from '../models/Produtora';
import { Roteiro } from '../models/Roteiro';
import { Diretor } from '../models/Diretor';
import { ClassificacaoIndicativa } from '../models/ClassificacaoIndicativa';



@Injectable({
  providedIn: 'root'
})
export class FilmeService {

  private url = 'http://localhost:5208';


  constructor(private http: HttpClient) { }

  ObterFilmes(): Observable<Filme[]> {
    return this.http.get<Filme[]>(`${this.url}/api/Filmes/GetFilmes`);
  }
  CadastrarFilme(parametro: FilmeCadastrar): Observable<FilmeCadastrar> {
    return this.http.post<FilmeCadastrar>(`${this.url}/api/Filmes/CadastrarFilme`, parametro);
  }
  ObterGeneros(): Observable<Genero[]> {
    return this.http.get<Genero[]>(`${this.url}/api/Filmes/GetGenero`);
  }
  CadastrarGenero(parametro: string): Observable<any> {
    return this.http.post<any>(`${this.url}/api/Filmes/CadastrarGenero/${parametro}`, parametro);
  }
  ObterProdutoras(): Observable<Produtora[]> {
    return this.http.get<Produtora[]>(`${this.url}/api/Filmes/GetProdutoras`);
  }
  CadastrarProdutora(parametro: string): Observable<any> {
    return this.http.post<any>(`${this.url}/api/Filmes/CadastrarProdutora/${parametro}`, parametro);
  }
  ObterRoteiros(): Observable<Roteiro[]> {
    return this.http.get<Roteiro[]>(`${this.url}/api/Filmes/GetRoteiro`);
  }
  CadastrarRoteiro(parametro: string): Observable<any> {
    return this.http.post<any>(`${this.url}/api/Filmes/CadastrarRoteiro/${parametro}`, parametro);
  }
  ObterDiretores(): Observable<Diretor[]> {
    return this.http.get<Diretor[]>(`${this.url}/api/Filmes/GetDiretores`);
  }
  CadastrarDiretor(parametro: string): Observable<any> {
    return this.http.post<any>(`${this.url}/api/Filmes/CadastrarDiretor/${parametro}`, parametro);
  }
  ObterClassificacao(): Observable<ClassificacaoIndicativa[]> {
    return this.http.get<ClassificacaoIndicativa[]>(`${this.url}/api/Filmes/GetClassificacao`);
  }
}
