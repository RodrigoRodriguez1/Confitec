import { Injectable, inject, Inject } from '@angular/core'
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuarios } from '../../modelo/usuarios';


@Injectable({
  providedIn: "root"
})
export class UsuarioServico {

  private baseURL: string;
  private _usuario: Usuarios;

  set usuario(usuario: Usuarios) {
    this._usuario = usuario;
  }

  get usuario(): Usuarios {
    return this._usuario;
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }
   
  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public cadastrarUsuario(usuario: Usuarios): Observable<Usuarios> {

    return this.http.post<Usuarios>(this.baseURL + "api/usuarios", JSON.stringify(usuario) , { headers: this.headers });

  }

  public salvar(usuarios: Usuarios): Observable<Usuarios> {


    return this.http.post<Usuarios>(this.baseURL + "api/usuarios/salvar", JSON.stringify(usuarios), { headers: this.headers })

  }


  public deletar(produto: Usuarios): Observable<Usuarios[]> {

    return this.http.post<Usuarios[]>(this.baseURL + "api/usuarios/deletar", JSON.stringify(produto), { headers: this.headers });
  }


  public obterTodosUsuarios(): Observable<Usuarios[]> {
    return this.http.get<Usuarios[]>(this.baseURL + "api/usuarios");
  }

  public obterUsuarios(usuariosId: number): Observable<Usuarios> {
    return this.http.get<Usuarios>(this.baseURL + "api/usuarios/obter");
  }

}
