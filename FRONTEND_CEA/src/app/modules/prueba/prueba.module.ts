import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RolComponent } from './rol/rol.component';
import { PruebaRoutingModule } from './prueba-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';



@NgModule({
  declarations: [
    RolComponent
  ],
  imports: [
    CommonModule,
    PruebaRoutingModule,
    SharedModule
  ]
})
export class PruebaModule { }
