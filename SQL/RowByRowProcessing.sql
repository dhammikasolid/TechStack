if object_id('tempdb..#LoopRefs') is null
	create table #LoopRefs
	(
		Id int identity(1,1),
		Ref int not null
	);

insert into #LoopRefs
select BookingFacilityReservationID from RecBookingFacilityReservation;

declare @to int = (select count(Id) from #LoopRefs);
declare @i int = 1;

declare @ReservationId int, @BookingId int, @Description varchar(200); 

while (@i <= @to)
	begin
		select top(1) @ReservationId = ref.Ref, @BookingId = fr.BookingID, @Description = fr.Description from #LoopRefs ref
		join RecBookingFacilityReservation fr on fr.BookingFacilityReservationID = ref.Ref
		where ref.Id = @i;

		print convert(varchar(100), @ReservationId) + ' ' + convert(varchar(100), @BookingId) + ' ' + @Description;

		set @i = @i + 1;
	end;