import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { Empleado } from 'src/app/models/empleado';
import { EmpleadoService } from 'src/app/services/empleado.service';

@Component({
  selector: 'app-empleado',
  templateUrl: './empleado.component.html',
  styleUrls: ['./empleado.component.css'],
})
export class EmpleadoComponent implements OnInit {
  form: FormGroup;
  subscription : Subscription;
  constructor(
    private FormBuilder: FormBuilder,
    private empleadoService: EmpleadoService
  ) {
    this.form = this.FormBuilder.group({
      Nombre: ['', [Validators.required]],
      Apellido: ['', [Validators.required]],
      DocIdentidad: ['', [Validators.required]],
      CargoID: ['', [Validators.required]],
    });
  }

  ngOnInit(): void {
    // this.subscription=this.empleadoService.obtenerEmpleados().subscribe((data) => {
    //   console.log(data);
    // });
  }

  guardarEmpleado() {
    const empleado: Empleado = {
      Nombre: this.form.get('Nombre').value,
      Apellido: this.form.get('Apellido').value,
      DocIdentidad: Number(this.form.get('DocIdentidad').value),
      CargoID: Number(this.form.get('CargoID').value),
    };
    this.empleadoService.guardarEmpleado(empleado).subscribe((data) => {
      console.log('Almacenado');
      this.empleadoService.obtenerEmpleados();
      this.form.reset();
    });
  }
}
