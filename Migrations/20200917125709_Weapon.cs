using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetRPG.Migrations
{
    public partial class Weapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapon_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_WeaponId",
                table: "Users",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_CharacterId",
                table: "Weapon",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Weapon_WeaponId",
                table: "Users",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Weapon_WeaponId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropIndex(
                name: "IX_Users_WeaponId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "Users");
        }
    }
}
