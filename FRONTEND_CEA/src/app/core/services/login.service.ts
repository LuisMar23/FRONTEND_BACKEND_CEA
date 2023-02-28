import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
// import { environment } from 'src/environments/environment';
import { Login } from '../interfaces/login';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  constructor(private httpClient: HttpClient){}

  enviarUsuario(usuario:Login): Observable<any>{
    return this.httpClient.post("http://localhost:7259/api/Login",usuario);
  }
}
