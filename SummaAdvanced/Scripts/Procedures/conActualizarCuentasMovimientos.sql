drop procedure conActualizarCuentasMovimientosDatos
go
create procedure conActualizarCuentasMovimientosDatos
(
@pCuentaARemplazar varchar(25),
@pFechaDesde datetime,
@pFechaHasta datetime,
@pEmpresa_Id int,
@pCuentaRemplazo varchar(25)
)
as
select conCuentas.Cuenta_Id as Cuenta_A_Remplazar, conCuentas.Descripcion as DescripcionCuenta_A_Remplazar, CuentaRemplazo.Cuenta_Id as Cuenta_Remplazo,
CuentaRemplazo.Descripcion as DescripcionCuenta_Remplazo ,@pFechaDesde as FechaDesde,
@pFechaHasta as FechaHasta 
from conCuentas 
left join conCuentas CuentaRemplazo on CuentaRemplazo.Cuenta_Id= @pCuentaRemplazo
where conCuentas.conCuentas= dbo.FuncFKconCuentas(@pCuentaARemplazar)
select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Segmento, LeyendaLibroMayor, conCentro1.Centro1_Id,
conCentro1.Descripcion as DescripcionCentro1, conCentro2.conCentro2, conCentro2.Descripcion as DescripcionCentro2,
disFormularios.Descripcion as Formulario, conAsientos.Fecha, conMovCont.conasientos, conMovCont.Renglon, conMovCont.Importe*(conMovCont.TipoMov*2-3)*-1 as Importe
from conMovCont
inner join conCuentas on conCuentas= conMovCont.Cuenta_Id 
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id= conMovCont.conAsientos
left join conCentro1 on conMovCont.Centro1_Id= conCentro1.conCentro1
left join conCentro2 on conMovCont.Centro2_Id= conCentro2.conCentro2
inner join conAsientos on conAsientos.conAsientos=conMovCont.conAsientos
inner join disFormularios on conAsientos.Formulario_Id=disFormularios.disFormularios
where conCuentas.Cuenta_Id=@pCuentaARemplazar and conAsientos.Fecha between @pFechaDesde and @pFechaHasta and conAsientos.Empresa_Id=@pEmpresa_Id and 
conAsientos.Anulado = 0 and conAsientos.Posteado =1
go

drop procedure conActualizarCuentasMovimientosGuardar
go
create procedure conActualizarCuentasMovimientosGuardar
(
@pCuentaARemplazar varchar(25),
@pCuentaRemplazo varchar(25),
@pconAsientos bigint,
@pRenglon int
)
as
update conMovCont set Cuenta_Id= dbo.FuncFKconCuentas(@pCuentaRemplazo)
from conMovCont
inner join conAsientos on conMovCont.conAsientos= conAsientos.conAsientos
where conMovCont.Cuenta_Id=dbo.FuncFKconCuentas(@pCuentaARemplazar) and
conMovCont.conAsientos = @pconAsientos and 
conMovCont.renglon = @pRenglon and 
conAsientos.Anulado = 0 and conAsientos.Posteado = 1


update conMovContCon set Cuenta_Id= dbo.FuncFKconCuentas(@pCuentaRemplazo)
from conMovContCon
inner join conAsientos on conMovContCon.conAsientos= conAsientos.conAsientos
where conMovContCon.Cuenta_Id=dbo.FuncFKconCuentas(@pCuentaARemplazar) and
conMovContcon.conAsientos = @pconAsientos and 
conMovContcon.renglon = @pRenglon and
conAsientos.Anulado = 0 and conAsientos.Posteado = 1
