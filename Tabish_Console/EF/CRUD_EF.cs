using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tabish_Console.AdoDotnet;

namespace Tabish_Console.EF
{
    internal class CRUD_EF
    {
        public string Add(Student student) {

            using (var context=new MyDbContext())
            {
                context.Students.Add(student);
                int record = context.SaveChanges();
                if (record > 0) return "Record added successfully";

                return "Error while creating record";
            }
            
        }
        public string Update(int id,string name) {

            using (var context = new MyDbContext())
            {
                Student student=context.Students.First(s => s.Id == id);
                student.Name = name;                
                int record = context.SaveChanges();
                if (record > 0) return "Record Modified successfully";

                return "Error while modifying record";
            }
        }
        public string Delete(int id) {

            using (var context = new MyDbContext())
            {
                Student student = context.Students.First(s => s.Id == id);
                context.Students.Remove(student);
                int record = context.SaveChanges();
                if (record > 0) return "Record Deleted successfully";

                return "Error while deleting record";
            }
        }
        public IList<Student> GetAll() {

            using (var context = new MyDbContext())
            {
                return context.Students.ToList();
            }
            
        }
        public Student GetById(int id) {

            using (var context = new MyDbContext())
            {
               return context.Students.First(s => s.Id == id);
               
                
               
            }
            

        }
    }
}
