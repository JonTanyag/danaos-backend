using System;
using Danaos.Application.Service.Grades;
using Danaos.Domain.Domain.Grades;

namespace Danaos.Application.Service.Students;

public class StudentDto
{
    public string Name { get; set; }
    public double Average { get; set; }
}
