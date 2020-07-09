import { Component, OnInit } from "@angular/core";
import { Usuarios } from "../../modelo/usuarios";
import { Router } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuarios/usuario.servico";

@Component({
  selector: "pesquisa-usuario",
  templateUrl: "./pesquisa.usuario.component.html",
  styleUrls: ["./pesquisa.usuario.component.scss"]
})
export class PesquisaUsuarioComponent implements OnInit {

  public usuarios: Usuarios[];

  constructor(private usuarioServico: UsuarioServico , private router:Router) {
    this.usuarioServico.obterTodosUsuarios()
      .subscribe(
        usuarios => {
          this.usuarios = usuarios
        },
        e => {
          console.log(e.error);

        });
  }
  ngOnInit(): void {

  }

  public adicionarUsuario() {
    this.router.navigate(['/cadastro-usuario']);
  }


  public deletarUsuario(usuario: Usuarios) {
    var retorno = confirm("Deseja realmente deletar o usuario selecionado ?");
    if (retorno == true) {
      this.usuarioServico.deletar(usuario).subscribe(
        usuarios => {
          this.usuarios = usuarios;
        }, e => {
          console.log(e.errors);
        });
    }
  }

  public editarUsuario(usuario: Usuarios) {
    sessionStorage.setItem('usuarioSession', JSON.stringify(usuario));
    this.router.navigate(['/cadastro-usuario']);

  }
 
  getEscolaridade(escolaridade: number) {
    if (escolaridade == 1) {

      return "Infantil";
    }
    else if (escolaridade == 2) {
      return "Fundamental";
    }
    else {
      return "Médio e Superior";
    }
  }


}
