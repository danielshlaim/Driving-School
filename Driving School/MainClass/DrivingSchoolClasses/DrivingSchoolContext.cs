using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Driving_School.DB.DrivingSchoolClasses
{
    public partial class DrivingSchoolContext : DbContext
    {
        public DrivingSchoolContext()
        {
        }

        public DrivingSchoolContext(DbContextOptions<DrivingSchoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DriveCourse> DriveCourses { get; set; }
        public virtual DbSet<DrivingInstructor> DrivingInstructors { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Driving School;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DriveCourse>(entity =>
            {
                entity.HasKey(e => e.CoursesId);

                entity.ToTable("Drive_Courses");

                entity.Property(e => e.CoursesId).HasColumnName("Courses_Id");

                entity.Property(e => e.DrivingInstructorId).HasColumnName("Driving_instructor_Id");

                entity.Property(e => e.HistoryId).HasColumnName("History_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumberOfLessones).HasColumnName("Number_Of_Lessones");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.History)
                    .WithMany(p => p.DriveCourses)
                    .HasForeignKey(d => d.HistoryId)
                    .HasConstraintName("FK_Drive_Courses_History");
            });

            modelBuilder.Entity<DrivingInstructor>(entity =>
            {
                entity.HasKey(e => e.DrivingInstructorsId);

                entity.ToTable("Driving_instructors");

                entity.Property(e => e.DrivingInstructorsId).HasColumnName("Driving_instructors_Id");

                entity.Property(e => e.CoursesId).HasColumnName("Courses_Id");

                entity.Property(e => e.DrivingInstructorIdentityNumber).HasColumnName("Driving_instructor_IdentityNumber");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone_Number");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Courses)
                    .WithMany(p => p.DrivingInstructors)
                    .HasForeignKey(d => d.CoursesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Driving_instructors_Drive_Courses");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("History");

                entity.Property(e => e.HistoryId).HasColumnName("History_Id");

                entity.Property(e => e.CoursesId).HasColumnName("Courses_Id");

                entity.Property(e => e.DrivingInstructorId).HasColumnName("Driving_instructor_Id");

                entity.Property(e => e.StudentId).HasColumnName("Student_Id");

                entity.HasOne(d => d.Courses)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.CoursesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_History_Drive_Courses");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId).HasColumnName("Student_Id");

                entity.Property(e => e.CoursesId).HasColumnName("Courses_Id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone_Number");

                entity.Property(e => e.StudentIdentityNumber).HasColumnName("Student_IdentityNumber");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

             OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "yakov", LastName = "lulu", Email = "yoy@gmail.com", UserName = "yasha111", Password = "123123" }
                ) ;
            modelBuilder.Entity<DrivingInstructor>().HasData(
                new DrivingInstructor {DrivingInstructorsId = 1 ,FirstName = "gil",LastName = "alkobi", Email = "gilnotok@gmail.com",UserName = "gilgul",Password = "124126" }
                );


        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}


