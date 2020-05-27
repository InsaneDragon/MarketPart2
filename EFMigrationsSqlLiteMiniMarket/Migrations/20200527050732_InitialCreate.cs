using Microsoft.EntityFrameworkCore.Migrations;

namespace EFMigrationsSqlLiteMiniMarket.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cattegories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cattegories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Cattegory = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cattegories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Dairy Products" });

            migrationBuilder.InsertData(
                table: "Cattegories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Meat Products" });

            migrationBuilder.InsertData(
                table: "Cattegories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Fruits" });

            migrationBuilder.InsertData(
                table: "Cattegories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Vegetables" });

            migrationBuilder.InsertData(
                table: "Cattegories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Bread" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cattegories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
