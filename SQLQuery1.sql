Create TABLE Inventory
(
    ItemName VARCHAR (50) PRIMARY KEY,
    Quantity INT NOT NULL,
	Price Decimal NOT NULL
);

CREATE TABLE Store
(
    [Location] VARCHAR(30) NOT NULL,
	ItemName VARCHAR(50) Primary KEY,
	Quantity INT NOT NULL,
	Price MONEY NOT NULL,
);

CREATE TABLE Customers
(
    FirstName VARCHAR (20)Primary KEY,
    LastName VARCHAR (20) NOT NULL
);

CREATE TABLE Orders
(
   StoreLocation VARCHAR(30),
   CustomerId INT PRIMARY KEY,
   OrderDate DATETIME2,
   ItemName VARCHAR(50) FOREIGN KEY REFERENCES Store(ItemName)
);

INSERT Store ([Location], ItemName, Quantity, Price) 
Values 
('Milwaukee, WI', 'Apples', 50, 0.50),
('Milwaukee, WI', 'Bananas', 50, 0.50),
('Milwaukee, WI', 'Bread', 25, 2.00),
('Milwaukee, WI', 'Milk', 25, 2.00),
('Milwaukee, WI', 'Chicken pieces', 25, 3.00),
('Milwaukee, WI', 'Potato Chips', 15, 2.15),
('Milwaukee, WI', 'Pizza', 20, 3.25),
('Milwaukee, WI', 'Chocolate Chip Cookies', 50, 1.00);


INSERT Customers (FirstName, LastName)
VALUES
('Bobby', 'Hill'),
('Christian', 'Yelich'),
('Giannis', 'Antetokounmpo');


