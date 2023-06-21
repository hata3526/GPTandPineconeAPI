﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cgptWebAPITest.Repositories;

#nullable disable

namespace cgptWebAPITest.Migrations
{
    [DbContext(typeof(ChatbotDbContext))]
    partial class ChatbotDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientModels.BotCharacter", b =>
                {
                    b.Property<long?>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("PK"));

                    b.Property<Guid?>("CreatedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeletedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UpdatedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("PK");

                    b.ToTable("BotCharacter");
                });

            modelBuilder.Entity("ClientModels.Message", b =>
                {
                    b.Property<long?>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("PK"));

                    b.Property<Guid?>("CreatedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeletedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<long>("FKSession")
                        .HasColumnType("bigint");

                    b.Property<long>("FKUser")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("PK");

                    b.HasIndex("FKSession");

                    b.HasIndex("FKUser");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("ClientModels.Session", b =>
                {
                    b.Property<long?>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("PK"));

                    b.Property<Guid?>("CreatedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeletedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndedOn")
                        .HasColumnType("datetime2");

                    b.Property<long>("FKBotCharacter")
                        .HasColumnType("bigint");

                    b.Property<long>("FKUser")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("PK");

                    b.HasIndex("FKBotCharacter");

                    b.HasIndex("FKUser");

                    b.ToTable("Conversation");
                });

            modelBuilder.Entity("ClientModels.User", b =>
                {
                    b.Property<long?>("PK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("PK"));

                    b.Property<Guid?>("CreatedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeletedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UpdatedByID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("PK");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ClientModels.Message", b =>
                {
                    b.HasOne("ClientModels.Session", "Session")
                        .WithMany("Messages")
                        .HasForeignKey("FKSession")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClientModels.User", "User")
                        .WithMany()
                        .HasForeignKey("FKUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClientModels.Session", b =>
                {
                    b.HasOne("ClientModels.BotCharacter", "BotCharacter")
                        .WithMany("Sessions")
                        .HasForeignKey("FKBotCharacter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClientModels.User", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("FKUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BotCharacter");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClientModels.BotCharacter", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("ClientModels.Session", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("ClientModels.User", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
