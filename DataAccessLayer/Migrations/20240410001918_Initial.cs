using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {   Password= table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                 
                   Name=table.Column<string>(type: "nvarchar(max)", nullable: false), },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "navchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Return_Date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });
            migrationBuilder.CreateTable(
               name: "Books",
               columns: table => new
               {
                   Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   Title = table.Column<string>(type: "navchar(max)", nullable: false),
                   Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Reservation_System=table.Column<Boolean>(type: "bit",nullable: false),
                   Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Quantity = table.Column<int>(type: "int", nullable: false),
                   AvailableQuantity=table.Column<int>(type:"int", nullable: false),
                   Description=table.Column<string>(type: "nvarchar(max)", nullable: true)
                   
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Books", x => x.Id);
               });
            migrationBuilder.CreateTable(
              name: "Admin",
              columns: table => new
              {
                  Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                  Name= table.Column<string>(type: "nvchar(max)", nullable: false),
                  Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
              
                  Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                

              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Admin", x => x.Id);
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Book");
            migrationBuilder.DropTable(
                name: "Books");
            migrationBuilder.DropTable(
                name: "Admin");

        }
    }
}
