using System;
using Danaos.Domain.Domain.Grades;
using Danaos.Infrastructure;

namespace Danaos.Application.Service.Grades;

public class GradeService : IGradeService
{
    private readonly SchoolDbContext _dbContext;
    public GradeService(SchoolDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task CreateGrade(GradeDto grade)
    {
        // We need to map GradeDto to Grade entity
        // so that EF can save the data
        var gradeEntity = new Grade
        {
            Student_Id = grade.StudentId,
            Course_Id = grade.CourseId,
            Course_Name = grade.CourseName,
            Grades = grade.Grades
        };

        _dbContext.Grades.Add(gradeEntity);
        await _dbContext.SaveChangesAsync();
    }

}
