USE [RefImpls]

insert into ReservationSchedule ([From], [To]) values
	('2010-01-01 08:00:00', '2010-01-01 12:00:00'),
	('2010-01-02 10:00:00', '2010-01-02 12:00:00'),
	('2010-01-03 12:00:00', '2010-01-03 18:00:00'),
	('2010-01-04 08:00:00', '2010-01-04 16:00:00');

insert into RateSchedule  ([From], [To], Rate) values 
	('2010-01-01 10:00:00', '2010-01-01 14:00:00', 1),
	('2010-01-02 08:00:00', '2010-01-02 14:00:00', 2),
	('2010-01-03 10:00:00', '2010-01-03 14:00:00', 3),
	('2010-01-04 10:00:00', '2010-01-04 14:00:00', 4);

if object_id('tempdb..#BreakDown') is not null
	drop table #BreakDown;

create table #BreakDown
(
	[From]	datetime,
	[To]	datetime,
	[Rate]	int,
	[STG]	varchar(10),
	[SF]	datetime,
	[ST]	datetime,
	[RF]	datetime,
	[RT]	datetime,
)


insert into #BreakDown
--[1] S T S T (*) --
select t.[From], s.[To], t.[Rate], 'S T S T', s.[From], s.[To], t.[From], t.[To] 
from ReservationSchedule s
join RateSchedule t on			t.[From] between s.[From] and s.[To]
						and		s.[To] between t.[From] and t.[To]
union all
--[2] T S S T (SS < TT)--
select s.[From], s.[To], t.[Rate], 'T S S T', s.[From], s.[To], t.[From], t.[To] 
from ReservationSchedule s
join RateSchedule t on			s.[From] between t.[From] and t.[To]
						and		s.[To] between t.[From] and t.[To]
union all
--[3] T S T S (*)--
select s.[From], t.[To], t.[Rate], 'T S T S', s.[From], s.[To], t.[From], t.[To] 
from ReservationSchedule s
join RateSchedule t on			s.[From] between t.[From] and t.[To]
						and		t.[To] between s.[From] and s.[To]
--[4] S T T S (SS > TT)--
union all
select t.[From], t.[To], t.[Rate], 'S T T S', s.[From], s.[To], t.[From], t.[To] 
from ReservationSchedule s
join RateSchedule t on			t.[From] between s.[From] and s.[To]
						and		t.[To] between s.[From] and s.[To]

select * from #BreakDown;

select * from ReservationSchedule;

delete s
--[2] T S S T (SS < TT)--
from ReservationSchedule s
join RateSchedule t on			s.[From] between t.[From] and t.[To]
						and		s.[To] between t.[From] and t.[To]

select * from ReservationSchedule;

update ReservationSchedule
set [To] = t.[From]
--[1] S T S T (*) --
from ReservationSchedule s
join RateSchedule t on			t.[From] between s.[From] and s.[To]
						and		s.[To] between t.[From] and t.[To]

update ReservationSchedule
set [To] = t.[To]
--[3] T S T S (*)--
from ReservationSchedule s
join RateSchedule t on			s.[From] between t.[From] and t.[To]
						and		t.[To] between s.[From] and s.[To]

select * from ReservationSchedule;

--[4] S T T S (SS > TT)--
insert into ReservationSchedule
select s.[From], t.[To] 
from ReservationSchedule s
join RateSchedule t on			t.[From] between s.[From] and s.[To]
						and		t.[To] between s.[From] and s.[To]

select * from ReservationSchedule;

truncate table ReservationSchedule;
truncate table RateSchedule;
truncate table #BreakDown;


