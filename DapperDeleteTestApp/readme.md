# About

Code sample which shows how to test deleting records followed by restoring the table. The reason for this is to test deleting records and then revert to the table’s original state. This really should be done in a test method but there are several test harnesses out there and did not want to exclude readers because I picked one test harness over another.

Before running, create the database and populate with the script provided followed by inspecting the server used in appsettings.json which is currently set to SQLEXPRESS.

## Step 1

Wrote the SQL in SSMS (SQL-Server Management Studio) with a backup of the database.

```sql
DROP TABLE IF EXISTS [dbo].ProductBackup;

--- create back-up
SELECT Id,
       ProductName,
       Category,
       Price
INTO dbo.ProductBackup
FROM dbo.Product;

--- keys to remove
DECLARE @IDs TABLE(ID INT);
INSERT INTO @IDs VALUES(1),(3),(5), (7);

--- delete some records
DELETE FROM dbo.Product
WHERE Id IN(SELECT ID FROM @IDs);

--- show results
SELECT Id,
       ProductName,
       Category,
       Price
FROM Bogus1.dbo.Product;

DELETE FROM dbo.Product;

--- reseed so first insert starts with 1
DBCC CHECKIDENT('product', RESEED, 0);

--- copy back-up to original table
INSERT INTO dbo.Product
(
    ProductName,
    Category,
    Price
)
SELECT ProductName,
       Category,
       Price
FROM dbo.ProductBackup;

SELECT Id,
       ProductName,
       Category,
       Price
FROM Bogus1.dbo.Product;
```

## Step 2

Create methods using Dapper.