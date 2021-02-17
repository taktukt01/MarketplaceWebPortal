
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2021 11:27:43
-- Generated from EDMX file: C:\Users\TAKTUK\Desktop\MarketplaceWebPortal\MarketplaceWebPortal.EntityLayer\Entities\MarketplaceModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MarketplaceWebPortal];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_ManufactureSeries_dbo_Manufactures_ManufactureID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ManufactureSeries] DROP CONSTRAINT [FK_dbo_ManufactureSeries_dbo_Manufactures_ManufactureID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ManufactureSeries_dbo_Series_CourseID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ManufactureSeries] DROP CONSTRAINT [FK_dbo_ManufactureSeries_dbo_Series_CourseID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Orders_dbo_User_UserID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_dbo_Orders_dbo_User_UserID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Property_dbo_Application_ApplicationID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Property] DROP CONSTRAINT [FK_dbo_Property_dbo_Application_ApplicationID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Property_dbo_ProductProperty_ProductPropertyID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Property] DROP CONSTRAINT [FK_dbo_Property_dbo_ProductProperty_ProductPropertyID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_SeriesModels_dbo_Models_ModelID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SeriesModels] DROP CONSTRAINT [FK_dbo_SeriesModels_dbo_Models_ModelID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_SeriesModels_dbo_Series_SiriesID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SeriesModels] DROP CONSTRAINT [FK_dbo_SeriesModels_dbo_Series_SiriesID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Shipments_dbo_Orders_OrderID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shipments] DROP CONSTRAINT [FK_dbo_Shipments_dbo_Orders_OrderID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_SubCategory_dbo_Category_CategoryID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubCategory] DROP CONSTRAINT [FK_dbo_SubCategory_dbo_Category_CategoryID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_TechSpecFilter_dbo_Property_PropertyID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TechSpecFilter] DROP CONSTRAINT [FK_dbo_TechSpecFilter_dbo_Property_PropertyID];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_TechSpecFilter_dbo_SubCategory_SubCategoryID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TechSpecFilter] DROP CONSTRAINT [FK_dbo_TechSpecFilter_dbo_SubCategory_SubCategoryID];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Application]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Application];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[Manufactures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Manufactures];
GO
IF OBJECT_ID(N'[dbo].[ManufactureSeries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ManufactureSeries];
GO
IF OBJECT_ID(N'[dbo].[Models]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Models];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[ProductProperty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductProperty];
GO
IF OBJECT_ID(N'[dbo].[Property]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Property];
GO
IF OBJECT_ID(N'[dbo].[Series]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Series];
GO
IF OBJECT_ID(N'[dbo].[SeriesModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SeriesModels];
GO
IF OBJECT_ID(N'[dbo].[Shipments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shipments];
GO
IF OBJECT_ID(N'[dbo].[SubCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubCategory];
GO
IF OBJECT_ID(N'[dbo].[TechSpecFilter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TechSpecFilter];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Applications'
CREATE TABLE [dbo].[Applications] (
    [ApplicationID] int IDENTITY(1,1) NOT NULL,
    [ApplicationInOrOut] int  NULL,
    [MountingLocation] nvarchar(50)  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryID] int IDENTITY(1,1) NOT NULL,
    [CategoryName] char(200)  NULL
);
GO

-- Creating table 'Manufactures'
CREATE TABLE [dbo].[Manufactures] (
    [ManufactureID] int  NOT NULL,
    [ManufactureName] nvarchar(50)  NULL
);
GO

-- Creating table 'ManufactureSeries'
CREATE TABLE [dbo].[ManufactureSeries] (
    [m_s_id] int  NOT NULL,
    [ManufactureID] int  NOT NULL,
    [SeriesID] int  NULL
);
GO

-- Creating table 'Models'
CREATE TABLE [dbo].[Models] (
    [Model_id] int  NOT NULL,
    [model_name] nvarchar(50)  NULL,
    [model_year] int  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [OrderID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NOT NULL,
    [OrderDate] datetime  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductID] int  NOT NULL,
    [ProductImgUrl] nvarchar(250)  NULL,
    [ProductName] nvarchar(50)  NULL,
    [ModelID] int  NOT NULL,
    [SubCategoryID] int  NOT NULL,
    [ManufactureID] int  NOT NULL
);
GO

-- Creating table 'ProductProperties'
CREATE TABLE [dbo].[ProductProperties] (
    [ProductPropertyID] int IDENTITY(1,1) NOT NULL,
    [PropertyValue] int  NULL
);
GO

-- Creating table 'Properties'
CREATE TABLE [dbo].[Properties] (
    [PropertyID] int IDENTITY(1,1) NOT NULL,
    [ApplicationID] int  NULL,
    [ProductPropertyID] int  NULL,
    [air_flow] int  NOT NULL,
    [power_min] decimal(4,2)  NOT NULL,
    [power_max] decimal(4,2)  NOT NULL,
    [operating_voltage_min] int  NOT NULL,
    [operating_voltage_max] int  NOT NULL,
    [fan_speed_min] int  NOT NULL,
    [fan_speed_max] int  NOT NULL,
    [number_of_fan_speed] int  NOT NULL,
    [sound_at_max_speed] int  NOT NULL,
    [height_min] decimal(18,0)  NOT NULL,
    [height_max] decimal(18,0)  NOT NULL,
    [weight] decimal(18,0)  NOT NULL,
    [Accessories] int  NULL
);
GO

-- Creating table 'Series'
CREATE TABLE [dbo].[Series] (
    [SeriesID] int  NOT NULL,
    [SeriesName] char(50)  NULL,
    [SeriesInfo] char(250)  NULL
);
GO

-- Creating table 'SeriesModels'
CREATE TABLE [dbo].[SeriesModels] (
    [s_m_id] int  NOT NULL,
    [SeriesID] int  NOT NULL,
    [ModelID] int  NULL
);
GO

-- Creating table 'Shipments'
CREATE TABLE [dbo].[Shipments] (
    [ShipmentID] int IDENTITY(1,1) NOT NULL,
    [OrderID] int  NOT NULL,
    [ShipmentDate] datetime  NOT NULL
);
GO

-- Creating table 'SubCategories'
CREATE TABLE [dbo].[SubCategories] (
    [SubCategoryID] int IDENTITY(1,1) NOT NULL,
    [CategoryID] int  NULL,
    [SubCategoryName] nvarchar(50)  NULL
);
GO

-- Creating table 'TechSpecFilters'
CREATE TABLE [dbo].[TechSpecFilters] (
    [TechSpecID] int IDENTITY(1,1) NOT NULL,
    [PropertyID] int  NULL,
    [SubCategoryID] int  NULL,
    [MaxVal] int  NULL,
    [MinVal] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [UserName] char(50)  NULL,
    [Password] nvarchar(300)  NULL,
    [Email] nvarchar(300)  NULL,
    [ImgUrl] nvarchar(300)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ApplicationID] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [PK_Applications]
    PRIMARY KEY CLUSTERED ([ApplicationID] ASC);
GO

-- Creating primary key on [CategoryID] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Creating primary key on [ManufactureID] in table 'Manufactures'
ALTER TABLE [dbo].[Manufactures]
ADD CONSTRAINT [PK_Manufactures]
    PRIMARY KEY CLUSTERED ([ManufactureID] ASC);
GO

-- Creating primary key on [m_s_id] in table 'ManufactureSeries'
ALTER TABLE [dbo].[ManufactureSeries]
ADD CONSTRAINT [PK_ManufactureSeries]
    PRIMARY KEY CLUSTERED ([m_s_id] ASC);
GO

-- Creating primary key on [Model_id] in table 'Models'
ALTER TABLE [dbo].[Models]
ADD CONSTRAINT [PK_Models]
    PRIMARY KEY CLUSTERED ([Model_id] ASC);
GO

-- Creating primary key on [OrderID] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([OrderID] ASC);
GO

-- Creating primary key on [ProductID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- Creating primary key on [ProductPropertyID] in table 'ProductProperties'
ALTER TABLE [dbo].[ProductProperties]
ADD CONSTRAINT [PK_ProductProperties]
    PRIMARY KEY CLUSTERED ([ProductPropertyID] ASC);
GO

-- Creating primary key on [PropertyID] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [PK_Properties]
    PRIMARY KEY CLUSTERED ([PropertyID] ASC);
GO

-- Creating primary key on [SeriesID] in table 'Series'
ALTER TABLE [dbo].[Series]
ADD CONSTRAINT [PK_Series]
    PRIMARY KEY CLUSTERED ([SeriesID] ASC);
GO

-- Creating primary key on [s_m_id] in table 'SeriesModels'
ALTER TABLE [dbo].[SeriesModels]
ADD CONSTRAINT [PK_SeriesModels]
    PRIMARY KEY CLUSTERED ([s_m_id] ASC);
GO

-- Creating primary key on [ShipmentID] in table 'Shipments'
ALTER TABLE [dbo].[Shipments]
ADD CONSTRAINT [PK_Shipments]
    PRIMARY KEY CLUSTERED ([ShipmentID] ASC);
GO

-- Creating primary key on [SubCategoryID] in table 'SubCategories'
ALTER TABLE [dbo].[SubCategories]
ADD CONSTRAINT [PK_SubCategories]
    PRIMARY KEY CLUSTERED ([SubCategoryID] ASC);
GO

-- Creating primary key on [TechSpecID] in table 'TechSpecFilters'
ALTER TABLE [dbo].[TechSpecFilters]
ADD CONSTRAINT [PK_TechSpecFilters]
    PRIMARY KEY CLUSTERED ([TechSpecID] ASC);
GO

-- Creating primary key on [UserID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ApplicationID] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [FK_dbo_Property_dbo_Application_ApplicationID]
    FOREIGN KEY ([ApplicationID])
    REFERENCES [dbo].[Applications]
        ([ApplicationID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Property_dbo_Application_ApplicationID'
CREATE INDEX [IX_FK_dbo_Property_dbo_Application_ApplicationID]
ON [dbo].[Properties]
    ([ApplicationID]);
GO

-- Creating foreign key on [CategoryID] in table 'SubCategories'
ALTER TABLE [dbo].[SubCategories]
ADD CONSTRAINT [FK_dbo_SubCategory_dbo_Category_CategoryID]
    FOREIGN KEY ([CategoryID])
    REFERENCES [dbo].[Categories]
        ([CategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_SubCategory_dbo_Category_CategoryID'
CREATE INDEX [IX_FK_dbo_SubCategory_dbo_Category_CategoryID]
ON [dbo].[SubCategories]
    ([CategoryID]);
GO

-- Creating foreign key on [ManufactureID] in table 'ManufactureSeries'
ALTER TABLE [dbo].[ManufactureSeries]
ADD CONSTRAINT [FK_dbo_ManufactureSeries_dbo_Manufactures_ManufactureID]
    FOREIGN KEY ([ManufactureID])
    REFERENCES [dbo].[Manufactures]
        ([ManufactureID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ManufactureSeries_dbo_Manufactures_ManufactureID'
CREATE INDEX [IX_FK_dbo_ManufactureSeries_dbo_Manufactures_ManufactureID]
ON [dbo].[ManufactureSeries]
    ([ManufactureID]);
GO

-- Creating foreign key on [SeriesID] in table 'ManufactureSeries'
ALTER TABLE [dbo].[ManufactureSeries]
ADD CONSTRAINT [FK_dbo_ManufactureSeries_dbo_Series_CourseID]
    FOREIGN KEY ([SeriesID])
    REFERENCES [dbo].[Series]
        ([SeriesID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ManufactureSeries_dbo_Series_CourseID'
CREATE INDEX [IX_FK_dbo_ManufactureSeries_dbo_Series_CourseID]
ON [dbo].[ManufactureSeries]
    ([SeriesID]);
GO

-- Creating foreign key on [ModelID] in table 'SeriesModels'
ALTER TABLE [dbo].[SeriesModels]
ADD CONSTRAINT [FK_dbo_SeriesModels_dbo_Models_ModelID]
    FOREIGN KEY ([ModelID])
    REFERENCES [dbo].[Models]
        ([Model_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_SeriesModels_dbo_Models_ModelID'
CREATE INDEX [IX_FK_dbo_SeriesModels_dbo_Models_ModelID]
ON [dbo].[SeriesModels]
    ([ModelID]);
GO

-- Creating foreign key on [UserID] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_dbo_Orders_dbo_User_UserID]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([UserID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Orders_dbo_User_UserID'
CREATE INDEX [IX_FK_dbo_Orders_dbo_User_UserID]
ON [dbo].[Orders]
    ([UserID]);
GO

-- Creating foreign key on [OrderID] in table 'Shipments'
ALTER TABLE [dbo].[Shipments]
ADD CONSTRAINT [FK_dbo_Shipments_dbo_Orders_OrderID]
    FOREIGN KEY ([OrderID])
    REFERENCES [dbo].[Orders]
        ([OrderID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Shipments_dbo_Orders_OrderID'
CREATE INDEX [IX_FK_dbo_Shipments_dbo_Orders_OrderID]
ON [dbo].[Shipments]
    ([OrderID]);
GO

-- Creating foreign key on [ProductPropertyID] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [FK_dbo_Property_dbo_ProductProperty_ProductPropertyID]
    FOREIGN KEY ([ProductPropertyID])
    REFERENCES [dbo].[ProductProperties]
        ([ProductPropertyID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Property_dbo_ProductProperty_ProductPropertyID'
CREATE INDEX [IX_FK_dbo_Property_dbo_ProductProperty_ProductPropertyID]
ON [dbo].[Properties]
    ([ProductPropertyID]);
GO

-- Creating foreign key on [PropertyID] in table 'TechSpecFilters'
ALTER TABLE [dbo].[TechSpecFilters]
ADD CONSTRAINT [FK_dbo_TechSpecFilter_dbo_Property_PropertyID]
    FOREIGN KEY ([PropertyID])
    REFERENCES [dbo].[Properties]
        ([PropertyID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_TechSpecFilter_dbo_Property_PropertyID'
CREATE INDEX [IX_FK_dbo_TechSpecFilter_dbo_Property_PropertyID]
ON [dbo].[TechSpecFilters]
    ([PropertyID]);
GO

-- Creating foreign key on [SeriesID] in table 'SeriesModels'
ALTER TABLE [dbo].[SeriesModels]
ADD CONSTRAINT [FK_dbo_SeriesModels_dbo_Series_SiriesID]
    FOREIGN KEY ([SeriesID])
    REFERENCES [dbo].[Series]
        ([SeriesID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_SeriesModels_dbo_Series_SiriesID'
CREATE INDEX [IX_FK_dbo_SeriesModels_dbo_Series_SiriesID]
ON [dbo].[SeriesModels]
    ([SeriesID]);
GO

-- Creating foreign key on [SubCategoryID] in table 'TechSpecFilters'
ALTER TABLE [dbo].[TechSpecFilters]
ADD CONSTRAINT [FK_dbo_TechSpecFilter_dbo_SubCategory_SubCategoryID]
    FOREIGN KEY ([SubCategoryID])
    REFERENCES [dbo].[SubCategories]
        ([SubCategoryID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_TechSpecFilter_dbo_SubCategory_SubCategoryID'
CREATE INDEX [IX_FK_dbo_TechSpecFilter_dbo_SubCategory_SubCategoryID]
ON [dbo].[TechSpecFilters]
    ([SubCategoryID]);
GO

-- Creating foreign key on [ModelID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ProductModel]
    FOREIGN KEY ([ModelID])
    REFERENCES [dbo].[Models]
        ([Model_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductModel'
CREATE INDEX [IX_FK_ProductModel]
ON [dbo].[Products]
    ([ModelID]);
GO

-- Creating foreign key on [SubCategoryID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ProductSubCategory]
    FOREIGN KEY ([SubCategoryID])
    REFERENCES [dbo].[SubCategories]
        ([SubCategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductSubCategory'
CREATE INDEX [IX_FK_ProductSubCategory]
ON [dbo].[Products]
    ([SubCategoryID]);
GO

-- Creating foreign key on [ManufactureID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ProductManufacture]
    FOREIGN KEY ([ManufactureID])
    REFERENCES [dbo].[Manufactures]
        ([ManufactureID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductManufacture'
CREATE INDEX [IX_FK_ProductManufacture]
ON [dbo].[Products]
    ([ManufactureID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------