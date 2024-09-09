using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Models;

namespace MuteMate.Server.Data
{
    public class MuteMateDbContext : IdentityDbContext<ApplicationUser>
    {
        public MuteMateDbContext(DbContextOptions<MuteMateDbContext> options) : base(options)
        {

        }

        public DbSet<UserAnswerModel> UserAnswers { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<QuoteModel> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserAnswerModel>()
           .HasOne(ua => ua.Question)
           .WithMany() // 
           .HasForeignKey(ua => ua.QuestionId)
           .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            builder.Entity<UserAnswerModel>()
                .HasOne(ua => ua.Answer)
                .WithMany()
                .HasForeignKey(ua => ua.AnswerId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete



            builder.Entity<QuestionModel>().HasData(
new QuestionModel
{
    Id = 1,
    Question = "What color is this?",
    Image = "images/colors/brown.png",  // Brown
    Category = "Colors"
},
   new QuestionModel
   {
       Id = 2,
       Question = "What animal is this?",
       Image = "images/animals/beartecken.png",  // Bear
       Category = "Animals"
   },
new QuestionModel
{
    Id = 3,
    Question = "What letter is this?",
    Image = "images/Alphabet/a.png", // här ska det vara en bild på A
    Category = "Letters"
},
new QuestionModel
{
    Id = 4,
    Question = "What letter is this?",
    Image = "images/Alphabet/b.png", // här ska det vara en bild på B
    Category = "Letters"
},
new QuestionModel
{
    Id = 5,
    Question = "What letter is this?",
    Image = "images/Alphabet/c.png", // här ska det vara en bild på C
    Category = "Letters"
},
new QuestionModel
{
    Id = 6,
    Question = "What letter is this?",
    Image = "images/Alphabet/d.png", // här ska det vara en bild på D
    Category = "Letters"
},
new QuestionModel
{
    Id = 7,
    Question = "What letter is this?",
    Image = "images/Alphabet/e.png", // här ska det vara en bild på E
    Category = "Letters"
},
new QuestionModel
{
    Id = 8,
    Question = "What letter is this?",
    Image = "images/Alphabet/f.png", // här ska det vara en bild på F
    Category = "Letters"
},
new QuestionModel
{
    Id = 9,
    Question = "What letter is this?",
    Image = "images/Alphabet/g.png", // här ska det vara en bild på G
    Category = "Letters"
},
new QuestionModel
{
    Id = 10,
    Question = "What letter is this?",
    Image = "images/Alphabet/h.png", // här ska det vara en bild på H
    Category = "Letters"
},
new QuestionModel
{
    Id = 11,
    Question = "What letter is this?",
    Image = "images/Alphabet/i.png", // här ska det vara en bild på I
    Category = "Letters"
},
new QuestionModel
{
    Id = 12,
    Question = "What letter is this?",
    Image = "images/Alphabet/j.png", // här ska det vara en bild på J
    Category = "Letters"
},
new QuestionModel
{
    Id = 13,
    Question = "What letter is this?",
    Image = "images/Alphabet/k.png", // här ska det vara en bild på K
    Category = "Letters"
},
new QuestionModel
{
    Id = 14,
    Question = "What letter is this?",
    Image = "images/Alphabet/L.png", // här ska det vara en bild på L
    Category = "Letters"
},
new QuestionModel
{
    Id = 15,
    Question = "What letter is this?",
    Image = "images/Alphabet/m.png", // här ska det vara en bild på M
    Category = "Letters"
},
new QuestionModel
{
    Id = 16,
    Question = "What letter is this?",
    Image = "images/Alphabet/n.png", // här ska det vara en bild på N
    Category = "Letters"
},
new QuestionModel
{
    Id = 17,
    Question = "What letter is this?",
    Image = "images/Alphabet/o.png", // här ska det vara en bild på O
    Category = "Letters"
},
new QuestionModel
{
    Id = 18,
    Question = "What letter is this?",
    Image = "images/Alphabet/p.png", // här ska det vara en bild på P
    Category = "Letters"
},
new QuestionModel
{
    Id = 19,
    Question = "What letter is this?",
    Image = "images/Alphabet/q.png", // här ska det vara en bild på Q
    Category = "Letters"
},
new QuestionModel
{
    Id = 20,
    Question = "What letter is this?",
    Image = "images/Alphabet/r.png", // här ska det vara en bild på R
    Category = "Letters"
},
new QuestionModel
{
    Id = 21,
    Question = "What letter is this?",
    Image = "images/Alphabet/s.png", // här ska det vara en bild på S
    Category = "Letters"
},
new QuestionModel
{
    Id = 22,
    Question = "What letter is this?",
    Image = "images/Alphabet/t.png", // här ska det vara en bild på T
    Category = "Letters"
},
new QuestionModel
{
    Id = 23,
    Question = "What letter is this?",
    Image = "images/Alphabet/u.png", // här ska det vara en bild på U
    Category = "Letters"
},
new QuestionModel
{
    Id = 24,
    Question = "What letter is this?",
    Image = "images/Alphabet/v.png", // här ska det vara en bild på V
    Category = "Letters"
},
new QuestionModel
{
    Id = 25,
    Question = "What letter is this?",
    Image = "images/Alphabet/w.png", // här ska det vara en bild på W
    Category = "Letters"
},
new QuestionModel
{
    Id = 26,
    Question = "What letter is this?",
    Image = "images/Alphabet/x.png", // här ska det vara en bild på X
    Category = "Letters"
},
new QuestionModel
{
    Id = 27,
    Question = "What letter is this?",
    Image = "images/Alphabet/y.png", // här ska det vara en bild på Y
    Category = "Letters"
},
new QuestionModel
{
    Id = 28,
    Question = "What letter is this?",
    Image = "images/Alphabet/z.png", // här ska det vara en bild på Z
    Category = "Letters"
},
new QuestionModel
{
    Id = 29,
    Question = "What color is this?",
    Image = "images/colors/red.png",  // Red
    Category = "Colors"
},
           new QuestionModel
           {
               Id = 30,
               Question = "What color is this?",
               Image = "images/colors/blue.png",  // Blue
               Category = "Colors"
           },

            new QuestionModel
            {
                Id = 31,
                Question = "What color is this?",
                Image = "images/colors/green.png",  // Green
                Category = "Colors"
            },
           new QuestionModel
           {
               Id = 32,
               Question = "What color is this?",
               Image = "images/colors/black.png",  // Black
               Category = "Colors"
           },
            new QuestionModel
            {
                Id = 33,
                Question = "What color is this?",
                Image = "images/colors/white.png",  // White
                Category = "Colors"
            },
           new QuestionModel
           {
               Id = 34,
               Question = "What color is this?",
               Image = "images/colors/pink.png",  // Pink
               Category = "Colors"
           },

           new QuestionModel
           {
               Id = 35,
               Question = "What color is this?",
               Image = "images/colors/yellow.png",  // Yellow
               Category = "Colors"
           },
           new QuestionModel
           {
               Id = 36,
               Question = "What color is this?",
               Image = "images/colors/grey.png",  // Grey
               Category = "Colors"
           },
             new QuestionModel
             {
                 Id = 37,
                 Question = "What color is this?",
                 Image = "images/colors/purple.png",  // Purple
                 Category = "Colors"
             },

             new QuestionModel
             {
                 Id = 38,
                 Question = "What animal is this?",
                 Image = "images/animals/birdtecken.png",  // Bird
                 Category = "Animals"
             },
             new QuestionModel
             {
                 Id = 39,
                 Question = "What animal is this?",
                 Image = "images/animals/bunnytecken.png",  // Bunny
                 Category = "Animals"
             },
             new QuestionModel
             {
                 Id = 40,
                 Question = "What animal is this?",
                 Image = "images/animals/cattecken.png",  // Cat
                 Category = "Animals"
             },
             new QuestionModel
             {
                 Id = 41,
                 Question = "What animal is this?",
                 Image = "images/animals/chickentecken.png",  // Chicken
                 Category = "Animals"
             },
             new QuestionModel
             {
                 Id = 42,
                 Question = "What animal is this?",
                 Image = "images/animals/cowtecken.png",  // Cow
                 Category = "Animals"
             },
             new QuestionModel
             {
                 Id = 43,
                 Question = "What animal is this?",
                 Image = "images/animals/dogtecken.png",  // Dog
                 Category = "Animals"
             },
             new QuestionModel
             {
                 Id = 44,
                 Question = "What animal is this?",
                 Image = "images/animals/goattecken.png",  // Goat
                 Category = "Animals"
             },
             new QuestionModel
             {
                 Id = 45,
                 Question = "What animal is this?",
                 Image = "images/animals/horsetecken.png",  // Horse
                 Category = "Animals"
             },
             new QuestionModel
             {
                 Id = 46,
                 Question = "What animal is this?",
                 Image = "images/animals/sheeptecken.png",  // Sheep
                 Category = "Animals"
             }

            );
            builder.Entity<AnswerModel>().HasData(
            // för bokstaven A
            new AnswerModel
            {
                Id = 1,
                Answer = "A",
                IsCorrect = true,
                QuestionId = 3,
            },

            new AnswerModel
            {
                Id = 2,
                Answer = "B",
                IsCorrect = false,
                QuestionId = 3,
            },
            new AnswerModel
            {
                Id = 3,
                Answer = "C",
                IsCorrect = false,
                QuestionId = 3,
            },
            new AnswerModel
            {
                Id = 4,
                Answer = "D",
                IsCorrect = false,
                QuestionId = 3,
            },
            //för bokstaven B
             new AnswerModel
             {
                 Id = 5,
                 Answer = "N",
                 IsCorrect = false,
                 QuestionId = 4,
             },

              new AnswerModel
              {
                  Id = 6,
                  Answer = "B",
                  IsCorrect = true,
                  QuestionId = 4,
              },
               new AnswerModel
               {
                   Id = 7,
                   Answer = "T",
                   IsCorrect = false,
                   QuestionId = 4,
               },
                new AnswerModel
                {
                    Id = 8,
                    Answer = "F",
                    IsCorrect = false,
                    QuestionId = 5,
                },
                //för bokstaven C
                new AnswerModel
                {
                    Id = 9,
                    Answer = "N",
                    IsCorrect = false,
                    QuestionId = 5,
                },

              new AnswerModel
              {
                  Id = 10,
                  Answer = "Z",
                  IsCorrect = false,
                  QuestionId = 5,
              },
               new AnswerModel
               {
                   Id = 11,
                   Answer = "C",
                   IsCorrect = true,
                   QuestionId = 5,
               },
                new AnswerModel
                {
                    Id = 12,
                    Answer = "K",
                    IsCorrect = false,
                    QuestionId = 5,
                },

                //för bokstaven D
                new AnswerModel
                {
                    Id = 13,
                    Answer = "D",
                    IsCorrect = true,
                    QuestionId = 6,
                },

              new AnswerModel
              {
                  Id = 14,
                  Answer = "P",
                  IsCorrect = false,
                  QuestionId = 6,
              },
               new AnswerModel
               {
                   Id = 15,
                   Answer = "H",
                   IsCorrect = false,
                   QuestionId = 6,
               },
                new AnswerModel
                {
                    Id = 16,
                    Answer = "R",
                    IsCorrect = false,
                    QuestionId = 6,
                },
                //för bokstaven E
                new AnswerModel
                {
                    Id = 17,
                    Answer = "G",
                    IsCorrect = false,
                    QuestionId = 7,
                },

              new AnswerModel
              {
                  Id = 18,
                  Answer = "R",
                  IsCorrect = false,
                  QuestionId = 7,
              },
               new AnswerModel
               {
                   Id = 19,
                   Answer = "I",
                   IsCorrect = false,
                   QuestionId = 7,
               },
                new AnswerModel
                {
                    Id = 20,
                    Answer = "E",
                    IsCorrect = true,
                    QuestionId = 7,
                },
                //för bokstaven F
                new AnswerModel
                {
                    Id = 21,
                    Answer = "O",
                    IsCorrect = false,
                    QuestionId = 8,
                },

              new AnswerModel
              {
                  Id = 22,
                  Answer = "F",
                  IsCorrect = true,
                  QuestionId = 8,
              },
               new AnswerModel
               {
                   Id = 23,
                   Answer = "H",
                   IsCorrect = false,
                   QuestionId = 8,
               },
                new AnswerModel
                {
                    Id = 24,
                    Answer = "T",
                    IsCorrect = false,
                    QuestionId = 8,
                },
                //för bokstaven G
                new AnswerModel
                {
                    Id = 25,
                    Answer = "M",
                    IsCorrect = false,
                    QuestionId = 9,
                },

              new AnswerModel
              {
                  Id = 26,
                  Answer = "U",
                  IsCorrect = false,
                  QuestionId = 9,
              },
               new AnswerModel
               {
                   Id = 27,
                   Answer = "G",
                   IsCorrect = true,
                   QuestionId = 9,
               },
                new AnswerModel
                {
                    Id = 28,
                    Answer = "E",
                    IsCorrect = false,
                    QuestionId = 9,
                },   //för bokstaven H
                new AnswerModel
                {
                    Id = 29,
                    Answer = "Q",
                    IsCorrect = false,
                    QuestionId = 10,
                },

              new AnswerModel
              {
                  Id = 30,
                  Answer = "H",
                  IsCorrect = true,
                  QuestionId = 10,
              },
               new AnswerModel
               {
                   Id = 31,
                   Answer = "S",
                   IsCorrect = false,
                   QuestionId = 10,
               },
                new AnswerModel
                {
                    Id = 32,
                    Answer = "Y",
                    IsCorrect = false,
                    QuestionId = 10,
                },
                //för bokstaven I
                new AnswerModel
                {
                    Id = 33,
                    Answer = "A",
                    IsCorrect = false,
                    QuestionId = 11,
                },

              new AnswerModel
              {
                  Id = 34,
                  Answer = "G",
                  IsCorrect = false,
                  QuestionId = 11,
              },
               new AnswerModel
               {
                   Id = 35,
                   Answer = "L",
                   IsCorrect = false,
                   QuestionId = 11,
               },
                new AnswerModel
                {
                    Id = 36,
                    Answer = "I",
                    IsCorrect = true,
                    QuestionId = 11,
                },
                //för bokstaven J
                new AnswerModel
                {
                    Id = 37,
                    Answer = "J",
                    IsCorrect = true,
                    QuestionId = 12,
                },

              new AnswerModel
              {
                  Id = 38,
                  Answer = "W",
                  IsCorrect = false,
                  QuestionId = 12,
              },
               new AnswerModel
               {
                   Id = 39,
                   Answer = "X",
                   IsCorrect = false,
                   QuestionId = 12,
               },
                new AnswerModel
                {
                    Id = 40,
                    Answer = "E",
                    IsCorrect = false,
                    QuestionId = 12,
                },
                //för bokstaven K
                new AnswerModel
                {
                    Id = 41,
                    Answer = "J",
                    IsCorrect = false,
                    QuestionId = 13,
                },

              new AnswerModel
              {
                  Id = 42,
                  Answer = "V",
                  IsCorrect = false,
                  QuestionId = 13,
              },
               new AnswerModel
               {
                   Id = 43,
                   Answer = "K",
                   IsCorrect = true,
                   QuestionId = 13,
               },
                new AnswerModel
                {
                    Id = 44,
                    Answer = "N",
                    IsCorrect = false,
                    QuestionId = 13,
                },
                //för bokstaven L
                new AnswerModel
                {
                    Id = 45,
                    Answer = "L",
                    IsCorrect = true,
                    QuestionId = 14,
                },

              new AnswerModel
              {
                  Id = 46,
                  Answer = "O",
                  IsCorrect = false,
                  QuestionId = 14,
              },
               new AnswerModel
               {
                   Id = 47,
                   Answer = "T",
                   IsCorrect = false,
                   QuestionId = 14,
               },
                new AnswerModel
                {
                    Id = 48,
                    Answer = "B",
                    IsCorrect = false,
                    QuestionId = 14,
                },
                //för bokstaven M
                new AnswerModel
                {
                    Id = 49,
                    Answer = "P",
                    IsCorrect = false,
                    QuestionId = 15,
                },

              new AnswerModel
              {
                  Id = 50,
                  Answer = "M",
                  IsCorrect = true,
                  QuestionId = 15,
              },
               new AnswerModel
               {
                   Id = 51,
                   Answer = "S",
                   IsCorrect = false,
                   QuestionId = 15,
               },
                new AnswerModel
                {
                    Id = 52,
                    Answer = "Z",
                    IsCorrect = false,
                    QuestionId = 15,
                },
                //för bokstaven N
                new AnswerModel
                {
                    Id = 53,
                    Answer = "J",
                    IsCorrect = false,
                    QuestionId = 16,
                },

              new AnswerModel
              {
                  Id = 54,
                  Answer = "F",
                  IsCorrect = false,
                  QuestionId = 16,
              },
               new AnswerModel
               {
                   Id = 55,
                   Answer = "U",
                   IsCorrect = false,
                   QuestionId = 16,
               },
                new AnswerModel
                {
                    Id = 56,
                    Answer = "N",
                    IsCorrect = true,
                    QuestionId = 16,
                },
                //för bokstaven O
                new AnswerModel
                {
                    Id = 57,
                    Answer = "O",
                    IsCorrect = true,
                    QuestionId = 17,
                },

              new AnswerModel
              {
                  Id = 58,
                  Answer = "Q",
                  IsCorrect = false,
                  QuestionId = 17,
              },
               new AnswerModel
               {
                   Id = 59,
                   Answer = "K",
                   IsCorrect = false,
                   QuestionId = 17,
               },
                new AnswerModel
                {
                    Id = 60,
                    Answer = "H",
                    IsCorrect = false,
                    QuestionId = 17,
                },
                //för bokstaven P
                new AnswerModel
                {
                    Id = 61,
                    Answer = "R",
                    IsCorrect = false,
                    QuestionId = 18,
                },

              new AnswerModel
              {
                  Id = 63,
                  Answer = "C",
                  IsCorrect = false,
                  QuestionId = 18,
              },
               new AnswerModel
               {
                   Id = 64,
                   Answer = "P",
                   IsCorrect = true,
                   QuestionId = 18,
               },
                new AnswerModel
                {
                    Id = 65,
                    Answer = "I",
                    IsCorrect = false,
                    QuestionId = 18,
                },
                //för bokstaven Q
                new AnswerModel
                {
                    Id = 66,
                    Answer = "M",
                    IsCorrect = false,
                    QuestionId = 18,
                },

              new AnswerModel
              {
                  Id = 67,
                  Answer = "Q",
                  IsCorrect = true,
                  QuestionId = 19,
              },
               new AnswerModel
               {
                   Id = 68,
                   Answer = "X",
                   IsCorrect = false,
                   QuestionId = 19,
               },
                new AnswerModel
                {
                    Id = 69,
                    Answer = "W",
                    IsCorrect = false,
                    QuestionId = 19,
                },
                //för bokstaven R
                new AnswerModel
                {
                    Id = 70,
                    Answer = "D",
                    IsCorrect = false,
                    QuestionId = 20,
                },

              new AnswerModel
              {
                  Id = 71,
                  Answer = "Y",
                  IsCorrect = false,
                  QuestionId = 20,
              },
               new AnswerModel
               {
                   Id = 72,
                   Answer = "T",
                   IsCorrect = false,
                   QuestionId = 20,
               },
                new AnswerModel
                {
                    Id = 73,
                    Answer = "R",
                    IsCorrect = true,
                    QuestionId = 20,
                },
                //för bokstaven S
                new AnswerModel
                {
                    Id = 74,
                    Answer = "´Q",
                    IsCorrect = false,
                    QuestionId = 21,
                },

              new AnswerModel
              {
                  Id = 75,
                  Answer = "Á",
                  IsCorrect = false,
                  QuestionId = 21,
              },
               new AnswerModel
               {
                   Id = 76,
                   Answer = "H",
                   IsCorrect = true,
                   QuestionId = 21,
               },
                new AnswerModel
                {
                    Id = 77,
                    Answer = "I",
                    IsCorrect = false,
                    QuestionId = 21,
                },
                //för bokstaven T
                new AnswerModel
                {
                    Id = 78,
                    Answer = "T",
                    IsCorrect = true,
                    QuestionId = 22,
                },

              new AnswerModel
              {
                  Id = 79,
                  Answer = "F",
                  IsCorrect = false,
                  QuestionId = 22,
              },
               new AnswerModel
               {
                   Id = 80,
                   Answer = "N",
                   IsCorrect = false,
                   QuestionId = 22,
               },
                new AnswerModel
                {
                    Id = 81,
                    Answer = "M",
                    IsCorrect = false,
                    QuestionId = 22,
                },
                //för bokstaven U
                new AnswerModel
                {
                    Id = 82,
                    Answer = "J",
                    IsCorrect = false,
                    QuestionId = 23,
                },

              new AnswerModel
              {
                  Id = 83,
                  Answer = "X",
                  IsCorrect = false,
                  QuestionId = 23,
              },
               new AnswerModel
               {
                   Id = 84,
                   Answer = "U",
                   IsCorrect = true,
                   QuestionId = 23,
               },
                new AnswerModel
                {
                    Id = 85,
                    Answer = "L",
                    IsCorrect = false,
                    QuestionId = 23,
                },
                //för bokstaven V
                new AnswerModel
                {
                    Id = 86,
                    Answer = "O",
                    IsCorrect = false,
                    QuestionId = 24,
                },

              new AnswerModel
              {
                  Id = 87,
                  Answer = "B",
                  IsCorrect = false,
                  QuestionId = 24,
              },
               new AnswerModel
               {
                   Id = 88,
                   Answer = "E",
                   IsCorrect = false,
                   QuestionId = 24,
               },
                new AnswerModel
                {
                    Id = 89,
                    Answer = "V",
                    IsCorrect = true,
                    QuestionId = 24,
                },
                //för bokstaven W
                new AnswerModel
                {
                    Id = 90,
                    Answer = "V",
                    IsCorrect = false,
                    QuestionId = 25,
                },

              new AnswerModel
              {
                  Id = 91,
                  Answer = "W",
                  IsCorrect = true,
                  QuestionId = 25,
              },
               new AnswerModel
               {
                   Id = 92,
                   Answer = "G",
                   IsCorrect = false,
                   QuestionId = 25,
               },
                new AnswerModel
                {
                    Id = 93,
                    Answer = "M",
                    IsCorrect = false,
                    QuestionId = 25,
                },
                //för bokstaven X
                new AnswerModel
                {
                    Id = 94,
                    Answer = "X",
                    IsCorrect = true,
                    QuestionId = 26,
                },

              new AnswerModel
              {
                  Id = 95,
                  Answer = "K",
                  IsCorrect = false,
                  QuestionId = 26,
              },
               new AnswerModel
               {
                   Id = 96,
                   Answer = "Z",
                   IsCorrect = false,
                   QuestionId = 26,
               },
                new AnswerModel
                {
                    Id = 97,
                    Answer = "H",
                    IsCorrect = false,
                    QuestionId = 26,
                },
                //för bokstaven Y
                new AnswerModel
                {
                    Id = 98,
                    Answer = "D",
                    IsCorrect = false,
                    QuestionId = 27,
                },

              new AnswerModel
              {
                  Id = 99,
                  Answer = "S",
                  IsCorrect = false,
                  QuestionId = 27,
              },
               new AnswerModel
               {
                   Id = 100,
                   Answer = "U",
                   IsCorrect = false,
                   QuestionId = 27,
               },
                new AnswerModel
                {
                    Id = 101,
                    Answer = "Y",
                    IsCorrect = true,
                    QuestionId = 27,
                },
                //för bokstaven Z
                new AnswerModel
                {
                    Id = 102,
                    Answer = "Y",
                    IsCorrect = false,
                    QuestionId = 28,
                },

              new AnswerModel
              {
                  Id = 103,
                  Answer = "W",
                  IsCorrect = false,
                  QuestionId = 28,
              },
               new AnswerModel
               {
                   Id = 104,
                   Answer = "V",
                   IsCorrect = false,
                   QuestionId = 28,
               },
                new AnswerModel
                {
                    Id = 105,
                    Answer = "Z",
                    IsCorrect = true,
                    QuestionId = 28,
                },
                //för färgen brown
                new AnswerModel
                {
                    Id = 106,
                    Answer = "Blue",
                    IsCorrect = false,
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id = 107,
                    Answer = "Brown",
                    IsCorrect = true,
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id = 108,
                    Answer = "Black",
                    IsCorrect = false,
                    QuestionId = 1,
                },
                new AnswerModel
                {
                    Id = 109,
                    Answer = "Red",
                    IsCorrect = false,
                    QuestionId = 1,
                },
                //för färgen RED
                new AnswerModel
                {
                    Id = 110,
                    Answer = "Red",
                    IsCorrect = true,
                    QuestionId = 29,
                },
                new AnswerModel
                {
                    Id = 111,
                    Answer = "White",
                    IsCorrect = false,
                    QuestionId = 29,
                },
                new AnswerModel
                {
                    Id = 112,
                    Answer = "Yellow",
                    IsCorrect = false,
                    QuestionId = 29,
                },
                new AnswerModel
                {
                    Id = 113,
                    Answer = "Purple",
                    IsCorrect = false,
                    QuestionId = 29,
                },
                //för färgen BLUE
                new AnswerModel
                {
                    Id = 114,
                    Answer = "Brown",
                    IsCorrect = false,
                    QuestionId = 30,
                },
                new AnswerModel
                {
                    Id = 115,
                    Answer = "Green",
                    IsCorrect = false,
                    QuestionId = 30,
                },
                new AnswerModel
                {
                    Id = 116,
                    Answer = "Pink",
                    IsCorrect = false,
                    QuestionId = 30,
                },
                new AnswerModel
                {
                    Id = 117,
                    Answer = "Blue",
                    IsCorrect = true,
                    QuestionId = 30,
                },
                //för färgen GREEN
                new AnswerModel
                {
                    Id = 118,
                    Answer = "Grey",
                    IsCorrect = false,
                    QuestionId = 31,
                },
                new AnswerModel
                {
                    Id = 119,
                    Answer = "Purple",
                    IsCorrect = false,
                    QuestionId = 31,
                },
                new AnswerModel
                {
                    Id = 120,
                    Answer = "Green",
                    IsCorrect = true,
                    QuestionId = 31,
                },
                new AnswerModel
                {
                    Id = 121,
                    Answer = "White",
                    IsCorrect = false,
                    QuestionId = 31,
                },
                //för färgen BLACK
                new AnswerModel
                {
                    Id = 122,
                    Answer = "Red",
                    IsCorrect = false,
                    QuestionId = 32,
                },
                new AnswerModel
                {
                    Id = 123,
                    Answer = "Blue",
                    IsCorrect = false,
                    QuestionId = 32,
                },
                new AnswerModel
                {
                    Id = 124,
                    Answer = "Grey",
                    IsCorrect = false,
                    QuestionId = 32,
                },
                new AnswerModel
                {
                    Id = 125,
                    Answer = "Black",
                    IsCorrect = true,
                    QuestionId = 32,
                },
                //för färgen WHITE
                new AnswerModel
                {
                    Id = 126,
                    Answer = "Green",
                    IsCorrect = false,
                    QuestionId = 33,
                },
                new AnswerModel
                {
                    Id = 127,
                    Answer = "White",
                    IsCorrect = true,
                    QuestionId = 33,
                },
                new AnswerModel
                {
                    Id = 128,
                    Answer = "Black",
                    IsCorrect = false,
                    QuestionId = 33,
                },
                new AnswerModel
                {
                    Id = 129,
                    Answer = "Pink",
                    IsCorrect = false,
                    QuestionId = 33,
                },
                //för färgen PINK
                new AnswerModel
                {
                    Id = 130,
                    Answer = "Yellow",
                    IsCorrect = false,
                    QuestionId = 34,
                },
                new AnswerModel
                {
                    Id = 131,
                    Answer = "Brown",
                    IsCorrect = false,
                    QuestionId = 34,
                },
                new AnswerModel
                {
                    Id = 132,
                    Answer = "Pink",
                    IsCorrect = true,
                    QuestionId = 34,
                },
                new AnswerModel
                {
                    Id = 133,
                    Answer = "Grey",
                    IsCorrect = false,
                    QuestionId = 34,
                },
                //för färgen YELLOW
                new AnswerModel
                {
                    Id = 134,
                    Answer = "Green",
                    IsCorrect = false,
                    QuestionId = 35,
                },
                new AnswerModel
                {
                    Id = 135,
                    Answer = "Purple",
                    IsCorrect = false,
                    QuestionId = 35,
                },
                new AnswerModel
                {
                    Id = 136,
                    Answer = "White",
                    IsCorrect = false,
                    QuestionId = 35,
                },
                new AnswerModel
                {
                    Id = 137,
                    Answer = "Yellow",
                    IsCorrect = true,
                    QuestionId = 35,
                },
                //för färgen GREY
                new AnswerModel
                {
                    Id = 138,
                    Answer = "Grey",
                    IsCorrect = true,
                    QuestionId = 36,
                },
                new AnswerModel
                {
                    Id = 139,
                    Answer = "Black",
                    IsCorrect = false,
                    QuestionId = 36,
                },
                new AnswerModel
                {
                    Id = 140,
                    Answer = "Brown",
                    IsCorrect = false,
                    QuestionId = 36,
                },
                new AnswerModel
                {
                    Id = 141,
                    Answer = "Red",
                    IsCorrect = false,
                    QuestionId = 36,
                },
                //för färgen PURPLE
                new AnswerModel
                {
                    Id = 142,
                    Answer = "Grey",
                    IsCorrect = false,
                    QuestionId = 37,
                },
                new AnswerModel
                {
                    Id = 143,
                    Answer = "Purple",
                    IsCorrect = true,
                    QuestionId = 37,
                },
                new AnswerModel
                {
                    Id = 144,
                    Answer = "Pink",
                    IsCorrect = false,
                    QuestionId = 37,
                },
                new AnswerModel
                {
                    Id = 145,
                    Answer = "Blue",
                    IsCorrect = false,
                    QuestionId = 37,
                },
                //För frågan bear
                new AnswerModel
                {
                    Id = 146,
                    Answer = "images/animals/bear.png",
                    IsCorrect = true,
                    QuestionId = 2,
                },
                new AnswerModel
                {
                    Id = 147,
                    Answer = "images/animals/horse.png",
                    IsCorrect = false,
                    QuestionId = 2,
                },
                new AnswerModel
                {
                    Id = 148,
                    Answer = "images/animals/cat.png",
                    IsCorrect = false,
                    QuestionId = 2,
                },
                new AnswerModel
                {
                    Id = 149,
                    Answer = "images/animals/sheep.png",
                    IsCorrect = false,
                    QuestionId = 2,
                },
                //För frågan bird
                new AnswerModel
                {
                    Id = 150,
                    Answer = "images/animals/bear.png",
                    IsCorrect = false,
                    QuestionId = 38,
                },
                new AnswerModel
                {
                    Id = 151,
                    Answer = "images/animals/bird.png",
                    IsCorrect = true,
                    QuestionId = 38,
                },
                new AnswerModel
                {
                    Id = 152,
                    Answer = "images/animals/cow.png",
                    IsCorrect = false,
                    QuestionId = 38,
                },
                new AnswerModel
                {
                    Id = 153,
                    Answer = "images/animals/bunny.png",
                    IsCorrect = false,
                    QuestionId = 38,
                },
                //För frågan bunny
                new AnswerModel
                {
                    Id = 154,
                    Answer = "images/animals/goat.png",
                    IsCorrect = false,
                    QuestionId = 39,
                },
                new AnswerModel
                {
                    Id = 155,
                    Answer = "images/animals/chicken.png",
                    IsCorrect = false,
                    QuestionId = 39,
                },
                new AnswerModel
                {
                    Id = 156,
                    Answer = "images/animals/cat.png",
                    IsCorrect = false,
                    QuestionId = 39,
                },
                new AnswerModel
                {
                    Id = 157,
                    Answer = "images/animals/bunny.png",
                    IsCorrect = true,
                    QuestionId = 39,
                },
                //För frågan cat
                new AnswerModel
                {
                    Id = 158,
                    Answer = "images/animals/dog.png",
                    IsCorrect = false,
                    QuestionId = 40,
                },
                new AnswerModel
                {
                    Id = 159,
                    Answer = "images/animals/chicken.png",
                    IsCorrect = false,
                    QuestionId = 40,
                },
                new AnswerModel
                {
                    Id = 160,
                    Answer = "images/animals/cat.png",
                    IsCorrect = true,
                    QuestionId = 40,
                },
                new AnswerModel
                {
                    Id = 161,
                    Answer = "images/animals/sheep.png",
                    IsCorrect = false,
                    QuestionId = 40,
                },
                //För frågan chicken
                new AnswerModel
                {
                    Id = 162,
                    Answer = "images/animals/cat.png",
                    IsCorrect = false,
                    QuestionId = 41,
                },
                new AnswerModel
                {
                    Id = 163,
                    Answer = "images/animals/chicken.png",
                    IsCorrect = true,
                    QuestionId = 41,
                },
                new AnswerModel
                {
                    Id = 164,
                    Answer = "images/animals/goat.png",
                    IsCorrect = false,
                    QuestionId = 41,
                },
                new AnswerModel
                {
                    Id = 165,
                    Answer = "images/animals/horse.png",
                    IsCorrect = false,
                    QuestionId = 41,
                },
                //För frågan cow
                new AnswerModel
                {
                    Id = 166,
                    Answer = "images/animals/bird.png",
                    IsCorrect = false,
                    QuestionId = 42,
                },
                new AnswerModel
                {
                    Id = 167,
                    Answer = "images/animals/cat.png",
                    IsCorrect = false,
                    QuestionId = 42,
                },
                new AnswerModel
                {
                    Id = 168,
                    Answer = "images/animals/bunny.png",
                    IsCorrect = false,
                    QuestionId = 42,
                },
                new AnswerModel
                {
                    Id = 169,
                    Answer = "images/animals/cow.png",
                    IsCorrect = true,
                    QuestionId = 42,
                },
                //För frågan Dog
                new AnswerModel
                {
                    Id = 170,
                    Answer = "images/animals/dog.png",
                    IsCorrect = true,
                    QuestionId = 43,
                },
                new AnswerModel
                {
                    Id = 171,
                    Answer = "images/animals/chicken.png",
                    IsCorrect = false,
                    QuestionId = 43,
                },
                new AnswerModel
                {
                    Id = 172,
                    Answer = "images/animals/horse.png",
                    IsCorrect = false,
                    QuestionId = 43,
                },
                new AnswerModel
                {
                    Id = 173,
                    Answer = "images/animals/sheep.png",
                    IsCorrect = false,
                    QuestionId = 43,
                },
                //För frågan Goat
                new AnswerModel
                {
                    Id = 174,
                    Answer = "images/animals/bear.png",
                    IsCorrect = false,
                    QuestionId = 44,
                },
                new AnswerModel
                {
                    Id = 175,
                    Answer = "images/animals/horse.png",
                    IsCorrect = false,
                    QuestionId = 44,
                },
                new AnswerModel
                {
                    Id = 176,
                    Answer = "images/animals/goat.png",
                    IsCorrect = true,
                    QuestionId = 44,
                },
                new AnswerModel
                {
                    Id = 177,
                    Answer = "images/animals/cat.png",
                    IsCorrect = false,
                    QuestionId = 44,
                },
                //För frågan Horse
                new AnswerModel
                {
                    Id = 178,
                    Answer = "images/animals/horse.png",
                    IsCorrect = true,
                    QuestionId = 45,
                },
                new AnswerModel
                {
                    Id = 179,
                    Answer = "images/animals/chicken.png",
                    IsCorrect = false,
                    QuestionId = 45,
                },
                new AnswerModel
                {
                    Id = 180,
                    Answer = "images/animals/sheep.png",
                    IsCorrect = false,
                    QuestionId = 45,
                },
                new AnswerModel
                {
                    Id = 181,
                    Answer = "images/animals/dog.png",
                    IsCorrect = false,
                    QuestionId = 45,
                },
                //För frågan Sheep
                new AnswerModel
                {
                    Id = 182,
                    Answer = "images/animals/bird.png",
                    IsCorrect = false,
                    QuestionId = 46,
                },
                new AnswerModel
                {
                    Id = 183,
                    Answer = "images/animals/sheep.png",
                    IsCorrect = true,
                    QuestionId = 46,
                },
                new AnswerModel
                {
                    Id = 184,
                    Answer = "images/animals/bunny.png",
                    IsCorrect = false,
                    QuestionId = 46,
                },
                new AnswerModel
                {
                    Id = 185,
                    Answer = "images/animals/cow.png",
                    IsCorrect = false,
                    QuestionId = 46,
                }
            );
            builder.Entity<QuoteModel>().HasData(
       new QuoteModel { Id = 1, Quote = "Wow, you’re really on a roll—keep up the great work!", Category = "Praise" },
       new QuoteModel { Id = 2, Quote = "Amazing job! Every step you take is a leap forward!", Category = "Praise" },
       new QuoteModel { Id = 3, Quote = "You’re shining brighter with every try—keep it up!", Category = "Praise" },
       new QuoteModel { Id = 4, Quote = "Fantastic effort! You're making it look easy!", Category = "Praise" },
       new QuoteModel { Id = 5, Quote = "You’re a natural—way to go!", Category = "Praise" },
       new QuoteModel { Id = 6, Quote = "It’s okay to take your time—you’re learning and growing!", Category = "Encouragement" },
       new QuoteModel { Id = 7, Quote = "Keep your chin up! Every try brings you closer to success!", Category = "Encouragement" },
       new QuoteModel { Id = 8, Quote = "Don’t worry about mistakes—they help you learn and improve!", Category = "Encouragement" },
       new QuoteModel { Id = 9, Quote = "Take a deep breath and give it another shot—you’ve got this!", Category = "Encouragement" },
       new QuoteModel { Id = 10, Quote = "Every step, no matter how small, is progress!", Category = "Encouragement" }
   );
        }
    }
}

