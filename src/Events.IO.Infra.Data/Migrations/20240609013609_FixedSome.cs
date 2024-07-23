using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Events.IO.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedSome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CascadeMode",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CascadeMode",
                table: "Events");
        }
    }
}
