﻿// <auto-generated />
using System;
using Ignitis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ignitis.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ignitis.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            QuestionId = 1,
                            Title = "Yes"
                        },
                        new
                        {
                            Id = 2,
                            QuestionId = 1,
                            Title = "No"
                        },
                        new
                        {
                            Id = 3,
                            QuestionId = 2,
                            Title = "Metinis Rangovas"
                        },
                        new
                        {
                            Id = 4,
                            QuestionId = 2,
                            Title = "Menesinis Rangovas"
                        },
                        new
                        {
                            Id = 5,
                            QuestionId = 3,
                            Title = "Taip"
                        },
                        new
                        {
                            Id = 6,
                            QuestionId = 3,
                            Title = "Ne"
                        },
                        new
                        {
                            Id = 7,
                            QuestionId = 4,
                            Title = "Automatinis"
                        },
                        new
                        {
                            Id = 8,
                            QuestionId = 4,
                            Title = "Manual"
                        },
                        new
                        {
                            Id = 9,
                            QuestionId = 5,
                            Title = "Taip"
                        },
                        new
                        {
                            Id = 10,
                            QuestionId = 5,
                            Title = "Ne"
                        });
                });

            modelBuilder.Entity("Ignitis.Models.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Forms");

                    b.HasData(
                        new
                        {
                            Id = 1
                        });
                });

            modelBuilder.Entity("Ignitis.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FormId = 1,
                            Title = "Reikia atlikti Rangos darbus"
                        },
                        new
                        {
                            Id = 2,
                            FormId = 1,
                            Title = "Rangos darbus atliks"
                        },
                        new
                        {
                            Id = 3,
                            FormId = 1,
                            Title = "Verslo klientas"
                        },
                        new
                        {
                            Id = 4,
                            FormId = 1,
                            Title = "Skaiciavimo metodas"
                        },
                        new
                        {
                            Id = 5,
                            FormId = 1,
                            Title = "Svarbus klientas"
                        });
                });

            modelBuilder.Entity("Ignitis.Models.Answer", b =>
                {
                    b.HasOne("Ignitis.Models.Question", "Question")
                        .WithMany("PossibleAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Ignitis.Models.Question", b =>
                {
                    b.HasOne("Ignitis.Models.Form", null)
                        .WithMany("Questions")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ignitis.Models.Form", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Ignitis.Models.Question", b =>
                {
                    b.Navigation("PossibleAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
