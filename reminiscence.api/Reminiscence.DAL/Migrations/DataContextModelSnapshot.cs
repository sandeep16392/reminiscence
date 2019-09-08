﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reminiscence.DAL.Data;

namespace Reminiscence.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Reminiscence.Model.EntityModels.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("GenreId");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Reminiscence.Model.EntityModels.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Reminiscence.Model.EntityModels.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<int>("GenreId");

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Reminiscence.Model.EntityModels.Feature", b =>
                {
                    b.HasOne("Reminiscence.Model.EntityModels.Genre")
                        .WithMany("Features")
                        .HasForeignKey("GenreId");
                });

            modelBuilder.Entity("Reminiscence.Model.EntityModels.Photo", b =>
                {
                    b.HasOne("Reminiscence.Model.EntityModels.Genre", "Genre")
                        .WithMany("Photos")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
