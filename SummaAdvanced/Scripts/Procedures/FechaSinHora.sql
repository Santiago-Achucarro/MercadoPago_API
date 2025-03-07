DROP FUNCTION  FechaSinHora
go
CREATE FUNCTION  FechaSinHora
(@Fecha datetime)
RETURNS datetime 
begin
	declare @Fecha_Rep DateTime
	
	SELECT @Fecha_rep = DATEADD(hh,-DatePart(hh,@Fecha),@Fecha)
	SELECT @Fecha_rep = DATEADD(mi,-DatePart(mi,@Fecha_rep),@Fecha_rep)
	SELECT @Fecha_rep = DATEADD(ss,-DatePart(ss,@Fecha_rep),@Fecha_rep)
	SELECT @Fecha_rep = DATEADD(ms,-DatePart(ms,@Fecha_rep),@Fecha_rep)


	return @Fecha_Rep	
end  

