                -------------------------
-------------- | 1. Create DB and Tables | --------------------------------------------------------------------------------------------------------------------
                -------------------------

CREATE DATABASE CompanyDB
GO

USE CompanyDB
GO

CREATE TABLE Employees
(
	EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Position VARCHAR(50),
	Department VARCHAR(50),
	Salary DECIMAL(10,2) NOT NULL,
	HireDate DATE
);
GO

CREATE TABLE Projects
(
	ProjectID INT IDENTITY(1,1) PRIMARY KEY,
	StartDate DATE,
	EndDate DATE
);
GO

CREATE TABLE EmployeeProjects
(
	EmployeeID INT,
	ProjectID INT,
	Role VARCHAR(50),

	CONSTRAINT PK_EmployeeProjects PRIMARY KEY (EmployeeID, ProjectID),
	CONSTRAINT FK_Employee FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_Project FOREIGN KEY(ProjectID) REFERENCES Projects(ProjectID)
);
GO

                --------------------
-------------- | 2. Data population | --------------------------------------------------------------------------------------------------------------------
                --------------------

INSERT INTO Employees(Name, Position, Department, Salary, HireDate)
VALUES
('Mihai Cibotaru', 'Accountant', 'Finance', 15000, '2016-01-01'),
('Alex Catana', 'Developer', 'IT', 20000, '2020-02-02'),
('Oleg Bolun', 'Developer', 'IT', 20000, '2019-03-03'),
('Alexandra Luca', 'Tester', 'IT', 18000, '2022-04-04'),
('Veronica Munteanu', 'Project Manager', 'IT', 35000, '2015-05-05'),
('Vlad Dante', 'Designer', 'Marketing', 20000, '2021-06-06'),
('Daniel Vilcu', 'Designer', 'Marketing', 20000, '2021-07-07'),
('Katerina Toma', 'Designer', 'Marketing', 15000, '2021-08-08')
GO

INSERT INTO Projects (StartDate, EndDate)
VALUES
('2020-01-02', '2020-04-02'),
('2024-02-13', '2024-06-15'),
('2024-03-04', '2024-08-30'),
('2022-04-15', '2022-10-10'),
('2022-05-06', '2022-12-05'),
('2023-08-08', '2024-04-15');
GO

INSERT INTO EmployeeProjects (EmployeeID, ProjectID, Role)
VALUES
(1, 1, 'Accountant'),
(2, 1, 'Developer'),
(3, 2, 'Developer'),
(4, 3, 'Tester'),
(5, 4, 'Project Manager'),
(6, 5, 'Designer'),
(7, 5, 'Designer'),
(2, 3, 'Developer'),
(3, 4, 'Developer'),
(4, 5, 'Tester');
GO

                ------------------
-------------- | 3. Interogations | --------------------------------------------------------------------------------------------------------------------
                ------------------

-- 1.
SELECT * FROM Employees
GO
-- 2.
SELECT * FROM Employees
WHERE Department = 'IT'
GO

-- 3.
SELECT * FROM Employees
ORDER BY HireDate ASC
GO

-- 4.
SELECT AVG(Salary) AS AverageSalary FROM Employees
GO

-- 5. 
SELECT e.Name, ep.ProjectID FROM Employees AS e
JOIN EmployeeProjects AS ep ON e.EmployeeID = ep.EmployeeID
GO

-- 6.
SELECT Department, SUM(Salary) AS TotalSalary FROM Employees 
GROUP BY Department
HAVING SUM(Salary) > 10000
GO

-- 7.
SELECT Name, Salary FROM Employees
WHERE Salary > (SELECT AVG(Salary) FROM Employees)

-- 8. 
SELECT e.Name, ep.Role, p.* FROM Employees AS e
JOIN EmployeeProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON p.ProjectID = ep.ProjectID
GO

-- 9.
SELECT e.Name FROM Employees AS e
LEFT JOIN EmployeeProjects AS ep ON ep.EmployeeID = e.EmployeeID
WHERE ep.EmployeeID IS NULL
GO