﻿// <auto-generated />
using MainMidlandsFly.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MainMidlandsFly.Migrations.Crew
{
    [DbContext(typeof(CrewContext))]
    partial class CrewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MainMidlandsFly.Models.Crew", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CrewID");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Crew");
                });
#pragma warning restore 612, 618
        }
    }
}
