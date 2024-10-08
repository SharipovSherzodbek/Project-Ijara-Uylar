﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace IjaraUy.API.Migrations
{
   
    public partial class InitialCreateAllTables : Migration
    {
       
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Guests", columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Gender = table.Column<int>(type: "int", nullable: false)

            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Guests", x => x.Id);
            });
        }

      
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Guests");
        }
    }
}
