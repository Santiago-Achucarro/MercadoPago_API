drop procedure conAsientosAperturaDatos
go
create procedure conAsientosAperturaDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)

AS
Declare @pAsiento_id bigint= (select Asiento_id from genAsiSegmentos
	Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C)
	select conAsientos.conAsientos, conEjercicio.Ejercicio, 
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C,
	Especial from conAsientos 
	INNER JOIN conPeriodos ON conAsientos.Fecha between conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta
INNER JOIN conEjercicio ON conEjercicio.Ejercicio = conPeriodos.Ejercicio
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_id
where conAsientos=@pAsiento_id
go
drop procedure conAsientosAperturaGuardar
go
create procedure conAsientosAperturaGuardar
(
@pAsiento_Id bigint
)
as
set nocount on
update conAsientos
set Especial='APE'
where conAsientos=@pAsiento_Id
go