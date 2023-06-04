--Script creacion base de datos:

create database ProyectoNomina;

use ProyectoNomina;

--Creacion de la Tabla
CREATE TABLE Empleado(
Id INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(50),
Apellido NVARCHAR(50),
Edad INT,
Sexo CHAR(1),
FechaNacimiento DATE,
PoseeLicencia BIT,
SueldoBruto DECIMAL(18,2),
SueldoNeto DECIMAL(18,2),
TSS DECIMAL(18,2),
ISR DECIMAL(18,2)
);

GO
--Tabla de usuario
CREATE TABLE Usuario(
Id INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(50),
UserName NVARCHAR(50),
Clave NVARCHAR(50)
);

GO
--Procedimientos Almacenados para insertar un nuevo empleado
CREATE PROCEDURE InsertarEmpleado
@Nombre NVARCHAR(50),
@Apellido NVARCHAR(50),
@Edad INT,
@Sexo CHAR(1),
@FechaNacimiento DATE,
@PoseeLicencia BIT,
@SueldoBruto DECIMAL(18,2)
AS
BEGIN
INSERT INTO Empleado(Nombre,Apellido,Edad,Sexo,FechaNacimiento,PoseeLicencia,SueldoBruto)
VALUES(@Nombre,@Apellido,@Edad,@Sexo,@FechaNacimiento,@PoseeLicencia,@SueldoBruto)
END

GO
-- Procedimiento Para actualizar Empleado
CREATE PROCEDURE ActualizaEmpleado
@Id INT,
@Nombre NVARCHAR(50),
@Apellido NVARCHAR(50),
@Edad INT,
@Sexo CHAR(1),
@FechaNacimiento DATE,
@PoseeLicencia BIT,
@SueldoBruto DECIMAL(18,2)
AS
BEGIN
UPDATE Empleado
SET Nombre = @Nombre,
	Apellido = @Apellido,
	Edad = @Edad,
	Sexo = @Sexo,
	FechaNacimiento = @FechaNacimiento,
	PoseeLicencia = @PoseeLicencia,
	SueldoBruto = @SueldoBruto
WHERE Id = @Id
END

GO
--Procedimientos eliminar Empleado
CREATE PROCEDURE EliminarEmpleado
@Id INT
AS
BEGIN
DELETE FROM Empleado WHERE Id = @Id
END
GO
--Procedimientos para obtener todos los empleados
CREATE PROCEDURE ObtenerEmpleados
AS
BEGIN
SELECT * FROM Empleado
END


--Procedimientos para obtener los empleados que son mujeres.
CREATE PROCEDURE ObtenerEmpleadosMujeres
AS
BEGIN
SELECT * FROM Empleado WHERE Sexo = 'F'
END

--Procedimientos para obtener los empleados que poseen licencia.
CREATE PROCEDURE ObtenerEmpleadosConLicencia
AS
BEGIN
SELECT * FROM Empleado WHERE PoseeLicencia = 1
END

--Procedimientos para obtener los empleados con el sueldo mayor a $50,000
CREATE PROCEDURE ObtenerEmpleadosSalario50
AS
BEGIN
SELECT * FROM Empleado WHERE SueldoBruto >= 50000
END

GO
--Procedimiento para calcular la nomina
CREATE PROCEDURE CalcularNomina
@Id INT,
@ISR DECIMAL(18,2),
@TSS DECIMAL(18,2),
@SueldoNeto DECIMAL(18,2)
AS
BEGIN
UPDATE Empleado
SET ISR = @ISR,
	TSS = @TSS,
	SueldoNeto = @SueldoNeto
WHERE Id = @Id
END

GO
--Procedimiento para iniciar sesion.
CREATE or ALTER PROCEDURE IniciarSesion
@UserName NVARCHAR(50),
@Clave NVARCHAR(50)
AS
BEGIN
DECLARE @Valido BIT
IF EXISTS(SELECT * FROM Usuario WHERE UserName = @UserName AND Clave = @Clave)
	SET @Valido = 1
ELSE
	SET @Valido = 0

	SELECT @Valido as EsValido
END

GO
--Procedimiento para registrar un usuario
CREATE OR ALTER PROCEDURE RegistrarUsuario
@Nombre NVARCHAR(50),
@UserName NVARCHAR(50),
@Clave NVARCHAR(50)
AS
BEGIN
INSERT INTO Usuario(Nombre,UserName,Clave)
VALUES(@Nombre,@UserName,@Clave)
END
GO
CREATE OR ALTER PROCEDURE UsuarioCache
@Id INT
AS
BEGIN
SELECT Nombre,UserName FROM Usuario WHERE Id = @Id
END
GO