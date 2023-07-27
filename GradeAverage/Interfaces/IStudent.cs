namespace GradeAverage.Interfaces
{
    public interface IStudent
    {
        string Name { get; }
        void AddGrade(double grade);
        double CalculateAverageGrade();
    }
}