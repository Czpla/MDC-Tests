using GradeAverage.Interfaces;

namespace GradeAverage.Implementations
{
    public class Student : IStudent
    {
        public string Name { get; private set; }
        private List<double> grades;

        public Student(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double CalculateAverageGrade()
        {
            if (grades.Count == 0)
                return 0;

            return grades.Sum() / grades.Count;
        }
    }
}

