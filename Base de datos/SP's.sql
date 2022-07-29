-- SP's para login

create procedure spLoginDoctores(
	@nombreDeUsuario nvarchar(10),
	@clave nvarchar(10)
)
as
begin

	if exists(select * from doctores where nombreDeUsuario = @nombreDeUsuario AND clave = @clave)
		select Id from doctores where nombreDeUsuario = @nombreDeUsuario AND clave = @clave
	else 
		select 0
end

create procedure spLoginPacientes(
	@nombreDeUsuario nvarchar(10),
	@clave nvarchar(10)
)
as
begin

	if exists(select * from pacientes where nombreDeUsuario = @nombreDeUsuario AND clave = @clave)
		select Id from pacientes where nombreDeUsuario = @nombreDeUsuario AND clave = @clave
	else 
		select 0
end
-- </ SP's para login

-- SP큦 De crear registros

create procedure NuevoDoctor(
	@nombre nvarchar(20),
	@apellido nvarchar(20),
	@nombreDeUsuario nvarchar(10),
	@clave nvarchar(10),
	@tipoDeDoc int,
	@numDeDoc int
)
as
begin
	insert into doctores
	(nombre, apellido, nombreDeUsuario, clave, tipoDeDoc, numDeDoc)
	values(@nombre, @apellido, @nombreDeUsuario, @clave, @tipoDeDoc, @numDeDoc)
end

create procedure NuevoPaciente(
	@nombre nvarchar(20),
	@apellido nvarchar(20),
	@nombreDeUsuario nvarchar(10),
	@clave nvarchar(10),
	@tipoDeDoc int,
	@numDeDoc int
)
as
begin
	insert into pacientes
	(nombre, apellido, nombreDeUsuario, clave, tipoDeDoc, numDeDoc)
	values(@nombre, @apellido, @nombreDeUsuario, @clave, @tipoDeDoc, @numDeDoc)
end

create procedure NuevoTurno(
	@paciente int,
	@doctor int,
	@horarioInicio datetime,
	@duracion int,
	@tipoDeTurno int,
	@comentariosPaciente nvarchar(50),
	@comentariosDoc nvarchar(50)
)
as
begin
	insert into turnos
	(paciente, doctor, horarioInicio, duracion, tipoDeTurno, comentariosPaciente, comentariosDoc, idEstado)
	values(@paciente, @doctor, @horarioInicio, @duracion, @tipoDeTurno, @comentariosPaciente, @comentariosDoc, 0)
end

create procedure NuevaReceta(
	@paciente int,
	@doctor int,
	@medicacion int,
	@frecuencia nvarchar(50),
	@comentarios nvarchar(50)
)
as
begin
	insert into recetas
	(paciente, doctor, medicacion, frecuencia, comentarios)
	values(@paciente, @doctor, @medicacion, @frecuencia, @comentarios)
end

create procedure NuevaMedicacion(
	@nombre nvarchar(50),
	@dosisEnMg int
)
as
begin
	insert into medicaciones
	(nombre, dosisEnMg)
	values(@nombre, @dosisEnMg)
end

-- </ SP큦 De crear registros

-- SP큦 De llevar datos

create procedure spMisTurnosPaciente(@IdPaciente int)
as
begin
	select 
	[Id]
	  ,[Nombre]
      ,[Apellido]
      ,[Horario]
      ,[Duracion]
      ,[Tipo de Turno]
      ,[Estado del turno]
      ,[Comentarios]
      ,[Comentarios del paciente]
	from [BD-ProyectoDoctores].[dbo].[MisTurnosPaciente]
	where IdPaciente = @IdPaciente
end

create procedure spMisTurnosDoctor(@IdDoctor int)
as
begin
	select 
	[Id]
	  ,[Nombre]
      ,[Apellido]
      ,[Horario]
      ,[Duracion]
      ,[Tipo de Turno]
      ,[Estado del turno]
      ,[Comentarios]
      ,[Comentarios del paciente]
	from [BD-ProyectoDoctores].[dbo].[MisTurnosDoctor]
	where IdDoctor = @IdDoctor
end

create procedure spMisRecetasPaciente(@IdPaciente int)
as
begin
	select
	[Id]
	  ,[Nombre]
      ,[Apellido]
      ,[Medicacion]
      ,[Dosis (mg)]
      ,[Frecuencia]
      ,[Comentarios]
	from [BD-ProyectoDoctores].[dbo].[MisRecetasPaciente]
	where IdPaciente = @IdPaciente
