using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiLojaStore.Migrations
{
    public partial class tablesprodutousersentradaevenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_entrada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_fabricacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_validade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    idProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstoqueMinimo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_venda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qtd = table.Column<int>(type: "int", nullable: false),
                    observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idComprador = table.Column<int>(type: "int", nullable: false),
                    idProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
