using Microsoft.EntityFrameworkCore;
using RazorPagesEFCoreFilterDemo.Models;

namespace RazorPagesEFCoreFilterDemo.Data;

public class ZooContext : DbContext
{
    public DbSet<Animal> Animals { get; set; } = default!;
    public DbSet<Canine> Canines { get; set; } = default!;
    public DbSet<CanineType> CanineTypes { get; set; } = default!;
    public DbSet<Color> Colors { get; set; } = default!;
    public DbSet<Crocodile> Crocodiles { get; set; } = default!;
    public DbSet<CrocodileType> CrocodileTypes { get; set; } = default!;
    public DbSet<Mammal> Mammals { get; set; } = default!;
    public DbSet<Primate> Primates { get; set; } = default!;
    public DbSet<PrimateType> PrimateTypes { get; set; } = default!;
    public DbSet<Reptile> Reptiles { get; set; } = default!;
    public DbSet<Turtle> Turtles { get; set; } = default!;
    public DbSet<TurtleType> TurtleTypes { get; set; } = default!;

    public ZooContext(DbContextOptions<ZooContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Color>(c => {
            c.HasIndex(c => c.Name)
            .IsUnique();

            c.HasIndex(c => new { c.Name, c.Hex })
            .IsUnique();
        });

        modelBuilder.Entity<Animal>(a => {
            a.Property(a => a.Sex)
            .HasConversion<string>()
            .HasMaxLength(1);

            a.HasDiscriminator(a => a.Type);
        });

        modelBuilder.Entity<Canine>(c =>
        {
            c.HasOne(c => c.CanineType)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Crocodile>(c =>
        {
            c.HasOne(c => c.CrocodileType)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Mammal>(m =>
        {
            m.HasMany(m => m.HairColors)
            .WithMany(c => c.Mammals)
            .UsingEntity(join => join.ToTable("MammalHairColors"));
        });

        modelBuilder.Entity<Primate>(p =>
        {
            p.HasOne(p => p.PrimateType)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Reptile>(r =>
        {
            r.HasOne(r => r.EggColor)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Turtle>(t =>
        {
            t.HasOne(t => t.TurtleType)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        });


    }


}
