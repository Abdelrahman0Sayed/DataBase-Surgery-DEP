﻿// <auto-generated />
using System;
using DataBaseProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBaseProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240621005334_edit2")]
    partial class edit2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataBaseProject.Models.Activity", b =>
                {
                    b.Property<int>("AcId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ac_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AcId"));

                    b.Property<string>("Action")
                        .HasColumnType("text")
                        .HasColumnName("action");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<int?>("Toid")
                        .HasColumnType("integer")
                        .HasColumnName("toid");

                    b.Property<int?>("Uid")
                        .HasColumnType("integer")
                        .HasColumnName("uid");

                    b.HasKey("AcId")
                        .HasName("activity_pk");

                    b.HasIndex("Toid");

                    b.HasIndex("Uid");

                    b.ToTable("activity");
                });

            modelBuilder.Entity("DataBaseProject.Models.Appointment", b =>
                {
                    b.Property<int>("Apid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("apid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Apid"));

                    b.Property<bool?>("Accept")
                        .HasColumnType("boolean")
                        .HasColumnName("accept");

                    b.Property<DateTime?>("Apdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("apdate");

                    b.Property<int?>("Did")
                        .HasColumnType("integer")
                        .HasColumnName("did");

                    b.Property<int>("Pid")
                        .HasColumnType("integer")
                        .HasColumnName("pid");

                    b.Property<string>("Status")
                        .HasColumnType("text")
                        .HasColumnName("Status");

                    b.Property<string>("notes")
                        .HasColumnType("text")
                        .HasColumnName("notes");

                    b.HasKey("Apid")
                        .HasName("appointment_pk");

                    b.HasIndex("Did");

                    b.HasIndex("Pid");

                    b.ToTable("appointment");
                });

            modelBuilder.Entity("DataBaseProject.Models.Deleteduser", b =>
                {
                    b.Property<int>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("uid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Uid"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("address");

                    b.Property<DateTime?>("Bdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("bdate");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("Facebook")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("facebook");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("firstname");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("gender");

                    b.Property<string>("Github")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("github");

                    b.Property<string>("Insta")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("insta");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("lastname");

                    b.Property<string>("Linkedin")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("linkedin");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone");

                    b.Property<string>("Profileimage")
                        .HasColumnType("text")
                        .HasColumnName("profileimage");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("role");

                    b.Property<string>("Twitter")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("twitter");

                    b.HasKey("Uid")
                        .HasName("deleteduser_pkey");

                    b.ToTable("deleteduser");
                });

            modelBuilder.Entity("DataBaseProject.Models.Disease", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("patient_id");

                    b.Property<string>("Disease1")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("disease");

                    b.HasKey("PatientId")
                        .HasName("disease_pk");

                    b.ToTable("disease");
                });

            modelBuilder.Entity("DataBaseProject.Models.Phistory", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("patient_id");

                    b.Property<float?>("Height")
                        .HasColumnType("real")
                        .HasColumnName("height");

                    b.Property<int?>("HospitalStay")
                        .HasColumnType("integer")
                        .HasColumnName("hospital_stay");

                    b.Property<bool?>("Smoking")
                        .HasColumnType("boolean")
                        .HasColumnName("smoking");

                    b.Property<float?>("Weight")
                        .HasColumnType("real")
                        .HasColumnName("weight");

                    b.HasKey("PatientId")
                        .HasName("phistory_pk");

                    b.ToTable("phistory");
                });

            modelBuilder.Entity("DataBaseProject.Models.Scan", b =>
                {
                    b.Property<int>("ScanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("scan_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ScanId"));

                    b.Property<bool?>("Accept")
                        .HasColumnType("boolean")
                        .HasColumnName("accept");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int?>("DocId")
                        .HasColumnType("integer")
                        .HasColumnName("doc_id");

                    b.Property<string>("Image")
                        .HasColumnType("text")
                        .HasColumnName("image");

                    b.Property<string>("Image2")
                        .HasColumnType("text")
                        .HasColumnName("image2");

                    b.Property<int?>("PId")
                        .HasColumnType("integer")
                        .HasColumnName("p_id");

                    b.Property<string>("Response")
                        .HasColumnType("text")
                        .HasColumnName("response");

                    b.HasKey("ScanId")
                        .HasName("scan_pk");

                    b.HasIndex("DocId");

                    b.HasIndex("PId");

                    b.ToTable("scan");
                });

            modelBuilder.Entity("DataBaseProject.Models.Surgery", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("sid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Sid"));

                    b.Property<int?>("Cost")
                        .HasColumnType("integer")
                        .HasColumnName("cost");

                    b.Property<int?>("Did")
                        .HasColumnType("integer")
                        .HasColumnName("did");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<int?>("Nid")
                        .HasColumnType("integer");

                    b.Property<int?>("OpRoom")
                        .HasColumnType("integer")
                        .HasColumnName("op_room");

                    b.Property<int?>("Pid")
                        .HasColumnType("integer")
                        .HasColumnName("pid");

                    b.Property<DateTime?>("Sdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("sdate");

                    b.HasKey("Sid")
                        .HasName("sid");

                    b.HasIndex("Did");

                    b.HasIndex("Pid");

                    b.ToTable("surgery");
                });

            modelBuilder.Entity("DataBaseProject.Models.User", b =>
                {
                    b.Property<int>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("uid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Uid"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("address");

                    b.Property<DateTime?>("Bdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("bdate");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("Facebook")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("facebook");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("firstname");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("gender");

                    b.Property<string>("Github")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("github");

                    b.Property<string>("Insta")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("insta");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("lastname");

                    b.Property<string>("Linkedin")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("linkedin");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone");

                    b.Property<string>("Profileimage")
                        .HasColumnType("text")
                        .HasColumnName("profileimage");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("role");

                    b.Property<string>("Twitter")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("twitter");

                    b.HasKey("Uid")
                        .HasName("User_pkey");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SugeryNurse", b =>
                {
                    b.Property<int>("Nid")
                        .HasColumnType("integer")
                        .HasColumnName("nid");

                    b.Property<int>("Sid")
                        .HasColumnType("integer")
                        .HasColumnName("sid");

                    b.HasKey("Nid", "Sid")
                        .HasName("sugery_nurses_pk");

                    b.HasIndex("Sid");

                    b.ToTable("sugery_nurses", (string)null);
                });

            modelBuilder.Entity("SurgeryUser", b =>
                {
                    b.Property<int>("Nid")
                        .HasColumnType("integer");

                    b.Property<int>("Sid")
                        .HasColumnType("integer");

                    b.HasKey("Nid", "Sid");

                    b.ToTable("SurgeryUser");
                });

            modelBuilder.Entity("DataBaseProject.Models.Activity", b =>
                {
                    b.HasOne("DataBaseProject.Models.User", "To")
                        .WithMany("ActivityTos")
                        .HasForeignKey("Toid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("activity_user_uid_fk_2");

                    b.HasOne("DataBaseProject.Models.User", "UidNavigation")
                        .WithMany("ActivityUidNavigations")
                        .HasForeignKey("Uid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("activity_user_uid_fk");

                    b.Navigation("To");

                    b.Navigation("UidNavigation");
                });

            modelBuilder.Entity("DataBaseProject.Models.Appointment", b =>
                {
                    b.HasOne("DataBaseProject.Models.User", "DidNavigation")
                        .WithMany("AppointmentDidNavigations")
                        .HasForeignKey("Did")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("appointment_user_uid_fk");

                    b.HasOne("DataBaseProject.Models.User", "PidNavigation")
                        .WithMany("AppointmentPidNavigations")
                        .HasForeignKey("Pid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk");

                    b.Navigation("DidNavigation");

                    b.Navigation("PidNavigation");
                });

            modelBuilder.Entity("DataBaseProject.Models.Disease", b =>
                {
                    b.HasOne("DataBaseProject.Models.Phistory", "Patient")
                        .WithOne("Disease")
                        .HasForeignKey("DataBaseProject.Models.Disease", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("disease_phistory_patient_id_fk");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DataBaseProject.Models.Phistory", b =>
                {
                    b.HasOne("DataBaseProject.Models.User", "Patient")
                        .WithOne("Phistory")
                        .HasForeignKey("DataBaseProject.Models.Phistory", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("phistory_user_uid_fk");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DataBaseProject.Models.Scan", b =>
                {
                    b.HasOne("DataBaseProject.Models.User", "Doc")
                        .WithMany("ScanDocs")
                        .HasForeignKey("DocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("scan_user_uid_fk");

                    b.HasOne("DataBaseProject.Models.User", "PIdNavigation")
                        .WithMany("ScanPIdNavigations")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("scan_user_uid_fk_2");

                    b.Navigation("Doc");

                    b.Navigation("PIdNavigation");
                });

            modelBuilder.Entity("DataBaseProject.Models.Surgery", b =>
                {
                    b.HasOne("DataBaseProject.Models.User", "DidNavigation")
                        .WithMany("SurgeryDidNavigations")
                        .HasForeignKey("Did")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("surgery_user_uid_fk");

                    b.HasOne("DataBaseProject.Models.User", "PidNavigation")
                        .WithMany("SurgeryPidNavigations")
                        .HasForeignKey("Pid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("surgery_user_uid_fk_2");

                    b.Navigation("DidNavigation");

                    b.Navigation("PidNavigation");
                });

            modelBuilder.Entity("SugeryNurse", b =>
                {
                    b.HasOne("DataBaseProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("Nid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("sugerynurses_user_uid_fk");

                    b.HasOne("DataBaseProject.Models.Surgery", null)
                        .WithMany()
                        .HasForeignKey("Sid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("sugerynurses_surgery_sid_fk");
                });

            modelBuilder.Entity("DataBaseProject.Models.Phistory", b =>
                {
                    b.Navigation("Disease");
                });

            modelBuilder.Entity("DataBaseProject.Models.User", b =>
                {
                    b.Navigation("ActivityTos");

                    b.Navigation("ActivityUidNavigations");

                    b.Navigation("AppointmentDidNavigations");

                    b.Navigation("AppointmentPidNavigations");

                    b.Navigation("Phistory");

                    b.Navigation("ScanDocs");

                    b.Navigation("ScanPIdNavigations");

                    b.Navigation("SurgeryDidNavigations");

                    b.Navigation("SurgeryPidNavigations");
                });
#pragma warning restore 612, 618
        }
    }
}
