﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UniversityRegistrar;

namespace UniversityRegistrar.Migrations
{
    [DbContext(typeof(UniversityRegistrar))]
    partial class UniversityRegistrarModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("UniversityRegistrar.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseName")
                        .HasMaxLength(50);

                    b.Property<string>("CourseNumber")
                        .HasMaxLength(10);

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UniversityRegistrar.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(75);

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });
        }
    }
}
