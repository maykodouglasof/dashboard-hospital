﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PainelHospital.Models;

namespace PainelHospital.Migrations
{
    [DbContext(typeof(PainelHospitalContext))]
    [Migration("20200303150058_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("PainelHospital.Models.Consulta", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.HasKey("ID");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("PainelHospital.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<int>("EstadoId");

                    b.Property<string>("Logradouro");

                    b.Property<int?>("MedicoId");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("MedicoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("PainelHospital.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Sigla");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("PainelHospital.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Atendimentos");

                    b.Property<string>("Crm");

                    b.Property<string>("Nome");

                    b.Property<string>("Tel");

                    b.HasKey("Id");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("PainelHospital.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ConsultaID");

                    b.Property<int>("EnderecoId");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<int>("Sexo");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaID");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("PainelHospital.Models.Endereco", b =>
                {
                    b.HasOne("PainelHospital.Models.Estado", "Estado")
                        .WithMany("Endereco")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PainelHospital.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");
                });

            modelBuilder.Entity("PainelHospital.Models.Paciente", b =>
                {
                    b.HasOne("PainelHospital.Models.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("ConsultaID");

                    b.HasOne("PainelHospital.Models.Endereco", "Endereco")
                        .WithOne("Paciente")
                        .HasForeignKey("PainelHospital.Models.Paciente", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
