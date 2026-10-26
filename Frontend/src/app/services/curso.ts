import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Curso } from '../models/curso';

@Injectable({
  providedIn: 'root'
})
export class CursoService {
  
  private apiUrl = 'https://catalago-sesi.onrender.com/api/cursos'; 

  constructor(private http: HttpClient) { }

  getCursos(filtros?: any): Observable<Curso[]> {
    let params = new HttpParams();
    if (filtros) {
      if (filtros.nome) params = params.append('nome', filtros.nome);
      if (filtros.categoria) params = params.append('categoria', filtros.categoria);
      if (filtros.modalidade) params = params.append('modalidade', filtros.modalidade);
      if (filtros.status) params = params.append('status', filtros.status);
    }
    return this.http.get<Curso[]>(this.apiUrl, { params });
  }
}