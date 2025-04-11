﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(db))]
    [Migration("20211031113208_7")]
    partial class _7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BE.Contant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("email")
                        .HasColumnType("int");

                    b.Property<int>("matn")
                        .HasColumnType("int");

                    b.Property<int>("name")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("contants");
                });

            modelBuilder.Entity("BE.DargahPardakht", b =>
                {
                    b.Property<int>("DargahPardakht_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DargahPardakht_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DargahPardakht_NameBank")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DargahPardakht_ID");

                    b.ToTable("dargahPardakhts");
                });

            modelBuilder.Entity("BE.Hotel", b =>
                {
                    b.Property<int>("Hotel_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Faal")
                        .HasColumnType("bit");

                    b.Property<long>("Jozeyat_Gheymat")
                        .HasColumnType("bigint");

                    b.Property<string>("Name_Hotel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tozihat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ZamanPayan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ZamanShoroa")
                        .HasColumnType("datetime2");

                    b.Property<int>("bathroom")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tedad_takht")
                        .HasColumnType("int");

                    b.Property<string>("urlpic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("zarfiat")
                        .HasColumnType("tinyint");

                    b.HasKey("Hotel_ID");

                    b.ToTable("hotels");
                });

            modelBuilder.Entity("BE.HotelRooms", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("bathroom")
                        .HasColumnType("int");

                    b.Property<int>("money")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("otagh")
                        .HasColumnType("int");

                    b.Property<string>("time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlpic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("BE.Jostejo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("GheymatYekShab")
                        .HasColumnType("bigint");

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("NameHotel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tozihat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bathroom")
                        .HasColumnType("int");

                    b.Property<string>("imgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tedad_takht")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Jostejo");
                });

            modelBuilder.Entity("BE.Nazarat", b =>
                {
                    b.Property<int>("Nazarat_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazarat_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nazarat_HotelID")
                        .HasColumnType("int");

                    b.Property<string>("Nazarat_Matn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazarat_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazarat_Zaman")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazarat_avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nazarat_ID");

                    b.HasIndex("Nazarat_HotelID");

                    b.ToTable("nazarats");
                });

            modelBuilder.Entity("BE.PardakhtHotel", b =>
                {
                    b.Property<int>("Pardakh_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Pardakh_IDHotel")
                        .HasColumnType("int");

                    b.Property<long>("Pardakh_Mablagh")
                        .HasColumnType("bigint");

                    b.Property<string>("Pardakh_Marjaa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pardakh_Pigiry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pardakh_Rezerv")
                        .HasColumnType("int");

                    b.Property<string>("Pardakh_Trakonesh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pardakh_Vazeiat")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Pardakh_ZamanVariz")
                        .HasColumnType("datetime2");

                    b.HasKey("Pardakh_ID");

                    b.HasIndex("Pardakh_IDHotel");

                    b.HasIndex("Pardakh_Rezerv");

                    b.ToTable("pardakhtHotels");
                });

            modelBuilder.Entity("BE.RezevHotel", b =>
                {
                    b.Property<int>("Rezerv_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Hotel_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Hotels")
                        .HasColumnType("int");

                    b.Property<string>("Rezerv_Codemeli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rezerv_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rezerv_IDHotel")
                        .HasColumnType("int");

                    b.Property<string>("Rezerv_IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rezerv_Jensiat")
                        .HasColumnType("int");

                    b.Property<DateTime>("Rezerv_Khoroj")
                        .HasColumnType("datetime2");

                    b.Property<long>("Rezerv_Mablagh")
                        .HasColumnType("bigint");

                    b.Property<string>("Rezerv_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rezerv_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rezerv_NameKhanevadgi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rezerv_Roz")
                        .HasColumnType("int");

                    b.Property<int>("Rezerv_TeadadNafarat")
                        .HasColumnType("int");

                    b.Property<int>("Rezerv_TeadadOthagh")
                        .HasColumnType("int");

                    b.Property<bool>("Rezerv_Vazeyt")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Rezerv_Vorod")
                        .HasColumnType("datetime2");

                    b.HasKey("Rezerv_ID");

                    b.HasIndex("Hotels");

                    b.ToTable("rezervHotels");
                });

            modelBuilder.Entity("BE.TanzimatEmail", b =>
                {
                    b.Property<int>("Eamil_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eamil_EmailSend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eamil_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eamil_Port")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eamil_Smtp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eamil_UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Eamil_ID");

                    b.ToTable("tanzimatEmails");
                });

            modelBuilder.Entity("BE.User_Login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("user_Logins");
                });

            modelBuilder.Entity("BE.Nazarat", b =>
                {
                    b.HasOne("BE.Hotel", "HotelNazar")
                        .WithMany("Nazarats")
                        .HasForeignKey("Nazarat_HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelNazar");
                });

            modelBuilder.Entity("BE.PardakhtHotel", b =>
                {
                    b.HasOne("BE.Hotel", "HotelPardakht")
                        .WithMany("PardakhtHotels")
                        .HasForeignKey("Pardakh_IDHotel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BE.RezevHotel", "RezevHotel")
                        .WithMany("PardakhtHotels")
                        .HasForeignKey("Pardakh_Rezerv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelPardakht");

                    b.Navigation("RezevHotel");
                });

            modelBuilder.Entity("BE.RezevHotel", b =>
                {
                    b.HasOne("BE.Hotel", "Hotel")
                        .WithMany("RezevHotel")
                        .HasForeignKey("Hotels");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BE.Hotel", b =>
                {
                    b.Navigation("Nazarats");

                    b.Navigation("PardakhtHotels");

                    b.Navigation("RezevHotel");
                });

            modelBuilder.Entity("BE.RezevHotel", b =>
                {
                    b.Navigation("PardakhtHotels");
                });
#pragma warning restore 612, 618
        }
    }
}
