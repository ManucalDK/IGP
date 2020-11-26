import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Empleado } from '../models/empleado';

@Injectable({
  providedIn: 'root',
})
export class EmpleadoService {
  myAppUrl = 'http://localhost/5000/';
  myApiUrl = 'empleado';
  lista: Empleado[];
  private actualizaForm = new BehaviorSubject<Empleado>({} as any);

  constructor(private HttpResourse: HttpClient) {}

  guardarEmpleado(tarjeta: Empleado): Observable<Empleado> {
    return this.HttpResourse.post<Empleado>(
      this.myAppUrl + this.myApiUrl,
      Empleado
    );
  }

  obtenerEmpleados() {
    return this.HttpResourse.get(this.myAppUrl + this.myApiUrl)
      .toPromise()
      .then((data) => (this.lista = data as Empleado[]));
  }

  actualizarEmpleado(empleado){
    this.actualizaForm.next(empleado);
  }

  obtenerEmpleado() : Observable<Empleado>{
    return this.actualizaForm.asObservable();
  }
}
