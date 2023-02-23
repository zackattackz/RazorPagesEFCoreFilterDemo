using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesEFCoreFilterDemo.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CanineTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dog" },
                    { 2, "Wolf" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Hex", "Name" },
                values: new object[,]
                {
                    { 1, "ff0000", "Red" },
                    { 2, "0000ff", "Blue" },
                    { 3, "008000", "Green" },
                    { 4, "808080", "Gray" }
                });

            migrationBuilder.InsertData(
                table: "CrocodileTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Saltwater" },
                    { 2, "Nile" }
                });

            migrationBuilder.InsertData(
                table: "PrimateTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chimpanzee" },
                    { 2, "Orangutan" }
                });

            migrationBuilder.InsertData(
                table: "TurtleTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Box" },
                    { 2, "Wood" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "CanineTypeId", "HowlVolume", "Name", "Sex", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "Clifford", "M", "Canine" },
                    { 2, new DateTime(2003, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9001, "Legoshi", "M", "Canine" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "BiteForce", "CrocodileTypeId", "EggColorId", "Name", "ScaleHardness", "Sex", "Type" },
                values: new object[,]
                {
                    { 3, new DateTime(1962, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3, "Wally Gator", 10, "M", "Crocodile" },
                    { 4, new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 2, "Allie Gator", 20, "F", "Crocodile" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "GameHighScore", "Name", "PrimateTypeId", "Sex", "Type" },
                values: new object[,]
                {
                    { 5, new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Betsy", 2, "F", "Primate" },
                    { 6, new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Fred", 1, "M", "Primate" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "EggColorId", "Name", "ScaleHardness", "Sex", "ShellHardness", "TurtleTypeId", "Type" },
                values: new object[,]
                {
                    { 7, new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Slowpoke", 1, "F", 100, 1, "Turtle" },
                    { 8, new DateTime(1888, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Ol' Travis", 500, "M", 1000, 2, "Turtle" }
                });

            migrationBuilder.InsertData(
                table: "MammalHairColors",
                columns: new[] { "ColorId", "MammalId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 2 },
                    { 1, 5 },
                    { 2, 5 },
                    { 4, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CrocodileTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MammalHairColors",
                keyColumns: new[] { "ColorId", "MammalId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MammalHairColors",
                keyColumns: new[] { "ColorId", "MammalId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "MammalHairColors",
                keyColumns: new[] { "ColorId", "MammalId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MammalHairColors",
                keyColumns: new[] { "ColorId", "MammalId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "MammalHairColors",
                keyColumns: new[] { "ColorId", "MammalId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CrocodileTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TurtleTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TurtleTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CanineTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CanineTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrimateTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrimateTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
