Drop Procedure TieneMovimientosTipo
Go
Create Procedure TieneMovimientosTipo
(
@pEmpresa_Id int,
@pCliente_Id varchar(15),
@pSubTipoMov_Id varChar(5)
)
As
Select Count(1) Cantidad 
	FROM genMovCuotas
	Inner Join venMovimientos On genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
	Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
	WHERE venMovimientos.venSubTipoMov_Id = dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id) AND 
	venMovimientos.Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) AND 
	genMovCuotas.Saldo > 0 And conAsientos.Anulado = 0 And
	conAsientos.Empresa_Id = @pEmpresa_Id

Go


Drop Procedure CalculoSaldoCtaCte
Go
Create Procedure CalculoSaldoCtaCte
(
@pEmpresa_Id int,
@pCliente_Id varChar(15),
@pMonedaLimCred varChar(3)
)
As

Declare @lHoy DateTime
Set @lHoy = Convert(DateTime, Convert(varchar(10), dbo.FechaActual(), 103),103)

Create Table #_TiposCambio
(Moneda_Id int Not Null,
Cambio Numeric(17,4) Not Null)

Insert Into #_TiposCambio
Select genMonedas, dbo.func_TipoCambio(genMonedas, @lHoy, @pEmpresa_Id) From genMonedas

Declare @pMonedaBase Int
Set @pMonedaBase = (Select Moneda_Id From genEmpresas Where genEmpresas = @pEmpresa_Id)

Declare @pMonedaLC Int
Set @pMonedaLC = (Select dbo.FuncFKgenMonedas(@pMonedaLimCred))

--AO: Se comenta el código porque siempre se va a calcular en la moneda base
--If @pMonedaLC = @pMonedaBase
--Begin
	-- Estoy pidiendo el saldo en la moneda base de la empresa => multiplico por el tipo de cambio de la moneda de cada movimiento --
	SELECT Sum(genMovCuotas.Saldo*venTipoMov.Signo*Cambio.Cambio) As Saldo 
		FROM genMovCuotas
		Inner Join venMovimientos On genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
		Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
		Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
		Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
		Inner Join #_TiposCambio Cambio On Cambio.Moneda_Id = conAsientos.Moneda_Id
		Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
		WHERE 
		venSubTipomov.EsPorDifCambio = 0 And 
		conAsientos.Anulado = 0 And 
		genMovCuotas.Saldo <> 0 And 
		venmovimientos.cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
		genEmpresas.genEmpresas = @pEmpresa_Id
--End
--Else
--Begin
--	Select Sum(Saldo) As Saldo From
--	(
--		-- Si el movimiento es en la moneda pedida, se toma el valor directamente --
--		SELECT Sum(genMovCuotas.Saldo*venTipoMov.Signo) As Saldo 
--		FROM genMovCuotas
--		Inner Join venMovimientos On genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
--		Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
--		Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
--		Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
--		Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
--		WHERE 
--		venSubTipomov.EsPorDifCambio = 0 And 
--		conAsientos.Anulado = 0 And 
--		genMovCuotas.Saldo <> 0 And 
--		venmovimientos.cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
--		genEmpresas.genEmpresas = @pEmpresa_Id And
--		conAsientos.Moneda_Id = @pMonedaLC
--		Union All
--		-- Los movimientos en la moneda base se dividen por el cambio para llevarlos a la moneda pedida --
--		SELECT Sum(genMovCuotas.Saldo*venTipoMov.Signo/CambioMLC.Cambio) As Saldo 
--		FROM genMovCuotas
--		Inner Join venMovimientos On genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
--		Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
--		Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
--		Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
--		Inner Join #_TiposCambio CambioMLC On CambioMLC.Moneda_Id = @pMonedaLC
--		Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
--		WHERE 
--		venSubTipomov.EsPorDifCambio = 0 And 
--		conAsientos.Anulado = 0 And 
--		genMovCuotas.Saldo <> 0 And 
--		venmovimientos.cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
--		genEmpresas.genEmpresas = @pEmpresa_Id And
--		conAsientos.Moneda_Id = @pMonedaBase
--		Union All
--		-- La moneda del movimiento no es ni la pedida ahora ni la del límite de crédito así que --
--		-- llevarla a la moneda base y luego a la moneda pedida como parámetro --
--		SELECT Sum(genMovCuotas.Saldo*venTipoMov.Signo*CambioMov.Cambio/CambioMB.Cambio) As Saldo 
--		FROM genMovCuotas
--		Inner Join venMovimientos On genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
--		Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
--		Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
--		Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
--		Inner Join #_TiposCambio CambioMov On CambioMov.Moneda_Id = conAsientos.Moneda_Id
--		Inner Join #_TiposCambio CambioMB On CambioMB.Moneda_Id = @pMonedaLC
--		Inner Join genEmpresas On genEmpresas.genEmpresas = conAsientos.Empresa_Id
--		WHERE 
--		venSubTipomov.EsPorDifCambio = 0 And 
--		conAsientos.Anulado = 0 And 
--		genMovCuotas.Saldo <> 0 And 
--		venmovimientos.cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
--		genEmpresas.genEmpresas = @pEmpresa_Id And
--		conAsientos.Moneda_Id <> @pMonedaBase And
--		conAsientos.Moneda_Id <> @pMonedaLC
--	) a
--End
Drop table #_TiposCambio
Go


