USE Drogueria;
GO
CREATE OR ALTER PROCEDURE dbo.spActualizarCliente
    @IdCliente INT,
    @Identificacion VARCHAR(50),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @IdCiudad INT
AS
    SET NOCOUNT ON;
    UPDATE dbo.Cliente
    SET Identificacion = @Identificacion, Nombre = @Nombre, Apellido = @Apellido, IdCiudad = @IdCiudad
    WHERE Id = @IdCliente;
GO