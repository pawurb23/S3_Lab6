using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class DodaniePływaków : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plywacy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImieNazwisko = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RokUrodzenia = table.Column<decimal>(type: "NUMERIC(4,0)", nullable: false),
                    NajlepszyCzas = table.Column<decimal>(type: "NUMERIC(5,2)", nullable: false),
                    CzyAktywnyZawodnik = table.Column<bool>(type: "bit", nullable: false),
                    IloscZlotychMedali = table.Column<byte>(type: "TINYINT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plywacy", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plywacy");
        }
    }
}
