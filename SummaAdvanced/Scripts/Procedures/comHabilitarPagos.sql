Drop procedure comHabilitarPagosDatos
Go

Create procedure comHabilitarPagosDatos
(
@pProveed_Id varChar(15),
@pMoneda_Id varChar(5),
@pSoloHabilitados bit,
@pEmpresa_Id int, 
@pFechaPago DateTime=NULL
)
As
Select distinct Proveed_Id, RazonSocial, genMonedas.Moneda_Id, genMonedas.Descripcion, @pSoloHabilitados SoloHabilitados, 0.00 as Total, 
	@pFechaPago FechaPago,'' as Upload
From comProveedores
Inner Join comProveedoresCtasPasivo On comProveedoresCtasPasivo.genEntidades = comProveedores.genEntidades
Inner Join genMonedas On genMonedas.genMonedas = comProveedoresCtasPasivo.Moneda_Id
Where Proveed_Id = @pProveed_Id And comProveedoresCtasPasivo.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)

Exec comPagosHabilitadosDatos @pProveed_Id, @pMoneda_Id, @pSoloHabilitados, @pEmpresa_Id, @pFechaPago

Exec comPagosAnticipoDatos @pProveed_Id, @pMoneda_Id, @pEmpresa_Id, @pFechaPago
Go

