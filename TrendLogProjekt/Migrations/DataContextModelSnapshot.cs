﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrendLogProjekt.Data;

namespace TrendLogProjekt.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrendLogProjekt.Models.AlarmSettings", b =>
                {
                    b.Property<string>("email");

                    b.HasKey("email");

                    b.ToTable("AlarmSettings");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.BandwithReports", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GeneratedLeads");

                    b.Property<int>("GeneratedLeads2");

                    b.Property<int>("ServerAllocation");

                    b.Property<int>("SubmittedTickets");

                    b.HasKey("ID");

                    b.ToTable("bandwithReports");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.Channel", b =>
                {
                    b.Property<int>("channel_id");

                    b.Property<string>("alarmsettingsemail");

                    b.Property<DateTime>("created");

                    b.Property<string>("description");

                    b.Property<int>("elevation");

                    b.Property<int>("latitude");

                    b.Property<int>("lifetime");

                    b.Property<int>("longtitude");

                    b.Property<int>("maxsize");

                    b.Property<string>("name");

                    b.Property<int>("pcount");

                    b.Property<DateTime>("timezone");

                    b.Property<DateTime>("updated");

                    b.HasKey("channel_id");

                    b.HasIndex("alarmsettingsemail");

                    b.ToTable("Channel");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.ChannelRootobject", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("channel_id");

                    b.HasKey("ChannelId");

                    b.HasIndex("channel_id");

                    b.ToTable("channels");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.Feeds", b =>
                {
                    b.Property<int>("feed_id");

                    b.Property<int>("alarm");

                    b.Property<string>("alarm_settings");

                    b.Property<int?>("channel_id");

                    b.Property<int>("enable_alarm");

                    b.Property<string>("label");

                    b.Property<string>("name");

                    b.Property<int>("scale");

                    b.HasKey("feed_id");

                    b.HasIndex("channel_id");

                    b.ToTable("Feeds");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.Points", b =>
                {
                    b.Property<int>("pointid");

                    b.Property<int?>("Feedsfeed_id");

                    b.Property<DateTime>("timestamp");

                    b.Property<int>("value");

                    b.HasKey("pointid");

                    b.HasIndex("Feedsfeed_id");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.TopAuthor", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageLocation");

                    b.Property<string>("Location");

                    b.Property<int>("Money");

                    b.Property<string>("Name");

                    b.Property<string>("Occupation");

                    b.Property<string>("Status");

                    b.HasKey("AuthorId");

                    b.ToTable("topAuthors");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.Channel", b =>
                {
                    b.HasOne("TrendLogProjekt.Models.AlarmSettings", "alarmsettings")
                        .WithMany()
                        .HasForeignKey("alarmsettingsemail");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.ChannelRootobject", b =>
                {
                    b.HasOne("TrendLogProjekt.Models.Channel", "channel")
                        .WithMany()
                        .HasForeignKey("channel_id");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.Feeds", b =>
                {
                    b.HasOne("TrendLogProjekt.Models.Channel")
                        .WithMany("feeds")
                        .HasForeignKey("channel_id");
                });

            modelBuilder.Entity("TrendLogProjekt.Models.Points", b =>
                {
                    b.HasOne("TrendLogProjekt.Models.Feeds")
                        .WithMany("points")
                        .HasForeignKey("Feedsfeed_id");
                });
#pragma warning restore 612, 618
        }
    }
}
