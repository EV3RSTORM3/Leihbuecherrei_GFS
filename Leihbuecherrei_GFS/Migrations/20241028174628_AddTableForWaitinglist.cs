using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Leihbuecherrei_GFS.Migrations
{
    /// <inheritdoc />
    public partial class AddTableForWaitinglist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_readers_Books_BookId",
                table: "readers");

            migrationBuilder.DropIndex(
                name: "IX_readers_BookId",
                table: "readers");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "readers");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReaderId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_readers_ReaderId",
                        column: x => x.ReaderId,
                        principalTable: "readers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BookId",
                table: "Reservations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReaderId",
                table: "Reservations",
                column: "ReaderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "readers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_readers_BookId",
                table: "readers",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_readers_Books_BookId",
                table: "readers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
