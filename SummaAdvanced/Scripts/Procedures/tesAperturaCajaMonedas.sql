--tesAperturaCajaMonedasDatos 1, '20180925', '0204'
Drop Procedure tesAperturaCajaMonedasDatos
GO
Create Procedure tesAperturaCajaMonedasDatos
(
@pEmpresa_Id int,
@pFecha DateTime, 
@pSucursal VarChar(4)
)
As

Select genSucursalesEmpr.FechaCaja FechaActual, @pFecha FechaNueva,  
	Cast( case when genEmpresas.SucursalCentral =genSucursalesEmpr.genSucursalesEmpr then 1 else 0 end  as bit) as EsCentral, 
	genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion DescripcionSucursal
from genSucursalesEmpr inner join genEmpresas ON 
genEmpresas.genEmpresas = @pEmpresa_Id
Where
	genSucursalesEmpr.Sucursal = @pSucursal



Select genMonedas.Moneda_Id, genMonedas.Descripcion, genTipoCambio.CambioCompra, genTipoCambio.CambioVenta 
From genMonedas
Inner Join genEmpresas On genEmpresas.genEmpresas = IsNull(genMonedas.Empresa_Id, genEmpresas.genEmpresas)
Left Join genTipoCambio On genTipoCambio.Moneda_Id = genMonedas.genMonedas And genTipoCambio.Fecha = @pFecha and 
	genTipoCambio.Empresa_Id = genEmpresas.genEmpresas
Where genMonedas.genMonedas <> genEmpresas.Moneda_Id And
genEmpresas.genEmpresas = @pEmpresa_Id
Go


