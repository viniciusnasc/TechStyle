﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStyle.Dominio.Modelo;

namespace TechStyle.Dados.Map
{
    class LojaMap : IEntityTypeConfiguration<Loja>
    {
        public void Configure(EntityTypeBuilder<Loja> builder)
        {
            builder.ToTable("Loja");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.QuantidadeLocal)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.QuantidadeMinima)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne<Produto>(p => p.Produto)
                    .WithOne(x => x.Loja)
                    .HasForeignKey<Loja>(i => i.IdProduto);
        }
    }
}
