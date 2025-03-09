using System;
using Danaos.Domain.Domain.Grades;

namespace Danaos.Domain.Domain.Student;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Grade> Grades { get; set; }
}