Drop Procedure CalculoSaldoDocumentada
Go
Create Procedure CalculoSaldoDocumentada
(
@pEmpresa_Id Int,
@pCliente_Id varChar(15)
)
As
Declare @lHoy DateTime
Set @lHoy = Convert(DateTime, Convert(varchar(10), dbo.FechaActual(), 103),103)

Select Sum(Saldo) Saldo From
(
Select Sum(conMovCont.Importe) Saldo
From conMovCont
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = conMovCont.conAsientos And 
		tesRengMovi.conRenglon = conMovCont.Renglon
Inner Join tesCTlink On tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos And
		tesCTlink.conRenglon = tesRengMovi.conRenglon
Inner Join tesCheqTerceros On tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros And
		tesCheqTerceros.SecuenciaActual = tesCTlink.Secuencia
	Inner Join conAsientos On conAsientos.conAsientos = tesRengMovi.tesMovimientos
Where ((tesCheqTerceros.Estado_Id IN ('N','E','P') And
	tesCheqTerceros.FechaVencimiento >= @lHoy) Or
	tesCheqTerceros.Estado_Id In ('C','S','T','U','R')) And
	tesCheqTerceros.Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
	conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id
Union All
Select Sum(conMovCont.Importe) Saldo
From conMovCont
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = conMovCont.conAsientos And 
		tesRengMovi.conRenglon = conMovCont.Renglon
Inner Join tesCTlink On tesCTlink.tesMovimientos = tesRengMovi.tesMovimientos And
		tesCTlink.conRenglon = tesRengMovi.conRenglon
Inner Join tesCheqTerceros On tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros And
		tesCheqTerceros.SecuenciaActual = tesCTlink.Secuencia
Inner Join tesClearing On tesClearing.Clearing = tesCheqTerceros.Clearing
Inner Join conAsientos On conAsientos.conAsientos = tesRengMovi.tesMovimientos
Where ((tesCheqTerceros.Estado_Id = 'N' And
	tesCheqTerceros.FechaVencimiento < @lHoy) Or
	tesCheqTerceros.Estado_Id In ('C','S','T','U','R')) And
	DateAdd(dd, tesClearing.Dias, conAsientos.Fecha) < @lHoy And
	tesCheqTerceros.Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
	conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id
) a
Go


Drop Procedure CalculoSaldoCtaCteVencida
Go
Create Procedure CalculoSaldoCtaCteVencida
(
@pEmpresa_Id Int,
@pCliente_Id varChar(15),
@pMonedaLimCred varChar(3)
)
As

Declare @lHoy DateTime
Set @lHoy = Convert(DateTime, Convert(varchar(10), dbo.FechaActual(), 103),103)

Create Table #_TiposCambio
(Moneda_Id int Not Null,
Cambio Numeric(17,4) Not Null)

Insert Into #_TiposCambio
Select genMonedas, dbo.func_TipoCambio(genMonedas, @lHoy, @pEmpresa_Id) From genMonedas

