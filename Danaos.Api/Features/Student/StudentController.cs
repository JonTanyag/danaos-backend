using Danaos.Application.Service.Students;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Danaos.Api.Features.Student
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;   
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateStudent([FromBody] StudentDto student)
        {
            await _service.CreateStudent(student);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var response = await _service.GetStudents();
            return Ok(response);
        }
    }
}
