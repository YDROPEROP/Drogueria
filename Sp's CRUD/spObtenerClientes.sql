USE Drogueria;
GO
CREATE OR ALTER PROCEDURE dbo.spObtenerClientes
AS
    SET NOCOUNT ON;
    SELECT cli.*, ciu.Nombre AS Ciudad
    FROM dbo.Cliente AS cli
    JOIN dbo.Ciudad AS ciu ON cli.IdCiudad = ciu.Id;
GO