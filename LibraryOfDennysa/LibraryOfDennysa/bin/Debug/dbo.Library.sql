CREATE TABLE [dbo].[Library]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[titlu] VARCHAR(50) NOT NULL, 
	[autor] VARCHAR(50) NOT NULL,
	[editura] VARCHAR(50) NOT NULL,
	[domeniu] VARCHAR(50) NOT NULL,
	[anaparitie] DATE NOT NULL,
	[nrpag] INT NOT NULL

)
