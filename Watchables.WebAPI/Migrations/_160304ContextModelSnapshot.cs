﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Migrations
{
    [DbContext(typeof(_160304Context))]
    partial class _160304ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Watchables.WebAPI.Database.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Admins", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("AccountId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.AiringDays", b =>
                {
                    b.Property<int>("AiringDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EndsAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartsAt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AiringDayId");

                    b.ToTable("AiringDays");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.AiringDaysOfCinema", b =>
                {
                    b.Property<int>("AiringDaysOfCinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AiringDayId")
                        .HasColumnType("int");

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("AiringDaysOfCinemaId");

                    b.HasIndex("AiringDayId");

                    b.HasIndex("CinemaId");

                    b.ToTable("AiringDaysOfCinema");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Appointments", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaDayMovieId")
                        .HasColumnType("int");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("SoldSeats")
                        .HasColumnType("int");

                    b.Property<string>("StartsAt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointmentId");

                    b.HasIndex("CinemaDayMovieId");

                    b.HasIndex("HallId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.CinemaDayMovie", b =>
                {
                    b.Property<int>("CinemaDayMovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AiringDaysOfCinemaId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("CinemaDayMovieId");

                    b.HasIndex("AiringDaysOfCinemaId");

                    b.HasIndex("MovieId");

                    b.ToTable("CinemaDayMovie");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Cinemas", b =>
                {
                    b.Property<int>("CinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.HasKey("CinemaId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Hall", b =>
                {
                    b.Property<int>("HallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("HallName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HallNumber")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfseats")
                        .HasColumnName("NumberOFSeats")
                        .HasColumnType("int");

                    b.HasKey("HallId");

                    b.HasIndex("CinemaId");

                    b.ToTable("Hall");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Movies", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool>("Standalone")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Notifications", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.OrderProducts", b =>
                {
                    b.Property<int>("OrderProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderProductsId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CinemaId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Rotations", b =>
                {
                    b.Property<int>("RotationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ForBirthday")
                        .HasColumnType("bit");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("RotationId");

                    b.HasIndex("MovieId");

                    b.HasIndex("ShowId");

                    b.ToTable("Rotations");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Shows", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeasons")
                        .HasColumnType("int");

                    b.Property<bool>("Ongoing")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ShowId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Subscriptions", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfMovies")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfShows")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfTickets")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("SubscriptionId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Tickets", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Seat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketId");

                    b.HasIndex("OrderId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Locked")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("AccountId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersMovies", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersMovies");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersNotifications", b =>
                {
                    b.Property<int>("UsersNotificationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NotificationId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UsersNotificationsId");

                    b.HasIndex("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersNotifications");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersRotations", b =>
                {
                    b.Property<int>("RotationId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RotationId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersRotations");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersShows", b =>
                {
                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ShowId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersShows");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersSubscriptions", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersSubscriptions");
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Admins", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.AiringDaysOfCinema", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.AiringDays", "AiringDay")
                        .WithMany("AiringDaysOfCinema")
                        .HasForeignKey("AiringDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Cinemas", "Cinema")
                        .WithMany("AiringDaysOfCinema")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Appointments", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.CinemaDayMovie", "CinemaDayMovie")
                        .WithMany("Appointments")
                        .HasForeignKey("CinemaDayMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Hall", "Hall")
                        .WithMany("Appointments")
                        .HasForeignKey("HallId")
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.CinemaDayMovie", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.AiringDaysOfCinema", "AiringDaysOfCinema")
                        .WithMany("CinemaDayMovie")
                        .HasForeignKey("AiringDaysOfCinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Movies", "Movie")
                        .WithMany("CinemaDayMovie")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Hall", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Cinemas", "Cinema")
                        .WithMany("Hall")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.OrderProducts", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Orders", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Products", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Orders", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Appointments", "Appointment")
                        .WithMany("Orders")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Users", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Products", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Cinemas", "Cinema")
                        .WithMany("Products")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Rotations", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Movies", "Movie")
                        .WithMany("Rotations")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Shows", "Show")
                        .WithMany("Rotations")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Tickets", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Orders", "Order")
                        .WithMany("Tickets")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.Users", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersMovies", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Movies", "Movie")
                        .WithMany("UsersMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Users", "User")
                        .WithMany("UsersMovies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersNotifications", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Notifications", "Notification")
                        .WithMany("UsersNotifications")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Users", "User")
                        .WithMany("UsersNotifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersRotations", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Rotations", "Rotation")
                        .WithMany("UsersRotations")
                        .HasForeignKey("RotationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Users", "User")
                        .WithMany("UsersRotations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersShows", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Shows", "Show")
                        .WithMany("UsersShows")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Users", "User")
                        .WithMany("UsersShows")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Watchables.WebAPI.Database.UsersSubscriptions", b =>
                {
                    b.HasOne("Watchables.WebAPI.Database.Subscriptions", "Subscription")
                        .WithMany("UsersSubscriptions")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watchables.WebAPI.Database.Users", "User")
                        .WithMany("UsersSubscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
