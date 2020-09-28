CREATE TABLE [dbo].[Projects] (
    [Id]                             UNIQUEIDENTIFIER NOT NULL,
    [Name]                           NVARCHAR (500)   NOT NULL,
    [CompanyOwner]                   NCHAR (500)      NOT NULL,
    [CompanyContractor]              NCHAR (500)      NULL,
    [CompanyOwnerContactPerson]      NCHAR (500)      NULL,
    [CompanyContractorContactPerson] NCHAR (500)      NULL,
    [StartDate]                      DATETIME2 (7)    NOT NULL,
    [FinishDate]                     DATETIME2 (7)    NOT NULL,
    [Priority]                       INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

