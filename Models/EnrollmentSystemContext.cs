using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace JPIEnrollmentSystem.Models
{
    public class EnrollmentSystemContext : DbContext
    {
        // Student Database Table
        //public virtual DbSet<Student> Students { get; set; }

        //// Still not sure
        //public DbSet<StudentRequirement> StudentsRequirements { get; set; }
        //public DbSet<StudentRemark> StudentsRemarks { get; set; }
        //public DbSet<StudentSubject> StudentsSubjects { get; set; }
        //public DbSet<AcademicYear> AcademicYears { get; set; }
        //public DbSet<Curriculum> Curriculums { get; set; }
        //public DbSet<Discount> Discounts { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public virtual DbSet<Requirement> Requirements { get; set; }
        //public DbSet<Room> Rooms { get; set; }
        //public DbSet<Section> Sections { get; set; }
        //public DbSet<Strand> Strand { get; set; }
        //public DbSet<Subject> Subjects { get; set; }
        //public DbSet<Tuition> Tuitions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public EnrollmentSystemContext() : base("name=DefaultConnection")
        {
        }
    }
}
