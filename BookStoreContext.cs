﻿
using Microsoft.EntityFrameworkCore;

namespace ODataWebAPI
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Press> Presses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Owned Entity Types https://bit.ly/3DHC9h8
            modelBuilder.Entity<Book>().OwnsOne(c => c.Location);
        }
    }
}
