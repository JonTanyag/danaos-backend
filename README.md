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
Grades
``` bash
GET /api/Grade: Retrieves a list of students.
POST /api/Grade/create: Add grade to student.
```