Declare @pMonedaBase Int
Set @pMonedaBase = (Select Moneda_Id From genEmpresas Where genEmpresas = @pEmpresa_Id)

Declare @pMonedaLC Int
Set @pMonedaLC = (Select dbo.FuncFKgenMonedas(@pMonedaLimCred))

--AO: Se comenta el código porque siempre se va a calcular en la moneda base
--If @pMonedaLC = @pMonedaBase
--Begin
	Select Sum(genMovCuotas.Saldo * venTipoMov.Signo * Cambio.Cambio) Saldo
	From genMovCuotas
	Inner Join venMovimientos On venMovimientos.venMovimientos = genMovCuotas.Asiento_Id
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
	Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
	Inner Join #_TiposCambio Cambio On Cambio.Moneda_Id = conAsientos.Moneda_Id
	Where venMovimientos.Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
	genMovCuotas.Saldo <> 0 And genMovCuotas.FechaVencimiento < @lHoy And
	conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id
--End
--Else
--Begin
--		-- Si el movimiento es en la moneda pedida, se toma el valor directamente --
--		Select Sum(genMovCuotas.Saldo * venTipoMov.Signo) Saldo
--		From genMovCuotas
--		Inner Join venMovimientos On venMovimientos.venMovimientos = genMovCuotas.Asiento_Id
--		Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
--		Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
--		Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
--		Where venMovimientos.Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
--		genMovCuotas.Saldo <> 0 And genMovCuotas.FechaVencimiento < @lHoy And
--		conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id And
--		conAsientos.Moneda_Id = @pMonedaLC
--		Union All
--		-- Los movimientos en la moneda base se dividen por el cambio para llevarlos a la moneda pedida --
--		Select Sum(genMovCuotas.Saldo * venTipoMov.Signo / CambioMLC.Cambio) Saldo
--		From genMovCuotas
--		Inner Join venMovimientos On venMovimientos.venMovimientos = genMovCuotas.Asiento_Id
--		Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
--		Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
--		Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
--		Inner Join #_TiposCambio CambioMLC On CambioMLC.Moneda_Id = @pMonedaLC
--		Where venMovimientos.Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
--		genMovCuotas.Saldo <> 0 And genMovCuotas.FechaVencimiento < @lHoy And
--		conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id And
--		conAsientos.Moneda_Id = @pMonedaBase
--		Union All
--		-- La moneda del movimiento no es ni la pedida ahora ni la del límite de crédito así que --
--		-- llevarla a la moneda base y luego a la moneda pedida como parámetro --
--		Select Sum(genMovCuotas.Saldo * venTipoMov.Signo * CambioMov.Cambio / CambioMB.Cambio) Saldo
--		From genMovCuotas
--		Inner Join venMovimientos On venMovimientos.venMovimientos = genMovCuotas.Asiento_Id
--		Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
--		Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
--		Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
--		Inner Join #_TiposCambio CambioMov On CambioMov.Moneda_Id = conAsientos.Moneda_Id
--		Inner Join #_TiposCambio CambioMB On CambioMB.Moneda_Id = @pMonedaLC
--		Where venMovimientos.Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
--		genMovCuotas.Saldo <> 0 And genMovCuotas.FechaVencimiento < @lHoy And
--		conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id And
--		conAsientos.Moneda_Id <> @pMonedaBase And
--		conAsientos.Moneda_Id <> @pMonedaLC
--End
Drop table #_TiposCambio
Go



Drop Procedure CalculoMaxAntiguedad
Go
Create Procedure CalculoMaxAntiguedad
(
@pEmpresa_Id Int,
@pCliente_Id varChar(15)
)
As

Declare @lHoy DateTime
Declare @lFecha DateTime
Set @lHoy = Convert(DateTime, Convert(varchar(10), dbo.FechaActual(), 103),103)

Select @lFecha = IsNull(Min(genMovCuotas.FechaVencimiento), @lHoy)
From genMovCuotas
Inner Join venMovimientos On venMovimientos.venMovimientos = genMovCuotas.Asiento_Id
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
Where venMovimientos.Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id) And
conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id and 
genMovCuotas.Saldo*venTipoMov.Signo > 0

Select Convert(int, @lHoy - @lFecha) Dias
Go






