using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your roll no.");
            int roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your emailid");
            string email = Console.ReadLine();
            Console.WriteLine("enter your address");
            string address = Console.ReadLine();
            StudentModel oStudentModel = new StudentModel();
            oStudentModel.StudentRegistration(roll, name, email, address);
        }
    }
}
