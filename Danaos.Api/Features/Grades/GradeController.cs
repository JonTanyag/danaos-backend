using Danaos.Application.Service.Grades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Danaos.Api.Features.Grades
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeService _service;
        public GradeController(IGradeService service)
        {
            _service = service;
        }
        [HttpPost("create")]
        public async Task<IActionResult> AddGradeToStudent([FromBody] GradeDto grade)
        {
            await _service.CreateGrade(grade);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            // var response = await _service.GetStudents();
            return Ok();
        }
    }
}
