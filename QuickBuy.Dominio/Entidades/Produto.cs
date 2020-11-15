using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Preco == 0)
                AdicionarMensagem("O preço do produto não pode ser 0");
            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Produto precisa de um nome");
        }
    }
}
