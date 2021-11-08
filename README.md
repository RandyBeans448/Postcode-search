# Postcode-search

You will need to install the .NET framework and Node.js onto your local machine for this project to work.

.Net download link - https://dotnet.microsoft.com/download/dotnet-framework

Node.js download link - https://nodejs.org/en/

Once .NET is installed navigate to the backend folder and run the command `dotnet build`.
Then run the command `dotnet run`.
This will start the backend server on http://localhost:5000/postcode.

Once Node.js is installed naviagte to the frontend folder and run the command 'npm install'.
Then run the command `npm start`.
This will start the server on http://localhost:3000.

The database is already filled but just in case I have included the sql query to fill the database, see below.

SQL data query 

INSERT INTO Products
(Postcode, WarehouseLocation)
VALUES ('ME10', 'Collect from Kitchen'),
('TN9 1AP', 'No Deliveries'),
('ME10 3HH', 'Collect from Kitchen, Delivery from
Sittingbourne'),
('ME9 1AA','No Deliveries'),
('W1N 4DJ','Delivery by Courier'),
('TN9 1AB', 'Delivery from Warehouse'),
('TN15 5AB', 'Collect from Sevenoaks'),
('TN1 2QP', 'TVan Delivery, Collect from Tunbridge Wells' )

