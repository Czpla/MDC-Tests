using GradeAverage.Interfaces;
using GradeAverage.Helpers;
using GradeAverage.Implementations;

namespace GradeAverage
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Grade Average Calculator");

            Console.Write("Enter student's name: ");
            string name = Console.ReadLine()!;

            IStudent student = new Student(name);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                double grade = Convert.ToDouble(Console.ReadLine());
                student.AddGrade(grade);
            }

            GradeAverageCalculator calculator = new GradeAverageCalculator();
            double average = calculator.CalculateAverage(student);

            Console.WriteLine($"Average grade for {student.Name}: {average:F2}");
        }
    }
}