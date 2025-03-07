Drop Function func_TipoCambio
Go

Create Function func_TipoCambio
(
@pMoneda_Id int,
@pFecha DateTime, 
@pEmpresa_Id int
)
Returns qMonedaD4
As
Begin
Declare @pCambio qMonedaD4

Declare @Dias Int
Set @Dias= ISNULL((select nValor from genGlobales where
		Nombre_Var = 'GENDIASCAMBIO' and 
		Empresa_Id = @pEmpresa_Id),0)
SET @pFecha  = DATEADD(DD, @Dias, @pFecha)


Select @pCambio = CambioVenta From genTipoCambio 
Where Moneda_Id = @pMoneda_Id And 
ISNULL(@pEmpresa_Id, Empresa_Id) =  @pEmpresa_Id and 
Fecha = 
isnull((Select Min(Fecha) Fecha From genTipoCambio 
	Where Moneda_Id = @pMoneda_Id And Fecha >= @pFecha and 
	ISNULL(@pEmpresa_Id, Empresa_Id) =  @pEmpresa_Id),
	(Select max(Fecha) Fecha From genTipoCambio 
	Where Moneda_Id = @pMoneda_Id And Fecha <= @pFecha and 
	ISNULL(@pEmpresa_Id, Empresa_Id) =  @pEmpresa_Id))

Return ISNULL(@pCambio,1)
End

GO


Drop Function func_TipoCambioCompra
Go

Create Function func_TipoCambioCompra
(
@pMoneda_Id int,
@pFecha DateTime, 
@pEmpresa_Id int
)
Returns qMonedaD4
As
Begin



Declare @pCambio qMonedaD4

Declare @Dias Int
Set @Dias= ISNULL((select nValor from genGlobales where
		Nombre_Var = 'GENDIASCAMBIO' and 
		Empresa_Id = @pEmpresa_Id),0)
SET @pFecha  = DATEADD(DD, @Dias, @pFecha)


Select @pCambio = CambioCompra From genTipoCambio 
Where Moneda_Id = @pMoneda_Id And 
ISNULL(@pEmpresa_Id, Empresa_Id) =  @pEmpresa_Id and 
Fecha = 
isnull((Select Min(Fecha) Fecha From genTipoCambio 
	Where Moneda_Id = @pMoneda_Id And Fecha >= @pFecha and 
	ISNULL(@pEmpresa_Id, Empresa_Id) =  @pEmpresa_Id),
	(Select max(Fecha) Fecha From genTipoCambio 
	Where Moneda_Id = @pMoneda_Id And Fecha <= @pFecha and 
	ISNULL(@pEmpresa_Id, Empresa_Id) =  @pEmpresa_Id))

Return ISNULL(@pCambio,1)
End

GO

Drop Function  NVLE
GO
Create Function  NVLE(
	@Campo1 VarChar(255),
	@Campo2 VarChar(255)
)
Returns VarChar(255)
as
begin
	if (@Campo1 is null or rtrim(@Campo1) = '')
		return @Campo2
return @Campo1
end