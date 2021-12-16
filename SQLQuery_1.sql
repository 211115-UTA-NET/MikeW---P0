--Tables for P0

Create TABLE Inventory
(
    ItemName VARCHAR (50) PRIMARY KEY,
    Quantity INT NOT NULL,
);

CREATE TABLE StoreLocation
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
    CustomerID INT PRIMARY KEY,
    CurrentList VARCHAR (50) NOT NULL,
    PreviousList VARCHAR (50) NOT NULL, 
);