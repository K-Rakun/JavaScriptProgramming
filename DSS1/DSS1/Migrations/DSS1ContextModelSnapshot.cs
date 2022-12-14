// <auto-generated />
using DSS1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DSS1.Migrations
{
    [DbContext(typeof(DSS1Context))]
    partial class DSS1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DSS1.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DSS1.Models.Image", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("DSS1.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseDateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReleaseDateId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("DSS1.Models.MovieGenreMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieGenreMap");
                });

            modelBuilder.Entity("DSS1.Models.ReleaseDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ReleaseDate");
                });

            modelBuilder.Entity("DSS1.Models.Movie", b =>
                {
                    b.HasOne("DSS1.Models.ReleaseDate", "ReleaseDate")
                        .WithMany("Movies")
                        .HasForeignKey("ReleaseDateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReleaseDate");
                });

            modelBuilder.Entity("DSS1.Models.MovieGenreMap", b =>
                {
                    b.HasOne("DSS1.Models.Genre", "genre")
                        .WithMany("MovieGenreMap")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DSS1.Models.Movie", "movie")
                        .WithMany("MovieGenreMap")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("genre");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("DSS1.Models.Genre", b =>
                {
                    b.Navigation("MovieGenreMap");
                });

            modelBuilder.Entity("DSS1.Models.Movie", b =>
                {
                    b.Navigation("MovieGenreMap");
                });

            modelBuilder.Entity("DSS1.Models.ReleaseDate", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
