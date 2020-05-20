using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciarCarteira.API.Migrations
{
    public partial class relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_carteiras",
                table: "carteiras");

            migrationBuilder.RenameTable(
                name: "carteiras",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carteiras",
                table: "Carteiras",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    CarteiraId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Carteiras_CarteiraId",
                        column: x => x.UserId,
                        principalTable: "Carteiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CarteiraId",
                table: "Posts",
                column: "CarteiraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carteiras",
                table: "Carteiras");

            migrationBuilder.RenameTable(
                name: "Carteiras",
                newName: "carteiras");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carteiras",
                table: "carteiras",
                column: "Id");
        }
    }
}
