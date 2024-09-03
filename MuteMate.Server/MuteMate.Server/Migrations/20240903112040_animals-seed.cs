using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MuteMate.Server.Migrations
{
    /// <inheritdoc />
    public partial class animalsseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "category", "image", "question" },
                values: new object[,]
                {
                    { 38, "Animals", "images/animals/beartecken.png", "What animal is this?" },
                    { 39, "Animals", "images/animals/birdtecken.png", "What animal is this?" },
                    { 40, "Animals", "images/animals/bunnytecken.png", "What animal is this?" },
                    { 41, "Animals", "images/animals/cattecken.png", "What animal is this?" },
                    { 42, "Animals", "images/animals/chickentecken.png", "What animal is this?" },
                    { 43, "Animals", "images/animals/cowtecken.png", "What animal is this?" },
                    { 44, "Animals", "images/animals/dogtecken.png", "What animal is this?" },
                    { 45, "Animals", "images/animals/goattecken.png", "What animal is this?" },
                    { 46, "Animals", "images/animals/horsetecken.png", "What animal is this?" },
                    { 47, "Animals", "images/animals/sheeptecken.png", "What animal is this?" },
                    { 48, "Animals", "images/animals/squirreltecken.png", "What animal is this?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "id", "answer", "is_correct", "question_id" },
                values: new object[,]
                {
                    { 146, "images/animals/bear.png", true, 38 },
                    { 147, "images/animals/horse.png", false, 38 },
                    { 148, "images/animals/cat.png", false, 38 },
                    { 149, "images/animals/sheep.png", false, 38 },
                    { 150, "images/animals/bear.png", false, 39 },
                    { 151, "images/animals/bird.png", true, 39 },
                    { 152, "images/animals/cow.png", false, 39 },
                    { 153, "images/animals/squirrel.png", false, 39 },
                    { 154, "images/animals/goat.png", false, 40 },
                    { 155, "images/animals/chicken.png", false, 40 },
                    { 156, "images/animals/cat.png", false, 40 },
                    { 157, "images/animals/bunny.png", true, 40 },
                    { 158, "images/animals/dog.png", false, 41 },
                    { 159, "images/animals/chicken.png", false, 41 },
                    { 160, "images/animals/cat.png", true, 41 },
                    { 161, "images/animals/sheep.png", false, 41 },
                    { 162, "images/animals/cat.png", false, 42 },
                    { 163, "images/animals/chicken.png", true, 42 },
                    { 164, "images/animals/goat.png", false, 42 },
                    { 165, "images/animals/horse.png", false, 42 },
                    { 166, "images/animals/bird.png", false, 43 },
                    { 167, "images/animals/squirrel.png", false, 43 },
                    { 168, "images/animals/bunny.png", false, 43 },
                    { 169, "images/animals/cow.png", true, 43 },
                    { 170, "images/animals/dog.png", true, 44 },
                    { 171, "images/animals/chicken.png", false, 44 },
                    { 172, "images/animals/horse.png", false, 44 },
                    { 173, "images/animals/sheep.png", false, 44 },
                    { 174, "images/animals/bear.png", false, 45 },
                    { 175, "images/animals/horse.png", false, 45 },
                    { 176, "images/animals/goat.png", true, 45 },
                    { 177, "images/animals/cat.png", false, 45 },
                    { 178, "images/animals/horse.png", true, 46 },
                    { 179, "images/animals/chicken.png", false, 46 },
                    { 180, "images/animals/sheep.png", false, 46 },
                    { 181, "images/animals/squirrel.png", false, 46 },
                    { 182, "images/animals/bird.png", false, 47 },
                    { 183, "images/animals/sheep.png", true, 47 },
                    { 184, "images/animals/bunny.png", false, 47 },
                    { 185, "images/animals/cow.png", false, 47 },
                    { 186, "images/animals/horse.png", false, 48 },
                    { 187, "images/animals/dog.png", false, 48 },
                    { 188, "images/animals/squirrel.png", true, 48 },
                    { 189, "images/animals/bear.png", false, 48 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 185);

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
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 48);
        }
    }
}
