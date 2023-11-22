﻿// <auto-generated />
using System;
using Accounts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Accounts.Migrations
{
    [DbContext(typeof(AccountingDbContext))]
    partial class AccountingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Accounts.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccountTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsBudgetProfit")
                        .HasColumnType("bit");

                    b.Property<string>("NameAccount")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumberAccount")
                        .HasColumnType("int");

                    b.Property<decimal?>("OpeningBlance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("SubAccounts")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Accounts.Models.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Accounttypes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("assetsFixeds");
                });

            modelBuilder.Entity("Accounts.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("companys");
                });

            modelBuilder.Entity("Accounts.Models.CostCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameCostCenter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberCostCenter")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CostCenter");
                });

            modelBuilder.Entity("Accounts.Models.MakeJournalBody", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Blance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CostCenterID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Credit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Debit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBudgetProfit")
                        .HasColumnType("bit");

                    b.Property<int?>("MakeJournalHeadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountID");

                    b.HasIndex("CostCenterID");

                    b.HasIndex("MakeJournalHeadId");

                    b.ToTable("makeJournalBody");
                });

            modelBuilder.Entity("Accounts.Models.MakeJournalHead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("EntryJournalId")
                        .HasColumnType("int");

                    b.Property<int>("MakeJurnalBodyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountID");

                    b.HasIndex("MakeJurnalBodyID");

                    b.ToTable("makeJournalHeads");
                });

            modelBuilder.Entity("Accounts.Models.TreeOfAccounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NumberAcc")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("treeOfAccounts");
                });

            modelBuilder.Entity("Accounts.Models.Useres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passwd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("useres");
                });

            modelBuilder.Entity("Accounts.Models.Account", b =>
                {
                    b.HasOne("Accounts.Models.AccountType", "AccountTypes")
                        .WithMany()
                        .HasForeignKey("AccountTypeId");

                    b.Navigation("AccountTypes");
                });

            modelBuilder.Entity("Accounts.Models.MakeJournalBody", b =>
                {
                    b.HasOne("Accounts.Models.Account", "Accounts")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accounts.Models.CostCenter", "costCenters")
                        .WithMany()
                        .HasForeignKey("CostCenterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accounts.Models.MakeJournalHead", null)
                        .WithMany("makeJournalBodies")
                        .HasForeignKey("MakeJournalHeadId");

                    b.Navigation("Accounts");

                    b.Navigation("costCenters");
                });

            modelBuilder.Entity("Accounts.Models.MakeJournalHead", b =>
                {
                    b.HasOne("Accounts.Models.Account", "accounts")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accounts.Models.MakeJournalBody", "MakeJournalBodys")
                        .WithMany()
                        .HasForeignKey("MakeJurnalBodyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MakeJournalBodys");

                    b.Navigation("accounts");
                });

            modelBuilder.Entity("Accounts.Models.MakeJournalHead", b =>
                {
                    b.Navigation("makeJournalBodies");
                });
#pragma warning restore 612, 618
        }
    }
}
