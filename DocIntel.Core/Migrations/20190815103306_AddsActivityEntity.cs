/*
 * DocIntel
 * Copyright (C) 2018-2021 Belgian Defense, Antoine Cailliau
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 * 
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DocIntel.Core.Migrations
{
    public partial class AddsActivityEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Activity",
                table => new
                {
                    ActivityId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ObjectId = table.Column<int>(nullable: false),
                    ObjectType = table.Column<int>(nullable: false),
                    TargetId = table.Column<int>(nullable: false),
                    TargetType = table.Column<int>(nullable: false),
                    Verb = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityId);
                    table.ForeignKey(
                        "FK_Activity_AspNetUsers_UserId",
                        x => x.UserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_Activity_UserId",
                "Activity",
                "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Activity");
        }
    }
}