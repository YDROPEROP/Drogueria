USE Drogueria;
GO
CREATE OR ALTER PROCEDURE dbo.spObtenerClientePorIdentificacion
    @Identificacion VARCHAR(50)
AS
    SET NOCOUNT ON;
    SELECT cli.*, ciu.Nombre AS Ciudad
    FROM dbo.Cliente AS cli
    JOIN dbo.Ciudad AS ciu ON cli.IdCiudad = ciu.Id
    WHERE cli.Identificacion = @Identificacion;
GO