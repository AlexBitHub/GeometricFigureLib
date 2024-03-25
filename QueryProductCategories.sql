CREATE TABLE Products 
(
	Id INT PRIMARY KEY,
	Name TEXT,
  	CategoryId INT NULL
);

CREATE TABLE Categories 
(
	Id INT PRIMARY KEY,
	Name TEXT
);

SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN Categories ON Products.CategoryId=Categories.Id;