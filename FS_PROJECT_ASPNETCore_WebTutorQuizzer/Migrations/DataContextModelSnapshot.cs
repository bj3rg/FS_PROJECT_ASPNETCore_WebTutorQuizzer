﻿// <auto-generated />
using System;
using FS_PROJECT_ASPNETCore_WebTutorQuizzer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.EnumerationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Enumeration");
                });

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.MultipleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Choice1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Choice2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Choice3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Choice4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Multiple");
                });

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.QuizModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Quiz");
                });

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.SubjectModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.EnumerationModel", b =>
                {
                    b.HasOne("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.QuizModel", "Quiz")
                        .WithMany("Enumeration")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.MultipleModel", b =>
                {
                    b.HasOne("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.QuizModel", "Quiz")
                        .WithMany("Multiple")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.QuizModel", b =>
                {
                    b.HasOne("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.SubjectModel", "Subject")
                        .WithMany("Quizzes")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.QuizModel", b =>
                {
                    b.Navigation("Enumeration");

                    b.Navigation("Multiple");
                });

            modelBuilder.Entity("FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models.SubjectModel", b =>
                {
                    b.Navigation("Quizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
