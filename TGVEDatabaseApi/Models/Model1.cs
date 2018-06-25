namespace TGVEDatabaseApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.Payment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Client>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Fees)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.TourName)
                .IsFixedLength();

            modelBuilder.Entity<Tour>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);
        }
    }
}
