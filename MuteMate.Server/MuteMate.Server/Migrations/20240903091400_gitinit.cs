using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MuteMate.Server.Migrations
{
    /// <inheritdoc />
    public partial class gitinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_correct = table.Column<bool>(type: "bit", nullable: false),
                    question_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_question_id",
                        column: x => x.question_id,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    isCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnswers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "category", "image", "question" },
                values: new object[,]
                {
                    { 1, "Colors", "images/colors/brown.png", "What color is this?" },
                    { 2, "Animals", "", "What animal is this?" },
                    { 3, "Letters", "images/Alphabet/a.png", "What letter is this?" },
                    { 4, "Letters", "images/Alphabet/b.png", "What letter is this?" },
                    { 5, "Letters", "images/Alphabet/c.png", "What letter is this?" },
                    { 6, "Letters", "images/Alphabet/d.png", "What letter is this?" },
                    { 7, "Letters", "images/Alphabet/e.png", "What letter is this?" },
                    { 8, "Letters", "images/Alphabet/f.png", "What letter is this?" },
                    { 9, "Letters", "images/Alphabet/g.png", "What letter is this?" },
                    { 10, "Letters", "images/Alphabet/h.png", "What letter is this?" },
                    { 11, "Letters", "images/Alphabet/i.png", "What letter is this?" },
                    { 12, "Letters", "images/Alphabet/j.png", "What letter is this?" },
                    { 13, "Letters", "images/Alphabet/k.png", "What letter is this?" },
                    { 14, "Letters", "images/Alphabet/L.png", "What letter is this?" },
                    { 15, "Letters", "images/Alphabet/m.png", "What letter is this?" },
                    { 16, "Letters", "images/Alphabet/n.png", "What letter is this?" },
                    { 17, "Letters", "images/Alphabet/o.png", "What letter is this?" },
                    { 18, "Letters", "images/Alphabet/p.png", "What letter is this?" },
                    { 19, "Letters", "images/Alphabet/q.png", "What letter is this?" },
                    { 20, "Letters", "images/Alphabet/r.png", "What letter is this?" },
                    { 21, "Letters", "images/Alphabet/s.png", "What letter is this?" },
                    { 22, "Letters", "images/Alphabet/t.png", "What letter is this?" },
                    { 23, "Letters", "images/Alphabet/u.png", "What letter is this?" },
                    { 24, "Letters", "images/Alphabet/v.png", "What letter is this?" },
                    { 25, "Letters", "images/Alphabet/w.png", "What letter is this?" },
                    { 26, "Letters", "images/Alphabet/x.png", "What letter is this?" },
                    { 27, "Letters", "images/Alphabet/y.png", "What letter is this?" },
                    { 28, "Letters", "images/Alphabet/z.png", "What letter is this?" },
                    { 29, "Colors", "images/colors/red.png", "What color is this?" },
                    { 30, "Colors", "images/colors/blue.png", "What color is this?" },
                    { 31, "Colors", "images/colors/green.png", "What color is this?" },
                    { 32, "Colors", "images/colors/black.png", "What color is this?" },
                    { 33, "Colors", "images/colors/white.png", "What color is this?" },
                    { 34, "Colors", "images/colors/pink.png", "What color is this?" },
                    { 35, "Colors", "images/colors/yellow.png", "What color is this?" },
                    { 36, "Colors", "images/colors/grey.png", "What color is this?" },
                    { 37, "Colors", "images/colors/purple.png", "What color is this?" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "category", "quote" },
                values: new object[,]
                {
                    { 1, "Praise", "Wow, you’re really on a roll—keep up the great work!" },
                    { 2, "Praise", "Amazing job! Every step you take is a leap forward!" },
                    { 3, "Praise", "You’re shining brighter with every try—keep it up!" },
                    { 4, "Praise", "Fantastic effort! You're making it look easy!" },
                    { 5, "Praise", "You’re a natural—way to go!" },
                    { 6, "Encouragement", "It’s okay to take your time—you’re learning and growing!" },
                    { 7, "Encouragement", "Keep your chin up! Every try brings you closer to success!" },
                    { 8, "Encouragement", "Don’t worry about mistakes—they help you learn and improve!" },
                    { 9, "Encouragement", "Take a deep breath and give it another shot—you’ve got this!" },
                    { 10, "Encouragement", "Every step, no matter how small, is progress!" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "id", "answer", "is_correct", "question_id" },
                values: new object[,]
                {
                    { 1, "A", true, 3 },
                    { 2, "B", false, 3 },
                    { 3, "C", false, 3 },
                    { 4, "D", false, 3 },
                    { 5, "N", false, 4 },
                    { 6, "B", true, 4 },
                    { 7, "T", false, 4 },
                    { 8, "F", false, 5 },
                    { 9, "N", false, 5 },
                    { 10, "Z", false, 5 },
                    { 11, "C", true, 5 },
                    { 12, "K", false, 5 },
                    { 13, "D", true, 6 },
                    { 14, "P", false, 6 },
                    { 15, "H", false, 6 },
                    { 16, "R", false, 6 },
                    { 17, "G", false, 7 },
                    { 18, "R", false, 7 },
                    { 19, "I", false, 7 },
                    { 20, "E", true, 7 },
                    { 21, "O", false, 8 },
                    { 22, "F", true, 8 },
                    { 23, "H", false, 8 },
                    { 24, "T", false, 8 },
                    { 25, "M", false, 9 },
                    { 26, "U", false, 9 },
                    { 27, "G", true, 9 },
                    { 28, "E", false, 9 },
                    { 29, "Q", false, 10 },
                    { 30, "H", true, 10 },
                    { 31, "S", false, 10 },
                    { 32, "Y", false, 10 },
                    { 33, "A", false, 11 },
                    { 34, "G", false, 11 },
                    { 35, "L", false, 11 },
                    { 36, "I", true, 11 },
                    { 37, "J", true, 12 },
                    { 38, "W", false, 12 },
                    { 39, "X", false, 12 },
                    { 40, "E", false, 12 },
                    { 41, "J", false, 13 },
                    { 42, "V", false, 13 },
                    { 43, "K", true, 13 },
                    { 44, "N", false, 13 },
                    { 45, "L", true, 14 },
                    { 46, "O", false, 14 },
                    { 47, "T", false, 14 },
                    { 48, "B", false, 14 },
                    { 49, "P", false, 15 },
                    { 50, "M", true, 15 },
                    { 51, "S", false, 15 },
                    { 52, "Z", false, 15 },
                    { 53, "J", false, 16 },
                    { 54, "F", false, 16 },
                    { 55, "U", false, 16 },
                    { 56, "N", true, 16 },
                    { 57, "O", true, 17 },
                    { 58, "Q", false, 17 },
                    { 59, "K", false, 17 },
                    { 60, "H", false, 17 },
                    { 61, "R", false, 18 },
                    { 63, "C", false, 18 },
                    { 64, "P", true, 18 },
                    { 65, "I", false, 18 },
                    { 66, "M", false, 18 },
                    { 67, "Q", true, 19 },
                    { 68, "X", false, 19 },
                    { 69, "W", false, 19 },
                    { 70, "D", false, 20 },
                    { 71, "Y", false, 20 },
                    { 72, "T", false, 20 },
                    { 73, "R", true, 20 },
                    { 74, "´Q", false, 21 },
                    { 75, "Á", false, 21 },
                    { 76, "H", true, 21 },
                    { 77, "I", false, 21 },
                    { 78, "T", true, 22 },
                    { 79, "F", false, 22 },
                    { 80, "N", false, 22 },
                    { 81, "M", false, 22 },
                    { 82, "J", false, 23 },
                    { 83, "X", false, 23 },
                    { 84, "U", true, 23 },
                    { 85, "L", false, 23 },
                    { 86, "O", false, 24 },
                    { 87, "B", false, 24 },
                    { 88, "E", false, 24 },
                    { 89, "V", true, 24 },
                    { 90, "V", false, 25 },
                    { 91, "W", true, 25 },
                    { 92, "G", false, 25 },
                    { 93, "M", false, 25 },
                    { 94, "X", true, 26 },
                    { 95, "K", false, 26 },
                    { 96, "Z", false, 26 },
                    { 97, "H", false, 26 },
                    { 98, "D", false, 27 },
                    { 99, "S", false, 27 },
                    { 100, "U", false, 27 },
                    { 101, "Y", true, 27 },
                    { 102, "Y", false, 28 },
                    { 103, "W", false, 28 },
                    { 104, "V", false, 28 },
                    { 105, "Z", true, 28 },
                    { 106, "Blue", false, 1 },
                    { 107, "Brown", true, 1 },
                    { 108, "Black", false, 1 },
                    { 109, "Red", false, 1 },
                    { 110, "Red", true, 29 },
                    { 111, "White", false, 29 },
                    { 112, "Yellow", false, 29 },
                    { 113, "Purple", false, 29 },
                    { 114, "Brown", false, 30 },
                    { 115, "Green", false, 30 },
                    { 116, "Pink", false, 30 },
                    { 117, "Blue", true, 30 },
                    { 118, "Grey", false, 31 },
                    { 119, "Purple", false, 31 },
                    { 120, "Green", true, 31 },
                    { 121, "White", false, 31 },
                    { 122, "Red", false, 32 },
                    { 123, "Blue", false, 32 },
                    { 124, "Grey", false, 32 },
                    { 125, "Black", true, 32 },
                    { 126, "Green", false, 33 },
                    { 127, "White", true, 33 },
                    { 128, "Black", false, 33 },
                    { 129, "Pink", false, 33 },
                    { 130, "Yellow", false, 34 },
                    { 131, "Brown", false, 34 },
                    { 132, "Pink", true, 34 },
                    { 133, "Grey", false, 34 },
                    { 134, "Green", false, 35 },
                    { 135, "Purple", false, 35 },
                    { 136, "White", false, 35 },
                    { 137, "Yellow", true, 35 },
                    { 138, "Grey", true, 36 },
                    { 139, "Black", false, 36 },
                    { 140, "Brown", false, 36 },
                    { 141, "Red", false, 36 },
                    { 142, "Grey", false, 37 },
                    { 143, "Purple", true, 37 },
                    { 144, "Pink", false, 37 },
                    { 145, "Blue", false, 37 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_question_id",
                table: "Answers",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_AnswerId",
                table: "UserAnswers",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_UserId",
                table: "UserAnswers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "UserAnswers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
