using Microsoft.EntityFrameworkCore;
using Project1.context;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext db = new MyContext();

            var q1 = db.Instructors.Include(i => i.ManagedDepartment);
            foreach (var item in q1)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
