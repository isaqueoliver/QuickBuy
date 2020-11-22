import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  template: "<html><body>{{ obterNome() }}</body></html>",

})
export class ProdutoComponent{
  //camelCase e PascalCase
  public nome: string;
  public liberadoParaVenda: number;

  public obterNome(): string {
    return "Samsung";
  }
}
