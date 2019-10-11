-- Set Operators (combine queries)
-- Union
--	gives you all rows that are found in both queries, without duplicates
-- Union ALL
--	gives all row found in either query, period, including duplicates
-- INTERSECT
--	all rows that are in both queries. (no duplicates)
-- EXCEPT
--	all rows that are in the first query but are not in the second query

-- to use any of them, the two queries must have the same number of columns

-- all first names of customer and employees
SELECT FirstName FROM Employee
UNION 
SELECT FirstName FROM Customer

Select FirstName FROM Employee
INTERSECT
SELECT FirstName FROM Customer