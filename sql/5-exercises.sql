-- exercises

-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?
Select Artist.* From Artist
	LEFT JOIN Album ON Artist.ArtistId = Album.ArtistId
Where Album.Title IS NULL


-- 2. which artists did not record any tracks of the Latin genre?

Select Name FROM Artist WHERE Name NOT IN (
	Select art.Name FROM Artist as art
	left JOIN Album as alb ON art.ArtistId = alb.ArtistId
	left JOIN Track as t ON alb.AlbumId = t.AlbumId
	right JOIN Genre as g ON g.GenreId = t.GenreId
	Where g.Name = 'Latin'
	)


-- 3. which video track has the longest length? (use media type table)
Select TOP 1 t.TrackId, t.Name, t.Milliseconds AS [Length] From Track AS t
	INNER JOIN MediaType as m ON m.MediaTypeId = t.MediaTypeId
Where m.Name LIKE '%video%'
Order by Length DESC

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

Select FirstName + ' ' + LastName as Name From Customer Where City IN (
Select City From Employee where Employee.ReportsTo Is Null
Intersect
Select City From Customer)

Select c.FirstName + ' ' + c.LastName as Name
From Employee as e, Customer as c
Where e.City = c.City AND e.ReportsTo Is Null


-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
Select Count(t.TrackId) as Count, Sum(il.UnitPrice) as TotalSales From Track as t
	INNER JOIN InvoiceLine as il ON t.TrackId = il.TrackId
	INNER JOIN Invoice as i ON il.InvoiceId = i.InvoiceId
	INNER JOIN Customer as c ON c.CustomerId = i.CustomerId
	where i.BillingCountry = 'Germany'




-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.
