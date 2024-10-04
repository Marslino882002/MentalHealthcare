﻿// <auto-generated />
using MentalHealthcare.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MentalHealthcare.Infrastructure.Migrations
{
    [DbContext(typeof(MentalHealthDbContext))]
    [Migration("20241001221425_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MentalHealthcare.Domain.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MentalHealthcare.Domain.Entities.CourseMateriel", b =>
                {
                    b.Property<int>("CourseMaterielId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CourseMaterielId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsVideo")
                        .HasColumnType("boolean");

                    b.Property<int>("ItemOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CourseMaterielId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseMateriels");
                });

            modelBuilder.Entity("MentalHealthcare.Domain.Entities.CourseMateriel", b =>
                {
                    b.HasOne("MentalHealthcare.Domain.Entities.Course", "Course")
                        .WithMany("CourseMateriels")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("MentalHealthcare.Domain.Entities.Course", b =>
                {
                    b.Navigation("CourseMateriels");
                });
#pragma warning restore 612, 618
        }
    }
}
