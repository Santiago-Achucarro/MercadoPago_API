-- exec inf_tesRendCobra '20220101','20220131',' ','zzz',1
DROP PROCEDURE inf_tesRendCobra
GO
CREATE PROCEDURE inf_tesRendCobra(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@Empresa_Id Int
)
as

SELECT genSucursalesEmpr.Sucursal, conAsientos.Fecha, 
		dbo.Segmento(genAsiSegmentosTes.Segmento_Id, genAsiSegmentosTes.Segmento1C, 
		genAsiSegmentosTes.Segmento2C, genAsiSegmentosTes.Segmento3C, genAsiSegmentosTes.Segmento4C,
		genAsiSegmentosTes.Segmento1N, genAsiSegmentosTes.Segmento2N, genAsiSegmentosTes.Segmento3N,
		genAsiSegmentosTes.Segmento4N)  Cobranza, 
		dbo.Segmento(genAsiSegmentosFac.Segmento_Id, genAsiSegmentosFac.Segmento1C, 
		genAsiSegmentosFac.Segmento2C, genAsiSegmentosFac.Segmento3C, genAsiSegmentosFac.Segmento4C,
		genAsiSegmentosFac.Segmento1N, genAsiSegmentosFac.Segmento2N, genAsiSegmentosFac.Segmento3N,
		genAsiSegmentosFac.Segmento4N)  Factura, 
		 genCancMov.importe * conAsientos.Cambio Importe, genUsuarios.Usuario_Id, 
			venClientes.Cliente_id, venClientes.RazonSocial
		FROM tesmovimientos
			inner join gencancmov ON tesmovimientos.tesMovimientos = gencancmov.Asiento_Id_Ap
			INNER JOIN venmovimientos ON venmovimientos.venmovimientos = gencancmov.Asiento_Id
			INNER JOIN conAsientos ON  conAsientos.conAsientos =tesmovimientos.tesMovimientos
			inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
			inner join genAsiSegmentos genAsiSegmentosFac ON genAsiSegmentosFac.Asiento_Id = venMovimientos.venMovimientos
			inner join genAsiSegmentos genAsiSegmentosTes ON genAsiSegmentosTes.Asiento_Id = tesMovimientos.tesMovimientos
			inner join conAsientos  conAsientosF ON conAsientosF.conAsientos = venMovimientos.venMovimientos
			INNER JOIN venClientes ON  venClientes.genEntidades = venMovimientos.Cliente_Id
			INNER JOIN genUsuarios ON  genUsuarios.genUsuarios = conAsientos.Usuario_Id
		WHERE 
		conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta AND 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and 
		genSucursalesEmpr.Sucursal BETWEEN @SucursalDesde and @SucursalHasta 
UNION ALL

SELECT genSucursalesEmpr.Sucursal,conAsientos.Fecha, 
		dbo.Segmento(genAsiSegmentosTes.Segmento_Id, genAsiSegmentosTes.Segmento1C, 
		genAsiSegmentosTes.Segmento2C, genAsiSegmentosTes.Segmento3C, genAsiSegmentosTes.Segmento4C,
		genAsiSegmentosTes.Segmento1N, genAsiSegmentosTes.Segmento2N, genAsiSegmentosTes.Segmento3N,
		genAsiSegmentosTes.Segmento4N)  Cobranza, 
		'Anticipo'  Factura, 
		 venMovimientos.Saldo * conAsientos.Cambio Importe, genUsuarios.Usuario_Id, 
			venClientes.Cliente_id, venClientes.RazonSocial
		FROM tesmovimientos
			INNER JOIN venmovimientos ON venmovimientos.venmovimientos = tesmovimientos.tesmovimientos
			INNER JOIN conAsientos ON  conAsientos.conAsientos =tesmovimientos.tesMovimientos
			inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
			inner join genAsiSegmentos genAsiSegmentosTes ON genAsiSegmentosTes.Asiento_Id = tesMovimientos.tesMovimientos
			INNER JOIN venClientes ON  venClientes.genEntidades = venMovimientos.Cliente_Id
			INNER JOIN genUsuarios ON  genUsuarios.genUsuarios = conAsientos.Usuario_Id
		WHERE 
		conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta AND 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and 
		genSucursalesEmpr.Sucursal BETWEEN @SucursalDesde and @SucursalHasta and 
		venMovimientos.Saldo >0 and 
		venMovimientos.venTipoMov = 'C'
ORDER BY 1,2,3
GO		