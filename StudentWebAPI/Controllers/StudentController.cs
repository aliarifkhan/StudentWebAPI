using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using StudentWebAPI.Models;

namespace StudentWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }
        

    [HttpGet]
    public ActionResult<List<StudentDetail>> GetStudentDetail()
        {
            return _context.StudentDetails.ToList();
        }

        [HttpGet("id")]
        public ActionResult<StudentDetail> GetStudentByID(int id)
        {
            var student = _context.StudentDetails.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;


        }

        [HttpPost("Add")]
        public ActionResult<StudentDetail> PostStudentDetail(StudentDetail studentData)
        {
            _context.StudentDetails.Add(studentData);
            _context.SaveChanges();
            return (studentData);
        }

        [HttpDelete("Delete")]
        public ActionResult<StudentDetail> DeleteStudent(int id) 
        {
          var student = _context.StudentDetails.Find(id);
            if (student == null) { 
            return NotFound();
            }
            _context.StudentDetails.Remove(student);
            _context.SaveChanges();
            return (student);

        }




        }


    }
