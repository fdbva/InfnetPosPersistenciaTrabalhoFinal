﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Sifiscon.Domain.Constants;
using Sifiscon.Infra.Data.Context;
using System;

namespace Sifiscon.Infra.Data.Migrations
{
    [DbContext(typeof(SifisconContext))]
    [Migration("20180407033713_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sifiscon.Domain.Entities.AutoDeInfracao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Agravante");

                    b.Property<bool>("Atenuante");

                    b.Property<int>("GravidadeInfracao");

                    b.Property<Guid?>("ProcessoId");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("AutosDeInfracao");
                });

            modelBuilder.Entity("Sifiscon.Domain.Entities.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Complemento")
                        .HasMaxLength(50);

                    b.Property<Guid?>("FornecedorId");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("UnidadeFederativa");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Sifiscon.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<string>("InscricaoMunicipal")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<decimal>("ReceitaBruta");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("Sifiscon.Domain.Entities.Processo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<DateTime>("DataRelato");

                    b.Property<string>("FiscalResposavel")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid?>("FornecedorId");

                    b.Property<string>("NumeroProcesso")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("RelatoFiscalizacao")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Processos");
                });

            modelBuilder.Entity("Sifiscon.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Estoque");

                    b.Property<Guid?>("FornecedorId");

                    b.Property<string>("Marca");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Sifiscon.Domain.Entities.AutoDeInfracao", b =>
                {
                    b.HasOne("Sifiscon.Domain.Entities.Processo", "Processo")
                        .WithMany("AutosDeInfracao")
                        .HasForeignKey("ProcessoId");
                });

            modelBuilder.Entity("Sifiscon.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("Sifiscon.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Enderecos")
                        .HasForeignKey("FornecedorId");
                });

            modelBuilder.Entity("Sifiscon.Domain.Entities.Processo", b =>
                {
                    b.HasOne("Sifiscon.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Processos")
                        .HasForeignKey("FornecedorId");
                });

            modelBuilder.Entity("Sifiscon.Domain.Entities.Produto", b =>
                {
                    b.HasOne("Sifiscon.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId");
                });
#pragma warning restore 612, 618
        }
    }
}