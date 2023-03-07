import { IPersona } from "./persona"

export interface IUsuario{
    nombreUsuario:string,
    contraseniaUsuario:string,
    estado:number|null,
    persona:IPersona,
    RolId:number
}