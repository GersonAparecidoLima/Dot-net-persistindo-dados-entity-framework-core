using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Casiane", "Cassiane Santana Santos Manhães Guimarães é uma cantora e pastora brasileira. Recordista de vendas, a cantora alcançou destaque nacional ainda jovem.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Aline Barros", "Aline Kistenmacker Barros dos Santos MT MmPE é uma cantora, compositora e pastora brasileira. Considerada uma das maiores cantoras de música cristã do Brasil.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Marco Aurélio", "Marco Aurélio é um cantora e pastora brasileira.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Armando Filho", "Armando José da Silva Filho, é um cantor e compositor brasileiro de música cristã contemporânea. Começou sua carreira na Assembleia de Deus.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "J. Neto", "José Clementino de Azevedo Neto, mais conhecido como J. Neto, é um cantor e compositor brasileiro de música cristã contemporânea.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Fernandinho", "Fernando Jerônimo dos Santos Júnior, conhecido popularmente como Fernandinho, é um cantor brasileiro de música cristã contemporânea, compositor e pastor evangélico.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Shirley Carvalhaes", "Shirley Carvalhaes de Camargo, é uma cantora brasileira de música cristã contemporânea, que atua no segmento pentecostal.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
