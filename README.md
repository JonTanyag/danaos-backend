*TechStack*
- .NET 9
- EF Core 9 
- MSSQL 2022 - Running in Docker

Setup

``` bash
git clone <repository-url>
cd <repository-folder>
dotnet clean
dotnet build

dotnet run
```
API Endpoints
Student
``` bash
GET /api/Student: Retrieves a list of students.
POST /api/Student/create: Add new student.
```
To add new Student
Please use `POST /api/Student/create: Add new student.` with the following payload.

``` bash
{
  "name": "Jon Wick",
  "average": 88
}

```
Grades
``` bash
GET /api/Grade: Retrieves a list of students.
POST /api/Grade/create: Add grade to student.
```

To add Grade to a Student
Please use `POST /api/Grade/create: Add grade to student` with the following payload.

``` bash
{
  "studentId": 2,
  "courseId": 102,
  "courseName": "Math",
  "grades": 88
}
```
