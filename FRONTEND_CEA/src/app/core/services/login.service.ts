import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
// import { environment } from 'src/environments/environment';
import { Login } from '../interfaces/login';

// @Injectable({
//   providedIn: 'root'
// })
export class LoginService {
  constructor(
    private httpClient: HttpClient,
  ){

  }

  enviarUsuario(usuario:Login): Observable<Login>{
    return this.httpClient.post<Login>("http://localhost:7259/api/Login",usuario);
  }
}
