using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Watchables.WebAPI.Database
{
    public partial class _160304Context : DbContext
    {
        public _160304Context()
        {
        }

        public _160304Context(DbContextOptions<_160304Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AiringDays> AiringDays { get; set; }
        public virtual DbSet<AiringDaysOfCinema> AiringDaysOfCinema { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<CinemaDayMovie> CinemaDayMovie { get; set; }
        public virtual DbSet<Cinemas> Cinemas { get; set; }
        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<OrderProducts> OrderProducts { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Rotations> Rotations { get; set; }
        public virtual DbSet<Shows> Shows { get; set; }
        public virtual DbSet<Subscriptions> Subscriptions { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersMovies> UsersMovies { get; set; }
        public virtual DbSet<UsersRotations> UsersRotations { get; set; }
        public virtual DbSet<UsersShows> UsersShows { get; set; }
        public virtual DbSet<UsersSubscriptions> UsersSubscriptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=160304; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AiringDays>(entity =>
            {
                entity.HasKey(e => e.AiringDayId);
            });

            modelBuilder.Entity<AiringDaysOfCinema>(entity =>
            {
                entity.HasIndex(e => e.AiringDayId);

                entity.HasIndex(e => e.CinemaId);

                entity.HasOne(d => d.AiringDay)
                    .WithMany(p => p.AiringDaysOfCinema)
                    .HasForeignKey(d => d.AiringDayId);

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.AiringDaysOfCinema)
                    .HasForeignKey(d => d.CinemaId);
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasKey(e => e.AppointmentId);

                entity.HasIndex(e => e.CinemaDayMovieId);

                entity.HasIndex(e => e.HallId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CinemaDayMovie)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.CinemaDayMovieId);

                entity.HasOne(d => d.Hall)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.HallId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CinemaDayMovie>(entity =>
            {
                entity.HasIndex(e => e.AiringDaysOfCinemaId);

                entity.HasIndex(e => e.MovieId);

                entity.HasOne(d => d.AiringDaysOfCinema)
                    .WithMany(p => p.CinemaDayMovie)
                    .HasForeignKey(d => d.AiringDaysOfCinemaId);

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.CinemaDayMovie)
                    .HasForeignKey(d => d.MovieId);
            });

            modelBuilder.Entity<Cinemas>(entity =>
            {
                entity.HasKey(e => e.CinemaId);

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Hall>(entity =>
            {
                entity.HasIndex(e => e.CinemaId);

                entity.Property(e => e.NumberOfseats).HasColumnName("NumberOFSeats");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Hall)
                    .HasForeignKey(d => d.CinemaId);
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<OrderProducts>(entity =>
            {
                entity.HasIndex(e => e.OrderId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasIndex(e => e.AppointmentId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AppointmentId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.HasIndex(e => e.CinemaId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Cinema)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CinemaId);
            });

            modelBuilder.Entity<Rotations>(entity =>
            {
                entity.HasKey(e => e.RotationId);

                entity.HasIndex(e => e.MovieId);

                entity.HasIndex(e => e.ShowId);

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Rotations)
                    .HasForeignKey(d => d.MovieId);

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.Rotations)
                    .HasForeignKey(d => d.ShowId);
            });

            modelBuilder.Entity<Shows>(entity =>
            {
                entity.HasKey(e => e.ShowId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Subscriptions>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.HasIndex(e => e.OrderId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);
            });

            modelBuilder.Entity<UsersMovies>(entity =>
            {
                entity.HasKey(e => new { e.MovieId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.UsersMovies)
                    .HasForeignKey(d => d.MovieId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersMovies)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UsersRotations>(entity =>
            {
                entity.HasKey(e => new { e.RotationId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Rotation)
                    .WithMany(p => p.UsersRotations)
                    .HasForeignKey(d => d.RotationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersRotations)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UsersShows>(entity =>
            {
                entity.HasKey(e => new { e.ShowId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.UsersShows)
                    .HasForeignKey(d => d.ShowId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersShows)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UsersSubscriptions>(entity =>
            {
                entity.HasKey(e => new { e.SubscriptionId, e.UserId });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.UsersSubscriptions)
                    .HasForeignKey(d => d.SubscriptionId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersSubscriptions)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
