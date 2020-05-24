﻿// <auto-generated />
using EscAdv.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EscAdv.Migrations
{
    [DbContext(typeof(EscAdvContext))]
    partial class EscAdvContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("EscAdv.Models.Process", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("petition")
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Process");
                });
#pragma warning restore 612, 618
        }
    }
}
