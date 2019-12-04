using Microsoft.EntityFrameworkCore.Migrations;

namespace shopapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    product_name = table.Column<string>(nullable: true),
                    product_description = table.Column<string>(nullable: true),
                    product_price = table.Column<float>(nullable: false),
                    product_image = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
