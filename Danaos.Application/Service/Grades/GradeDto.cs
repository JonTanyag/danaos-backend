using System;

namespace Danaos.Application.Service.Grades;

public class GradeDto
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int Grades { get; set; }
}
