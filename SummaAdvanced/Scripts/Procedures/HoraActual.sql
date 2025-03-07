drop function HoraActual
go
create function HoraActual(@Fecha DateTime )
returns varChar(5)
as
BEGIN
DECLARE @Hora int, @Min int, @REt varchar(5)
set @Hora =DATEPART(HOUR, @Fecha)
set @Min =DATEPART(MI, @Fecha)
if @Hora < 10
    set @Ret = '0'+str(@Hora,1)+':'
ELSE    
    set @Ret = str(@Hora,2)+':'

if @Min < 10
    set @Ret =@Ret+ '0'+str(@Min,1)
ELSE    
    set @Ret =@Ret+ str(@Min,2)

return @Ret

END

