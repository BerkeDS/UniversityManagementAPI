using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UniversityWebAPI;

public partial class UniversityContext : DbContext
{
    public UniversityContext()
    {
    }

    public UniversityContext(DbContextOptions<UniversityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassCourse> ClassCourses { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Semester> Semesters { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherCourse> TeacherCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:University");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Building>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BuildingId).HasColumnName("buildingId");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.DivisionId).HasColumnName("divisionId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Lab).HasColumnName("lab");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Projector).HasColumnName("projector");
        });

        modelBuilder.Entity<ClassCourse>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClassId).HasColumnName("classId");
            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SemesterId).HasColumnName("semesterId");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CourseName)
                .HasMaxLength(250)
                .HasColumnName("courseName");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Schedule).HasColumnName("schedule");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DivisionId).HasColumnName("divisionId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BuildingId).HasColumnName("buildingId");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.DivisionId).HasColumnName("divisionId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Semester>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AvaragePoint)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("avaragePoint");
            entity.Property(e => e.ConfirmCredit).HasColumnName("confirmCredit");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentId");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.GraduateDate)
                .HasColumnType("date")
                .HasColumnName("graduateDate");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .HasColumnName("lastName");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.SocialNumber)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("socialNumber");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("startDate");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AvarageGrade)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("avarageGrade");
            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.FinalGrade).HasColumnName("finalGrade");
            entity.Property(e => e.Grade1).HasColumnName("grade1");
            entity.Property(e => e.Grade2).HasColumnName("grade2");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nonattendance).HasColumnName("nonattendance");
            entity.Property(e => e.ProjectGrade1).HasColumnName("projectGrade1");
            entity.Property(e => e.ProjectGrade2).HasColumnName("projectGrade2");
            entity.Property(e => e.SemesterId).HasColumnName("semesterId");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.StudentId).HasColumnName("studentId");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DepartmentId).HasColumnName("departmentId");
            entity.Property(e => e.DivisionId).HasColumnName("divisionId");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .HasColumnName("lastName");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.RoomId).HasColumnName("roomId");
            entity.Property(e => e.SocialNumber)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("socialNumber");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("startDate");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<TeacherCourse>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SemesterId).HasColumnName("semesterId");
            entity.Property(e => e.TeacherId).HasColumnName("teacherId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
