﻿// <auto-generated />
using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    [DbContext(typeof(QueryDbContext))]
    [Migration("20210509225111_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Dependent", b =>
                {
                    b.Property<int>("DependencyFilterListId")
                        .HasColumnType("integer");

                    b.Property<int>("DependentFilterListId")
                        .HasColumnType("integer");

                    b.HasKey("DependencyFilterListId", "DependentFilterListId");

                    b.HasIndex("DependentFilterListId");

                    b.ToTable("Dependents");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ChatUrl")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DonateUrl")
                        .HasColumnType("text");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("ForumUrl")
                        .HasColumnType("text");

                    b.Property<string>("HomeUrl")
                        .HasColumnType("text");

                    b.Property<string>("IssuesUrl")
                        .HasColumnType("text");

                    b.Property<int?>("LicenseId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OnionUrl")
                        .HasColumnType("text");

                    b.Property<string>("PolicyUrl")
                        .HasColumnType("text");

                    b.Property<string>("SubmissionUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LicenseId");

                    b.ToTable("FilterLists");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListLanguage", b =>
                {
                    b.Property<int>("FilterListId")
                        .HasColumnType("integer");

                    b.Property<string>("Iso6391")
                        .HasColumnType("character(2)");

                    b.HasKey("FilterListId", "Iso6391");

                    b.HasIndex("Iso6391");

                    b.ToTable("FilterListLanguages");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListMaintainer", b =>
                {
                    b.Property<int>("FilterListId")
                        .HasColumnType("integer");

                    b.Property<int>("MaintainerId")
                        .HasColumnType("integer");

                    b.HasKey("FilterListId", "MaintainerId");

                    b.HasIndex("MaintainerId");

                    b.ToTable("FilterListMaintainers");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListSyntax", b =>
                {
                    b.Property<int>("FilterListId")
                        .HasColumnType("integer");

                    b.Property<int>("SyntaxId")
                        .HasColumnType("integer");

                    b.HasKey("FilterListId", "SyntaxId");

                    b.HasIndex("SyntaxId");

                    b.ToTable("FilterListSyntaxes");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListTag", b =>
                {
                    b.Property<int>("FilterListId")
                        .HasColumnType("integer");

                    b.Property<int>("TagId")
                        .HasColumnType("integer");

                    b.HasKey("FilterListId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("FilterListTags");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListViewUrl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FilterListId")
                        .HasColumnType("integer");

                    b.Property<short>("Primariness")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<short>("SegmentNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FilterListId", "SegmentNumber", "Primariness")
                        .IsUnique();

                    b.ToTable("FilterListViewUrls");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Fork", b =>
                {
                    b.Property<int>("UpstreamFilterListId")
                        .HasColumnType("integer");

                    b.Property<int>("ForkFilterListId")
                        .HasColumnType("integer");

                    b.HasKey("UpstreamFilterListId", "ForkFilterListId");

                    b.HasIndex("ForkFilterListId");

                    b.ToTable("Forks");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Language", b =>
                {
                    b.Property<string>("Iso6391")
                        .HasMaxLength(2)
                        .HasColumnType("character(2)")
                        .IsFixedLength(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Iso6391");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.License", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("PermitsCommercialUse")
                        .HasColumnType("boolean");

                    b.Property<bool>("PermitsDistribution")
                        .HasColumnType("boolean");

                    b.Property<bool>("PermitsModification")
                        .HasColumnType("boolean");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Maintainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TwitterHandle")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Maintainers");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Merge", b =>
                {
                    b.Property<int>("IncludedInFilterListId")
                        .HasColumnType("integer");

                    b.Property<int>("IncludesFilterListId")
                        .HasColumnType("integer");

                    b.HasKey("IncludedInFilterListId", "IncludesFilterListId");

                    b.HasIndex("IncludesFilterListId");

                    b.ToTable("Merges");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DownloadUrl")
                        .HasColumnType("text");

                    b.Property<string>("HomeUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SupportsAbpUrlScheme")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Software");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.SoftwareSyntax", b =>
                {
                    b.Property<int>("SoftwareId")
                        .HasColumnType("integer");

                    b.Property<int>("SyntaxId")
                        .HasColumnType("integer");

                    b.HasKey("SoftwareId", "SyntaxId");

                    b.HasIndex("SyntaxId");

                    b.ToTable("SoftwareSyntaxes");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Syntax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Syntaxes");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Dependent", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "DependencyFilterList")
                        .WithMany("DependentFilterLists")
                        .HasForeignKey("DependencyFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "DependentFilterList")
                        .WithMany("DependencyFilterLists")
                        .HasForeignKey("DependentFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DependencyFilterList");

                    b.Navigation("DependentFilterList");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.License", "License")
                        .WithMany("FilterLists")
                        .HasForeignKey("LicenseId");

                    b.Navigation("License");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListLanguage", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("FilterListLanguages")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Language", "Language")
                        .WithMany("FilterListLanguages")
                        .HasForeignKey("Iso6391")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListMaintainer", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("FilterListMaintainers")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Maintainer", "Maintainer")
                        .WithMany("FilterListMaintainers")
                        .HasForeignKey("MaintainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");

                    b.Navigation("Maintainer");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListSyntax", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("FilterListSyntaxes")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Syntax", "Syntax")
                        .WithMany("FilterListSyntaxes")
                        .HasForeignKey("SyntaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");

                    b.Navigation("Syntax");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListTag", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("FilterListTags")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Tag", "Tag")
                        .WithMany("FilterListTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListViewUrl", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("ViewUrls")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Fork", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "ForkFilterList")
                        .WithMany("UpstreamFilterLists")
                        .HasForeignKey("ForkFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "UpstreamFilterList")
                        .WithMany("ForkFilterLists")
                        .HasForeignKey("UpstreamFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ForkFilterList");

                    b.Navigation("UpstreamFilterList");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Merge", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "IncludedInFilterList")
                        .WithMany("IncludesFilterLists")
                        .HasForeignKey("IncludedInFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "IncludesFilterList")
                        .WithMany("IncludedInFilterLists")
                        .HasForeignKey("IncludesFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncludedInFilterList");

                    b.Navigation("IncludesFilterList");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.SoftwareSyntax", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Software", "Software")
                        .WithMany("SoftwareSyntaxes")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Syntax", "Syntax")
                        .WithMany("SoftwareSyntaxes")
                        .HasForeignKey("SyntaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Software");

                    b.Navigation("Syntax");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", b =>
                {
                    b.Navigation("DependencyFilterLists");

                    b.Navigation("DependentFilterLists");

                    b.Navigation("FilterListLanguages");

                    b.Navigation("FilterListMaintainers");

                    b.Navigation("FilterListSyntaxes");

                    b.Navigation("FilterListTags");

                    b.Navigation("ForkFilterLists");

                    b.Navigation("IncludedInFilterLists");

                    b.Navigation("IncludesFilterLists");

                    b.Navigation("UpstreamFilterLists");

                    b.Navigation("ViewUrls");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Language", b =>
                {
                    b.Navigation("FilterListLanguages");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.License", b =>
                {
                    b.Navigation("FilterLists");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Maintainer", b =>
                {
                    b.Navigation("FilterListMaintainers");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Software", b =>
                {
                    b.Navigation("SoftwareSyntaxes");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Syntax", b =>
                {
                    b.Navigation("FilterListSyntaxes");

                    b.Navigation("SoftwareSyntaxes");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Tag", b =>
                {
                    b.Navigation("FilterListTags");
                });
#pragma warning restore 612, 618
        }
    }
}
