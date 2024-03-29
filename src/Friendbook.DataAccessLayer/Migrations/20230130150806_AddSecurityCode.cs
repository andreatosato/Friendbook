﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friendbook.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddSecurityCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "People",
                type: "varchar(256)",
                unicode: false,
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "People");
        }
    }
}
