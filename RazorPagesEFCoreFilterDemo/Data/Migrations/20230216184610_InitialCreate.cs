using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesEFCoreFilterDemo.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CanineTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanineTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Hex = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrocodileTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrocodileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimateTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimateTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TurtleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurtleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HowlVolume = table.Column<int>(type: "int", nullable: true),
                    CanineTypeId = table.Column<int>(type: "int", nullable: true),
                    GameHighScore = table.Column<int>(type: "int", nullable: true),
                    PrimateTypeId = table.Column<int>(type: "int", nullable: true),
                    ScaleHardness = table.Column<int>(type: "int", nullable: true),
                    EggColorId = table.Column<int>(type: "int", nullable: true),
                    BiteForce = table.Column<int>(type: "int", nullable: true),
                    CrocodileTypeId = table.Column<int>(type: "int", nullable: true),
                    ShellHardness = table.Column<int>(type: "int", nullable: true),
                    TurtleTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_CanineTypes_CanineTypeId",
                        column: x => x.CanineTypeId,
                        principalTable: "CanineTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Animals_Colors_EggColorId",
                        column: x => x.EggColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Animals_CrocodileTypes_CrocodileTypeId",
                        column: x => x.CrocodileTypeId,
                        principalTable: "CrocodileTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Animals_PrimateTypes_PrimateTypeId",
                        column: x => x.PrimateTypeId,
                        principalTable: "PrimateTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Animals_TurtleTypes_TurtleTypeId",
                        column: x => x.TurtleTypeId,
                        principalTable: "TurtleTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MammalHairColors",
                columns: table => new
                {
                    HairColorsId = table.Column<int>(type: "int", nullable: false),
                    MammalsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MammalHairColors", x => new { x.HairColorsId, x.MammalsId });
                    table.ForeignKey(
                        name: "FK_MammalHairColors_Animals_MammalsId",
                        column: x => x.MammalsId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MammalHairColors_Colors_HairColorsId",
                        column: x => x.HairColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CanineTypeId",
                table: "Animals",
                column: "CanineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CrocodileTypeId",
                table: "Animals",
                column: "CrocodileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_EggColorId",
                table: "Animals",
                column: "EggColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_PrimateTypeId",
                table: "Animals",
                column: "PrimateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_TurtleTypeId",
                table: "Animals",
                column: "TurtleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_Name",
                table: "Colors",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colors_Name_Hex",
                table: "Colors",
                columns: new[] { "Name", "Hex" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MammalHairColors_MammalsId",
                table: "MammalHairColors",
                column: "MammalsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MammalHairColors");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "CanineTypes");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "CrocodileTypes");

            migrationBuilder.DropTable(
                name: "PrimateTypes");

            migrationBuilder.DropTable(
                name: "TurtleTypes");
        }
    }
}
