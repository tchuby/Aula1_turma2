CREATE DATABASE BaseSistemaLocacao -- Criamos nossa base de dados
GO
USE BaseSistemaLocacao -- Indicamosque a estamos usando para os comandos logo abaixo.
GO
/*Criação da nossa primeira tabela ddo banco de dados*/
CREATE TABLE [dbo].[Usuarios] (
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NULL,
    [Login]            NCHAR (50)  NULL,
    [Senha]            NCHAR (50)  NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO --Aqui definimos que vamos criar novas tabelas.

CREATE TABLE [dbo].[Marcas] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [dbo].[Locacoes] (
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId ]       INT      NOT NULL,
    [CarroId]          INT      NOT NULL,
    [Valor]            MONEY    NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DataDeDevolucao]  DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [dbo].[Carros] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Modelo]           NCHAR (50) NULL,
    [MarcaCodigo]           INT NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ano]              INT        NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
insert into Usuarios ([Nome], [Login], [Senha]) values ('Administrador', 'Admin', 'Admin')
insert into Marcas ([Codigo], [Nome]) values (1,'VolksWagen'), (2, 'Chevrolet')