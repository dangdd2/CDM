/*
Run this script on:

        ..TmagCdm2Dev    -  This database will be modified

to synchronize it with:

        ..TmagPROD
*/
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL Serializable
GO
BEGIN TRANSACTION
GO

-----------Update dbo.Consumer/[PrimaryEmail] From NULL to NOT NULL---------------
Print('Updating dbo.Consumer/[PrimaryEmail] has null value to dummy email value');
GO
Update dbo.consumers
Set primary_email = CAST(@@ROWCOUNT as nvarchar) + 'test@email.com'
where primary_email IS NULL;
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

PRINT N'Droping index [idx_PrimaryEmail] on [dbo].[consumers]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'idx_PrimaryEmail') DROP INDEX [idx_PrimaryEmail] ON [dbo].[consumers];
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

PRINT N'Alter [PrimaryEmail] on [dbo].[consumers] from NULL to NOT NULL'
GO
ALTER TABLE [dbo].[consumers] ALTER COLUMN [primary_email] [nvarchar] (2000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

PRINT N'Creating index [idx_PrimaryEmail] on [dbo].[consumers]'
GO
CREATE NONCLUSTERED INDEX [idx_PrimaryEmail] ON [dbo].[consumers] ([primary_email])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

-----------Update [dbo].[JpConsumerList]/[ec_cube_id1] From NVARCHAR to INT---------------
PRINT N'Droping index [ec_cube_id1] on [dbo].[JpConsumerList]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'ec_cube_id1') DROP INDEX [ec_cube_id1] ON [dbo].[JpConsumerList];
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

PRINT N'Alter [ec_cube_id1] on [dbo].[JpConsumerList] from NVARCHAR to INT'
GO
ALTER TABLE [dbo].[JpConsumerList] ALTER COLUMN [ec_cube_id1] [INT] NULL
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

PRINT N'Creating index [ec_cube_id1] on [dbo].[JpConsumerList]'
GO
CREATE NONCLUSTERED INDEX [ec_cube_id1] ON [dbo].[JpConsumerList] ([ec_cube_id1])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO


-------Remove Column [Email] on [dbo].[mfe-userIds] -------
IF COL_LENGTH('dbo.mfe-userIds', 'email') IS NOT NULL
BEGIN
    PRINT N'Droping column [Email] on [dbo].[mfe-userIds]'	
	ALTER TABLE [dbo].[mfe-userIds] DROP COLUMN [email]	
	IF @@ERROR <> 0 SET NOEXEC ON	
END

-------Remove Columns: [dba],[fitting_type],[sales_representative],[shipto_name]  on [dbo].[retail_store]-------
IF COL_LENGTH('dbo.retail_store', 'dba') IS NOT NULL
BEGIN
	PRINT N'Droping column [dba] on [dbo].[retail_store]'
	ALTER TABLE [dbo].[retail_store] DROP COLUMN [dba]
	IF @@ERROR <> 0 SET NOEXEC ON
END
GO

IF COL_LENGTH('dbo.retail_store', 'fitting_type') IS NOT NULL
BEGIN
	PRINT N'Droping column [fitting_type] on [dbo].[retail_store]'
	ALTER TABLE [dbo].[retail_store] DROP COLUMN [fitting_type]
	IF @@ERROR <> 0 SET NOEXEC ON
END
GO

IF COL_LENGTH('dbo.retail_store', 'sales_representative') IS NOT NULL
BEGIN
	PRINT N'Droping column [sales_representative] on [dbo].[retail_store]'
	ALTER TABLE [dbo].[retail_store] DROP COLUMN [sales_representative]
	IF @@ERROR <> 0 SET NOEXEC ON
END
GO

IF COL_LENGTH('dbo.retail_store', 'shipto_name') IS NOT NULL
BEGIN
	PRINT N'Droping column [shipto_name] on [dbo].[retail_store]'
	ALTER TABLE [dbo].[retail_store] DROP COLUMN [shipto_name]
	IF @@ERROR <> 0 SET NOEXEC ON
END
GO


-----------COMMIT TRANSACTION-----------
COMMIT TRANSACTION
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

DECLARE @Success AS BIT
SET @Success = 1
SET NOEXEC OFF
IF (@Success = 1) PRINT 'The database update succeeded'
ELSE BEGIN
	IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
	PRINT 'The database update failed'
END
GO