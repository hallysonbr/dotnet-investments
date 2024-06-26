﻿// <auto-generated />
using System;
using Investments.InfraStructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Investments.InfraStructure.Data.Migrations
{
    [DbContext(typeof(InvestmentsContext))]
    [Migration("20220913120756_Inserindo Dados")]
    partial class InserindoDados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Investments.Core.Entities.Ativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ativos");
                });

            modelBuilder.Entity("Investments.Core.Entities.Carteira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AtivoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AtivoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Carteiras");
                });

            modelBuilder.Entity("Investments.Core.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Investments.Core.Entities.Carteira", b =>
                {
                    b.HasOne("Investments.Core.Entities.Ativo", "Ativo")
                        .WithMany()
                        .HasForeignKey("AtivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Investments.Core.Entities.Usuario", "Usuario")
                        .WithMany("Ativos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ativo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Investments.Core.Entities.Usuario", b =>
                {
                    b.Navigation("Ativos");
                });
#pragma warning restore 612, 618
        }
    }
}
