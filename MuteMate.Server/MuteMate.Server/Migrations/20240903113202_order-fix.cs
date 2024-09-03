using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuteMate.Server.Migrations
{
    /// <inheritdoc />
    public partial class orderfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 146,
                column: "question_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 147,
                column: "question_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 148,
                column: "question_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 149,
                column: "question_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 150,
                column: "question_id",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 151,
                column: "question_id",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 152,
                column: "question_id",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153,
                column: "question_id",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 154,
                column: "question_id",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 155,
                column: "question_id",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 156,
                column: "question_id",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 157,
                column: "question_id",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 158,
                column: "question_id",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 159,
                column: "question_id",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 160,
                column: "question_id",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 161,
                column: "question_id",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 162,
                column: "question_id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 163,
                column: "question_id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 164,
                column: "question_id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 165,
                column: "question_id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 166,
                column: "question_id",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167,
                column: "question_id",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 168,
                column: "question_id",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 169,
                column: "question_id",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 170,
                column: "question_id",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 171,
                column: "question_id",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 172,
                column: "question_id",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 173,
                column: "question_id",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 174,
                column: "question_id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 175,
                column: "question_id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 176,
                column: "question_id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 177,
                column: "question_id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 178,
                column: "question_id",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 179,
                column: "question_id",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 180,
                column: "question_id",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181,
                column: "question_id",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 182,
                column: "question_id",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 183,
                column: "question_id",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 184,
                column: "question_id",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 185,
                column: "question_id",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 186,
                column: "question_id",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 187,
                column: "question_id",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 188,
                column: "question_id",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 189,
                column: "question_id",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "image",
                value: "images/animals/beartecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38,
                column: "image",
                value: "images/animals/birdtecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39,
                column: "image",
                value: "images/animals/bunnytecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                column: "image",
                value: "images/animals/cattecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41,
                column: "image",
                value: "images/animals/chickentecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42,
                column: "image",
                value: "images/animals/cowtecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                column: "image",
                value: "images/animals/dogtecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44,
                column: "image",
                value: "images/animals/goattecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "image",
                value: "images/animals/horsetecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46,
                column: "image",
                value: "images/animals/sheeptecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47,
                column: "image",
                value: "images/animals/squirreltecken.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 146,
                column: "question_id",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 147,
                column: "question_id",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 148,
                column: "question_id",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 149,
                column: "question_id",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 150,
                column: "question_id",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 151,
                column: "question_id",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 152,
                column: "question_id",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153,
                column: "question_id",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 154,
                column: "question_id",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 155,
                column: "question_id",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 156,
                column: "question_id",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 157,
                column: "question_id",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 158,
                column: "question_id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 159,
                column: "question_id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 160,
                column: "question_id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 161,
                column: "question_id",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 162,
                column: "question_id",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 163,
                column: "question_id",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 164,
                column: "question_id",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 165,
                column: "question_id",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 166,
                column: "question_id",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167,
                column: "question_id",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 168,
                column: "question_id",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 169,
                column: "question_id",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 170,
                column: "question_id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 171,
                column: "question_id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 172,
                column: "question_id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 173,
                column: "question_id",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 174,
                column: "question_id",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 175,
                column: "question_id",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 176,
                column: "question_id",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 177,
                column: "question_id",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 178,
                column: "question_id",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 179,
                column: "question_id",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 180,
                column: "question_id",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181,
                column: "question_id",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 182,
                column: "question_id",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 183,
                column: "question_id",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 184,
                column: "question_id",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 185,
                column: "question_id",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 186,
                column: "question_id",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 187,
                column: "question_id",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 188,
                column: "question_id",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 189,
                column: "question_id",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38,
                column: "image",
                value: "images/animals/beartecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39,
                column: "image",
                value: "images/animals/birdtecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                column: "image",
                value: "images/animals/bunnytecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41,
                column: "image",
                value: "images/animals/cattecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42,
                column: "image",
                value: "images/animals/chickentecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                column: "image",
                value: "images/animals/cowtecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44,
                column: "image",
                value: "images/animals/dogtecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "image",
                value: "images/animals/goattecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46,
                column: "image",
                value: "images/animals/horsetecken.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47,
                column: "image",
                value: "images/animals/sheeptecken.png");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "category", "image", "question" },
                values: new object[] { 48, "Animals", "images/animals/squirreltecken.png", "What animal is this?" });
        }
    }
}
