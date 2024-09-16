import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CdbCalcComponent } from './pages/cdb-calc/cdb-calc.component';

const routes: Routes = [
  { path: '', component: AppComponent },
  { path: 'calculo', component: CdbCalcComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