end

create procedure spMisRecetasDoctor(@IdDoctor int)
as
begin
	select 
	[Id]
	  ,[Nombre]
      ,[Apellido]
      ,[Medicacion]
      ,[Dosis (mg)]
      ,[frecuencia]
      ,[comentarios]
	  from [BD-ProyectoDoctores].[dbo].[MisRecetasDoctor]
	  where [IdDoctor] = @IdDoctor
end

-- </ SP큦 De llevar datos

-- SP큦 De llevar datos para combo boxes
create procedure spTodasLasMedicaciones
as
begin
	select 
	Id, Nombre, dosisEnMg as [Dosis en mg]
	from medicaciones
end

create procedure spMiInfoDoctor(@Id int)
as
begin
	select * from doctores where Id = @Id
end

create procedure spMiInfoPaciente(@Id int)
as
begin
	select * from pacientes where Id = @Id
end

create procedure [dbo].[spPacientes]
as
begin
	select Id, CONCAT(nombre, ' ' , apellido) as Nombre
	from pacientes
end

create procedure [dbo].[spDoctores]
as
begin
	select Id, CONCAT(nombre, ' ' , apellido) as Nombre
	from doctores
end

create procedure [dbo].[spMedicaciones]
as
begin
	select Id, CONCAT(nombre, '/' , dosisEnMg) as NombreYDosis
	from medicaciones
end

create procedure [dbo].[spTiposDeTurnos]
as
begin
	select Id, TipoDeTurno
	from tipoDeTurno
end
-- </ SP큦 De llevar datos para combo boxes

-- SP's de modificar datos

create procedure EditarPaciente(
	@Id int,
	@nombre nvarchar(20),
	@apellido nvarchar(20),
	@nombreDeUsuario nvarchar(10),
	@clave nvarchar(10),
	@tipoDeDoc int,
	@numDeDoc int
)
as
begin
	update pacientes set
	nombre          = @nombre,
	apellido        = @apellido,
	nombreDeUsuario = @nombreDeUsuario,
	clave           = @clave,
	tipoDeDoc       = @tipoDeDoc,
	numDeDoc         = @numDeDoc
	where Id = @Id
end

create procedure EditarDoctor(
	@Id int,
	@nombre nvarchar(20),
	@apellido nvarchar(20),
	@nombreDeUsuario nvarchar(10),
	@clave nvarchar(10),
	@tipoDeDoc int,
	@numDeDoc int
)
as
begin
	update doctores set
	nombre          = @nombre,
	apellido        = @apellido,
	nombreDeUsuario = @nombreDeUsuario,
	clave           = @clave,
	tipoDeDoc       = @tipoDeDoc,
	numDeDoc         = @numDeDoc
	where Id = @Id
end

create procedure EditarTurno(
	@Id int,
	@comentariosDoc nvarchar(50),
	@aprobadoPorDoc bit
)
as
begin
	update turnos set
	comentariosDoc = @comentariosDoc,
	aprobadoPorDoc = @aprobadoPorDoc
	where Id = @Id
end

create procedure ActualizarTurnosPasados as
begin
	update turnos
	set idEstado = 3
	where turnos.horarioInicio < SYSDATETIME()
end

create procedure ActualizarMedicacion(
	@Id int,
	@nombre nvarchar(50),
	@dosisEnMg float
)
as
begin
	update medicaciones
	set nombre = @nombre, dosisEnMg = @dosisEnMg
	where Id = @Id
end
-- </ SP's de modificar datos

-- SP's de eliminar datos

create procedure EliminarMedicacion(
	@Id int
)
as
begin
	delete from medicaciones 
	where Id = @Id
end

create procedure EliminarReceta(
	@Id int
)
as
begin
	delete from recetas 
	where Id = @Id
end

create procedure EliminarDoctor(
	@Id int
)
as
begin
	delete from doctores 
	where Id = @Id

	delete from turnos
	where doctor = @Id

	delete from recetas
	where doctor = @Id
end

create procedure EliminarPaciente(
	@Id int
)
as
begin
	delete from pacientes 
	where Id = @Id

	delete from turnos
	where paciente = @Id

	delete from recetas
	where paciente = @Id
end

-- </ SP's de eliminar datos
