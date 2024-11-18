﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPF_SlowkaProjekt.ClassModel;

#nullable disable

namespace WPF_SlowkaProjekt.Migrations
{
    [DbContext(typeof(WordsContext))]
    partial class WordsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WPF_SlowkaProjekt.ClassModel.CategoryModel", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_ID"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WPF_SlowkaProjekt.ClassModel.WordModel", b =>
                {
                    b.Property<int>("Word_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Word_ID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordTranslated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Word_ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("WPF_SlowkaProjekt.ClassModel.WordModel", b =>
                {
                    b.HasOne("WPF_SlowkaProjekt.ClassModel.CategoryModel", "Category")
                        .WithMany("Words")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WPF_SlowkaProjekt.ClassModel.CategoryModel", b =>
                {
                    b.Navigation("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
