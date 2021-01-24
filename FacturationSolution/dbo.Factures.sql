CREATE TABLE [dbo].[Factures] (
    [Id]             INT        IDENTITY (1, 1) NOT NULL,
    [Client]         NCHAR (10) NOT NULL,
    [Emission]       DATETIME   NOT NULL,
    [Reglementation] DATETIME   NOT NULL,
    [Numero]         INT        NOT NULL,
    [MontantDu]      INT        NOT NULL,
    [MontantsRegler] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
