
# JobBoard full stack web application



```
ASP.NET 5.0 MVC | Entity Framework | Microsoft Identity | SQLServer

| As an unidentified user, you can browse through job offers and search for available jobs by keyword and type.

| As an identified user, you can update your personal information, submit job applications, and view the history of all your applications.

| As a company, you can post job openings, view who has applied, and delete jobs.

| As an administrator, you can approve pending job offers, add categories, and view the number of posted jobs and active users.


Applicants and companies can register, while the administrator account must be hardcoded directly into the database.

How to deploy the project in your local computer?

1. You need to have Visual Studio and ASP.NET 5.0 installed on your local machine.
2. Modify the connection string in the appsettings.json file.
3. Use the following two commands in your package manager: "migrate-database <nameOfMigration>" and "update-database". (This will create the tables)

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




