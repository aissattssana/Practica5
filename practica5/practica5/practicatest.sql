
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/04/2022 19:20:22
-- Generated from EDMX file: C:\Users\1\Desktop\stud\isrpo\practica5\practica5\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Practica];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Plant_Region]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Plant] DROP CONSTRAINT [FK_Plant_Region];
GO
IF OBJECT_ID(N'[dbo].[FK_Plant_ResponsiblePerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Plant] DROP CONSTRAINT [FK_Plant_ResponsiblePerson];
GO
IF OBJECT_ID(N'[dbo].[FK_PriceList_Plant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PriceList] DROP CONSTRAINT [FK_PriceList_Plant];
GO
IF OBJECT_ID(N'[dbo].[FK_PriceList_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PriceList] DROP CONSTRAINT [FK_PriceList_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_PriceList_ResponsiblePerson]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PriceList] DROP CONSTRAINT [FK_PriceList_ResponsiblePerson];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Plant]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Plant];
GO
IF OBJECT_ID(N'[dbo].[PriceList]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PriceList];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Region]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Region];
GO
IF OBJECT_ID(N'[dbo].[ResponsiblePerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResponsiblePerson];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Plant'
CREATE TABLE [dbo].[Plant] (
    [PlantID] int IDENTITY(1,1) NOT NULL,
    [PlantName] nvarchar(1000)  NOT NULL,
    [PlantAddress] nvarchar(1000)  NOT NULL,
    [PlantPhonenumber] nvarchar(20)  NOT NULL,
    [ResponsiblePersonID] int  NOT NULL,
    [RegionID] int  NOT NULL
);
GO

-- Creating table 'PriceList'
CREATE TABLE [dbo].[PriceList] (
    [PriceID] int IDENTITY(1,1) NOT NULL,
    [ProductID] int  NOT NULL,
    [PlantID] int  NOT NULL,
    [ResponsiblePersonID] int  NOT NULL,
    [Price] float  NOT NULL,
    [DateoOfChange] nvarchar(1000)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(1000)  NOT NULL,
    [ProductSort] nvarchar(1000)  NOT NULL,
    [ProductGroup] nvarchar(1000)  NOT NULL
);
GO

-- Creating table 'Region'
CREATE TABLE [dbo].[Region] (
    [RegionID] int IDENTITY(1,1) NOT NULL,
    [RegionName] nvarchar(100)  NOT NULL,
    [City] nchar(1000)  NOT NULL
);
GO

-- Creating table 'ResponsiblePerson'
CREATE TABLE [dbo].[ResponsiblePerson] (
    [ResponsiblePersonID] int IDENTITY(1,1) NOT NULL,
    [ResponsiblePersonName] nvarchar(1000)  NOT NULL,
    [ResponsiblePersonPost] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PlantID] in table 'Plant'
ALTER TABLE [dbo].[Plant]
ADD CONSTRAINT [PK_Plant]
    PRIMARY KEY CLUSTERED ([PlantID] ASC);
GO

-- Creating primary key on [PriceID] in table 'PriceList'
ALTER TABLE [dbo].[PriceList]
ADD CONSTRAINT [PK_PriceList]
    PRIMARY KEY CLUSTERED ([PriceID] ASC);
GO

-- Creating primary key on [ProductID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- Creating primary key on [RegionID] in table 'Region'
ALTER TABLE [dbo].[Region]
ADD CONSTRAINT [PK_Region]
    PRIMARY KEY CLUSTERED ([RegionID] ASC);
GO

-- Creating primary key on [ResponsiblePersonID] in table 'ResponsiblePerson'
ALTER TABLE [dbo].[ResponsiblePerson]
ADD CONSTRAINT [PK_ResponsiblePerson]
    PRIMARY KEY CLUSTERED ([ResponsiblePersonID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------