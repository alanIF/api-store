using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiLojaStore.Migrations
{
    public partial class addcollumstableentrada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "qtd",
                table: "Entradas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "qtd",
                table: "Entradas");
        }
    }
}
