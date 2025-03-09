using System;
using StudentTable = Danaos.Domain.Domain.Student.Student;

namespace Danaos.Domain.Domain.Grades;

public class Grade
{
    public int Id { get; set; }
    public int Student_Id { get; set; }
    public int Course_Id { get; set; }
    public string Course_Name { get; set; }
    public int Grades { get; set; }
    public StudentTable Student { get; set; }
}
