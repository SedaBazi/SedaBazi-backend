using Microsoft.EntityFrameworkCore.Migrations;

namespace SedaBazi.Persistence.Migrations
{
    public partial class addIsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemoveTime",
                table: "AudioCollections",
                newName: "DeleteTime");

            migrationBuilder.RenameColumn(
                name: "IsRemoved",
                table: "AudioCollections",
                newName: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "AudioCollections",
                newName: "IsRemoved");

            migrationBuilder.RenameColumn(
                name: "DeleteTime",
                table: "AudioCollections",
                newName: "RemoveTime");
        }
    }
}
