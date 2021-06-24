using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = new List<int>() { 10, 2330, 112233, 10, 949, 3764, 2942 };


            Console.WriteLine("The numbers are");
            foreach(int n in nums)
            {
                Console.WriteLine(n);
            }

            int result = nums.Min();
            int result2 = nums.Max();
            double result3 = nums.Average();

            Console.WriteLine("Min Value: {0}", result);
            Console.WriteLine("Max Value: {0}", result2);
            Console.WriteLine("Average Value: {0}", result3);


            List<Student> students = new List<Student>();
            {
                students.Add(new Student("Jimmy",13));
                students.Add(new Student("Hannah Banana", 21));
                students.Add(new Student("Justin", 30));
                students.Add(new Student("Sarah", 53));
                students.Add(new Student("Hannibal", 15));
                students.Add(new Student("Maria", 63));
                students.Add(new Student("Abe", 33));
                students.Add(new Student("Curtis", 10));


                Console.WriteLine();
                Console.WriteLine("Students aged 21 and older:");
                students.Where(s => s.Age >= 21).ToList().ForEach(x => Console.WriteLine($"Student Name: {x.Name}\nStudent Age: {x.Age}\n"));

                Console.WriteLine($"The oldest student is: {students.OrderByDescending(x => x.Age).First().Name}");
                Console.WriteLine();

                Console.WriteLine($"The youngest student is: {students.OrderBy(x => x.Age).First().Name}");
                Console.WriteLine();

                Console.WriteLine($"The oldest student under the age of 25 is: {students.Where(x => x.Age < 25).OrderByDescending(x => x.Age).First().Name}");
                Console.WriteLine();

                students.Where(s => s.Age >= 21 && s.Age % 2 == 0).ToList().ForEach(x => Console.WriteLine($"Students over the age of 21 with even ages: {x.Name}\nStudent Age: {x.Age}\n"));
                Console.WriteLine();

                Console.WriteLine("Students between the ages of 13 and 19: ");
                students.Where(s => s.Age >= 13 && s.Age <= 19).ToList().ForEach(x => Console.WriteLine($"{x.Name}"));
                Console.WriteLine();
               
                Console.WriteLine("Students whose name starts with a vowel: ");
                students.Where(x => "aeiouAEIOU".Contains(x.Name[0])).ToList().ForEach(x => Console.WriteLine($"{x.Name}"));
            }
        }

        public static void PrintStudentList(List<Student> students)
        {
            foreach(Student s in students)
            {
                Console.WriteLine("Student Name: " + s.Name);
                Console.WriteLine("Student Age" + s.Age);
                Console.WriteLine();
            }
        }
    }
}
