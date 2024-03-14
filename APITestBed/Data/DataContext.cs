using APITestBed.Models;
using Microsoft.EntityFrameworkCore;

namespace APITestBed.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<BookAuthorModel> BookAuthors { get; set; }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<BookPublisherModel> BookPublishers { get; set; }
        public DbSet<PublisherModel> Publishers { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorModel>()
                .HasKey(a => a.Author_ID);
            modelBuilder.Entity<BookModel>()
                .HasKey(b => b.Book_ID);
            modelBuilder.Entity<PublisherModel>()
                .HasKey(p => p.Publisher_ID);

            modelBuilder.Entity<BookAuthorModel>()
                .HasKey(ba => new { ba.Book_ID, ba.Author_ID });
            modelBuilder.Entity<BookAuthorModel>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(b => b.Book_ID);
            modelBuilder.Entity<BookAuthorModel>()
                .HasOne(b => b.Author)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(b => b.Author_ID);

            modelBuilder.Entity<BookPublisherModel>()
                .HasKey(ba => new { ba.Book_ID, ba.Publisher_Id });
            modelBuilder.Entity<BookPublisherModel>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.BookPublishers)
                .HasForeignKey(b => b.Book_ID);
            modelBuilder.Entity<BookPublisherModel>()
                .HasOne(b => b.Publisher)
                .WithMany(ba => ba.BookPublishers)
                .HasForeignKey(b => b.Publisher_Id);
        }

    }
}
