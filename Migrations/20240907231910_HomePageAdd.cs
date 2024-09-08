using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personalwebsite.Migrations
{
    /// <inheritdoc />
    public partial class HomePageAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomePage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Menu1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Menu2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Menu3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuContact = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePage", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePage");
        }
    }
}
