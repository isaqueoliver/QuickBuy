﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);

            //Builder utiliza o padrão Fluent
            builder.Property(x => x.DataPedido).IsRequired();
            builder.Property(x => x.DataPrevisaoEntrega).IsRequired();
            builder.Property(x => x.CEP).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(100);
            builder.Property(x => x.EnderecoCompleto).IsRequired().HasMaxLength(100);
            builder.Property(x => x.NumeroEndereco).IsRequired();
        }
    }
}
