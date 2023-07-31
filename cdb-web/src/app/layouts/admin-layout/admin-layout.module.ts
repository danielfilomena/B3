import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule } from '@angular/forms';
import { RouterModule } from "@angular/router";

import { AdminLayoutRoutes } from './admin-layout.routing';
import { CalcularCDBComponent } from "src/app/pages/calcularCDB/calcularCDB.component";

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule
  ],
  declarations: [
    CalcularCDBComponent
  ],
  exports: []
})

export class AdminLayoutModule {}
