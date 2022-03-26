using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLTest02.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Estado_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Estado_id);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    Actividad_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false),
                    Detalles = table.Column<string>(maxLength: 1024, nullable: false),
                    Resuelto = table.Column<bool>(nullable: false),
                    Estado_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.Actividad_id);
                    table.ForeignKey(
                        name: "FK_Actividades_Estados_Estado_id",
                        column: x => x.Estado_id,
                        principalTable: "Estados",
                        principalColumn: "Estado_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_Estado_id",
                table: "Actividades",
                column: "Estado_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
