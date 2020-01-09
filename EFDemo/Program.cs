using System;
using System.Linq;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentContext = new StudentContext();
            var databaseCreated = studentContext.Database.EnsureCreated();
            var canConnect = studentContext.Database.CanConnect();
            var studentsunder20 = studentContext.Students.Where(student => student.Age < 20).ToList();
            
        }
    }
}
