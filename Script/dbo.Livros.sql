CREATE TABLE [dbo].[Livros] (
    [Id]               INT         NOT NULL,
    [Nome]             NCHAR (100) NULL,
    [Ativo]            BIT         NULL,
    [ UsuarioCriacao]  INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

