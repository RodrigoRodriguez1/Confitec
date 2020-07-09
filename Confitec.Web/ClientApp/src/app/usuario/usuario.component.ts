import { Component, OnInit } from '@angular/core';
import { UsuarioServico } from '../servicos/usuarios/usuario.servico';
import { Usuarios } from '../modelo/usuarios';
import { Router } from '@angular/router';

@Component({
  selector: "cadastro-usuario",
  templateUrl: "./cadastro.usuario.component.html",
  styleUrls: ["./cadastro.usuario.component.scss"]
})
export class CadastroUsuario implements OnInit {

  public usuarios: Usuarios;
  public ativar_spinner: boolean;
  public mensagem: string;
  public usuarioCadastrado: boolean;

  constructor(private usuarioServico: UsuarioServico, private router: Router) {

  }

  ngOnInit(): void {
    var usuarioSession = sessionStorage.getItem('usuarioSession')
    if (usuarioSession) {
      this.usuarios = JSON.parse(usuarioSession);
    } else {
      this.usuarios = new Usuarios();
    }    
    
  }

  public cadastrar() {

    //alert(this.usuarios.Nome + " - " + this.usuarios.SobreNome + " - " + this.usuarios.Email + " - " + this.usuarios.Escolariedade + " - " + this.usuarios.DataNascimento);
    this.ativar_spinner = true;

    this.usuarioServico.cadastrarUsuario(this.usuarios)
      .subscribe(
        usuarioJson => {
          this.usuarioCadastrado = true;
          this.mensagem = "";
          this.ativar_spinner = false;
          this.router.navigate(['/pesquisa-usuario']);
        },
        e => {
          this.mensagem = e.error;
          this.ativar_spinner = false;
        }
      );
  }

}


