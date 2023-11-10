USE Drogueria;
GO
CREATE OR ALTER PROCEDURE dbo.spEliminarCliente
    @IdCliente INT
AS
    SET NOCOUNT ON;
    DELETE dbo.Cliente
    WHERE Id = @IdCliente;
GO