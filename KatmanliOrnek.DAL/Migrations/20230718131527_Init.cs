using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatmanliOrnek.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plaks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlakName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Discontinued = table.Column<bool>(type: "bit", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plaks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plaks_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "ArtistName", "CreatedBy", "CreatedDate", "State", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "Tarkan", null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(8057), "Created", null, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Password", "Role", "State", "UpdatedDate", "UserName" },
                values: new object[] { 1, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(4797), "admin", "Admin", "Created", null, "admin" });

            migrationBuilder.InsertData(
                table: "Plaks",
                columns: new[] { "Id", "ArtistId", "CreatedBy", "CreatedDate", "Discontinued", "Discount", "PlakName", "RecordDate", "State", "UnitPrice", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7109), false, 0.14999999999999999, "Şımarık", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 2, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7126), false, 0.14999999999999999, "Plak2", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 3, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7131), true, 0.14999999999999999, "Palk3", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 4, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7135), false, 0.14999999999999999, "plak4", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 5, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7141), true, 0.14999999999999999, "Palk4", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 6, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7146), false, 0.14999999999999999, "Plak5", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 7, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7151), false, 0.14999999999999999, "Palk6", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 8, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7155), false, 0.14999999999999999, "Plak7", new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 9, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7159), false, 0.14999999999999999, "Plak8", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 10, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7164), false, 0.14999999999999999, "Plak9", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 11, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7168), true, 0.14999999999999999, "Palk10", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 12, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7172), false, 0.14999999999999999, "Plak11", new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 13, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7177), false, 0.14999999999999999, "Plak12", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null },
                    { 14, 1, null, new DateTime(2023, 7, 18, 16, 15, 26, 978, DateTimeKind.Local).AddTicks(7181), true, 0.14999999999999999, "Plak13", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created", 10m, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plaks_ArtistId",
                table: "Plaks",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plaks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
