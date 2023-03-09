

import { Component, Inject, OnInit } from '@angular/core';

import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DateAdapter } from '@angular/material/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSelect } from '@angular/material/select';
import { Dialog } from '@angular/cdk/dialog';

import { IRol } from 'src/app/core/interfaces/rol';
import { RolService } from 'src/app/core/services/rol.service';


@Component({
  selector: 'app-agregar-editar-usuario',
  templateUrl: './agregar-editar-usuario.component.html',
  styleUrls: ['./agregar-editar-usuario.component.css']
})
export class AgregarEditarUsuarioComponent implements OnInit  {

  constructor(public dialogRef: MatDialogRef<AgregarEditarUsuarioComponent>,private rol:RolService) { }
  ngOnInit(): void {
    this.listarRoles();
  }
  listaRoles!: IRol[];

  cancelar(){
    this.dialogRef.close();
    };
   hide = true;
  listarRoles(){
    this.rol.obtenerRoles().subscribe((resp)=>{
      this.listaRoles=resp;
      console.log(this.listaRoles);
    })
  }
}
