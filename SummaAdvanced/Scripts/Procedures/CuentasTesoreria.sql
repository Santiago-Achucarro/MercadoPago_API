-- FM 11/04/2023 13638 Agregué el sp FuncTesoAcumSuc para que traiga el acumulado solamente de la sucursal del parámetro --

Drop Procedure FuncTesotRet
Go

Create Procedure FuncTesotRet
(
@pEmpresa_Id int,
@pFechaDesde Datetime,
@pFechaHasta Datetime,
@pProveed_Id varChar(15),
@pCartera_Id varChar(5)
)
As
Select IsNull(sum((-2*conMovCont.TipoMov+3)*-conMovCont.Importe), 0) As ValorN
From tesMovimientos 
Inner Join tesRengMovi On tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
Inner Join comMovProv On comMovProv.comMovProv = tesMovimientos.tesMovimientos
Inner Join conAsientos On conAsientos.conAsientos = tesMovimientos.tesMovimientos
Inner Join conMovCont On conMovCont.conAsientos = tesMovimientos.tesMovimientos And
						conMovCont.Renglon = tesRengMovi.conRenglon
Where conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And
			conAsientos.Fecha Between @pFechaDesde and @pFechaHasta And
			tesRengMovi.Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id) And
			comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id)
GO


Drop Procedure FuncTesoAcum
GO

Create Procedure FuncTesoAcum
(
@pEmpresa_Id int,
@pFechaDesde Datetime,
@pFechaHasta Datetime,
@pProveed_Id varChar(15),
@pTipoPasivo int = Null
)
As
Select IsNull(Sum(tesMoviGravado.Importe * conAsientos.Cambio), 0) As Total
From tesMoviGravado
Inner Join tesMovimientos On tesMovimientos.tesMovimientos = tesMoviGravado.tesMovimientos
Inner Join comMovProv On comMovProv.comMovProv = tesMovimientos.tesMovimientos
Inner Join conAsientos On conAsientos.conAsientos = tesMovimientos.tesMovimientos
 
Where conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And
conAsientos.Fecha Between @pFechaDesde and @pFechaHasta And
comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And
tesMoviGravado.TipoCtaProv = IsNull(@pTipoPasivo, tesMoviGravado.TipoCtaProv)

/* TODO Ver
			tesMoviProv.Tipomov_ccp > 50)  AND	
			not exists (select * from tesMoviReversa, tesmovimientos tesmovi WHERE
			tesMoviReversa.SucursalRev =tesMovimientos.Sucursal and
			tesMoviReversa.ComprobanteRev =tesMovimientos.Comprobante and
			tesMoviReversa.TipomovRev =tesMovimientos.Tipomov and
			tesMoviReversa.Comprobante = tesmovi.Comprobante and
			tesMoviReversa.Tipomov = tesmovi.Tipomov and
			tesMoviReversa.Sucursal = tesmovi.Sucursal and
			tesmovi.subTipo_id <>  'CVE'
*/
Go


Drop Procedure FuncTesoTabla
Go

Create Procedure FuncTesoTabla
(
@pEmpresa_Id int,
@pTabla_Id int,
@pValor decimal
)
As
Declare @lPorcentaje decimal
Declare @lMinimo decimal
Declare @lHasta decimal
Declare @pHasta decimal

Set @pHasta = @pValor

Declare @lRet decimal

Select @lPorcentaje = Porcentaje, @lMinimo = Minimo, @lHasta = Hasta 
FROM tesGanCuerpo
Inner Join tesGanancias On tesGanancias.tesGanancias = tesGanCuerpo.Tabla_Id
WHERE IsNull(tesGanancias.Empresa_Id, @pEmpresa_Id) = @pEmpresa_Id And
tesGanancias.Tabla_Id = @pTabla_Id
And Hasta In (Select Min(Hasta) From tesGanCuerpo Where Tabla_Id = @pTabla_Id And Hasta >= @pHasta)

If @lPorcentaje Is Null
	Set @lRet = 0
