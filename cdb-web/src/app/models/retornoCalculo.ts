import { DecimalPipe } from "@angular/common";
import { Imposto } from "./imposto";

export class RetornoCalculo {

  valorInicial!: DecimalPipe;
  valorBruto!: DecimalPipe;
  imposto!: Imposto;
  prazo!: number;
  valorLiquido!: DecimalPipe;

}
