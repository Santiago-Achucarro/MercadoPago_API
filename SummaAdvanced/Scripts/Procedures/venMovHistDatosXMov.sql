drop procedure venMovHistDatosXMov
go
create procedure venMovHistDatosXMov
(
@pvenMovimientos int
)
as
set nocount on
select distinct(venMovimientos),stkMoviCabe 
	from venMovStkHist  inner join conAsientos ON conAsientos.conAsientos = venMovStkHist.stkMoviCabe
	where venMovimientos=@pvenMovimientos AND 
conAsientos.Anulado = 0
go