import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { environment } from 'src/environments/environment.development';
import { Calculo } from '../models/calculo';
import { Observable } from 'rxjs';
import { RetornoCalculo } from '../models/retornoCalculo';

@Injectable({
  providedIn: 'root'
})
export class CalcularService {

  url = environment.urlApi;

  constructor(private https: HttpClient) { }


  calcularCDB(calc: Calculo): Observable<RetornoCalculo[]> {

    return this.https.post<RetornoCalculo[]>(this.url + 'CDB/calcular-CDB', calc);

  }

}
