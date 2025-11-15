using System;

namespace CoursePlatform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Student {i}: ");
                int codeStudent = int.Parse(Console.ReadLine());
                courseA.Add(codeStudent);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Student {i}: ");
                int codeStudent = int.Parse(Console.ReadLine());
                courseB.Add(codeStudent);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Student {i}: ");
                int codeStudent = int.Parse(Console.ReadLine());
                courseC.Add(codeStudent);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine($"Total students: {all.Count()}");
        }
    }
}