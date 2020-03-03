
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

		IF OBJECT_ID('tempdb..#ConsumerProfileTemp') IS NOT NULL
		BEGIN
			DROP TABLE #ConsumerProfileTemp;
		END;


		IF OBJECT_ID('tempdb..#ConsumerProfileToBeDeleted') IS NOT NULL
		BEGIN
			DROP TABLE #ConsumerProfileToBeDeleted;
		END;

		select  
				cp.consumer_profile_id,
				cp.consumer_id,
				cp.region_id,
				cp2.number_of_regions,
				cp2.FirstCreatedDate,
				cp.created,
				case when cp2.FirstCreatedDate = cp.created then '' else 'TO BE DELETED' end as IsDeleted 
				
		INTO #ConsumerProfileTemp
		from consumer_profile cp
				INNER JOIN 
				(
					select 
						   cp.consumer_id, 
						   cp.region_id, 
						   count(*) as number_of_regions,				   
						   min(cp.created) as FirstCreatedDate
					from consumer_profile cp
					group by cp.region_id,cp.consumer_id
					having count(*) > 1

				) as cp2 on cp.consumer_id = cp2.consumer_id and cp.region_id = cp2.region_id
		
	    order by cp.consumer_id
		

		select consumer_profile_id 
				INTO #ConsumerProfileToBeDeleted
		from #ConsumerProfileTemp c 
		where IsDeleted = 'TO BE DELETED'
										
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
		DROP TABLE #ConsumerProfileTemp
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