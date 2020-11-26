import { Component } from "@angular/core";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"],
})
export class LoginComponent {
  public enderecoImg = "../../../assets/img/buy.jpeg";
  public titulo = "Titulo adicionado no componente";
  public email = "";
  public senha = "";

  entrar() {
    alert('entrar no sistema');
  }
}
