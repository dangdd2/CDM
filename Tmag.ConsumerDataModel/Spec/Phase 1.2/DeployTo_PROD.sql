/*
Run this script on:

        ..TmagPROD    -  This database will be modified

to synchronize it with:

        ..TmagCdm2Dev

You are recommended to back up your database before running this script

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

PRINT N'Creating index [idx_PrimaryEmail] on [dbo].[consumers]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'idx_PrimaryEmail') DROP INDEX [idx_PrimaryEmail] ON [dbo].[consumers]; 
CREATE NONCLUSTERED INDEX [idx_PrimaryEmail] ON [dbo].[consumers] ([primary_email])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [created] on [dbo].[consumers]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'created') DROP INDEX [created] ON [dbo].[consumers]; 
CREATE NONCLUSTERED INDEX [created] ON [dbo].[consumers] ([created])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [IX_ConsumerModifiedDt] on [dbo].[consumers]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'IX_ConsumerModifiedDt') DROP INDEX [IX_ConsumerModifiedDt] ON [dbo].[consumers]; 
CREATE NONCLUSTERED INDEX [IX_ConsumerModifiedDt] ON [dbo].[consumers] ([modified])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [ec_cube_id1] on [dbo].[JpConsumerList]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'ec_cube_id1') DROP INDEX [ec_cube_id1] ON [dbo].[JpConsumerList]; 
CREATE NONCLUSTERED INDEX [ec_cube_id1] ON [dbo].[JpConsumerList] ([ec_cube_id1])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [ConsumerId] on [dbo].[JpConsumerList]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'ConsumerId') DROP INDEX [ConsumerId] ON [dbo].[JpConsumerList]; 
CREATE NONCLUSTERED INDEX [ConsumerId] ON [dbo].[JpConsumerList] ([ConsumerId])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [IX_AddressModifiedDt] on [dbo].[addresses]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'IX_AddressModifiedDt') DROP INDEX [IX_AddressModifiedDt] ON [dbo].[addresses]; 
CREATE NONCLUSTERED INDEX [IX_AddressModifiedDt] ON [dbo].[addresses] ([modified])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [IX_brands_club_category_id] on [dbo].[brands]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'IX_brands_club_category_id') DROP INDEX [IX_brands_club_category_id] ON [dbo].[brands]; 
CREATE NONCLUSTERED INDEX [IX_brands_club_category_id] ON [dbo].[brands] ([club_category_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [IX_consumer_opt_in_consumer_profile_id_key] on [dbo].[consumer_opt_in]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'IX_consumer_opt_in_consumer_profile_id_key') DROP INDEX [IX_consumer_opt_in_consumer_profile_id_key] ON [dbo].[consumer_opt_in]; 
CREATE UNIQUE NONCLUSTERED INDEX [IX_consumer_opt_in_consumer_profile_id_key] ON [dbo].[consumer_opt_in] ([consumer_profile_id], [key]) WHERE ([key] IS NOT NULL)
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [consumer_id] on [dbo].[consumer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'consumer_id') DROP INDEX [consumer_id] ON [dbo].[consumer_profile]; 
CREATE NONCLUSTERED INDEX [consumer_id] ON [dbo].[consumer_profile] ([consumer_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [IX_ConProfileModifiedDt] on [dbo].[consumer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'IX_ConProfileModifiedDt') DROP INDEX [IX_ConProfileModifiedDt] ON [dbo].[consumer_profile]; 
CREATE NONCLUSTERED INDEX [IX_ConProfileModifiedDt] ON [dbo].[consumer_profile] ([modified])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [club_hand] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'club_hand') DROP INDEX [club_hand] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [club_hand] ON [dbo].[golfer_profile] ([club_hand_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [ClubLoftAdjustmentId] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'ClubLoftAdjustmentId') DROP INDEX [ClubLoftAdjustmentId] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [ClubLoftAdjustmentId] ON [dbo].[golfer_profile] ([ClubLoftAdjustmentId])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [consumer_id] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'golfer_profile_consumer_id') DROP INDEX [golfer_profile_consumer_id] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [golfer_profile_consumer_id] ON [dbo].[golfer_profile] ([consumer_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [current_driver_flex_id] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'current_driver_flex_id') DROP INDEX [current_driver_flex_id] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [current_driver_flex_id] ON [dbo].[golfer_profile] ([current_driver_flex_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [current_iron_length_id] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'current_iron_length_id') DROP INDEX [current_iron_length_id] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [current_iron_length_id] ON [dbo].[golfer_profile] ([current_iron_length_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [current_iron_lie_id] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'current_iron_lie_id') DROP INDEX [current_iron_lie_id] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [current_iron_lie_id] ON [dbo].[golfer_profile] ([current_iron_lie_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [desired_driver_flex_id] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'desired_driver_flex_id') DROP INDEX [desired_driver_flex_id] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [desired_driver_flex_id] ON [dbo].[golfer_profile] ([desired_driver_flex_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [driver_loft_id] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'driver_loft_id') DROP INDEX [driver_loft_id] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [driver_loft_id] ON [dbo].[golfer_profile] ([driver_loft_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [IX_GolfProfileModifiedDt] on [dbo].[golfer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'IX_GolfProfileModifiedDt') DROP INDEX [IX_GolfProfileModifiedDt] ON [dbo].[golfer_profile];
CREATE NONCLUSTERED INDEX [IX_GolfProfileModifiedDt] ON [dbo].[golfer_profile] ([modified])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO

PRINT N'Creating index [consumer_profile_id] on [dbo].[system_to_consumer_profile]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'consumer_profile_id') DROP INDEX [consumer_profile_id] ON [dbo].[system_to_consumer_profile];
CREATE NONCLUSTERED INDEX [consumer_profile_id] ON [dbo].[system_to_consumer_profile] ([consumer_profile_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [brand_id] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'brand_id') DROP INDEX [brand_id] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [brand_id] ON [dbo].[whats_in_the_bag] ([brand_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [category_id] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'category_id') DROP INDEX [category_id] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [category_id] ON [dbo].[whats_in_the_bag] ([category_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [club_category_type_id] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'club_category_type_id') DROP INDEX [club_category_type_id] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [club_category_type_id] ON [dbo].[whats_in_the_bag] ([club_category_type_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [face_lie_adjustment] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'face_lie_adjustment') DROP INDEX [face_lie_adjustment] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [face_lie_adjustment] ON [dbo].[whats_in_the_bag] ([face_lie_adjustment])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [face_loft_adjustment] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'face_loft_adjustment') DROP INDEX [face_loft_adjustment] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [face_loft_adjustment] ON [dbo].[whats_in_the_bag] ([face_loft_adjustment])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [flex] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'flex') DROP INDEX [flex] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [flex] ON [dbo].[whats_in_the_bag] ([flex])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [golfer_profile_id] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'golfer_profile_id') DROP INDEX [golfer_profile_id] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [golfer_profile_id] ON [dbo].[whats_in_the_bag] ([golfer_profile_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [loft] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'loft') DROP INDEX [loft] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [loft] ON [dbo].[whats_in_the_bag] ([loft])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [model_id] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'model_id') DROP INDEX [model_id] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [model_id] ON [dbo].[whats_in_the_bag] ([model_id])
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
PRINT N'Creating index [shaft_length_id] on [dbo].[whats_in_the_bag]'
GO
IF EXISTS (SELECT name FROM sys.indexes  WHERE name = N'shaft_length_id') DROP INDEX [shaft_length_id] ON [dbo].[whats_in_the_bag];
CREATE NONCLUSTERED INDEX [shaft_length_id] ON [dbo].[whats_in_the_bag] ([shaft_length_id])
GO

COMMIT TRANSACTION
GO
IF @@ERROR <> 0 SET NOEXEC ON
GO
-- This statement writes to the SQL Server Log so SQL Monitor can show this deployment.
IF HAS_PERMS_BY_NAME(N'sys.xp_logevent', N'OBJECT', N'EXECUTE') = 1
BEGIN
    DECLARE @databaseName AS nvarchar(2048), @eventMessage AS nvarchar(2048)
    SET @databaseName = REPLACE(REPLACE(DB_NAME(), N'\', N'\\'), N'"', N'\"')
    SET @eventMessage = N'Redgate SQL Compare: { "deployment": { "description": "Redgate SQL Compare deployed to ' + @databaseName + N'", "database": "' + @databaseName + N'" }}'
    EXECUTE sys.xp_logevent 55000, @eventMessage
END
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
