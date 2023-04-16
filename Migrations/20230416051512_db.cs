using Microsoft.EntityFrameworkCore.Migrations;

namespace Job_Board.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a17ff5f9-f465-426b-9b37-754a111fecb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "51295b18-fd49-4b15-b934-813b9e91a748");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d9e203d2-329a-4273-85a3-edf5f7ec12ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "af3fc0b3-9985-412e-8c4e-54f53c0e1e3a", "ADMIN@JOBBOARD.COM", "ADMIN", "AQAAAAEAACcQAAAAECZq4+hKcDyZNh7NmCQoqOwB2QbsUSxrkee4UpuLkgKmbN8vqNhXCBMn0NAJoo/3hw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "37f88515-ea21-4516-8906-66ddfcc8fdcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9b0daaf1-a429-4d7d-b8b8-1a3fd5d28137");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2c0c80d8-7cc9-41ab-9b7e-9688e07775e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "085b75cc-e227-41eb-aa45-b6720fc95557", null, null, "AQAAAAEAACcQAAAAENKP0tNNMym331aL2dSNkW3ghHdZB0khjIeTVraXw+IgRCn1z8GGL8rf3nH25Dk1Rw==" });
        }
    }
}
