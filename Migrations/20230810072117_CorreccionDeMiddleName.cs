using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABCareApp.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionDeMiddleName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MidleName",
                table: "AspNetUsers",
                newName: "MiddleName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "AspNetUsers",
                newName: "MidleName");
        }
    }
}
