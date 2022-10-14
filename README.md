# ExperisAPI

Cambiar la cadena de conexion en ```appsettings.json```

```
"ConnectionStrings": {
    "Conexion": "Server=.;Database=Experis;User Id=sa;Password=Password1234;Connection Timeout=30;"
  }
```

SCRIPT SQL

```
CREATE DATABASE Experis
GO
USE Experis
GO
CREATE TABLE Product
(
    Id int NOT NULL PRIMARY KEY,
    Name varchar(255) NOT NULL,
    Price decimal(10, 2) NOT NULL,
    Stock int NOT NULL,
    Registrationdate Date NOT NULL
);
GO
CREATE PROCEDURE GetAllProduct
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM Product
    SET NOCOUNT OFF;
END
GO
CREATE PROCEDURE GetByIdProduct @Id int
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM Product
    WHERE Id = @Id
    SET NOCOUNT OFF;
END
GO
CREATE PROCEDURE CreateProduct
    @Id int,
    @Name varchar(255),
    @Price decimal(10, 2),
    @Stock int,
    @Registrationdate Date
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Product
    (
        Id,
        Name,
        Price,
        Stock,
        Registrationdate
    )
    VALUES
    (@Id, @Name, @Price, @Stock, @Registrationdate)
    SET NOCOUNT OFF;
END
GO
CREATE PROCEDURE UpdateProduct
    @Id int,
    @Name varchar(255),
    @Price decimal(10, 2),
    @Stock int,
    @Registrationdate Date
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Product
    SET Name = @Name,
        Price = @Price,
        Stock = @Stock,
        Registrationdate = @Registrationdate
    WHERE Id = @Id
    SET NOCOUNT OFF;
END
GO
CREATE PROCEDURE DeleteProduct @Id int
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Product
    WHERE Id = @id
    SET NOCOUNT OFF;
END
```
Docker compose para levantar SQL Server 2022 
```
version: '3.4'

services:
  sqlserver2022:
    image: mcr.microsoft.com/mssql/server:2022-latest
    ports:
       - 1433:1433
    environment:
      - SA_PASSWORD=Password1234
      - ACCEPT_EULA=Y
    networks:
      - backend
networks:
  backend:
    name: backend
    driver: bridge
```
