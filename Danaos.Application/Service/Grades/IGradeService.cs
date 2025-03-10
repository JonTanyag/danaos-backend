using System;

namespace Danaos.Application.Service.Grades;

public interface IGradeService
{
    Task CreateGrade(GradeDto grade);
}
