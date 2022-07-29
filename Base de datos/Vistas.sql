CREATE VIEW [dbo].MisRecetasDoctor
	AS
    SELECT
    r.Id,
    p.nombre,
    p.apellido,
    m.nombre AS Medicacion,
    m.dosisEnMg AS [Dosis (mg)],
    r.frecuencia, dbo.recetas.comentarios,
    r.doctor AS IdDoctor

    FROM   dbo.recetas AS r

    INNER JOIN dbo.pacientes AS p
    ON dbo.recetas.paciente = dbo.pacientes.Id

    INNER JOIN dbo.medicaciones AS m
    on dbo.recetas.medicacion = dbo.medicaciones.Id

CREATE VIEW [dbo].MisRecetasPaciente
    AS
    SELECT
    r.Id,
    d.Nombre,
    d.Apellido,
    m.nombre AS Medicacion,
    m.dosisEnMg AS [Dosis (mg)],
    r.frecuencia,
    r.comentarios,
    r.paciente AS IdPaciente

    FROM   dbo.recetas AS r

    INNER JOIN dbo.doctores AS d
    ON dbo.recetas.doctor = dbo.doctores.Id

    INNER JOIN dbo.medicaciones AS m
    ON dbo.recetas.medicacion = dbo.medicaciones.Id

CREATE VIEW [dbo].MisTurnosDoctor
    AS
    SELECT 
    t.Id,
    p.nombre,
    p.apellido,
    t.horarioInicio AS Horario,
    t.duracion, tipo.TipoDeTurno AS [Tipo de Turno],
    e.Estado AS [Estado del turno],
    t.comentariosDoc AS Comentarios,
    t.comentariosPaciente AS [Comentarios del paciente],
    t.doctor AS IdDoctor

    FROM   dbo.turnos AS t

    INNER JOIN dbo.pacientes AS p
    ON t.paciente = p.Id
    
    INNER JOIN dbo.tipoDeTurno AS tipo
    ON t.tipoDeTurno = tipo.Id
    
    INNER JOIN dbo.estadosTurnos AS e
    ON t.idEstado = e.Id

CREATE VIEW [dbo].MisTurnosPaciente
    AS
    SELECT
    t.Id,
    d.Nombre,
    d.Apellido,
    t.horarioInicio AS Horario,
    t.duracion,
    tipo.TipoDeTurno AS [Tipo de Turno],
    e.Estado AS [Estado del turno],
    t.comentariosDoc AS Comentarios,
    t.comentariosPaciente AS [Comentarios del paciente],
    t.paciente AS IdPaciente

    FROM   dbo.turnos AS t
    
    INNER JOIN dbo.doctores AS d
    ON t.doctor = d.Id
    
    INNER JOIN dbo.tipoDeTurno AS tipo
    ON t.tipoDeTurno = tipo.Id
    
    INNER JOIN dbo.estadosTurnos AS e
    ON t.idEstado = e.Id