CREATE TABLE [dbo].[doctores] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]          NVARCHAR (20) NOT NULL,
    [Apellido]        NVARCHAR (20) NOT NULL,
    [NombreDeUsuario] NVARCHAR (10) NOT NULL,
    [Clave]           NVARCHAR (10) NOT NULL,
    [tipoDeDoc]       SMALLINT      NOT NULL,
    [numDeDoc]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[pacientes] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [nombre]          NVARCHAR (20) NOT NULL,
    [apellido]        NVARCHAR (20) NOT NULL,
    [nombreDeUsuario] NVARCHAR (10) NOT NULL,
    [clave]           NVARCHAR (10) NOT NULL,
    [tipoDeDoc]       SMALLINT      NOT NULL,
    [numDeDoc]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[medicaciones] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [nombre]    NVARCHAR (50) NOT NULL,
    [dosisEnMg] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[recetas] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [paciente]    INT           NOT NULL,
    [doctor]      INT           NOT NULL,
    [medicacion]  INT           NOT NULL,
    [frecuencia]  NVARCHAR (50) NULL,
    [comentarios] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([paciente]) REFERENCES [dbo].[pacientes] ([Id]),
    FOREIGN KEY ([doctor]) REFERENCES [dbo].[doctores] ([Id]),
    FOREIGN KEY ([medicacion]) REFERENCES [dbo].[medicaciones] ([Id])
);

CREATE TABLE [dbo].[turnos] (
    [Id]                  INT           IDENTITY (1, 1) NOT NULL,
    [paciente]            INT           NOT NULL,
    [doctor]              INT           NOT NULL,
    [horarioInicio]       DATETIME      NOT NULL,
    [tipoDeTurno]         INT           NOT NULL,
    [comentariosPaciente] NVARCHAR (50) NULL,
    [comentariosDoc]      NVARCHAR (50) NULL,
    [idEstado]            SMALLINT      DEFAULT ((0)) NOT NULL,
    [duracion]            INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([idEstado]) REFERENCES [dbo].[estadosTurnos] ([Id]),
    FOREIGN KEY ([tipoDeTurno]) REFERENCES [dbo].[tipoDeTurno] ([Id]),
    FOREIGN KEY ([paciente]) REFERENCES [dbo].[pacientes] ([Id]),
    FOREIGN KEY ([doctor]) REFERENCES [dbo].[doctores] ([Id])
);

CREATE TABLE [dbo].[estadosTurnos] (
    [Id]     SMALLINT     IDENTITY (0, 1) NOT NULL,
    [Estado] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[tipoDeTurno] (
    [Id]          INT          IDENTITY (0, 1) NOT NULL,
    [TipoDeTurno] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);