CREATE TABLE [dbo].[Executors] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [Name]         NVARCHAR (500)   NOT NULL,
    [ExecutorType] NVARCHAR (500)   NULL,
    [ProjectId]    UNIQUEIDENTIFIER NULL,
    [TaskId]       UNIQUEIDENTIFIER NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);