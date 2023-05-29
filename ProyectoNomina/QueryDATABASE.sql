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


--Procedimientos eliminar Empleado
CREATE PROCEDURE EliminarEmpleado
@Id INT
AS
BEGIN
DELETE FROM Empleado WHERE Id = @Id
END

