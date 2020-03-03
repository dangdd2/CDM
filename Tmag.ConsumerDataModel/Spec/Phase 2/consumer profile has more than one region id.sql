-- list all customers which has more than one regionId
select 
	   cp.consumer_id, 
	   cp.region_id, 
	   count(*) as NumberOfRegigion from consumer_profile cp
group by cp.region_id,cp.consumer_id
having count(*) > 2

<<<<<<< HEAD

-- for testing specific customer
select  cp.consumer_id,
=======
-- there are some record duplicated in created date
select 
	   cp.consumer_id, 
	   cp.region_id, 	   
	   cp.created,
	   count(*) as NumberOfRegigion
from consumer_profile cp
group by cp.region_id,cp.consumer_id, cp.created
having count(*) > 1

------
-- total record : 2366

select  cp.consumer_id,
		cp.region_id,
		cp2.number_of_regions,
		cp2.FirstCreatedDate,
		cp.created,
		case when cp2.FirstCreatedDate = cp.created then '' else 'to be deleted' end as IsDeleted, 
		cp.* 
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
--1180 will be remove
--expect 1186 remaining


-- for testing specific customer
-- 2366 - (3 * 2)
-- skip 1180
-- the list data will be removed
select  
		cp.consumer_profile_id,
		cp.consumer_id,
>>>>>>> dev
		cp.region_id,
		cp.* 
		from consumer_profile cp
		INNER JOIN 
		(
			select 
				   cp.consumer_id, 
				   cp.region_id, 
<<<<<<< HEAD
=======
				   count(*) as number_of_regions,				   
				   min(cp.created) as FirstCreatedDate
			from consumer_profile cp
			group by cp.region_id,cp.consumer_id
			having count(*) > 1

		) as cp2 on cp.consumer_id = cp2.consumer_id and cp.region_id = cp2.region_id
where 
	  cp.Created <> cp2.FirstCreatedDate
	  -- and cp2.number_of_regions < 3 -- 1176 (1180 - 4(same created date ))
order by cp.consumer_id

-- 2366

----------------------------------------------
---------------------------------------------
---- 
select  cp.consumer_id,
		cp.region_id,
		cp.* ,
		a.*,
		ce.*,
		co.*,
		sp.*
		from consumer_profile cp
		INNER JOIN 
		(
			select 
				   cp.consumer_id, 
				   cp.region_id, 
>>>>>>> dev
				   count(*) as number_of_regions
			from consumer_profile cp
			group by cp.region_id,cp.consumer_id
			having count(*) > 1

<<<<<<< HEAD
		) as cp2 on cp.consumer_id = cp2.consumer_id
=======
		) as cp2 on cp.consumer_id = cp2.consumer_id and cp.region_id = cp2.region_id
		left join addresses a on a.address_id = cp.address_id
		left join consumer_experiences ce on ce.consumer_profile_id = cp.consumer_profile_id
		left join consumer_opt_in co on co.consumer_profile_id = cp.consumer_profile_id -- 2368
		left join system_to_consumer_profile sp on sp.consumer_profile_id = cp.consumer_profile_id --2370
>>>>>>> dev
order by cp.consumer_id

-- show full customer infomation 
select  
		c.consumer_id,
		c.first_name + c.last_name as FullName,
		c.primary_email,
		cp.region_id,
		cp.number_of_regions,
		r.region_code + ' - ' + r.region_desc as region
  from consumers c
		INNER JOIN 
		(
			select 
				   cp.consumer_id, 
				   cp.region_id, 
				   count(*) as number_of_regions
			from consumer_profile cp
			group by cp.region_id,cp.consumer_id
			having count(*) > 1

		) as cp on c.consumer_id = cp.consumer_id
		inner join region r on cp.region_id = r.region_id




		
		--select * from #ConsumerProfileToBeDeleted c
		--where consumer_id NOT in ('E470B28A-AF98-4F47-82AE-992B63787A00',
		--						 '77B0F65F-86E9-4B8F-87C3-8F261802C316',
		--						 'BC750593-A192-4013-B93A-803F2972A294',
		--						 'DAEDC97E-3ECC-43C9-B869-F412C20FAB40'
		--	  ) -- 2358

		---- 2358 - 6 = 2352 / 2 = 1176 + 4  (NUMBER OF REGION 3 = 2 RECORDS) = 1180

	 --  select * from #ConsumerProfileToBeDeleted c
	 --  where number_of_regions = 3
