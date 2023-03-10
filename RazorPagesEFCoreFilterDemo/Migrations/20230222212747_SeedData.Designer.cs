// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesEFCoreFilterDemo.Data;

#nullable disable

namespace RazorPagesEFCoreFilterDemo.Migrations
{
    [DbContext(typeof(ZooContext))]
    [Migration("20230222212747_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasDiscriminator<string>("Type").HasValue("Animal");
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.CanineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("CanineTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dog"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wolf"
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Hex")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Name", "Hex")
                        .IsUnique();

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Hex = "ff0000",
                            Name = "Red"
                        },
                        new
                        {
                            Id = 2,
                            Hex = "0000ff",
                            Name = "Blue"
                        },
                        new
                        {
                            Id = 3,
                            Hex = "008000",
                            Name = "Green"
                        },
                        new
                        {
                            Id = 4,
                            Hex = "808080",
                            Name = "Gray"
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.CrocodileType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("CrocodileTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Saltwater"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nile"
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.MammalHairColor", b =>
                {
                    b.Property<int>("MammalId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.HasKey("MammalId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("MammalHairColors");

                    b.HasData(
                        new
                        {
                            MammalId = 1,
                            ColorId = 1
                        },
                        new
                        {
                            MammalId = 2,
                            ColorId = 4
                        },
                        new
                        {
                            MammalId = 5,
                            ColorId = 1
                        },
                        new
                        {
                            MammalId = 5,
                            ColorId = 2
                        },
                        new
                        {
                            MammalId = 6,
                            ColorId = 4
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.PrimateType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("PrimateTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chimpanzee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Orangutan"
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.TurtleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("TurtleTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Box"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wood"
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Mammal", b =>
                {
                    b.HasBaseType("RazorPagesEFCoreFilterDemo.Models.Animal");

                    b.HasDiscriminator().HasValue("Mammal");
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Reptile", b =>
                {
                    b.HasBaseType("RazorPagesEFCoreFilterDemo.Models.Animal");

                    b.Property<int>("EggColorId")
                        .HasColumnType("int");

                    b.Property<int>("ScaleHardness")
                        .HasColumnType("int");

                    b.HasIndex("EggColorId");

                    b.HasDiscriminator().HasValue("Reptile");
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Canine", b =>
                {
                    b.HasBaseType("RazorPagesEFCoreFilterDemo.Models.Mammal");

                    b.Property<int>("CanineTypeId")
                        .HasColumnType("int");

                    b.Property<int>("HowlVolume")
                        .HasColumnType("int");

                    b.HasIndex("CanineTypeId");

                    b.HasDiscriminator().HasValue("Canine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Clifford",
                            Sex = "M",
                            CanineTypeId = 1,
                            HowlVolume = 100
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2003, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Legoshi",
                            Sex = "M",
                            CanineTypeId = 2,
                            HowlVolume = 9001
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Crocodile", b =>
                {
                    b.HasBaseType("RazorPagesEFCoreFilterDemo.Models.Reptile");

                    b.Property<int>("BiteForce")
                        .HasColumnType("int");

                    b.Property<int>("CrocodileTypeId")
                        .HasColumnType("int");

                    b.HasIndex("CrocodileTypeId");

                    b.HasDiscriminator().HasValue("Crocodile");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1962, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Wally Gator",
                            Sex = "M",
                            EggColorId = 3,
                            ScaleHardness = 10,
                            BiteForce = 2,
                            CrocodileTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Allie Gator",
                            Sex = "F",
                            EggColorId = 2,
                            ScaleHardness = 20,
                            BiteForce = 5,
                            CrocodileTypeId = 1
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Primate", b =>
                {
                    b.HasBaseType("RazorPagesEFCoreFilterDemo.Models.Mammal");

                    b.Property<int?>("GameHighScore")
                        .HasColumnType("int");

                    b.Property<int>("PrimateTypeId")
                        .HasColumnType("int");

                    b.HasIndex("PrimateTypeId");

                    b.HasDiscriminator().HasValue("Primate");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Betsy",
                            Sex = "F",
                            GameHighScore = 25,
                            PrimateTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Fred",
                            Sex = "M",
                            GameHighScore = 24,
                            PrimateTypeId = 1
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Turtle", b =>
                {
                    b.HasBaseType("RazorPagesEFCoreFilterDemo.Models.Reptile");

                    b.Property<int>("ShellHardness")
                        .HasColumnType("int");

                    b.Property<int>("TurtleTypeId")
                        .HasColumnType("int");

                    b.HasIndex("TurtleTypeId");

                    b.HasDiscriminator().HasValue("Turtle");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Slowpoke",
                            Sex = "F",
                            EggColorId = 1,
                            ScaleHardness = 1,
                            ShellHardness = 100,
                            TurtleTypeId = 1
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(1888, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ol' Travis",
                            Sex = "M",
                            EggColorId = 4,
                            ScaleHardness = 500,
                            ShellHardness = 1000,
                            TurtleTypeId = 2
                        });
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.MammalHairColor", b =>
                {
                    b.HasOne("RazorPagesEFCoreFilterDemo.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorPagesEFCoreFilterDemo.Models.Mammal", "Mammal")
                        .WithMany()
                        .HasForeignKey("MammalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Mammal");
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Reptile", b =>
                {
                    b.HasOne("RazorPagesEFCoreFilterDemo.Models.Color", "EggColor")
                        .WithMany()
                        .HasForeignKey("EggColorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("EggColor");
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Canine", b =>
                {
                    b.HasOne("RazorPagesEFCoreFilterDemo.Models.CanineType", "CanineType")
                        .WithMany()
                        .HasForeignKey("CanineTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CanineType");
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Crocodile", b =>
                {
                    b.HasOne("RazorPagesEFCoreFilterDemo.Models.CrocodileType", "CrocodileType")
                        .WithMany()
                        .HasForeignKey("CrocodileTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CrocodileType");
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Primate", b =>
                {
                    b.HasOne("RazorPagesEFCoreFilterDemo.Models.PrimateType", "PrimateType")
                        .WithMany()
                        .HasForeignKey("PrimateTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PrimateType");
                });

            modelBuilder.Entity("RazorPagesEFCoreFilterDemo.Models.Turtle", b =>
                {
                    b.HasOne("RazorPagesEFCoreFilterDemo.Models.TurtleType", "TurtleType")
                        .WithMany()
                        .HasForeignKey("TurtleTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("TurtleType");
                });
#pragma warning restore 612, 618
        }
    }
}
