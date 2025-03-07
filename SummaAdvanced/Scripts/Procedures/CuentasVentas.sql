Drop procedure dTodo
Go

Create procedure dTodo
(
@pEmpresa_Id int,
@pvenMovimientos bigInt,
@pImpuesto_Id varChar(5)
)
As

Declare @lRet qMonedaD2

Select @lRet = venMovImpuestos.BaseImponible --AO Antes venMovImpuestos.BaseImponibleMonedaNac Mantis_13684
From venMovImpuestos
Inner Join conAsientos On conAsientos.conAsientos = venMovImpuestos.venMovimientos
Where conAsientos.Empresa_Id = @pEmpresa_Id And
venMovImpuestos.venMovimientos = @pvenMovimientos And
venMovImpuestos.Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id)

Select isNull(@lRet, 0)
Go


Drop procedure PorceAsoc
GO

Create procedure PorceAsoc
(
@pvenMovimientos bigint,
@pImpuesto_Id varChar(5)
)
As

Declare @lRet qPorcentaje

Select @lRet = Porcentaje From venMovImpuestos
Where venMovimientos = @pvenMovimientos And
Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id) And Importe > 0

Select IsNull(@lRet, 0)
Go
