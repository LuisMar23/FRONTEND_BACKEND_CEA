import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RolComponent } from './rol/rol.component';
import { SingInRoutingModule } from './singin-routing.module';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { UsuarioComponent } from './usuario/usuario.component';
import { MatSortModule } from '@angular/material/sort';

import { MatInputModule } from '@angular/material/input';
import { AgregarEditarUsuarioComponent } from './agregar-editar-usuario/agregar-editar-usuario.component';

import {MatDialogModule} from '@angular/material/dialog';
@NgModule({
  declarations: [
    RolComponent,
    UsuarioComponent,
    AgregarEditarUsuarioComponent
  ],
  imports: [
    CommonModule,
    SingInRoutingModule,
    MatFormFieldModule,
    MatPaginatorModule,
    MatTableModule,
    MatSortModule,
    MatInputModule,
    MatDialogModule
    

  ],
  exports: [
    RolComponent,
    UsuarioComponent
  ]
})
export class SingInModule { }
