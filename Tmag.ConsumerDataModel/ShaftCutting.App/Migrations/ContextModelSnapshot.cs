﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ShaftCutting.App;
using System;

namespace ShaftCutting.App.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShaftCutting.App.Models.ShaftCutTemplate", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<DateTime?>("Deleted");

                    b.Property<DateTime>("Modified")
                        .HasColumnName("modified");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("modified_by");

                    b.Property<string>("Text");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("ShaftCutTemplates");
                });
#pragma warning restore 612, 618
        }
    }
}
