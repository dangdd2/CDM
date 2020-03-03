
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

		-- DROP TEMP if existed	
		IF OBJECT_ID('tempdb..#ConsumerProfileToBeDeleted') IS NOT NULL
		BEGIN
			DROP TABLE #ConsumerProfileToBeDeleted;
		END;

		SELECT consumer_profile_id
				INTO #ConsumerProfileToBeDeleted
		from (
				SELECT  'ee197518-0cd0-414a-bee0-8fb53aa63683' AS consumer_profile_id
				UNION  
				SELECT  'b5a8d652-5a05-4f43-bbd8-2fdb8061d983' AS consumer_profile_id
				UNION  
				SELECT  '6526daf6-8b8b-4a14-a379-be9649ca9bee' AS consumer_profile_id
				UNION  
				SELECT  '9f0d6209-8441-4343-aaa5-972a5c3dc7cc' AS consumer_profile_id
		) AS C
										
		---- DELETE ALL item marked 'TO BE DELETED'	

		-- consumer_bag_panel_campaigns
		DELETE from consumer_bag_panel_campaigns
		WHERE consumer_profile_id IN (
							select consumer_profile_id from #ConsumerProfileToBeDeleted 
							)
		-- consumer_experiences
		DELETE  from consumer_experiences
		WHERE consumer_profile_id IN (
							select consumer_profile_id from #ConsumerProfileToBeDeleted 
							)
		-- system_to_consumer_profile
		DELETE  from system_to_consumer_profile
		WHERE consumer_profile_id IN (
							select consumer_profile_id from #ConsumerProfileToBeDeleted 
							)
		--consumer_opt_in
		DELETE  from consumer_opt_in
		WHERE consumer_profile_id IN (
							select consumer_profile_id from #ConsumerProfileToBeDeleted 
							)
	    
		--CONSUMER PROFILE		
		DELETE  
		FROM consumer_profile 
		WHERE consumer_profile_id IN (
							select consumer_profile_id from #ConsumerProfileToBeDeleted 
							)
			
		-- clean temp table 
		DROP TABLE #ConsumerProfileToBeDeleted
		
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