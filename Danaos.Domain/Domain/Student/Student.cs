using System;
using Danaos.Domain.Domain.Grades;

namespace Danaos.Domain.Domain.Student;

public class Student
{
    /// <summary>
    /// Primary key
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Student Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Mapping to Grades table
    /// Determine 1-to-many relationship
    /// </summary>
    public ICollection<Grade> Grades { get; set; }
}
