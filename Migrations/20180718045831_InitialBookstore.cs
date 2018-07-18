using Microsoft.EntityFrameworkCore.Migrations;

namespace empstore.Migrations
{
    public partial class InitialBookstore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookstores",
                table: "Bookstores");

            migrationBuilder.RenameTable(
                name: "Bookstores",
                newName: "Empstores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empstores",
                table: "Empstores",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Empstores",
                table: "Empstores");

            migrationBuilder.RenameTable(
                name: "Empstores",
                newName: "Bookstores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookstores",
                table: "Bookstores",
                column: "Id");
        }
    }
}
