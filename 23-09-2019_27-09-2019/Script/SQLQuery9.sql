CREATE TABLE [dbo].[FUNCIONARIO]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] NVARCHAR(30) NULL, 
    [Valor] MONEY NULL DEFAULT 0, 
    [UsuarioCriacao] NVARCHAR(30) NULL DEFAULT 1, 
    [UsuarioAlteracao] NVARCHAR(30) NULL DEFAULT 1, 
    [Datacriacao] DATETIME NULL DEFAULT GetDate(), 
    [DataAlteracao] DATETIME NULL DEFAULT GetDate(), 
    [Ativo] BIT NULL, 
    [DataInicio] DATETIME NULL DEFAULT '10/07/2001', 
    [DataSaida] DATETIME NULL DEFAULT GetDate()
)
