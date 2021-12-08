using Microsoft.EntityFrameworkCore.Migrations;

namespace Arthropoda.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Familys",
                columns: table => new
                {
                    FamilyId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    InfraOrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familys", x => x.FamilyId);
                    table.ForeignKey(
                        name: "FK_Familys_InfraOrders_InfraOrderId",
                        column: x => x.InfraOrderId,
                        principalTable: "InfraOrders",
                        principalColumn: "InfraOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Familyinsects",
                columns: table => new
                {
                    FamilyinsectId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familyinsects", x => x.FamilyinsectId);
                    table.ForeignKey(
                        name: "FK_Familyinsects_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Generas",
                columns: table => new
                {
                    GeneraId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    FamilyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generas", x => x.GeneraId);
                    table.ForeignKey(
                        name: "FK_Generas_Familys_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Familys",
                        principalColumn: "FamilyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Familyinsects_OrderId",
                table: "Familyinsects",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Familys_InfraOrderId",
                table: "Familys",
                column: "InfraOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Generas_FamilyId",
                table: "Generas",
                column: "FamilyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Familyinsects");

            migrationBuilder.DropTable(
                name: "Generas");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Familys");

            migrationBuilder.DropTable(
                name: "InfraOrders");
        }
    }
}
