using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder bd)
        {
            bd.Sql("INSERT INTO Categorias (Nome, ImagemURL) VALUES ('Bebidas', 'https://localhost:5001/images/categorias/bebidas.png')");
            bd.Sql("INSERT INTO Categorias (Nome, ImagemURL) VALUES ('Lanches', 'https://localhost:5001/images/categorias/lanches.png')");
            bd.Sql("INSERT INTO Categorias (Nome, ImagemURL) VALUES ('Sobremesas', 'https://localhost:5001/images/categorias/massas.png')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder bd)
        {
            bd.Sql("DELETE FROM Categorias");
        }
    }
}
