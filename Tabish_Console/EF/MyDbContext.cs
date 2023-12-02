using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabish_Console.AdoDotnet;

namespace Tabish_Console.EF
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext():base("Data Source=.;Initial Catalog=EFStudentDb;Integrated Security=true")
        {
                
        }

        public DbSet<Student> Students   { get; set; }
    }
}
