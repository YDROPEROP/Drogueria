-- CREATE TABLE Ciudad (
--     Id INT IDENTITY PRIMARY KEY,
--     Nombre VARCHAR(255) NOT NULL
-- );

-- CREATE TABLE Cliente (
--     Id INT IDENTITY PRIMARY KEY,
--     Identificacion VARCHAR(255) NOT NULL,
--     Nombre VARCHAR(255) NOT NULL,
--     Apellido VARCHAR(255) NOT NULL,
--     IdCiudad INT FOREIGN KEY REFERENCES Ciudad(Id)
-- );

-- INSERT INTO dbo.Ciudad (Nombre) VALUES('Bogotá'), ('Tunja'), ('Yopal');
-- INSERT INTO dbo.Cliente (Identificacion, Nombre, Apellido, IdCiudad) VALUES('1040000000', 'Yiver', 'Doney', 1);

-- EXECUTE dbo.spObtenerClientes;
-- EXECUTE dbo.spObtenerClientePorIdentificacion N'1040000000';
-- EXECUTE dbo.spCrearCliente N'1050000000', N'Sandy', N'Rodriguez', 2;
-- EXECUTE dbo.spActualizarCliente 1, N'1040000000', N'Yiver', N'Ropero', 1;
-- EXECUTE dbo.spEliminarCliente 2;

