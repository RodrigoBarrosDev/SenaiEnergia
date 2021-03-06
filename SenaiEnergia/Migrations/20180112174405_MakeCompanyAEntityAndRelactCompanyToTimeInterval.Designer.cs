﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SenaiEnergia.Domain;
using System;

namespace SenaiEnergia.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20180112174405_MakeCompanyAEntityAndRelactCompanyToTimeInterval")]
    partial class MakeCompanyAEntityAndRelactCompanyToTimeInterval
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SenaiEnergia.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CompanyID");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("SenaiEnergia.Domain.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EquipmentID");

                    b.Property<double>("EletricPower");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("SenaiEnergia.Domain.TimeInterval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TimeIntervalID");

                    b.Property<int?>("CompanyId");

                    b.Property<TimeSpan>("EndTime");

                    b.Property<TimeSpan>("StartTime");

                    b.Property<string>("Type");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("TimeInterval");
                });

            modelBuilder.Entity("SenaiEnergia.Domain.TimeInterval", b =>
                {
                    b.HasOne("SenaiEnergia.Domain.Company", "Company")
                        .WithMany("TimeIntervals")
                        .HasForeignKey("CompanyId");
                });
#pragma warning restore 612, 618
        }
    }
}
