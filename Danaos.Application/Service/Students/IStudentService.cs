using System;

namespace Danaos.Application.Service.Students;

public interface IStudentService
{
    Task CreateStudent(StudentDto student);
    Task<IEnumerable<StudentDto>> GetStudents();
    Task<StudentDto> GetStudentById(int id);
    Task UpdateStudent(StudentDto student);
    Task DeleteStudent(int id);
}
