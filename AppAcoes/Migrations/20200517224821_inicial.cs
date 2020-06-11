using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAcoes.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    codigoAcao = table.Column<string>(nullable: true),
                    qtdAcao = table.Column<int>(nullable: false),
                    precoAcao = table.Column<double>(nullable: false),
                    data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acoes");
        }
    }
}
