using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_BlogRayting_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_blogRaytings",
                table: "blogRaytings");

            migrationBuilder.RenameTable(
                name: "blogRaytings",
                newName: "BlogRaytings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogRaytings",
                table: "BlogRaytings",
                column: "BlogRaytingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogRaytings",
                table: "BlogRaytings");

            migrationBuilder.RenameTable(
                name: "BlogRaytings",
                newName: "blogRaytings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogRaytings",
                table: "blogRaytings",
                column: "BlogRaytingId");
        }
    }
}
