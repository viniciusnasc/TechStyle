﻿using Microsoft.EntityFrameworkCore;
using System;
using TechStyle.Dados.Map;
using TechStyle.Dominio.Modelo;

namespace TechStyle.Dados
{
    public class Contexto : DbContext
    {
        public DbSet<Segmento> Segmento { get; set; } //Colocar todas classes q se tornarão tabela
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Loja> Loja { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R9JFMSC; Database=TechStyle; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SegmentoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new EstoqueMap());
            modelBuilder.ApplyConfiguration(new LojaMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}