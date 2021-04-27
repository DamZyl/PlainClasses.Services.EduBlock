using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlainClasses.Services.EduBlock.Api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EduBlockSubjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduBlockSubjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EduBlockSubjectId = table.Column<Guid>(nullable: false),
                    EduBlockSubjectName = table.Column<string>(nullable: true),
                    StartEduBlock = table.Column<DateTime>(nullable: false),
                    EndEduBlock = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    Place = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduBlocks_EduBlockSubjects_EduBlockSubjectId",
                        column: x => x.EduBlockSubjectId,
                        principalTable: "EduBlockSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonFunctions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: false),
                    EduBlockId = table.Column<Guid>(nullable: false),
                    Function = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonFunctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonFunctions_EduBlocks_EduBlockId",
                        column: x => x.EduBlockId,
                        principalTable: "EduBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlatoonInEduBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PlatoonId = table.Column<Guid>(nullable: false),
                    EduBlockId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatoonInEduBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlatoonInEduBlocks_EduBlocks_EduBlockId",
                        column: x => x.EduBlockId,
                        principalTable: "EduBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EduBlocks_EduBlockSubjectId",
                table: "EduBlocks",
                column: "EduBlockSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonFunctions_EduBlockId",
                table: "PersonFunctions",
                column: "EduBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatoonInEduBlocks_EduBlockId",
                table: "PlatoonInEduBlocks",
                column: "EduBlockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonFunctions");

            migrationBuilder.DropTable(
                name: "PlatoonInEduBlocks");

            migrationBuilder.DropTable(
                name: "EduBlocks");

            migrationBuilder.DropTable(
                name: "EduBlockSubjects");
        }
    }
}
