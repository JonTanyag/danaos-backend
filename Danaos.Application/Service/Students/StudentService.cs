using System;
using Danaos.Application.Service.Grades;
using Danaos.Domain.Domain.Student;
using Danaos.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Danaos.Application.Service.Students;

public class StudentService : IStudentService
{
    private readonly SchoolDbContext _context;
    public StudentService(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task CreateStudent(StudentDto student)
    {
        var studentEntity = new Student {
            Name = student.Name
        };

        _context.Students.Add(studentEntity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudent(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<StudentDto> GetStudentById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<StudentDto>> GetStudents()
    {
        var students = _context.Students
                        .Include(g => g.Grades)
                        .Select(s => new StudentDto
        {
            Name = s.Name,
            Average = s.Grades.Any()
                ? s.Grades.Average(g => g.Grades)
                : 0
        }).ToList();

        return students;
    }

    public Task UpdateStudent(StudentDto student)
    {
        throw new NotImplementedException();
    }
}
