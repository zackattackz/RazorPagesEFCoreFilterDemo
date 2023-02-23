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
    public DbSet<MammalHairColor> MammalHairColors { get; set; }
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
            .UsingEntity<MammalHairColor>();
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

        modelBuilder.Entity<MammalHairColor>(m =>
        {
            m.HasKey(m => new { m.MammalId, m.ColorId });
        });

        modelBuilder.Entity<CanineType>().HasData(new[]
        {
            new CanineType
            {
                Id = 1,
                Name = "Dog"
            },
            new CanineType
            {
                Id = 2,
                Name = "Wolf"
            }
        });

        modelBuilder.Entity<CrocodileType>().HasData(new[]
        {
            new CrocodileType
            {
                Id = 1,
                Name = "Saltwater"
            },
            new CrocodileType
            {
                Id = 2,
                Name = "Nile"
            }
        });

        modelBuilder.Entity<PrimateType>().HasData(new[]
        {
            new PrimateType
            {
                Id = 1,
                Name = "Chimpanzee"
            },
            new PrimateType
            {
                Id = 2,
                Name = "Orangutan"
            }
        });

        modelBuilder.Entity<TurtleType>().HasData(new[]
        {
            new TurtleType
            {
                Id = 1,
                Name = "Box"
            },
            new TurtleType
            {
                Id = 2,
                Name = "Wood"
            }
        });

        modelBuilder.Entity<Color>().HasData(new[]
        {
            new Color
            {
                Id = 1,
                Name = "Red",
                Hex = "ff0000"
            },
            new Color
            {
                Id = 2,
                Name = "Blue",
                Hex = "0000ff"
            },
            new Color
            {
                Id = 3,
                Name = "Green",
                Hex = "008000"
            },
            new Color
            {
                Id = 4,
                Name = "Gray",
                Hex = "808080"
            }
        });

        modelBuilder.Entity<Canine>().HasData(new[]
        {
            new Canine
            {
                Id = 1,
                Name = "Clifford",
                Sex = Sex.M,
                BirthDate = DateTime.Parse("1/1/1963"),
                HowlVolume = 100,
                CanineTypeId = 1,
            },
            new Canine
            {
                Id = 2,
                Name = "Legoshi",
                Sex = Sex.M,
                BirthDate = DateTime.Parse("4/3/2003"),
                HowlVolume = 9001,
                CanineTypeId = 2,
            }
        });

        modelBuilder.Entity<Crocodile>().HasData(new[]
        {
            new Crocodile
            {
                Id = 3,
                Name = "Wally Gator",
                Sex = Sex.M,
                BirthDate = DateTime.Parse("9/3/1962"),
                ScaleHardness = 10,
                EggColorId = 3,
                BiteForce = 2,
                CrocodileTypeId = 1
            },
            new Crocodile
            {
                Id = 4,
                Name = "Allie Gator",
                Sex = Sex.F,
                BirthDate = DateTime.Parse("1/2/2003"),
                ScaleHardness = 20,
                EggColorId = 2,
                BiteForce = 5,
                CrocodileTypeId = 1
            }
        });

        modelBuilder.Entity<Primate>().HasData(new[]
        {
            new Primate
            {
                Id = 5,
                Name = "Betsy",
                Sex = Sex.F,
                BirthDate = DateTime.Parse("10/10/2010"),
                GameHighScore = 25,
                PrimateTypeId = 2
            },
            new Primate
            {
                Id = 6,
                Name = "Fred",
                Sex = Sex.M,
                BirthDate = DateTime.Parse("10/10/2010"),
                GameHighScore = 24,
                PrimateTypeId = 1
            }
        });

        modelBuilder.Entity<Turtle>().HasData(new[]
        {
            new Turtle
            {
                Id = 7,
                Name = "Slowpoke",
                Sex = Sex.F,
                BirthDate = DateTime.Parse("9/9/1999"),
                ScaleHardness = 1,
                EggColorId = 1,
                ShellHardness = 100,
                TurtleTypeId = 1
            },
            new Turtle
            {
                Id = 8,
                Name = "Ol' Travis",
                Sex = Sex.M,
                BirthDate = DateTime.Parse("8/8/1888"),
                ScaleHardness = 500,
                EggColorId = 4,
                ShellHardness = 1000,
                TurtleTypeId = 2
            }
        });

        modelBuilder.Entity<MammalHairColor>().HasData(new[]
        {
            new MammalHairColor
            {
                MammalId = 1,
                ColorId = 1
            },
            new MammalHairColor
            {
                MammalId = 2,
                ColorId = 4
            },
            new MammalHairColor
            {
                MammalId = 5,
                ColorId = 1
            },
            new MammalHairColor
            {
                MammalId = 5,
                ColorId = 2
            },
            new MammalHairColor
            {
                MammalId = 6,
                ColorId = 4
            }
        });
    }
}
