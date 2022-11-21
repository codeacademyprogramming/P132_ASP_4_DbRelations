using Microsoft.EntityFrameworkCore.Migrations;

namespace YumyApp.Migrations
{
    public partial class TestimonilsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(maxLength: 20, nullable: false),
                    Position = table.Column<string>(maxLength: 20, nullable: false),
                    Img = table.Column<string>(maxLength: 100, nullable: true),
                    StarCount = table.Column<byte>(nullable: false),
                    Text = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
