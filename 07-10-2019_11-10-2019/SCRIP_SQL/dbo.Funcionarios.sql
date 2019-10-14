CREATE TABLE [dbo].[Funcionarios] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Nome]             NVARCHAR (50) NOT NULL,
    [DataInicio]       DATETIME      NOT NULL,
    [DataSaida]        DATETIME      NULL,
    [Ativo]            BIT           DEFAULT ((1)) NOT NULL,
    [UsuarioCriacao]   INT           DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT           DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME      DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME      DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

