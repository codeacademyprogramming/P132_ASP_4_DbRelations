using Microsoft.EntityFrameworkCore.Migrations;

namespace YumyApp.Migrations
{
    public partial class PriceColumnTypechangedInMeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Meals",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Meals",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
