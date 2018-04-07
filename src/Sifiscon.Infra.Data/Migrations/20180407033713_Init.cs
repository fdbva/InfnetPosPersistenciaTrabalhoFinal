using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sifiscon.Infra.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cnpj = table.Column<string>(maxLength: 14, nullable: false),
                    InscricaoMunicipal = table.Column<string>(maxLength: 8, nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 200, nullable: false),
                    ReceitaBruta = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Bairro = table.Column<string>(maxLength: 100, nullable: false),
                    Cep = table.Column<string>(maxLength: 8, nullable: false),
                    Complemento = table.Column<string>(maxLength: 50, nullable: true),
                    FornecedorId = table.Column<Guid>(nullable: true),
                    Logradouro = table.Column<string>(maxLength: 100, nullable: false),
                    Municipio = table.Column<string>(maxLength: 200, nullable: false),
                    Numero = table.Column<string>(maxLength: 50, nullable: false),
                    UnidadeFederativa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cnpj = table.Column<string>(maxLength: 14, nullable: false),
                    DataRelato = table.Column<DateTime>(nullable: false),
                    FiscalResposavel = table.Column<string>(maxLength: 100, nullable: false),
                    FornecedorId = table.Column<Guid>(nullable: true),
                    NumeroProcesso = table.Column<string>(maxLength: 30, nullable: false),
                    RelatoFiscalizacao = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processos_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Estoque = table.Column<string>(nullable: true),
                    FornecedorId = table.Column<Guid>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AutosDeInfracao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Agravante = table.Column<bool>(nullable: false),
                    Atenuante = table.Column<bool>(nullable: false),
                    GravidadeInfracao = table.Column<int>(nullable: false),
                    ProcessoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutosDeInfracao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutosDeInfracao_Processos_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "Processos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutosDeInfracao_ProcessoId",
                table: "AutosDeInfracao",
                column: "ProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_FornecedorId",
                table: "Enderecos",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_FornecedorId",
                table: "Processos",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedorId",
                table: "Produtos",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutosDeInfracao");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Processos");

            migrationBuilder.DropTable(
                name: "Fornecedores");
        }
    }
}
