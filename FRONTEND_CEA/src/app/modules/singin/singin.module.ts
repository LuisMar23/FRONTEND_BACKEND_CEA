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
import { SharedModule } from 'src/app/shared/shared.module';
import { MatSelectModule } from '@angular/material/select';
import {MatIconModule} from '@angular/material/icon';



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
    MatDialogModule,
    SharedModule,
    MatSelectModule,
    MatIconModule

  ],
  exports: [
    RolComponent,
    UsuarioComponent
  ]
})
export class SingInModule { }
