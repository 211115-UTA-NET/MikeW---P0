# MikeW---P0
Project 0
# project 0: store application
Nov 15 2021 Arlington .NET / Richard Hawkins, Nick Escalona

## functionality
* interactive console application - DONE
* place orders to store locations for customers - Done
* add a new customer - Done
* search customers by name - Done
* display details of an order
* display all order history of a store location
* display all order history of a customer
* input validation - Done
* exception handling - Done
* persistent data (no prices, customers, order history, etc. hardcoded in C#) - DONE
* (optional: order history can be sorted by earliest, latest, cheapest, most expensive, etc.)
* (optional: get a suggested order for a customer based on his order history)
* (optional: display some statistics based on order history)
* (optional: asynchronous network & file I/O)

## design
* don't use public fields- DONE
* define and use at least one interface
* documentation with `<summary>` XML comments on all public types and members (optional: `<params>` and `<return>`)

#### customer - DONE!
* has first name, last name, etc.
* (optional: has a default store location to order from)

#### order
* has a store location - Done
* has a customer - Done
* has an order time (when the order was placed) -Done
* can contain multiple kinds of product in the same order - Done
* rejects orders with unreasonably high product quantities 
* (optional: some additional business rules, like special deals)

#### location
* has an inventory - Done
* inventory decreases when orders are accepted
* rejects orders that cannot be fulfilled with remaining inventory
* (optional: for at least one product, more than one inventory item decrements when ordering that product)

### test
* at least 10 test methods
* focus on unit testing business logic; testing the console-app-specific parts is low priority
