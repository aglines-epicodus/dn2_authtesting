using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DN2_AuthTesting.Models;

namespace DN2_AuthTesting.Migrations
{
    [DbContext(typeof(DN2DbContext))]
    [Migration("20170810194848_MakeTableNamesPlural")]
    partial class MakeTableNamesPlural
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DN2_AuthTesting.Models.PartOfSpeech", b =>
                {
                    b.Property<int>("PartOfSpeechId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("PartOfSpeechId");

                    b.ToTable("PartofSpeeches");
                });

            modelBuilder.Entity("DN2_AuthTesting.Models.Word", b =>
                {
                    b.Property<int>("WordId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("PartOfSpeechId");

                    b.HasKey("WordId");

                    b.HasIndex("PartOfSpeechId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("DN2_AuthTesting.Models.Word", b =>
                {
                    b.HasOne("DN2_AuthTesting.Models.PartOfSpeech", "PartOfSpeech")
                        .WithMany("Words")
                        .HasForeignKey("PartOfSpeechId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
