﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStyle.Dominio.Modelo;

namespace TechStyle.Dados.Map
{
    class EstoqueMap : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("Estoque"); 

            builder.HasKey(x => x.Id); 

            builder.Property(x => x.QuantidadeMinima)
                .HasColumnType("int(5)")
                .IsRequired();

            builder.Property(x => x.QuantidadeTotal)
                .HasColumnType("int(5)")
                .IsRequired();

            builder.Property(x => x.Local)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}