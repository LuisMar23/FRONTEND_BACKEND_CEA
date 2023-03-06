import { IPersona } from "./persona"

export interface IUsuario{
    id:number,
    nombreUsuario:string,
    contraseniaUsuario:string,
    estado:number
    idPersona:number,
    idRol:number
}