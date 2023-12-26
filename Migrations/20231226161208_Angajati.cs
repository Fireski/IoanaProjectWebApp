using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IoanaProjectWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Angajati : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Angajati",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "AngajatiID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Angajati",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAngajarii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Departament = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Angajati", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AngajatiID",
                table: "Orders",
                column: "AngajatiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Angajati_AngajatiID",
                table: "Orders",
                column: "AngajatiID",
                principalTable: "Angajati",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Angajati_AngajatiID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Angajati");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AngajatiID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AngajatiID",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Angajati",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
