﻿// <auto-generated />
using System;
using CoreLearning.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreLearning.API.Migrations
{
    [DbContext(typeof(CoreLearningDBContext))]
    partial class CoreLearningDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreLearning.API.Model.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb7abb56-6a34-4403-b67c-3c963c178600"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("bc5772c0-5f62-4fab-b99c-c706749f5f9d"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("afe7fc48-bcb9-44ca-85a8-2f4ea8016638"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("CoreLearning.API.Model.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("df63303b-f7da-45d9-9ba9-5b0c9cbccd1b"),
                            Code = "GJ",
                            Name = "Gujarat",
                            RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Dgujarat%2Bmap&psig=AOvVaw3b0B2UfZ-jfvSasOPu9OA6&ust=1699107375317000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIjbwK6CqIIDFQAAAAAdAAAAABAE"
                        },
                        new
                        {
                            Id = new Guid("41d3352d-2182-4ce9-be1b-c30d3af15b86"),
                            Code = "RJ",
                            Name = "Rajasthan",
                            RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.mapsofindia.com%2Fmaps%2Frajasthan%2F&psig=AOvVaw1Lbu_lsMXAN4l2DtuEdyzv&ust=1699107459863000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCJD48taCqIIDFQAAAAAdAAAAABAJ"
                        },
                        new
                        {
                            Id = new Guid("915c3eb9-9199-4c42-b127-672d9778699c"),
                            Code = "MH",
                            Name = "Maharastra",
                            RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FGeography_of_Maharashtra&psig=AOvVaw3vItKiMLD0TlI8k89RNuKN&ust=1699107533018000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPiS1_mCqIIDFQAAAAAdAAAAABAE"
                        },
                        new
                        {
                            Id = new Guid("a0b6d31e-828c-4948-ab5b-05a7844ddcb2"),
                            Code = "DL",
                            Name = "Delhi",
                            RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FNational_Capital_Region_%2528India%2529&psig=AOvVaw1B-sJYDzq3vTUzhtTCgSCm&ust=1699107574151000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNjZ-YyDqIIDFQAAAAAdAAAAABAE"
                        },
                        new
                        {
                            Id = new Guid("faab149c-f5cd-4035-9fe0-63c0eb1a4b7f"),
                            Code = "MP",
                            Name = "MadhyaPradesh",
                            RegionImageUrl = "https://www.google.com/url?sa=i&url=http%3A%2F%2Fwww.slbcmadhyapradesh.in%2Fgeographical-map.aspx&psig=AOvVaw2AYreGQs4RUOMjBHNxTMkl&ust=1699107643409000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPCBhK6DqIIDFQAAAAAdAAAAABAE"
                        });
                });

            modelBuilder.Entity("CoreLearning.API.Model.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("CoreLearning.API.Model.Domain.Walk", b =>
                {
                    b.HasOne("CoreLearning.API.Model.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreLearning.API.Model.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
