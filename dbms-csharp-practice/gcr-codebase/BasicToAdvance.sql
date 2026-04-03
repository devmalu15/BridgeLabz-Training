--DDL--
--CREATE--
CREATE TABLE employees (empID INT PRIMARY KEY, empName VARCHAR(50));
CREATE TABLE dept (deptName VARCHAR(50));

--ALTER--
ALTER TABLE employees ADD deptID INT;

--DROP--
DROP TABLE Dept;

--TRUNCATE--
TRUNCATE TABLE dept;


--DML--
--INSERT--
INSERT INTO employees (empID, empName, deptID) VALUES (1, 'emp1', 1);

--SELECT--
SELECT * FROM employees;

--UPDATE--
UPDATE employees SET deptID = 100 WHERE empID = 1;

--DELETE--
DELETE FROM employees WHERE empID = 1;


--EXTRAS--
CREATE TABLE dept (deptID INT PRIMARY KEY, deptName VARCHAR(50), deptEmpCount INT);

INSERT INTO employees(empID, empName, deptID) VALUES (004, 'EMP4', 100), (005, 'EMP5', 101), (006, 'EMP6', 100);

INSERT INTO dept(deptID, deptName) VALUES (100, 'Finance'), (101, 'Management');

--JOINS--
--INNER JOIN--
SELECT * FROM employees INNER JOIN dept ON employees.deptID = dept.deptID;

--LEFT JOIN--
SELECT * FROM employees LEFT JOIN dept ON employees.deptID = dept.deptID;

--RIGHT JOIN--
SELECT * FROM employees RIGHT JOIN dept ON employees.deptID = dept.deptID;


--ADVANCED T-SQL--
CREATE PROCEDURE sp_GetEmployeeName @empID INT
AS
BEGIN
SELECT empName FROM employees WHERE empID = @empID;
END;

--EXECUTION--
EXEC sp_GetEmployeeName 001;


--User Defined Functions(UDFs)--
CREATE FUNCTION fn_PrintEmpID (@empID INT)
RETURNS INT
AS
BEGIN
RETURN empID * 2;
END;

--Usage--




--TRIGGERS--
CREATE TRIGGER trg_AuditLog
ON employees
AFTER INSERT
AS
BEGIN
SELECT d.empID FROM inserted d;
END;

