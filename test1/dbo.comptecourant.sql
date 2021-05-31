CREATE TABLE [dbo].[comptecourant] (
    [IdC]       INT   IDENTITY (1, 1) NOT NULL,
    [decouvert] MONEY NOT NULL,
    [idClient]  INT   NOT NULL,
    [solde]     MONEY NOT NULL,
    [plafond]   MONEY NOT NULL
    
);

