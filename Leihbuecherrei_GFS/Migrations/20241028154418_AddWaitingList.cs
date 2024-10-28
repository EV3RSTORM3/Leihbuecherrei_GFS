using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leihbuecherrei_GFS.Migrations
{
    /// <inheritdoc />
    public partial class AddWaitingList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
