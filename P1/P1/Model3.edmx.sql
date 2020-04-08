
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/08/2020 13:09:43
-- Generated from EDMX file: C:\Users\EliteBook\source\repos\P1\P1\Model3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProiectTSP2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Detaliis'
CREATE TABLE [dbo].[Detaliis] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NULL,
    [Eveniment] nvarchar(max)  NULL,
    [Persoane] nvarchar(max)  NULL,
    [Data] datetime  NULL,
    [Peisaje] nvarchar(max)  NULL,
    [Locatie] nvarchar(max)  NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Extras'
CREATE TABLE [dbo].[Extras] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(max)  NOT NULL,
    [Valoare] nvarchar(max)  NOT NULL,
    [DetaliiId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Detaliis'
ALTER TABLE [dbo].[Detaliis]
ADD CONSTRAINT [PK_Detaliis]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Extras'
ALTER TABLE [dbo].[Extras]
ADD CONSTRAINT [PK_Extras]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DetaliiId] in table 'Extras'
ALTER TABLE [dbo].[Extras]
ADD CONSTRAINT [FK_DetaliiExtras]
    FOREIGN KEY ([DetaliiId])
    REFERENCES [dbo].[Detaliis]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliiExtras'
CREATE INDEX [IX_FK_DetaliiExtras]
ON [dbo].[Extras]
    ([DetaliiId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------