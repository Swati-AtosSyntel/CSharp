using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Employee
    {
       public int empid;
       public string ename;
       public string location;
        public static int count;

        static Employee()
        {
            Console.WriteLine("Static Constructor");
            count = 0;
        }
        public Employee()
        {
            Console.WriteLine("Enter employee id");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            ename = Console.ReadLine();
            Console.WriteLine("Enter work location");
            location = Console.ReadLine();
            count++;
        }
        public Employee(int id, string ename,string location)
        {
            empid = id;
            this.ename = ename;
            this.location = location;
        }
       
        //public void acceptData()
        //{
        //    Console.WriteLine("Enter employee id");
        //    empid = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter employee name");
        //    ename = Console.ReadLine();
        //    Console.WriteLine("Enter employee id");
        //    location = Console.ReadLine();
        //}
        public void display()
        {
            Console.WriteLine(empid);
            Console.WriteLine(ename);
            Console.WriteLine(location);
        }
        
    }
}
