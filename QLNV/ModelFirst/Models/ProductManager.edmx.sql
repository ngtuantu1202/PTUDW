
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/13/2023 08:29:27
-- Generated from EDMX file: C:\Users\Nguyen Tuan Tu\Documents\GitHub\QLNV\ModelFirst\Models\ProductManager.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QuanLyNhanVien];
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

-- Creating table 'PhongBans'
CREATE TABLE [dbo].[PhongBans] (
    [maphong] int IDENTITY(1,1) NOT NULL,
    [tenphong] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NhanViens'
CREATE TABLE [dbo].[NhanViens] (
    [manhanvien] int IDENTITY(1,1) NOT NULL,
    [tennhanvien] nvarchar(max)  NOT NULL,
    [ngaysinh] datetime  NOT NULL,
    [luong] decimal(18,0)  NOT NULL,
    [hinhanh] nvarchar(max)  NOT NULL,
    [maphong] int  NOT NULL
);
GO

-- Creating table 'PhongBanNhanVien'
CREATE TABLE [dbo].[PhongBanNhanVien] (
    [PhongBans_maphong] int  NOT NULL,
    [NhanViens_manhanvien] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [maphong] in table 'PhongBans'
ALTER TABLE [dbo].[PhongBans]
ADD CONSTRAINT [PK_PhongBans]
    PRIMARY KEY CLUSTERED ([maphong] ASC);
GO

-- Creating primary key on [manhanvien] in table 'NhanViens'
ALTER TABLE [dbo].[NhanViens]
ADD CONSTRAINT [PK_NhanViens]
    PRIMARY KEY CLUSTERED ([manhanvien] ASC);
GO

-- Creating primary key on [PhongBans_maphong], [NhanViens_manhanvien] in table 'PhongBanNhanVien'
ALTER TABLE [dbo].[PhongBanNhanVien]
ADD CONSTRAINT [PK_PhongBanNhanVien]
    PRIMARY KEY CLUSTERED ([PhongBans_maphong], [NhanViens_manhanvien] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PhongBans_maphong] in table 'PhongBanNhanVien'
ALTER TABLE [dbo].[PhongBanNhanVien]
ADD CONSTRAINT [FK_PhongBanNhanVien_PhongBan]
    FOREIGN KEY ([PhongBans_maphong])
    REFERENCES [dbo].[PhongBans]
        ([maphong])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NhanViens_manhanvien] in table 'PhongBanNhanVien'
ALTER TABLE [dbo].[PhongBanNhanVien]
ADD CONSTRAINT [FK_PhongBanNhanVien_NhanVien]
    FOREIGN KEY ([NhanViens_manhanvien])
    REFERENCES [dbo].[NhanViens]
        ([manhanvien])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhongBanNhanVien_NhanVien'
CREATE INDEX [IX_FK_PhongBanNhanVien_NhanVien]
ON [dbo].[PhongBanNhanVien]
    ([NhanViens_manhanvien]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------