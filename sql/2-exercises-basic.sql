-- basic exercises (Chinook database)

-- 1. list all customers (full names, customer ID, and country) who are not in the US

SELECT FirstName + ' ' + LastName AS [Full Name], CustomerId, Country
FROM Customer
WHERE Country != 'USA'

-- 2. list all customers from brazil

SELECT *
FROM Customer
WHERE Country = 'Brazil'

-- 3. list all sales agents

SELECT *
FROM Employee
WHERE Title LIKE '%sales%agent'

-- 4. show a list of all countries in billing addresses on invoices.

SELECT DISTINCT BillingCountry
FROM Invoice

-- 5. how many invoices were there in 2009, and what was the sales total for that year?
--    (extra challenge: find the invoice count sales total for every year, using one query)

SELECT year(InvoiceDate), Count(*) AS [Number of Invoices], SUM(Total) AS [SalesTotal]
FROM Invoice
WHERE year(InvoiceDate) = 2009
GROUP BY year(InvoiceDate)


SELECT year(InvoiceDate) AS Year, Count(*) AS [Number of Invoices], SUM(Total) AS SalesTotal
FROM Invoice
GROUP BY year(InvoiceDate)



-- 6. how many line items were there for invoice #37?

SELECT InvoiceId, Count(*) AS [NumberofLineItems]
FROM InvoiceLine
WHERE InvoiceId = 37
GROUP BY InvoiceId

-- 7. how many invoices per country?
SELECT BillingCountry, Count(*) AS NumberOfInvoices 
FROM Invoice
GROUP BY BillingCountry
Order BY NumberOfInvoices DESC

-- 8. show total sales per country, ordered by highest sales first.
SELECT BillingCountry, SUM(Total) AS [SalesTotal]
FROM Invoice
GROUP BY BillingCountry
ORDER BY SalesTotal DESC, BillingCountry


