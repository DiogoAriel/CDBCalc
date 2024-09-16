import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CdbService {
  private apiUrl = 'https://localhost:5001/api/cdb/calcular';

  constructor(private http: HttpClient) { }

  calcularCdb(valorInicial: number, prazoMeses: number): Observable<any> {
    return this.http.post(this.apiUrl, { valorInicial, prazoMeses });
  }
}
