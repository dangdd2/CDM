select * from consumers
where consumer_id = 'C8DA57B1-DAA6-4E4B-0ED9-08D54BBEC2C7'
where primary_email like '%dangdd%'


select * from consumer_profile
where consumer_id = 'C8DA57B1-DAA6-4E4B-0ED9-08D54BBEC2C7'

update consumer_profile
		SET region_id = 'D890342D-FCC4-4D4D-2F11-08D5483C74A8'
where consumer_profile_id = '72E6658F-EFF2-4626-6979-08D63FD5B24A'


-- get all the cosumer has more than one consumer profile_id
select count(*) as count, consumer_id from consumer_profile
group by consumer_id
having count(*) > 1