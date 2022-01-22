﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPPweb2122.Data;

namespace TPPweb2122.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "2",
                            Name = "Gestor",
                            NormalizedName = "GESTOR"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "3",
                            Name = "Funcionario",
                            NormalizedName = "FUNCIONARIO"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "4",
                            Name = "Cliente",
                            NormalizedName = "CLIENTE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 3,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TPPweb2122.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("TPPweb2122.Models.Imovel", b =>
                {
                    b.Property<int>("ImovelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAlojamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<DateTime>("dataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("gestorId")
                        .HasColumnType("int");

                    b.HasKey("ImovelId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("gestorId");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("TPPweb2122.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool?>("Confirmacao")
                        .HasColumnType("bit");

                    b.Property<int?>("ImovelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataSaida")
                        .HasColumnType("datetime2");

                    b.HasKey("ReservaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ImovelId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("TPPweb2122.Models.Utilizador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Utilizador");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "426b3f08-e990-4c8d-bfc1-11a350138d77",
                            Email = "admin@airbnb.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            Morada = "454",
                            Nome = "344",
                            NormalizedEmail = "ADMIN@AIRBNB.COM",
                            NormalizedUserName = "ADMIN@AIRBNB.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFjGMOTNCi+vMB78gzCV3yHmDe37usXUFeDz+PQYKFlcRSO9BYzRXBHcoj4npfxZHw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c103c12d-ad5c-4183-8783-fc59ffefaeac",
                            Telefone = "945",
                            TwoFactorEnabled = false,
                            UserName = "admin@airbnb.com"
                        });
                });

            modelBuilder.Entity("TPPweb2122.Models.Cliente", b =>
                {
                    b.HasBaseType("TPPweb2122.Models.Utilizador");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("TPPweb2122.Models.Funcionario", b =>
                {
                    b.HasBaseType("TPPweb2122.Models.Utilizador");

                    b.Property<int?>("gestorId")
                        .HasColumnType("int");

                    b.HasIndex("gestorId");

                    b.HasDiscriminator().HasValue("Funcionario");
                });

            modelBuilder.Entity("TPPweb2122.Models.Gestor", b =>
                {
                    b.HasBaseType("TPPweb2122.Models.Utilizador");

                    b.HasDiscriminator().HasValue("Gestor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("TPPweb2122.Models.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("TPPweb2122.Models.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPPweb2122.Models.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("TPPweb2122.Models.Utilizador", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPPweb2122.Models.Imovel", b =>
                {
                    b.HasOne("TPPweb2122.Models.Categoria", "Categoria")
                        .WithMany("Imoveis")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("TPPweb2122.Models.Gestor", "Gestor")
                        .WithMany("Imoveis")
                        .HasForeignKey("gestorId");

                    b.Navigation("Categoria");

                    b.Navigation("Gestor");
                });

            modelBuilder.Entity("TPPweb2122.Models.Reserva", b =>
                {
                    b.HasOne("TPPweb2122.Models.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("TPPweb2122.Models.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("ImovelId");

                    b.Navigation("Cliente");

                    b.Navigation("Imovel");
                });

            modelBuilder.Entity("TPPweb2122.Models.Funcionario", b =>
                {
                    b.HasOne("TPPweb2122.Models.Gestor", "Gestor")
                        .WithMany("Funcionarios")
                        .HasForeignKey("gestorId");

                    b.Navigation("Gestor");
                });

            modelBuilder.Entity("TPPweb2122.Models.Categoria", b =>
                {
                    b.Navigation("Imoveis");
                });

            modelBuilder.Entity("TPPweb2122.Models.Cliente", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("TPPweb2122.Models.Gestor", b =>
                {
                    b.Navigation("Funcionarios");

                    b.Navigation("Imoveis");
                });
#pragma warning restore 612, 618
        }
    }
}
