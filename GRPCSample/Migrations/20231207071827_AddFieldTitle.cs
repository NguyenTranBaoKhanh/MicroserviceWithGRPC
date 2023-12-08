using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GRPCSample.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ToDoItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "ToDoItems");
        }
    }
}
