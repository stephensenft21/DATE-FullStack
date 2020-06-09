using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class changedcommentdatabaseIDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7275254-8e36-4d34-9204-aa769f06a19a", "AQAAAAEAACcQAAAAEFftKqr/0dpgbhrT+/Z3fI/oTIo1YUn+zBhfs1p5vap2PArLtJygl4aWb3kIHoCdGw==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Text",
                keyValue: "Cool Shop",
                column: "CommentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Text",
                keyValue: "This place rocks",
                column: "CommentId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a543c3e8-1219-4918-84a3-b91dd31da335", "AQAAAAEAACcQAAAAEKmDmCwAkQJSqPLfgXm00gausB4Kl9z+Ma2F0Lme8jBh1qVRnxC+0ih1rmM/LvVHrA==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Text",
                keyValue: "Cool Shop",
                column: "CommentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Text",
                keyValue: "This place rocks",
                column: "CommentId",
                value: 4);
        }
    }
}