Else
Begin

	If @pHasta = @lHasta
	Begin
		-- No tiene diferencia con el hasta anterior para calcular --
		-- Debo buscar el mínimo de siguiente --
		Set @pHasta = @lHasta + 1
		Select @lMinimo = Minimo
		FROM tesGanCuerpo 
		Inner Join tesGanancias On tesGanancias.tesGanancias = tesGanCuerpo.Tabla_Id
		WHERE IsNull(tesGanancias.Empresa_Id, @pEmpresa_Id) = @pEmpresa_Id And
		tesGanCuerpo.Tabla_Id = @pTabla_Id
		And Hasta In (Select Min(Hasta) From tesGanCuerpo Where Tabla_Id = @pTabla_Id And Hasta >= @pHasta)

		Set @lRet = @lMinimo
	End
	Else
	Begin

		-- Busco el Hasta anterior para calcular la diferencia --
		Set @pHasta = @lHasta
		Select @lHasta = Hasta 
		From tesGanCuerpo 
		Inner Join tesGanancias On tesGanancias.tesGanancias = tesGanCuerpo.Tabla_Id
		WHERE IsNull(tesGanancias.Empresa_Id, @pEmpresa_Id) = @pEmpresa_Id And
		tesGanCuerpo.Tabla_Id = @pTabla_Id
		And Hasta In (Select Max(Hasta) From tesGanCuerpo Where Tabla_Id = @pTabla_Id And Hasta < @pHasta)

		Set @lRet = @lMinimo + @lPorcentaje * (@pValor - @lHasta) / 100
	End
End

Select @lret
Go


Drop Procedure FuncTesoAcumUsu
GO

Create Procedure FuncTesoAcumUsu
(
@pEmpresa_Id int,
@pFechaDesde Datetime,
@pFechaHasta Datetime,
@pProveed_Id varChar(15),
@pTipoPasivo int = Null,
@pCartera_Id varChar(5)
)
As

Declare @lAcum decimal
Declare @lconAsientos bigint
Declare @lAcumSinRet decimal
Set @lconAsientos = 0

Select @lconAsientos = Max(conAsientos.conAsientos)
From tesRengMovi
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner Join comMovProv On comMovProv.comMovProv = tesRengMovi.tesMovimientos
Inner Join comProveedores On comProveedores.genEntidades = comMovProv.Proveed_Id
Inner Join conAsientos On conAsientos.conAsientos = tesRengMovi.tesMovimientos
Where conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Fecha Between @pFechaDesde And @pFechaHasta And
comProveedores.Proveed_Id = @pProveed_Id And tesIdentifica.Cartera_Id = @pCartera_Id And conAsientos.Anulado = 0

If @lconAsientos Is Null
	Set @lconAsientos = 0

Set @lAcum = 0

Select @lAcum = Acum 
From tesRengMoviRetProv
Where tesRengMoviRetProv.tesMovimientos = @lconAsientos

-- Puede ser que no haya encontrado ningún pago con retención o que no sea el último pago --
-- así que tengo que buscar los pagos desde este número interno hasta hoy --
Set @lAcumSinRet = 0

Select @lAcumSinRet = IsNull(Sum(tesMoviGravado.Importe), 0)
From tesMoviGravado
Inner Join tesMovimientos On tesMovimientos.tesMovimientos = tesMoviGravado.tesMovimientos
Inner Join comMovProv On comMovProv.comMovProv = tesMovimientos.tesMovimientos
Inner Join conAsientos On conAsientos.conAsientos = tesMovimientos.tesMovimientos
 
Where conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And
conAsientos.Fecha Between @pFechaDesde and @pFechaHasta And
comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And
tesMoviGravado.TipoCtaProv = IsNull(@pTipoPasivo, tesMoviGravado.TipoCtaProv) And
conAsientos.conAsientos > @lconAsientos

Select @lAcum + @lAcumSinRet Acum

Go

Drop Procedure FuncTesoAcumSuc
GO

Create Procedure FuncTesoAcumSuc
(
@pEmpresa_Id int,
@pFechaDesde Datetime,
@pFechaHasta Datetime,
@pProveed_Id varChar(15),
@pTipoPasivo int = Null,
@pSucursal varchar(4)
)
As
Select IsNull(Sum(tesMoviGravado.Importe * conAsientos.Cambio), 0) As Total
From tesMoviGravado
Inner Join tesMovimientos On tesMovimientos.tesMovimientos = tesMoviGravado.tesMovimientos
Inner Join comMovProv On comMovProv.comMovProv = tesMovimientos.tesMovimientos
Inner Join conAsientos On conAsientos.conAsientos = tesMovimientos.tesMovimientos
 
Where conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And
conAsientos.Fecha Between @pFechaDesde and @pFechaHasta And
comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And
tesMoviGravado.TipoCtaProv = IsNull(@pTipoPasivo, tesMoviGravado.TipoCtaProv) And
conAsientos.Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal)

Go