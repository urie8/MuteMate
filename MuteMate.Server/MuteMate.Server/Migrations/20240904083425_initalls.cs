using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MuteMate.Server.Migrations
{
    /// <inheritdoc />
    public partial class initalls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153,
                column: "answer",
                value: "images/animals/bunny.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167,
                column: "answer",
                value: "images/animals/cat.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181,
                column: "answer",
                value: "images/animals/dog.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153,
                column: "answer",
                value: "images/animals/squirrel.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167,
                column: "answer",
                value: "images/animals/squirrel.png");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181,
                column: "answer",
                value: "images/animals/squirrel.png");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "category", "image", "question" },
                values: new object[] { 47, "Animals", "images/animals/squirreltecken.png", "What animal is this?" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "id", "answer", "is_correct", "question_id" },
                values: new object[,]
                {
                    { 186, "images/animals/horse.png", false, 47 },
                    { 187, "images/animals/dog.png", false, 47 },
                    { 188, "images/animals/squirrel.png", true, 47 },
                    { 189, "images/animals/bear.png", false, 47 }
                });
        }
    }
}
