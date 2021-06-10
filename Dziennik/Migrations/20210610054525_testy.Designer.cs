﻿// <auto-generated />
using System;
using Dziennik.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dziennik.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210610054525_testy")]
    partial class testy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dziennik.Models.Klasa", b =>
                {
                    b.Property<int>("KlasaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KontoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KlasaId");

                    b.HasIndex("KontoId")
                        .IsUnique();

                    b.ToTable("Klasa");
                });

            modelBuilder.Entity("Dziennik.Models.Konto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("KlasaId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RodzicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.Property<string>("adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typ_uzytkownika")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KlasaId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("RodzicId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Dziennik.Models.Lekcja", b =>
                {
                    b.Property<int>("LekcjaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NauczanieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.HasKey("LekcjaId");

                    b.HasIndex("NauczanieId");

                    b.ToTable("Lekcja");
                });

            modelBuilder.Entity("Dziennik.Models.Nauczanie", b =>
                {
                    b.Property<int>("NauczanieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KlasaId")
                        .HasColumnType("int");

                    b.Property<string>("KontoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("NauczanieId1")
                        .HasColumnType("int");

                    b.Property<int>("PrzedmiotId")
                        .HasColumnType("int");

                    b.HasKey("NauczanieId");

                    b.HasIndex("KlasaId");

                    b.HasIndex("KontoId");

                    b.HasIndex("NauczanieId1");

                    b.HasIndex("PrzedmiotId");

                    b.ToTable("Nauczanie");
                });

            modelBuilder.Entity("Dziennik.Models.Obecnosc", b =>
                {
                    b.Property<int>("ObecnoscId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KontoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("LekcjaId")
                        .HasColumnType("int");

                    b.Property<int>("typ_obecnosci")
                        .HasColumnType("int");

                    b.HasKey("ObecnoscId");

                    b.HasIndex("KontoId");

                    b.HasIndex("LekcjaId");

                    b.ToTable("Obecnosc");
                });

            modelBuilder.Entity("Dziennik.Models.Ocena", b =>
                {
                    b.Property<int>("OcenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KontoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NauczanieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<int>("koncowa")
                        .HasColumnType("int");

                    b.Property<string>("opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wartosc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OcenaId");

                    b.HasIndex("KontoId");

                    b.HasIndex("NauczanieId");

                    b.ToTable("Ocena");
                });

            modelBuilder.Entity("Dziennik.Models.Ogloszenie", b =>
                {
                    b.Property<int>("OgloszenieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NauczanieId")
                        .HasColumnType("int");

                    b.Property<int>("akceptacja")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<string>("nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("wszyscy")
                        .HasColumnType("int");

                    b.HasKey("OgloszenieId");

                    b.HasIndex("NauczanieId");

                    b.ToTable("Ogloszenie");
                });

            modelBuilder.Entity("Dziennik.Models.Plik", b =>
                {
                    b.Property<int>("PlikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PrzedmiotId")
                        .HasColumnType("int");

                    b.Property<string>("nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("plik")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("typ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("utworzenie")
                        .HasColumnType("datetime2");

                    b.HasKey("PlikId");

                    b.HasIndex("PrzedmiotId");

                    b.ToTable("Plik");
                });

            modelBuilder.Entity("Dziennik.Models.Przedmiot", b =>
                {
                    b.Property<int>("PrzedmiotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dziedzina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tresci")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrzedmiotId");

                    b.ToTable("Przedmiot");
                });

            modelBuilder.Entity("Dziennik.Models.Pytanie", b =>
                {
                    b.Property<int>("PytanieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("czas_trwania")
                        .HasColumnType("int");

                    b.Property<string>("odpA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("odpB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("odpC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("odpD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poprawna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("punkty")
                        .HasColumnType("int");

                    b.Property<string>("tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PytanieId");

                    b.HasIndex("TestId");

                    b.ToTable("Pytanie");
                });

            modelBuilder.Entity("Dziennik.Models.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NauczanieId")
                        .HasColumnType("int");

                    b.Property<string>("nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId");

                    b.HasIndex("NauczanieId");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Dziennik.Models.Wiadomosc", b =>
                {
                    b.Property<int>("WiadomoscId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NadawcaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OdbiorcaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("czy_odczytana")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<string>("tresc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tytul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WiadomoscId");

                    b.HasIndex("NadawcaId");

                    b.HasIndex("OdbiorcaId");

                    b.ToTable("Wiadomosc");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Dziennik.Models.Klasa", b =>
                {
                    b.HasOne("Dziennik.Models.Konto", "Wychowawca")
                        .WithOne("Wychowankowie")
                        .HasForeignKey("Dziennik.Models.Klasa", "KontoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Konto", b =>
                {
                    b.HasOne("Dziennik.Models.Klasa", "Klasa")
                        .WithMany("Uczniowie")
                        .HasForeignKey("KlasaId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Dziennik.Models.Konto", "Rodzic")
                        .WithMany()
                        .HasForeignKey("RodzicId");
                });

            modelBuilder.Entity("Dziennik.Models.Lekcja", b =>
                {
                    b.HasOne("Dziennik.Models.Nauczanie", "Nauczanie")
                        .WithMany("Lekcje")
                        .HasForeignKey("NauczanieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Nauczanie", b =>
                {
                    b.HasOne("Dziennik.Models.Klasa", "Klasa")
                        .WithMany("Nauczania")
                        .HasForeignKey("KlasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dziennik.Models.Konto", "Konto")
                        .WithMany("Nauczania")
                        .HasForeignKey("KontoId");

                    b.HasOne("Dziennik.Models.Nauczanie", null)
                        .WithMany("Nauczania")
                        .HasForeignKey("NauczanieId1");

                    b.HasOne("Dziennik.Models.Przedmiot", "Przedmiot")
                        .WithMany("Nauczania")
                        .HasForeignKey("PrzedmiotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Obecnosc", b =>
                {
                    b.HasOne("Dziennik.Models.Konto", "Konto")
                        .WithMany("Obecnosci")
                        .HasForeignKey("KontoId");

                    b.HasOne("Dziennik.Models.Lekcja", "Lekcja")
                        .WithMany("Obecnosci")
                        .HasForeignKey("LekcjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Ocena", b =>
                {
                    b.HasOne("Dziennik.Models.Konto", "Konto")
                        .WithMany("Oceny")
                        .HasForeignKey("KontoId");

                    b.HasOne("Dziennik.Models.Nauczanie", "Nauczanie")
                        .WithMany("Ocena")
                        .HasForeignKey("NauczanieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Ogloszenie", b =>
                {
                    b.HasOne("Dziennik.Models.Nauczanie", "Nauczania")
                        .WithMany("Ogloszenia")
                        .HasForeignKey("NauczanieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Plik", b =>
                {
                    b.HasOne("Dziennik.Models.Przedmiot", "Przedmiot")
                        .WithMany("Pliki")
                        .HasForeignKey("PrzedmiotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Pytanie", b =>
                {
                    b.HasOne("Dziennik.Models.Test", "Test")
                        .WithMany("Pytania")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Test", b =>
                {
                    b.HasOne("Dziennik.Models.Nauczanie", "Nauczanie")
                        .WithMany("Testy")
                        .HasForeignKey("NauczanieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dziennik.Models.Wiadomosc", b =>
                {
                    b.HasOne("Dziennik.Models.Konto", "Nadawca")
                        .WithMany("wyslane")
                        .HasForeignKey("NadawcaId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Dziennik.Models.Konto", "Odbiorca")
                        .WithMany("odebrane")
                        .HasForeignKey("OdbiorcaId")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Dziennik.Models.Konto", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Dziennik.Models.Konto", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dziennik.Models.Konto", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Dziennik.Models.Konto", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
