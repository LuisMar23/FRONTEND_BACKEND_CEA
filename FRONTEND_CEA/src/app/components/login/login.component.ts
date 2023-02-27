import { Component } from '@angular/core';
import { FormGroup,FormBuilder, Validators  } from '@angular/forms';
import { Login } from 'src/app/core/interfaces/login';
import { LoginService } from 'src/app/core/services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent {
  displayedColumns: string[] = [
    'username',
    'contrasenia',
  ];
  public form!: FormGroup;

  constructor(
    private loginService: LoginService,
    private fb: FormBuilder){
      this.form = this.fb.group({
        username: ['', Validators.required],
        contrasenia: ['', Validators.required],
      });
    }
  // ngOnInit(): void {}


  loguear():void{
    const usuario: Login = this.form.value;
      this.loginService.enviarUsuario(usuario).subscribe(
        (resp) => {
           console.log(resp);
           this.form.reset();
        },
    )
  }
}
