using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.display();
            Employee e2 = new Employee();
            e2.display();
            Employee e3 = new Employee();
            e3.display();
            Employee e4 = new Employee(678, "Prasad", "Pune");
            Console.WriteLine("Total No. Of Employees:"+Employee.count);
           
            //int[] nums = new int[5];
            //int[] nums1 = new int[] { 23, 45, 77, 89 };
            ////for (int i=0;i<5;i++)
            //{
            //    Console.WriteLine("Enter element "+i);
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Array Data");
            //for (int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine(nums[i]);  
            //}
            //int[][] jArr = new int[3][];
            //jArr[0] = new int[4];
            //jArr[1] = new int[3];
            //jArr[2] = new int[5];
            //for(int i=0;i<3; i++)
            //{
            //    for(int j=0;j<jArr[i].Length;j++)
            //    {
            //        Console.WriteLine("Enter element {0}{1}",i,j);
            //        jArr[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Jagged Array Data");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < jArr[i].Length; j++)
            //    {
            //        Console.Write(jArr[i][j]+" ");

            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
