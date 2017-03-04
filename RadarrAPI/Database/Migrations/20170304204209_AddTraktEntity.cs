﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RadarrAPI.Database.Migrations
{
    public partial class AddTraktEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trakt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false).Annotation("MySql:ValueGeneratedOnAdd", true),
                    State = table.Column<Guid>(nullable: false),
                    Target = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trakt", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trakt_State",
                table: "Trakt",
                column: "State");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trakt");
        }
    }
}
