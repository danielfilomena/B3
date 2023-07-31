import { Component, OnInit, NgModule, ViewChild } from '@angular/core';
import { Calculo } from 'src/app/models/calculo';
import { RetornoCalculo } from 'src/app/models/retornoCalculo';

import { CalcularService } from 'src/app/services/calcular.service';

@Component({
  selector: 'app-calcularCDB',
  templateUrl: './calcularCDB.component.html',
  styleUrls: ['./calcularCDB.component.css']
})
export class CalcularCDBComponent implements OnInit {

  totalRegistro!: number;

  @ViewChild('form') form!: NgModule;

  calculoViewModel = new Calculo();
  retornoCalculo: RetornoCalculo[] = [];


  constructor(private calcularService: CalcularService) { }

  ngOnInit() {
  }

  onSubmit(ev: any) {

    ev.preventDefault();

    this.calcularService.calcularCDB(this.calculoViewModel).subscribe(result => {
      this.retornoCalculo = result;
      console.log(result);
    }, (err) => {
      window.alert("Ocorreu um erro ao tentar Calcular o CDB!");
    }) ;

  }

}
