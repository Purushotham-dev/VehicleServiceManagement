using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VSM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class loginModelUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LoginID",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_LoginID",
                table: "Users",
                column: "LoginID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Authentiation_LoginID",
                table: "Users",
                column: "LoginID",
                principalTable: "Authentiation",
                principalColumn: "LoginID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Authentiation_LoginID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LoginID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LoginID",
                table: "Users");
        }
    }
}
