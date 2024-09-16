import { Component } from '@angular/core';
import { CdbService } from '../../services/cdb.service';

@Component({
  selector: 'app-cdb-calc',
  templateUrl: './cdb-calc.component.html',
  styleUrls: ['./cdb-calc.component.css']
})
export class CdbCalcComponent {
  valorInicial: number = 0; 
  prazo: number = 1; 
  resultado: any;

  constructor(private cdbService: CdbService) { }

  onSubmit() {
    this.cdbService.calcularCdb(this.valorInicial, this.prazo).subscribe(data => {
      this.resultado = data;
    });
  }
}
