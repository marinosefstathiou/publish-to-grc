﻿// <auto-generated />
using System;
using KubeTestAPI.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KubeTestAPI.Migrations
{
    [DbContext(typeof(WeatherDBContext))]
    [Migration("20230214105802_test021420231257")]
    partial class test021420231257
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KubeTestAPI.Entities.Locations", b =>
                {
                    b.Property<string>("LocationId")
                        .HasColumnType("text");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("KubeTestAPI.Entities.Temperatures", b =>
                {
                    b.Property<string>("LocationID")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("Timestamp")
                        .HasColumnType("date");

                    b.HasKey("LocationID");

                    b.ToTable("Temperatures");
                });
#pragma warning restore 612, 618
        }
    }
}
