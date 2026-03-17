using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    public static class StudentQueriesA
    {
        static void Run()
        {
         var names =   StudentRepository.students.Where(s => s.Value > 5).Select(s => s.Key);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
