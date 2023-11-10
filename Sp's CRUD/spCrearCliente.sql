USE Drogueria;
GO
CREATE OR ALTER PROCEDURE dbo.spCrearCliente
    @Identificacion VARCHAR(50),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @IdCiudad INT
AS
    SET NOCOUNT ON;
    INSERT INTO dbo.Cliente 
    (Identificacion, Nombre, Apellido, IdCiudad) 
    VALUES(@Identificacion, @Nombre, @Apellido, @IdCiudad);
GO