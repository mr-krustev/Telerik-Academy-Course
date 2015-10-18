## Structured Query Language (SQL)
### _Homework_

1.	What is SQL? What is DML? What is DDL? Recite the most important SQL commands.
	* SQL means Structured Query Language - used for reaching out to databases's information.
	* DML - Data Manipulation Language (SELECT, INSERT, UPDATE, DELETE) - used for modifying/selecting information in tables
	* DDL - Data Definition Language - CREATE, DROP, ALTER, GRANT, REVOKE - used for creating/modifying tables.

1.	What is Transact-SQL (T-SQL)?
	* An extension to the base SQL language used by Microsoft's SQL Server
	* Supports if statements, loops, exceptions
	* T-SQL is used for writing stored procedures, functions, triggers, etc.

1.	Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.
	* There are 5 main tables: Departments, Employees, EmployeesProject(many-to-many), Projects, Towns

1.	Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
	
````
	USE TelerikAcademy

	SELECT *
	FROM Departments
````

1.	Write a SQL query to find all department names.
	
````
	USE TelerikAcademy

	SELECT D.Name
	FROM Departments D
````

1.	Write a SQL query to find the salary of each employee.

````
	USE TelerikAcademy

	SELECT E.Salary
  	FROM Employees E
````

1.	Write a SQL to find the full name of each employee.

````
	USE TelerikAcademy

	SELECT FirstName + ' ' + LastName AS FullName
  	FROM Employees E
````

1.	Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

````
	USE TelerikAcademy

	SELECT FirstName + '.' + LastName + '@telerik.com' AS "Full Email Addresses"
  	FROM Employees E
````

1.	Write a SQL query to find all different employee salaries.

````
	USE TelerikAcademy

	SELECT DISTINCT E.Salary
  	FROM Employees E
````
  

1.	Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

````
	USE TelerikAcademy

	SELECT *
	FROM Employees E
	WHERE E.JobTitle = 'Sales Representative'
````
  
1.	Write a SQL query to find the names of all employees whose first name starts with "SA".

````
	USE TelerikAcademy

	SELECT E.FirstName + ' ' + E.LastName
	FROM Employees E
	WHERE (E.FirstName LIKE 'SA%');
````
  

1.	Write a SQL query to find the names of all employees whose last name contains "ei".

````
	USE TelerikAcademy

	SELECT E.FirstName + ' ' + E.LastName
	FROM Employees E
	WHERE (E.LastName LIKE '%ei%');
````

1.	Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

````
	USE TelerikAcademy

	SELECT E.Salary
	FROM Employees E
	WHERE E.Salary BETWEEN 20000 AND 30000
````

1.	Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

````
	USE TelerikAcademy

	SELECT E.FirstName + ' ' + E.LastName
	FROM Employees E
	WHERE E.Salary IN (25000, 14000, 12500 , 23600)
````

1.	Write a SQL query to find all employees that do not have manager.

````
	USE TelerikAcademy

	SELECT E.FirstName + ' ' + E.LastName
	FROM Employees E
	WHERE E.ManagerID IS NULL
````

1.	Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

````
	USE TelerikAcademy

	SELECT *
	FROM Employees E
	WHERE E.Salary > 50000
	ORDER BY E.Salary DESC
````
1.	Write a SQL query to find the top 5 best paid employees.

````
	USE TelerikAcademy

	SELECT TOP 5 *
  	FROM Employees E
  	ORDER BY E.Salary DESC
````

1.	Write a SQL query to find all employees along with their address. Use inner join with `ON` clause.

````
	USE TelerikAcademy

	SELECT *
	FROM Employees E
	INNER JOIN Addresses A
	ON E.AddressID = A.AddressID
````

1.	Write a SQL query to find all employees and their address. Use equijoins (conditions in the `WHERE` clause).

````
	USE TelerikAcademy

	SELECT E.FirstName, E.LastName, A.AddressText
	FROM Employees E
	INNER JOIN Addresses A
	ON E.AddressID = A.AddressID
````

1.	Write a SQL query to find all employees along with their manager.

````
	USE TelerikAcademy

	SELECT *
	FROM Employees E
	LEFT OUTER JOIN Employees M
	ON E.ManagerID = M.EmployeeID
````

1.	Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: `Employees e`, `Employees m` and `Addresses a`.

````
	USE TelerikAcademy

	SELECT E.FirstName + ' ' + E.LastName AS EmployeeName,
	A.AddressText AS Adress,
	M.FirstName + ' ' + M.LastName AS ManagerName,
	AM.AddressText AS ManagerAdress
	FROM Employees E
	LEFT OUTER JOIN Employees M
	ON E.ManagerID = M.EmployeeID
	INNER JOIN Addresses A
	ON E.AddressID = A.AddressID
	INNER JOIN Addresses AM
	ON M.AddressID = AM.AddressID
````

1.	Write a SQL query to find all departments and all town names as a single list. Use `UNION`.

````
	USE TelerikAcademy

	SELECT D.Name
	FROM Departments D
	UNION
	SELECT T.Name
	FROM Towns T
````

1.	Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

````
	USE TelerikAcademy

	SELECT E.FirstName + ' ' + E.LastName AS FullName,
	M.FirstName + ' ' + M.LastName AS ManagerName
	FROM Employees E
	RIGHT OUTER JOIN Employees M
	ON E.ManagerID = M.EmployeeID
````

````
	USE TelerikAcademy

	SELECT E.FirstName + ' ' + E.LastName AS FullName,
	M.FirstName + ' ' + M.LastName AS ManagerName
	FROM Employees E
	LEFT OUTER JOIN Employees M
	ON E.ManagerID = M.EmployeeID
````

1.	Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

````
	USE TelerikAcademy

	SELECT E.FirstName, E.LastName, E.HireDate, D.Name
 	 FROM Employees E
  	INNER JOIN Departments D
  	ON E.DepartmentID = D.DepartmentID
  	WHERE D.Name = 'Sales' OR D.Name = 'Finance' AND E.HireDate BETWEEN 1995 AND 2005
````