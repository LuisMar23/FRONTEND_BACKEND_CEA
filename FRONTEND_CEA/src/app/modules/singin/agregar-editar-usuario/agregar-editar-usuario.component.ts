
import { Dialog } from '@angular/cdk/dialog';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DateAdapter } from '@angular/material/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSelect } from '@angular/material/select';
import { IRol } from 'src/app/core/interfaces/rol';
import { RolService } from 'src/app/core/services/rol.service';
import { IUsuario } from 'src/app/core/interfaces/usuario';
import { IPersona } from 'src/app/core/interfaces/persona';


@Component({
  selector: 'app-agregar-editar-usuario',
  templateUrl: './agregar-editar-usuario.component.html',
  styleUrls: ['./agregar-editar-usuario.component.css']
})
export class AgregarEditarUsuarioComponent implements OnInit  {
  form: FormGroup;
  constructor(public dialogRef: MatDialogRef<AgregarEditarUsuarioComponent>,private rol:RolService,
    private fb: FormBuilder){
      this.form = this.fb.group({
        nombre:['', ],
        apellido:['', ],
        edad:['', ],
        ci:['', ],
        celular:['', ],
        usuario:['', ],
        contrasenia:['',],
        rolid:[],
      });
    }

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
  agregarUsuario(){
    const usuario:IUsuario = {
      nombreUsuario: this.form.value.usuario,
      contraseniaUsuario: this.form.value.contrasenia,
      estado: 1,
      RolId: this.form.value.rolid,
      persona: {
        nombrePersona:this.form.value.nombre,
        apellidoPersona: this.form.value.apellido,
        edadPersona: this.form.value.edad,
        ciPersona: this.form.value.ci,
        celularPersona: this.form.value.celular,
        estadoPersona: 1
      }

    }
    console.log(usuario);
  }
  
}
