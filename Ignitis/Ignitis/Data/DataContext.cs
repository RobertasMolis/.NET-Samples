using Microsoft.EntityFrameworkCore;
using Ignitis.Models;
using System.Collections.Generic;

namespace Ignitis.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>().HasData(
            new Form
            {
                Id = 1
            });

            modelBuilder.Entity<Question>().HasData(new List<Question>()
            {
                    new Question(){
                    Id = 1,
                    AnswerId = null,
                    FormId = 1,
                    Title = "Reikia atlikti Rangos darbus"
                      },
                    new Question(){
                    Id = 2,
                    AnswerId = null,
                    FormId = 1,
                    Title = "Rangos darbus atliks"
                     },
                    new Question(){
                    Id = 3,
                    AnswerId = null,
                    FormId = 1,
                    Title = "Verslo klientas"
                    },
                    new Question()
                    {
                    Id = 4,
                    AnswerId = null,
                    FormId = 1,
                    Title = "Skaiciavimo metodas"
                    },
                    new Question()
                    {
                    Id = 5,
                    AnswerId = null,
                    FormId = 1,
                    Title = "Svarbus klientas"
                    }
            });

            modelBuilder.Entity<Answer>().HasData(new List<Answer>()
            {

                new Answer(){
                    Id = 1,
                    Title = "Taip",
                    QuestionId = 1
                },
                new Answer(){
                    Id = 2,
                    Title = "Ne",
                    QuestionId = 1
                }
            });

            modelBuilder.Entity<Answer>().HasData(new List<Answer>()
            {

                new Answer(){
                    Id = 3,
                    Title = "Metinis rangovas",
                    QuestionId = 2
                },
                new Answer(){
                    Id = 4,
                    Title = "Vienkartinis rangovas",
                    QuestionId = 2
                }
            });

            modelBuilder.Entity<Answer>().HasData(new List<Answer>()
            {

                new Answer(){
                    Id = 5,
                    Title = "Taip",
                    QuestionId = 3

                },
                new Answer(){
                    Id = 6,
                    Title = "Ne",
                    QuestionId = 3
                }
            });

            modelBuilder.Entity<Answer>().HasData(new List<Answer>()
            {

                new Answer(){
                    Id = 7,
                    Title = "Automatinis",
                    QuestionId = 4

                },
                new Answer(){
                    Id = 8,
                    Title = "Rankinis",
                    QuestionId = 4
                }
            });

            modelBuilder.Entity<Answer>().HasData(new List<Answer>()
            {

                new Answer(){
                    Id = 9,
                    Title = "Taip",
                    QuestionId = 5

                },
                new Answer(){
                    Id = 10,
                    Title = "Ne",
                    QuestionId = 5
                }
            });
        }
    }
}
