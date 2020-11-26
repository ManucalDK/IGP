import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { EmpleadosComponent } from './components/empleados/empleados.component';
import { EmpleadoComponent } from './components/empleados/empleado/empleado.component';
import { LstempleadosComponent } from './components/empleados/lstempleados/lstempleados.component';

@NgModule({
  declarations: [
    AppComponent,

    EmpleadosComponent,

    EmpleadoComponent,

    LstempleadosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
