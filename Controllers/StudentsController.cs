using Microsoft.AspNetCore.Mvc;
using oData.Models;
using oData.Services;

namespace oData.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService studentService;

    public StudentsController(IStudentService studentService)
    {
        this.studentService = studentService;
    }
    [HttpGet]
    public ActionResult<IQueryable<Student>> GetAllStudent()
    {
        IQueryable<Student> retrievedStudents = 
            this.studentService.RetrieveAllStudents();

        return Ok(retrievedStudents);
        
    }
    
}