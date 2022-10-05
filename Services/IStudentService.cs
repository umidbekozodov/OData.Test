using oData.Models;

namespace oData.Services;

public interface IStudentService
{
    IQueryable<Student> RetrieveAllStudents();
}