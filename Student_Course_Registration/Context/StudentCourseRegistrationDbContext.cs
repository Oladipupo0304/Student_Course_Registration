using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Student_Course_Registration.Data;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace StudentCourseRegistration.Context
{

    public class StudentCourseRegistrationDbContext(DbContextOptions<StudentCourseRegistrationDbContext> options) : IdentityDbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }


}