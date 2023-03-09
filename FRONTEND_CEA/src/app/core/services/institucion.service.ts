import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IInstitucion } from '../interfaces/institucion';
@Injectable({
  providedIn: 'root'
})
export class InstitucionService {
  private ruta:string="/api/Institucion";
  constructor(private httpclient:HttpClient) { }

  obtenerInstituciones():Observable <any>{
    return this.httpclient.get<any>(`${environment.API_URL}${this.ruta}`);
  }
  agregarInstitucion(institucion:IInstitucion):Observable<any>{
    return this.httpclient.post<any>(`${environment.API_URL}${this.ruta}`,institucion);
  }
  editarInstitucion(id:number,institucion:IInstitucion):Observable<any>{
    return this.httpclient.put<any>(`${environment.API_URL}${this.ruta}/${id}`,institucion);
  }
}
