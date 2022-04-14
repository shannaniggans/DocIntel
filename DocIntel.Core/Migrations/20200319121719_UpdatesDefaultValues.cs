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

using Microsoft.EntityFrameworkCore.Migrations;

namespace DocIntel.Core.Migrations
{
    public partial class UpdatesDefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                "BiasedWording",
                "Sources",
                oldDefaultValue: 0,
                defaultValue: -1);

            migrationBuilder.AlterColumn<int>(
                "Factual",
                "Sources",
                oldDefaultValue: 0,
                defaultValue: -1);

            migrationBuilder.AlterColumn<int>(
                "PoliticalAffiliation",
                "Sources",
                oldDefaultValue: 0,
                defaultValue: -1);

            migrationBuilder.AlterColumn<int>(
                "StoryChoice",
                "Sources",
                oldDefaultValue: 0,
                defaultValue: -1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                "BiasedWording",
                "Sources",
                oldDefaultValue: -1,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                "Factual",
                "Sources",
                oldDefaultValue: -1,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                "PoliticalAffiliation",
                "Sources",
                oldDefaultValue: -1,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                "StoryChoice",
                "Sources",
                oldDefaultValue: -1,
                defaultValue: 0);
        }
    }
}