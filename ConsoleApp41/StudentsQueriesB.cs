using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class StudentsQueriesB
    {
        static void Run()
        {
            var students = StudentRepository.students.OrderBy(s => s.Value).FirstOrDefault(s => s.Value == 6);
            Console.WriteLine("Първия ученик с 6: ");

            if (students.Key != null)
            {
                Console.WriteLine($"{students.Key} , {students.Value}");
            }
            else
                Console.WriteLine("Няма такъв ученик! ");
        }
    }
}
