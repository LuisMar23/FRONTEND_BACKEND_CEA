import { Component, OnInit } from '@angular/core';

import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSelect } from '@angular/material/select';
import { Dialog } from '@angular/cdk/dialog';
import { InstitucionService } from 'src/app/core/services/institucion.service';
import { IInstitucion } from 'src/app/core/interfaces/institucion';

@Component({
  selector: 'app-agregar-editar-institucion',
  templateUrl: './agregar-editar-institucion.component.html',
  styleUrls: ['./agregar-editar-institucion.component.css']
})
export class AgregarEditarInstitucionComponent implements OnInit{
  institutions:string[]=['Unidad Educativa','Institucion'];
  hide = true;
  form:FormGroup;
  constructor(public dialogRef: MatDialogRef<AgregarEditarInstitucionComponent>,
    private fb:FormBuilder ,private _institucion :InstitucionService){
      this.form=this.fb.group({
        nombre:['',Validators.required],
        tipo:['',Validators.required]
      });
    }
  ngOnInit(): void {
   
  }
  addEditarInstitucion(){
    // if(this.form.invalid){
    //   return;
    // }
    const institucion:IInstitucion={
      Nombre:this.form.value.nombre,
      Tipo:this.form.value.tipo,
      Estado:1
    }
    this._institucion.agregarInstitucion(institucion).subscribe(()=>{
      console.log('persona agregada con exito');
    })

     console.log(institucion)
  }
  cancelar(){
    this.dialogRef.close();
  };
}
