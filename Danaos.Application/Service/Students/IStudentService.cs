using System;

namespace Danaos.Application.Service.Students;

public interface IStudentService
{
    Task CreateStudent(StudentDto student);
    Task<IEnumerable<StudentDto>> GetStudents();
}
