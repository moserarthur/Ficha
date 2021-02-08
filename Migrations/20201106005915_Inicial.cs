using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FichaApexEntityFramework.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Curso = table.Column<string>(maxLength: 20, nullable: false),
                    Instrutor = table.Column<string>(maxLength: 20, nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    SalaEquipamentos = table.Column<int>(nullable: false),
                    Pontualidade = table.Column<int>(nullable: false),
                    ConteudoApresentado = table.Column<int>(nullable: false),
                    InstrutorAV = table.Column<int>(nullable: false),
                    Dificuldade = table.Column<string>(maxLength: 200, nullable: true),
                    Sugestao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fichas");
        }
    }
}
