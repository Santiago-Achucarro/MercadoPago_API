drop procedure AfiActivoFijoOtrosDesactivar


go
create PROCEDURE AfiActivoFijoOtrosDesactivar
(
	@pconAsientos bigint,
	@pRenglon int	
	)

	as
	update AficonMovcont 
	set Inactivo=1 where conAsientos=@pconAsientos and Renglon=@pRenglon

