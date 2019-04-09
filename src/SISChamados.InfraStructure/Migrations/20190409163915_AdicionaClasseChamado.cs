using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SISChamados.InfraStructure.Migrations
{
    public partial class AdicionaClasseChamado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbChamado",
                columns: table => new
                {
                    ChamadoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    DtFim = table.Column<DateTime>(nullable: false),
                    DtInicio = table.Column<DateTime>(nullable: false),
                    Solucao = table.Column<string>(nullable: true),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbChamado", x => x.ChamadoID);
                    table.ForeignKey(
                        name: "FK_TbChamado_TbUsuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "TbUsuario",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbChamado_UsuarioID",
                table: "TbChamado",
                column: "UsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbChamado");
        }
    }
}
