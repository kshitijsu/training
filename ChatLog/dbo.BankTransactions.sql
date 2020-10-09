CREATE TABLE [dbo].[BankTransactions] (
    [TransactionID] INT             IDENTITY (1, 1) NOT NULL,
    [AccountId]     INT             NOT NULL,
    [TransType]     VARCHAR (50)    NOT NULL,
    [TransDateTime] SMALLDATETIME   DEFAULT (getdate()) NOT NULL,
    [TransDesc]     VARCHAR(150) NULL,
    [Debit]         MONEY           DEFAULT ((0)) NOT NULL,
    [Credit]        MONEY           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    CONSTRAINT [FK_BankTransactions_ToAccounts] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Accounts] ([AccountId])
);

