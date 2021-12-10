using Microsoft.EntityFrameworkCore.Migrations;

namespace Arthropoda.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Familyinsects",
                columns: table => new
                {
                    FamilyinsectId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familyinsects", x => x.FamilyinsectId);
                });

            migrationBuilder.CreateTable(
                name: "Familys",
                columns: table => new
                {
                    FamilyId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familys", x => x.FamilyId);
                });

            migrationBuilder.CreateTable(
                name: "Generas",
                columns: table => new
                {
                    GeneraId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generas", x => x.GeneraId);
                });

            migrationBuilder.CreateTable(
                name: "InfraOrders",
                columns: table => new
                {
                    InfraOrderId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfraOrders", x => x.InfraOrderId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Familyinsects");

            migrationBuilder.DropTable(
                name: "Familys");

            migrationBuilder.DropTable(
                name: "Generas");

            migrationBuilder.DropTable(
                name: "InfraOrders");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
