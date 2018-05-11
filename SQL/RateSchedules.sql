CREATE TABLE [dbo].[RateSchedule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[From] [datetime] NULL,
	[To] [datetime] NULL,
	[Rate] [int] NULL,
 CONSTRAINT [PK_RateSchedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [RefImpls]
GO

CREATE TABLE [dbo].[ReservationSchedule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[From] [datetime] NULL,
	[To] [datetime] NULL,
 CONSTRAINT [PK_ReservationSchedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

insert into RateSchedule  ([From], [To], Rate)
select '2010-01-01 10:00:00', '2010-01-01 12:00:00', 1000 union all
select '2010-01-02 14:00:00', '2010-01-02 16:00:00', 2000

insert into ReservationSchedule ([From], [To])
select '2010-01-01 08:00:00', '2010-01-01 18:00:00' union all
select '2010-01-02 08:00:00', '2010-01-02 18:00:00'


if object_id('tempdb..#BreakDown') is not null
	drop table #BreakDown;

create table #BreakDown
(
	[From] datetime,
	[To] datetime,
	[Rate] int,
)

insert into #BreakDown
select rt.[From], rt.[To], rt.[Rate] from ReservationSchedule rs
join RateSchedule rt on		rt.[From] between rs.[From] and rs.[To]
						and  rt.[To] between rs.[From] and rs.[To]

select * from #BreakDown;

truncate table ReservationSchedule;
truncate table RateSchedule;
truncate table #BreakDown;
