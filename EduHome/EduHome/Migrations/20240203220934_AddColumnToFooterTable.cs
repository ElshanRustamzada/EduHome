using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class AddColumnToFooterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FooterNumber",
                table: "Footer",
                newName: "VcontactUrl");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Footer",
                newName: "TwitterUrl");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FooterNumber1",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FooterNumber2",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InfoSite",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PinterestUrl",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubscribeSubTitle",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubscribeTitle",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Footer");

            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "Footer");

            migrationBuilder.DropColumn(
                name: "FooterNumber1",
                table: "Footer");

            migrationBuilder.DropColumn(
                name: "FooterNumber2",
                table: "Footer");

            migrationBuilder.DropColumn(
                name: "InfoSite",
                table: "Footer");

            migrationBuilder.DropColumn(
                name: "PinterestUrl",
                table: "Footer");

            migrationBuilder.DropColumn(
                name: "SubscribeSubTitle",
                table: "Footer");

            migrationBuilder.DropColumn(
                name: "SubscribeTitle",
                table: "Footer");

            migrationBuilder.RenameColumn(
                name: "VcontactUrl",
                table: "Footer",
                newName: "FooterNumber");

            migrationBuilder.RenameColumn(
                name: "TwitterUrl",
                table: "Footer",
                newName: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
