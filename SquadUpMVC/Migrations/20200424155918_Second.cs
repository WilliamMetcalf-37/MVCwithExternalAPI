using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadUpMVC.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artitst",
                table: "Squad");

            migrationBuilder.AddColumn<string>(
                name: "Venue",
                table: "Squad",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SquadId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    SquadId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artist_Squad_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SquadId",
                table: "AspNetUsers",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_SquadId",
                table: "Artist",
                column: "SquadId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Squad_SquadId",
                table: "AspNetUsers",
                column: "SquadId",
                principalTable: "Squad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Squad_SquadId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SquadId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Venue",
                table: "Squad");

            migrationBuilder.DropColumn(
                name: "SquadId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Artitst",
                table: "Squad",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
