Drop procedure stkExistenciaDespaXFifo
Go

Create procedure stkExistenciaDespaXFifo
(
@pEmpresa_Id int,
@pProducto_Id varChar(25),
@pDeposito_Id varChar(15),
@pCantidad qCantidadD8
)
As

Declare @lDespacho_Id varChar(25)
Declare @lCantidad qCantidadD8

Declare lCursorDespa Cursor for
Select comDespachos.Despacho_Id, Cantidad
From stkExistenciaDespa 
Inner Join comDespachos On comDespachos.comDespachos = stkExistenciaDespa.Despacho_Id
Where stkExistenciaDespa.Empresa_Id = @pEmpresa_Id And
	Producto_Id = dbo.funcFKstkProductos(@pProducto_Id) And
	Deposito_Id = dbo.funcFKstkDepositos(@pDeposito_Id) And stkExistenciaDespa.Cantidad > 0
Order By comDespachos.Fecha

Open lCursorDespa

Create table #lCursorDevol
(
Despacho_Id varChar(25) Not Null,
Cantidad Numeric(19,8) Not Null
)

Fetch Next From lCursorDespa
Into @lDespacho_Id, @lCantidad

While (@@FETCH_STATUS = 0 And @pCantidad > 0 And @lCantidad > 0)
Begin
print @pCantidad
print @lCantidad
	If @lCantidad >= @pCantidad
	Begin
		Insert Into #lCursorDevol Values (@lDespacho_Id, @pCantidad)
		Set @pCantidad = 0
	End
	Else
	Begin
		Insert Into #lCursorDevol Values (@lDespacho_Id, @lCantidad)
		Set @pCantidad = @pCantidad - @lCantidad
	End

	Fetch Next From lCursorDespa
	Into @lDespacho_Id, @lCantidad
End

Select @pProducto_Id Producto_Id, @pDeposito_Id Deposito_Id, @pCantidad Cantidad

Select Despacho_Id, Cantidad From #lCursorDevol
Drop table #lCursorDevol

Close lCursorDespa
Deallocate lCursorDespa

Go
