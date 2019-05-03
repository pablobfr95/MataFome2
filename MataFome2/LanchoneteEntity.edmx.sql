
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/21/2019 11:02:28
-- Generated from EDMX file: C:\Users\botaf\source\repos\MataFome2 19-04-2019 - Noite\MataFome2\MataFome2\LanchoneteEntity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MataFome];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------
IF OBJECT_ID(N'[dbo].[FK_PagamentoVenda_FormaPagamentos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagamentoVenda] DROP CONSTRAINT [FK_PagamentoVenda_FormaPagamentos];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoVenda_Venda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagamentoVenda] DROP CONSTRAINT [FK_PagamentoVenda_Venda];
GO

IF OBJECT_ID(N'[dbo].[PagamentoVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagamentoVenda];
GO


-- Creating table 'PagamentoVenda'
CREATE TABLE [dbo].[PagamentoVenda] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [VendaId] int  NOT NULL,
    [FormaPagamentoId] int  NOT NULL
);
GO

-- Creating primary key on [Id] in table 'PagamentoVenda'
ALTER TABLE [dbo].[PagamentoVenda]
ADD CONSTRAINT [PK_PagamentoVenda]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating foreign key on [FormaPagamentoId] in table 'PagamentoVenda'
ALTER TABLE [dbo].[PagamentoVenda]
ADD CONSTRAINT [FK_PagamentoVenda_FormaPagamentos]
    FOREIGN KEY ([FormaPagamentoId])
    REFERENCES [dbo].[FormaPagamentos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoVenda_FormaPagamentos'
CREATE INDEX [IX_FK_PagamentoVenda_FormaPagamentos]
ON [dbo].[PagamentoVenda]
    ([FormaPagamentoId]);
GO

-- Creating foreign key on [VendaId] in table 'PagamentoVenda'
ALTER TABLE [dbo].[PagamentoVenda]
ADD CONSTRAINT [FK_PagamentoVenda_Venda]
    FOREIGN KEY ([VendaId])
    REFERENCES [dbo].[Venda]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoVenda_Venda'
CREATE INDEX [IX_FK_PagamentoVenda_Venda]
ON [dbo].[PagamentoVenda]
    ([VendaId]);
GO