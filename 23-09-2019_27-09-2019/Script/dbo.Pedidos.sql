CREATE TABLE [dbo].[Pedidos] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Numero]           NVARCHAR (10) NOT NULL,
    [ClienteId]        INT           NOT NULL,
    [VALOR]            MONEY         DEFAULT ((0)) NOT NULL,
    [ATIVO]            BIT           DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT           DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT           DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME      DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME      DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pedidos_ToCLIENTES] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([Id])
);

