import { Routes, RouterModule } from '@angular/router';
import { CalcularCDBComponent } from 'src/app/pages/calcularCDB/calcularCDB.component';

export const AdminLayoutRoutes: Routes = [
  {
    path: "",
    children: [
      {
        path: "calculocdb",
        component: CalcularCDBComponent
      }
    ]
  }

]
