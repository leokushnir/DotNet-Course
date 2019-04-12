﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rmdb.Infrastructure;

namespace Rmdb.Infrastructure.Migrations
{
    [DbContext(typeof(RmdbContext))]
    [Migration("20190412072249_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Rmdb.Domain.Model.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Color");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<TimeSpan>("RunTime");

                    b.Property<double>("Score");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Rmdb.Domain.Model.MovieActor", b =>
                {
                    b.Property<Guid>("MovieId");

                    b.Property<Guid>("ActorId");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("Rmdb.Domain.Model.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDate");

                    b.Property<DateTime?>("Deceased");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Rmdb.Domain.Model.MovieActor", b =>
                {
                    b.HasOne("Rmdb.Domain.Model.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Rmdb.Domain.Model.Person", "Actor")
                        .WithMany("PlayedMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
