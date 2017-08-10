using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DN2_AuthTesting.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartOfSpeeches",
                columns: table => new
                {
                    PartOfSpeechId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartOfSpeeches", x => x.PartOfSpeechId);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    WordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PartOfSpeechId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.WordId);
                    table.ForeignKey(
                        name: "FK_Words_PartOfSpeeches_PartOfSpeechId",
                        column: x => x.PartOfSpeechId,
                        principalTable: "PartOfSpeeches",
                        principalColumn: "PartOfSpeechId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Words_PartOfSpeechId",
                table: "Words",
                column: "PartOfSpeechId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "PartOfSpeeches");
        }
    }
}
