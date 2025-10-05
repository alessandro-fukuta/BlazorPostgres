using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorPostgres.Migrations
{
    /// <inheritdoc />
    public partial class dbProdutosV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    codigo_barra = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    preco_custo = table.Column<decimal>(type: "numeric", nullable: false),
                    preco_custo_medio = table.Column<decimal>(type: "numeric", nullable: false),
                    preco_venda_prazo = table.Column<decimal>(type: "numeric", nullable: false),
                    preco_venda_vista = table.Column<decimal>(type: "numeric", nullable: false),
                    estoque = table.Column<int>(type: "integer", nullable: false),
                    categoriaID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                    table.ForeignKey(
                        name: "FK_produtos_categorias_categoriaID",
                        column: x => x.categoriaID,
                        principalTable: "categorias",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtos_categoriaID",
                table: "produtos",
                column: "categoriaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");

        }
    }
}
