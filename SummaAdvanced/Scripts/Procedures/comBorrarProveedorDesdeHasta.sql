Drop procedure dbo.comBorrarProveedorDesdeHasta
GO

Create procedure dbo.comBorrarProveedorDesdeHasta
(
@pProveed_IdDesde varChar(15),
@pProveed_IdHasta varChar(15),
@pFechaHasta datetime,
@pSecuencia int = NULL,
@pEmpresa_Id int,
@pMoneda varchar(3)
)

as SET NOCOUNT ON 

DELETE FROM comPagosHabilitados 
Where
comPagosHabilitados.tesMovimientos IS NULL AND 
(Secuencia = ISNULL(@pSecuencia, Secuencia)) And 
	exists(select 1 from comProveedores , comMovprov ,conAsientos,genMonedas
		where 
		comMovProv.comMovProv = comPagosHabilitados.comMovProv AND 
		comProveedores.genEntidades=comMovProv.Proveed_Id 
		and 
		comProveedores.Proveed_Id between @pProveed_IdDesde and @pProveed_IdHasta
		and comMovProv.comMovProv=conAsientos.conAsientos
		and conAsientos.Moneda_Id= genMonedas.genMonedas
		and	genMonedas.Moneda_Id=@pMoneda
		)
		
RETURN @@Error 

GO

