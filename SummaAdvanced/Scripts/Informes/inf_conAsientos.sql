drop procedure inf_conAsientosPrincipal
go
create procedure inf_conAsientosPrincipal
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
SET NOCOUNT ON 

Declare @pIdentity bigint= (select Asiento_id from genAsiSegmentos
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

select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS SegmentoSTR, conAsientosCon.LeyendaLibroDiario,
conAsientos.Fecha, conAsientos.Observaciones, 
genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, 
genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSucursal, 
conAsientos.FechaRegistro, conAsientos.Posteado, conAsientos.Anulado,  conAsientos.Cambio
from conAsientos 
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=conAsientos.conAsientos
left join conAsientosCon on conAsientos.conAsientos= conAsientosCon.conAsientos
inner join genUsuarios ON 
genUsuarios.genUsuarios = conAsientos.Usuario_Id
left join genSucursalesEmpr ON 
genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
where @pIdentity=conAsientos.conAsientos

go
drop procedure inf_conAsientosCuerpo
go
create procedure inf_conAsientosCuerpo
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
SET NOCOUNT ON 

Declare @pIdentity bigint= (select Asiento_id from genAsiSegmentos
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


select conCuentas.Cuenta_Id, conCuentas.Descripcion, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id,conCentro2.Descripcion as DescripcionCentro2, 
case when TipoMov=1 then conMovContCon.Importe else 0 end as Cargo, case when TipoMov=2 then conMovContCon.Importe else 0 end as Abono
 from conMovContCon
inner join conAsientos on conAsientos.conAsientos=conMovContCon.conAsientos
left join conCuentas on conCuentas.conCuentas=conMovContCon.Cuenta_Id
left join conCentro1 on conCentro1.conCentro1=conMovContCon.Centro1_Id
left join conCentro2 on conCentro2.conCentro2=conMovContCon.Centro2_Id
where @pIdentity=conAsientos.conAsientos
	
go