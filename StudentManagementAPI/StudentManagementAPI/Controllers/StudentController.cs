using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Interfaces;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]

    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students =
                await _service.GetAllStudents();

            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(
            Students student)
        {
            var result =
                await _service.AddStudent(student);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(
            Students student)
        {
            var result =
                await _service.UpdateStudent(student);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(
            int id)
        {
            var result =
                await _service.DeleteStudent(id);

            return Ok(result);
        }
    }
}