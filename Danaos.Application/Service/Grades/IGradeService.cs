using System;

namespace Danaos.Application.Service.Grades;

public interface IGradeService
{
    Task CreateGrade(GradeDto grade);
    Task<IEnumerable<GradeDto>> GetStudentGrades(int studentId);
    Task UpdateGrade(GradeDto grade);
}
