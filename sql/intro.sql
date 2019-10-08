-- basics of SQL

-- SQL is declarative - we say what we want, not how to implement that
-- we don't specify exactly how SQL Server will iterate through the data, check caches, etc.

-- with SQL we send commands / queries to a database

-- DML, Data Manipulation Language
-- all operations on indivdual rows
-- SELECT is for read access (no modification)

-- DDL, Data Definition Language
-- all operations on whole table, table structure, most all
-- other objects in the DB like functions, procedures, triggers, etc.

-- DCL, Data Control Language
-- database administration, allow users to have different permisions

SELECT 1;
SELECT 1;

SELECT 2 + 3;
SELECT 'str1' + ' ' + CONVERT(varchar, 2 + 3);
-- the semicolons aren't required
-- single quotes for string literals

SELECT *
FROM Employee

SELECT FirstName, LastName
FROM Employee

SELECT *
FROM Employee
WHERE LEN(FirstName) <= 5

SELECT *
FROM Employee
WHERE FirstName = 'steve' AND LastName = 'johnson'

SELECT 
	FirstName + ' ' + LastName AS [Full Name], 
	LEN(FirstName + ' ' + LastName) AS [Length]
FROM Employee