using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DN2_AuthTesting.Migrations
{
    public partial class MakeTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_PartOfSpeeches_PartOfSpeechId",
                table: "Words");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartOfSpeeches",
                table: "PartOfSpeeches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartofSpeeches",
                table: "PartOfSpeeches",
                column: "PartOfSpeechId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_PartofSpeeches_PartOfSpeechId",
                table: "Words",
                column: "PartOfSpeechId",
                principalTable: "PartOfSpeeches",
                principalColumn: "PartOfSpeechId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "PartOfSpeeches",
                newName: "PartofSpeeches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_PartofSpeeches_PartOfSpeechId",
                table: "Words");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartofSpeeches",
                table: "PartofSpeeches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartOfSpeeches",
                table: "PartofSpeeches",
                column: "PartOfSpeechId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_PartOfSpeeches_PartOfSpeechId",
                table: "Words",
                column: "PartOfSpeechId",
                principalTable: "PartofSpeeches",
                principalColumn: "PartOfSpeechId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "PartofSpeeches",
                newName: "PartOfSpeeches");
        }
    }
}
