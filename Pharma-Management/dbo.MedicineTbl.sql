CREATE TABLE [dbo].[MedicineTbl] (
	[MedID]			INT			NOT NULL,
    [MedName]      VARCHAR (50) NOT NULL,
    [BuyingPrice]  INT          NOT NULL,
    [SellingPrice] INT          NOT NULL,
    [MedQty]       INT          NOT NULL,
    [ExpDate]      VARCHAR (50) NOT NULL,
    [Company]      VARCHAR (50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([MedID] ASC)
);

