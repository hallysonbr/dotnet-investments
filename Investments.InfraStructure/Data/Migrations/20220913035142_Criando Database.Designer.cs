﻿// <auto-generated />
using Investments.InfraStructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Investments.InfraStructure.Data.Migrations
{
    [DbContext(typeof(InvestmentsContext))]
    [Migration("20220913035142_Criando Database")]
    partial class CriandoDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");
#pragma warning restore 612, 618
        }
    }
}