using MvcLabData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcLabData
{
    public class MvcLabContext:DbContext
    {
        public MvcLabContext() : base("name=MvcLabConnectionString")
        {

        }
        DbSet<Course> Courses{ get; set; }
        DbSet<Enrollment> Enrollments{ get; set; }
        DbSet<Student> Students{ get; set; }
    }
}
