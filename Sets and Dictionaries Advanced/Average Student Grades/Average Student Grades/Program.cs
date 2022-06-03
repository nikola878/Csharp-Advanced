using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsGrade = new Dictionary<string, List<decimal>>();
            int gradesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < gradesCount; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string name = line[0];
                decimal grade = decimal.Parse(line[1]);
                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade.Add(name, new List<decimal>());
                }
                studentsGrade[name].Add(grade);
            }

            foreach (var name in studentsGrade.Keys)
            {
                List<decimal> grades = studentsGrade[name];
                string gradesStr = string.Join(" ",
                    grades.Select(g => g.ToString("f2")));
                decimal avg = grades.Average();
                Console.WriteLine($"{name} -> {gradesStr} (avg: {avg:f2})");
            }
        }
    }
}
