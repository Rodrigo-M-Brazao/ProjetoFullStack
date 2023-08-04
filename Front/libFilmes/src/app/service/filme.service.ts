import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Filme } from '../models/Filme';


@Injectable({
  providedIn: 'root'
})
export class FilmeService {

  private url = 'http://localhost:5208';


  constructor(private http: HttpClient) { }

  ObterFilmes(): Observable<any[]> {
    return this.http.get<any[]>(`${this.url}/api/Filmes/GetFilmes`);
  }


}
