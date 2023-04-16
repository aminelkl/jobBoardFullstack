
# JobBoard full stack web application



```
ASP.NET 5.0 MVC | Entity Framework | Microsoft Identity | SQLServer

| As an unidentified user, you can browse through job offers and search for available jobs by keyword and type.

| As an identified user, you can update your personal information, submit job applications, and view the history of all your applications.

| As a company, you can post job openings, view who has applied, and delete jobs.

| As an administrator, you can approve pending job offers, add categories, and view the number of posted jobs and active users.


Applicants and companies can register, while the administrator account must be hardcoded directly into the database.

How to hardcode an administrator directly in the database?

1. To add an admin to the user table, you will need to paste the hashed password
using Microsoft.AspNetCore.Identity;
var passwordHasher = new PasswordHasher<string>();
string password = "myPassword123";
string hashedPassword = passwordHasher.HashPassword(null, password);
Console.WriteLine(hashedPassword);

2. Add a security stamp.
UPDATE [dbo].[AspNetUsers]
SET [SecurityStamp] = NEWID()
WHERE [Id] = '666'
```

![Home](https://user-images.githubusercontent.com/96929412/232344928-f3eca6d6-b5bd-4793-8f8a-f50e93597381.PNG)
![Login](https://user-images.githubusercontent.com/96929412/232344932-a5c02573-cd0a-45e6-927e-91f43c76f961.PNG)
![Job](https://user-images.githubusercontent.com/96929412/232344936-100bf75c-327a-457c-89e6-5c34b5d41cda.PNG)



