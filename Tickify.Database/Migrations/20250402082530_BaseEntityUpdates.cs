using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickify.Database.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntityUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LogId",
                table: "Logs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogId",
                table: "Logs",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LogId",
                table: "Logs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogId",
                table: "Logs",
                column: "Id")
                .Annotation("SqlServer:Clustered", false);
        }
    }
}
