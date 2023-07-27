using GradeAverage.Interfaces;

namespace GradeAverage.Helpers
{
    public class GradeAverageCalculator
    {
        public double CalculateAverage(IStudent student)
        {
            return student.CalculateAverageGrade();
        }
    }
}