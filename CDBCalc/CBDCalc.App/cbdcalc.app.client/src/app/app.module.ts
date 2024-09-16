import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { CdbCalcComponent } from './pages/cdb-calc/cdb-calc.component';
import { AppRoutingModule } from './app-routing.module';
import { CommonModule } from '@angular/common'; // Importa o CommonModule

@NgModule({
  declarations: [
    AppComponent,
    CdbCalcComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    CommonModule // Certifique-se de importar o CommonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
