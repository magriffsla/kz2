using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using kz2.Models;

namespace kz2.Migrations.Store
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("kz2.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("Published");

                    b.Property<int?>("SubjectSubjectId");

                    b.HasKey("PostId");
                });

            modelBuilder.Entity("kz2.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("SubjectId");
                });

            modelBuilder.Entity("kz2.Models.Post", b =>
                {
                    b.HasOne("kz2.Models.Subject")
                        .WithMany()
                        .HasForeignKey("SubjectSubjectId");
                });
        }
    }
}
