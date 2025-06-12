using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder bd)
        {
            bd.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES ('Cerveja Brahma','Lata 350 ML', '3.99', 'cerveja.jpg', 30, now(), 1)");
            bd.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES ('Cachorro Quente','Salsicha com Pão', '4.99', 'cachorroquente.jpg', 10, now(), 2)");
            bd.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES ('Pizza Margherita','Massa com Molho de Tomate e Queijo', '29.99', 'pizza.jpg', 15, now(), 2)");
            bd.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES ('Pudim','Sobremesa Tradicional', '10.99', 'pudim.jpg', 15, now(), 3)");
            bd.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES ('Bolo de Chocolate','Sobremesa Tradicional', '5.80', 'bolo.jpg', 10, now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder bd)
        {
            bd.Sql("DELETE FROM Produtos");
        }
    }
}
