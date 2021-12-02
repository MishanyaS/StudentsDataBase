using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsDataBase.Models;

namespace StudentsDataBase.Data
{
    public class StudentsDataBaseContext : DbContext
    {
        public StudentsDataBaseContext (DbContextOptions<StudentsDataBaseContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsDataBase.Models.Student> Student { get; set; }
    }
}
