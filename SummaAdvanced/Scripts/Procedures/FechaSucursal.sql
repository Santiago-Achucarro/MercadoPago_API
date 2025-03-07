Drop function [dbo].[FechaSucursal]
go
Create function [dbo].[FechaSucursal](
	@Sucursal VarChar(4)
)
returns dateTime
as
begin

DECLARE @Fecha DateTime 
set @Fecha = dbo.FechaActual()
Declare @DiaInicioInv VarChar(20)
Declare @MesInicioHInv int
Declare @HoraInicioInv Numeric(5,2)

Declare @DiaInicioVerano VarChar(20)
Declare @MesInicioHVerano int
Declare @HoraInicioVerano Numeric(5,2)
declare @n int


SELECT top 1 @DiaInicioInv = genUsosHorarios.DiaInicioInv , @MesInicioHInv = genUsosHorarios.MesInicioHInv, 
	@HoraInicioInv= genUsosHorarios.HoraInicioInv, 
	@DiaInicioVerano= genUsosHorarios.DiaInicioVerano,  @MesInicioHVerano= genUsosHorarios.MesInicioHVerano, 
	@HoraInicioVerano = genUsosHorarios.HoraInicioVerano 
	from genSucursalesEmpr 
		inner join genCodPostal ON genSucursalesEmpr.CodigoPostal =genCodPostal.CodigoPostal
		inner join genUsosHorarios ON genUsosHorarios.Codigo = genCodPostal.CodigoUso 	
	WHERE
		genSucursalesEmpr.Sucursal = @Sucursal

if (@MesInicioHInv=0)
	begin
		return dbo.FechaActual()
	end

declare @FechaIniVer  DateTime
set @FechaIniVer = CONVERT(datetime, str(YEAR(@Fecha),4) + case when @MesInicioHVerano<10 then '0' +STR(@MesInicioHVerano,1)
	ELSE STR(@MesInicioHVerano,2) END + '01')


if @DiaInicioVerano ='Primer domingo'
Begin
	WHILE DATEPART(weekday, @FechaIniVer) <> 7
	begin
		SET @FechaIniVer = DATEADD(dd,1,@FechaIniVer)
	end
end

if @DiaInicioVerano ='Segundo domingo'
Begin
	set @n=0
	WHILE @n < 2
	begin
		if DATEPART(weekday, @FechaIniVer) = 7 
			set @n = @n+1
		if (@n<2)
			SET @FechaIniVer = DATEADD(dd,1,@FechaIniVer)
		
	end
end

declare @FechaIniInv  DateTime
set @FechaIniInv = CONVERT(datetime, str(YEAR(@Fecha),4) + case when @MesInicioHInv<10 then '0' +STR(@MesInicioHInv,1)
	ELSE STR(@MesInicioHInv,2) END + '01')

	

if @DiaInicioInv ='Primer domingo'
Begin
	WHILE DATEPART(weekday, @FechaIniInv) <> 7
	begin
		SET @FechaIniInv = DATEADD(dd,1,@FechaIniInv)
	end
end

if @DiaInicioInv ='Último domingo'
Begin
	set @FechaIniInv = DATEADD(DD,-1, DATEADD(MONTH,1, @FechaIniInv))
	WHILE DATEPART(weekday, @FechaIniInv) <> 7
	begin
		SET @FechaIniInv = DATEADD(dd,-1,@FechaIniInv)
	end
end


return (
SELECT top 1 DATEADD(HH,ISNULL(case when @Fecha between @FechaIniVer and @FechaIniInv then genUsosHorarios.UsoVerano else  genUsosHorarios.UsoInv end, genInstalacion.UsoHorario) ,GETUTCDATE()  ) 
	from genSucursalesEmpr 
		LEFT join (genCodPostal 
		inner join genUsosHorarios ON genUsosHorarios.Codigo = genCodPostal.CodigoUso) 	ON 
			genSucursalesEmpr.CodigoPostal =genCodPostal.CodigoPostal
		CROSS JOIN genInstalacion
		WHERE
			genSucursalesEmpr.Sucursal = @Sucursal
		)
		
end
GO


