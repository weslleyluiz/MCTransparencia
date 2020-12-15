using Microsoft.EntityFrameworkCore.Migrations;

namespace MCTransparencia.Migrations
{
    public partial class MCTransparenciaModelsServidorContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servidores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Rendimentos = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Rgf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servidores");
        }
    }
}
