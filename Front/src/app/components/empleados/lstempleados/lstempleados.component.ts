import { Component, OnInit } from '@angular/core';
import { EmpleadoService } from 'src/app/services/empleado.service';

@Component({
  selector: 'app-lstempleados',
  templateUrl: './lstempleados.component.html',
  styleUrls: ['./lstempleados.component.css']
})
export class LstempleadosComponent implements OnInit {

  constructor(public empleadoService : EmpleadoService) { }

  ngOnInit(): void {
    this.empleadoService.obtenerEmpleados();
  }

  editar(empleado){
    this.empleadoService.actualizarEmpleado(empleado);
  }

}
