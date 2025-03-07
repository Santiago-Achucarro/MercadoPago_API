-- espPVAutorizarPendientesKSK 1
DROP PROCEDURE espPVAutorizarPendientesKSK
GO

CREATE PROCEDURE espPVAutorizarPendientesKSK
(
	@pEmpresa_Id Int
)
as

SELECT genEmpresas.genEmpresas as Empresa_Id
from genEmpresas 
WHERE
genEmpresas.genEmpresas = @pEmpresa_Id

SELECT KSKParaAutorizar.Estado, conAsientos.FechaRegistro, 
	KSKParaAutorizar.venMovimientos, KSKParaAutorizar.tesMovimientos,
	genUsuarios.Usuario_Id, 
	venClientes.Cliente_Id, venClientes.RazonSocial, venMovimientos.Importe, 
	genMonedas.Moneda_Id, KSKParaAutorizar.Causa, 
		dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
		genAsiSegmentos.Segmento1n, genAsiSegmentos.Segmento2n, genAsiSegmentos.Segmento3n, 
		genAsiSegmentos.Segmento4n) AS Comprobante, genSucursalesEmpr.Sucursal
From KSKParaAutorizar 
		INNER JOIN venMovimientos ON  venMovimientos.venMovimientos = KSKParaAutorizar.venMovimientos
		INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
		INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
		INNER JOIN genUsuarios ON  genUsuarios.genUsuarios = conAsientos.Usuario_Id
		INNER JOIN genMonedas ON genMonedas.genMonedas  = conAsientos.Moneda_Id
		INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
Where
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 0 and 
		conAsientos.Empresa_Id = @pEmpresa_Id AND 
		KSKParaAutorizar.Estado = 'P' 
ORDER BY 2,3
GO

		