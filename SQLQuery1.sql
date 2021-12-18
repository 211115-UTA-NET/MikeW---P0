Create TABLE Inventory
(
    ItemName VARCHAR (50) PRIMARY KEY,
    Quantity INT NOT NULL,
	Price Decimal NOT NULL
);

CREATE TABLE Store
(
    CityName VARCHAR (20) PRIMARY KEY,
    StateName VARCHAR (20) NOT NULL,
);

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR (20) NOT NULL,
    LastName VARCHAR (20) NOT NULL,
    CityName VARCHAR (50) NOT NULL,
);

CREATE TABLE Orders
(
    CustomerID INT NOT NULL,
    CurrentList VARCHAR (50) NOT NULL,
    PreviousList VARCHAR (50) NOT NULL, 
);

INSERT Inventory (ItemName, Quantity, Price) 
Values 
('Apples', 50, 0.50),
('Bananas', 50, 0.50),
('Bread', 25, 2.00),
('Milk', 25, 2.00),
('Chicken pieces', 25, 3.00),
('Potato Chips', 15, 2.15),
('Pizza', 20, 3.25),
('Chocolate Chip Cookies', 50, 1.00);


INSERT Store (CityName, StateName)
VALUES
('Milwaukee', 'WI');

INSERT Customers (CustomerID, FirstName, LastName, CityName)
VALUES
(123, 'Bobby', 'Hill', 'Milwaukee'),
(456, 'Christian', 'Yelich', 'Milwaukee'),
(789, 'Giannis', 'Antetokounmpo', 'Milwaukee');

INSERT Orders (CustomerID, CurrentList, PreviousList)
Values
(123, ' ', ' '),
(456, ' ', ' '),
(789, '', ' ');