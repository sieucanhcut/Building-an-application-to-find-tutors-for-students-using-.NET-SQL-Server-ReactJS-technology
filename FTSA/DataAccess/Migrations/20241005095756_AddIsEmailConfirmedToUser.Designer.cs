﻿// <auto-generated />
using System;
using DataAccess.dbContext_Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(TutorWebContext))]
    [Migration("20241005095756_AddIsEmailConfirmedToUser")]
    partial class AddIsEmailConfirmedToUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataObject.Contract", b =>
                {
                    b.Property<Guid>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContractPaper")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContractTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("SignDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ContractId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DataObject.Course", b =>
                {
                    b.Property<Guid>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("DataObject.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EventId");

                    b.HasIndex("AdminId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("DataObject.Feedback", b =>
                {
                    b.Property<Guid>("FeddbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CommenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FreeCourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ReceiverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TutorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FeddbackId");

                    b.HasIndex("CommenterId");

                    b.HasIndex("FreeCourseId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("TutorId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("DataObject.FreeCourse", b =>
                {
                    b.Property<Guid>("FreeCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Media")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid?>("TutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FreeCourseId");

                    b.HasIndex("TutorId");

                    b.ToTable("FreeCourse");
                });

            modelBuilder.Entity("DataObject.Invoice", b =>
                {
                    b.Property<Guid>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AmountCharged")
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid?>("ContractId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContractPaper")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("InvoiceAmount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("TimeCharge")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TimeGenerated")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ContractId")
                        .IsUnique()
                        .HasFilter("[ContractId] IS NOT NULL");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("DataObject.Location", b =>
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityOrProvince")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("DataObject.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("6ec884e6-e6c1-4db3-9c21-b4b9302c8bd1"),
                            RoleName = "Admin",
                            Status = "None"
                        },
                        new
                        {
                            RoleId = new Guid("945014d0-5a78-4b09-97ca-d7ba5a199173"),
                            RoleName = "Student",
                            Status = "None"
                        },
                        new
                        {
                            RoleId = new Guid("714e6594-7cc4-430f-bfba-bab0b109dc18"),
                            RoleName = "Tutor",
                            Status = "None"
                        });
                });

            modelBuilder.Entity("DataObject.StudentDetails", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DataObject.StudentRequirement", b =>
                {
                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentRequirement");
                });

            modelBuilder.Entity("DataObject.StudyCourse", b =>
                {
                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudyCourse");
                });

            modelBuilder.Entity("DataObject.TutionFeeSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("FeePerPeriod")
                        .HasColumnType("real");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("TutorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TutorId");

                    b.ToTable("TutionFeeSchedules");
                });

            modelBuilder.Entity("DataObject.TutorAdvertisement", b =>
                {
                    b.Property<Guid>("AdvertisementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Media")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("TutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AdvertisementId");

                    b.HasIndex("TutorId");

                    b.ToTable("TutorAdvertisement");
                });

            modelBuilder.Entity("DataObject.TutorDetails", b =>
                {
                    b.Property<Guid>("TutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AcademicSpecialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IncludingPhotos")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("OnlineTutor")
                        .HasColumnType("bit");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SelfIntroduction")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TeachingAchievement")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Transportation")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TutorId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("DataObject.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CitizenId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber2")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlaceOfWork")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("LocationId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataObject.Contract", b =>
                {
                    b.HasOne("DataObject.StudentDetails", "Student")
                        .WithMany("Contacts")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataObject.TutorDetails", "Tutor")
                        .WithMany("Contacts")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Student");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("DataObject.Event", b =>
                {
                    b.HasOne("DataObject.User", "Admin")
                        .WithMany("_Events")
                        .HasForeignKey("AdminId");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("DataObject.Feedback", b =>
                {
                    b.HasOne("DataObject.User", "Commenter")
                        .WithMany("_Feedbacks")
                        .HasForeignKey("CommenterId");

                    b.HasOne("DataObject.FreeCourse", "FreeCourse")
                        .WithMany("_Feedbacks")
                        .HasForeignKey("FreeCourseId");

                    b.HasOne("DataObject.User", "Receiver")
                        .WithMany("_FeedbacksAbout")
                        .HasForeignKey("ReceiverId");

                    b.HasOne("DataObject.TutorDetails", "Tutor")
                        .WithMany("_FeedbacksAbout")
                        .HasForeignKey("TutorId");

                    b.Navigation("Commenter");

                    b.Navigation("FreeCourse");

                    b.Navigation("Receiver");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("DataObject.FreeCourse", b =>
                {
                    b.HasOne("DataObject.TutorDetails", "Tutor")
                        .WithMany("_FreeCourse")
                        .HasForeignKey("TutorId");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("DataObject.Invoice", b =>
                {
                    b.HasOne("DataObject.Contract", "Contract")
                        .WithOne("Invoice")
                        .HasForeignKey("DataObject.Invoice", "ContractId");

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("DataObject.StudentDetails", b =>
                {
                    b.HasOne("DataObject.User", "User")
                        .WithOne("_Student")
                        .HasForeignKey("DataObject.StudentDetails", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataObject.StudentRequirement", b =>
                {
                    b.HasOne("DataObject.Course", "Course")
                        .WithMany("_StudentRequirements")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataObject.StudentDetails", "Student")
                        .WithMany("_StudentRequirements")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DataObject.StudyCourse", b =>
                {
                    b.HasOne("DataObject.Course", "Course")
                        .WithMany("_StudyingCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataObject.StudentDetails", "Student")
                        .WithMany("_StudyingCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DataObject.TutionFeeSchedule", b =>
                {
                    b.HasOne("DataObject.Course", "Course")
                        .WithMany("_TutionFeeSchedules")
                        .HasForeignKey("CourseId");

                    b.HasOne("DataObject.TutorDetails", "Tutor")
                        .WithMany("_tutionFeeSchedules")
                        .HasForeignKey("TutorId");

                    b.Navigation("Course");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("DataObject.TutorAdvertisement", b =>
                {
                    b.HasOne("DataObject.TutorDetails", "Tutor")
                        .WithMany("_TutorAdvertisements")
                        .HasForeignKey("TutorId");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("DataObject.TutorDetails", b =>
                {
                    b.HasOne("DataObject.User", "User")
                        .WithOne("_Tutor")
                        .HasForeignKey("DataObject.TutorDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataObject.User", b =>
                {
                    b.HasOne("DataObject.Location", "Location")
                        .WithMany("_Users")
                        .HasForeignKey("LocationId");

                    b.HasOne("DataObject.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataObject.Contract", b =>
                {
                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("DataObject.Course", b =>
                {
                    b.Navigation("_StudentRequirements");

                    b.Navigation("_StudyingCourses");

                    b.Navigation("_TutionFeeSchedules");
                });

            modelBuilder.Entity("DataObject.FreeCourse", b =>
                {
                    b.Navigation("_Feedbacks");
                });

            modelBuilder.Entity("DataObject.Location", b =>
                {
                    b.Navigation("_Users");
                });

            modelBuilder.Entity("DataObject.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataObject.StudentDetails", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("_StudentRequirements");

                    b.Navigation("_StudyingCourses");
                });

            modelBuilder.Entity("DataObject.TutorDetails", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("_FeedbacksAbout");

                    b.Navigation("_FreeCourse");

                    b.Navigation("_TutorAdvertisements");

                    b.Navigation("_tutionFeeSchedules");
                });

            modelBuilder.Entity("DataObject.User", b =>
                {
                    b.Navigation("_Events");

                    b.Navigation("_Feedbacks");

                    b.Navigation("_FeedbacksAbout");

                    b.Navigation("_Student");

                    b.Navigation("_Tutor");
                });
#pragma warning restore 612, 618
        }
    }
}
