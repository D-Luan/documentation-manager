using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentationManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameTechnologyNameToTitleInLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TechnologyName",
                table: "DocumentationLinks",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "DocumentationLinks",
                newName: "TechnologyName");
        }
    }
}
