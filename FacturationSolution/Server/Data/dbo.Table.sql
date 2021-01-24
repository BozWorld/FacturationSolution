CREATE TABLE [dbo].Factures
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Client] NCHAR(10) NOT NULL, 
    [Emission] DATETIME NOT NULL, 
    [Reglementation] DATETIME NOT NULL, 
    [Numero] INT NOT NULL, 
    [MontantDu] INT NOT NULL, 
    [MontantsRegler] INT NOT NULL
)
