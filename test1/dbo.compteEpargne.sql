CREATE TABLE [dbo].[compteEpargne] (
    [IdC]      INT        IDENTITY (1, 1) NOT NULL,
    [Taux]     FLOAT (53) NOT NULL,
    [idClient] INT        NOT NULL,
    [solde]    MONEY      NOT NULL,
    [plafond]  MONEY      NOT NULL
    
);

