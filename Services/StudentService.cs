using oData.Models;

namespace oData.Services;

public class StudentService : IStudentService
{
    public IQueryable<Student> RetrieveAllStudents()
    {
        return new List<Student>
        {
            new Student
            {
                Id = Guid.NewGuid(),
                Name = "Vishu Goli",
                Score = 200
            },
            new Student
            {
                Id = Guid.NewGuid(),
                Name = "Mustafo",
                Score = 190
            },
            new Student
            {
                Id = Guid.NewGuid(),
                Name = "Farrux",
                Score = 169
            }
            
        }.AsQueryable(); ;
    }
}