using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

public class LMSDBContext : DbContext
{
    // Simplified Constructor with options
    public LMSDBContext(DbContextOptions<LMSDBContext> options)
        : base(options)
    {
    }

    // Define DbSet properties
    public DbSet<TestTable> TestTables { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Borrowing> Borrowings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TestTable configuration
        modelBuilder.Entity<TestTable>(entity =>
        {
            entity.HasNoKey();
            entity.ToTable("TestTable");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        // Relationship between Book and Author
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

        // Relationship between Borrowing and User
        modelBuilder.Entity<Borrowing>()
            .HasOne(b => b.User)
            .WithMany(u => u.Borrowings)
            .HasForeignKey(b => b.UserId);

        // Relationship between Borrowing and Book
        modelBuilder.Entity<Borrowing>()
            .HasOne(b => b.Book)
            .WithMany(bk => bk.Borrowings)
            .HasForeignKey(b => b.BookId);

        base.OnModelCreating(modelBuilder);
    }
}
