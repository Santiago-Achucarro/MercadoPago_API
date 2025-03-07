--INF_venFactuCabe  1, 'FC',42034,0,0,0,'F','0003','A',' '
--INF_venFactuCuerpo 1, 'FC',1,0,0,0,'F','0001',' ',' '
--INF_venFactuImpuestos 1, 'FC',766,0,0,0,'F','0004','A',' '
-- INF_venFactuComRel 1, 'FC',1,0,0,0,'F','0001',' ',' '
--INF_venFactuINE 1, 'FC',1,0,0,0,'F','0001',' ',' '

DROP PROCEDURE INF_venFactuCabe 
GO
CREATE PROCEDURE INF_venFactuCabe (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)
	)
	as
	Select N, Impuesto_Id, Descripcion, Importe Into #FacImpuestos From (
		Select ROW_NUMBER() OVER( ORDER BY TipoImpuesto ) as N, SPOrig.* From
		(SELECT venImpuestos.Impuesto_Id, venImpuestos.Descripcion, venMovImpuestos.Importe, venImpuestos.TipoImpuesto
		FROM venMovImpuestos 
		INNER JOIN venImpuestos ON venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos
		Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovImpuestos.venMovimientos
		Where 
		genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N And
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
		) SpOrig) a
	Select genAsiSegmentos.Asiento_Id, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	conAsientos.Fecha, conAsientos.FechaRegistro, conAsientos.Cambio, conAsientos.CambioMonedaOriginal,
	venClientes.Cliente_Id, venClientes.RazonSocial, genEntidades.Cuit,
	venClieHabitual.NombreFantasia, venClieHabitual.Direccion1_Fact, 
	venClieHabitual.NroExterior_Fact, venClieHabitual.NroInterior_Fact,
	venClieHabitual.Direccion2_Fact, venClieHabitual.Localidad_Fact, 
	venClieHabitual.CodPostal_Fact, genProvincias.Provincia_Id AS Provincia_Id_Fact,
	genProvincias.Descripcion AS DescripcionProvincia_Id_Fact, genProvincias.CodFiscal as CodFiscalProv,
	genPaises.Pais_Id as Pais_Id_Fact, genPaises.Descripcion as DescripcionPais_Id,

	venClieHabitual.Direccion1_Entr, 
	venClieHabitual.NroExterior_Entr, venClieHabitual.NroInterior_Entr,
	venClieHabitual.Direccion2_Entr, venClieHabitual.Localidad_Entr, 
	venClieHabitual.CodPostal_Entr, genProvinciasE.Provincia_Id AS Provincia_Id_Entr,
	genProvinciasE.Descripcion AS DescripcionProvincia_Id_Entr, 
	genPaisesE.Pais_Id as Pais_Id_Entr, genPaisesE.Descripcion as DescripcionPaisEntr,
	venSubTipoMov.SubTipoMov_Id, 
	venSubTipoMov.Descripcion as DescripcionSubTipoMov,
	venMovimientos.Importe, conAsientos.Observaciones, 
	venMovimientosFiscal.ClaveFiscal, venMovimientosFiscal.Fecha as FechaFiscal, venMovimientosMetodoPago.UsoCfdi, 
	venMovimientosMetodoPago.MetodoPago as FormaPago, EntidadBasica.Descripcion as DescripcionFormaPago
	, venMovimientosMetodoPago.NMetodoPago, NEntidadBasica.Descripcion as NMetodoPagoDescripcion,
	venMovimientosFiscal.SelloDigital, venMovimientosFiscal.FechaString as FechaTimbre, 
	venMovimientosFiscal.SelloFiscal, venMovimientosFiscal.NoCertificadoFiscal, 
	venMovimientosFiscal.NoCertificadoPropio, venMovimientosFiscal.RfcProvCertif, 
	venMovimientosFiscal.TipoProceso, venMovimientosFiscal.TipoComite, venMovimientosFiscal.idContabilidad,
	genAsiSegmentos.Segmento1N,venTipoMov.Signo, genMonedas.Moneda_Id, genMonedas.Descripcion AS DescripcionMoneda, genMonedas.Simbolo,
	genMonedas.CodigoFiscal as MonedaFiscal, venCondFiscal.CondFisc_Id, venCondFiscal.Descripcion DescripcionCondFiscal, venCondFiscal.CodigoFiscal,
	IsNull(venMovimientosFiscal.Comprobante_Id, 0) TipoComprobante, venCondPago.CondPagoCli_Id,
	venCondPago.Descripcion DescripcionCondPago, venTipoMov.Descripcion DescripcionTipoMov,
		IsNull(Imp1.Impuesto_Id, '') Imp1,
		IsNull(Imp1.Descripcion, '') ImpDesc1,
		IsNull(Imp1.Importe, 0) ImpImporte1,
		IsNull(Imp2.Impuesto_Id, '') Imp2,
		IsNull(Imp2.Descripcion, '') ImpDesc2,
		IsNull(Imp2.Importe, 0) ImpImporte2,
		IsNull(Imp3.Impuesto_Id, '') Imp3,
		IsNull(Imp3.Descripcion, '') ImpDesc3,
		IsNull(Imp3.Importe, 0) ImpImporte3,
		IsNull(Imp4.Impuesto_Id, '') Imp4,
		IsNull(Imp4.Descripcion, '') ImpDesc4,
		IsNull(Imp4.Importe, 0) ImpImporte4,
		IsNull(Imp5.Impuesto_Id, '') Imp5,
		IsNull(Imp5.Descripcion, '') ImpDesc5,
		IsNull(Imp5.Importe, 0) ImpImporte5,
		venMovimientos.Bonificacion1 + venMovimientos.Bonificacion2 + venMovimientos.Bonificacion3 + venMovimientos.Bonificacion4 + venMovimientos.Bonificacion5 Bonificacion,
	isnull(venClientes.CbuBanco, venClieHabitual.numCuenta)  CbuBanco, (Select Max(FechaVencimiento) From genMovCuotas Where genMovCuotas.Asiento_Id = venMovimientos.venMovimientos) FechaVencimiento, 
		ISNULL(dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C,
		venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,
		venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,
		venPediSegmentos.Segmento4N), ' ') AS Pedido,
		ISNULL(venPedidos.CliOrdenCompra,' ') AS CliOrdenCompra,
		ISNULL(venPedidos.venNroPedido,' ') AS venNroPedido, 
		venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVendedor, 
		genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as NombreUsuario, genUsuarios.Email as eMailUsuario,
		venClieHabitual.EMail MailCliente, venClieHabitual.Telefonos TelefonoCliente, 
		Usos.Descripcion as DescUsoCfdi, genTiposDoc.TipoDoc,
		CAST(
             CASE
                  WHEN conAsientos.Anulado = 1 or conAsientosAnul.FechaAnulacion is not null
                     THEN 1
                  ELSE 0
             END AS bit) as Anulado, ISNULL(venClientes.Regimen,'') AS Regimen, 
			 ISNULL(Regimenes.Descripcion,'') AS DescripcionRegimen,
			 isnull(stuff((
                SELECT ''+ A FROM (Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
                genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
                genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) a
                From stkRemitos
                INNER JOIN genAsiSegmentos ON genAsisegmentos.Asiento_Id = stkRemitos.stkMoviCabe
                INNER JOIN (SELECT DISTINCT venMovStkHist.venMovimientos, venMovStkHist.stkMoviCabe
                    FROM venMovStkHist
                    INNER JOIN venMovConStockcr ON venmovconstockcr.venmovimientos = venMovStkHist.venMovimientos) Rem ON
                    Rem.venMovimientos = venMovimientos.venMovimientos AND Rem.stkMoviCabe = stkRemitos.stkMoviCabe) b
                FOR XML PATH ('')),1,1,''),'') Remitos,
	venMovimientos.Dato1, venMovimientos.Dato2, venMovimientos.Dato3, 
	ISNULL(conMovCont.LeyendaLibroMayor,'') DescOtrosCargos, ISNULL(conMovCont.ImporteMonedaOriginal,0) ImpOtCargos 
	From genAsiSegmentos 
	Inner join genSegmentos on genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
	INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genEntidades ON genEntidades.genEntidades =venMovimientos.Cliente_Id 
	Inner join venClientes ON venClientes.genEntidades = genEntidades.genEntidades 
	INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id and 
		venClieHabitual.Sucursal =venMovimientos.Sucursal
	INNER JOIN genProvincias ON	genProvincias.genProvincias = venClieHabitual.Provincia_Id_Fact
	INNER JOIN genPaises ON	genPaises.genPaises = venClieHabitual.Pais_Id_Fact
	INNER JOIN genProvincias genProvinciasE ON	genProvinciasE.genProvincias = venClieHabitual.Provincia_Id_Entr
	INNER JOIN genPaises genPaisesE ON	genPaisesE.genPaises = venClieHabitual.Pais_Id_Entr
	INNER JOIN venSubTipoMov ON	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	LEFT JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
	INNER JOIN genUsuarios ON  genUsuarios.genUsuarios = conAsientos.Usuario_Id
	LEFT JOIN venMovimientosFiscal ON venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
	left join venMovimientosMetodoPago on venMovimientosMetodoPago.venMovimientos=venMovimientos.venMovimientos
	left join genEntidadesBasicasValor NEntidadBasica on NEntidadBasica.Entidad_Id=7 and NEntidadBasica.Dominio_Id='MX' and NEntidadBasica.Clave=venMovimientosMetodoPago.NMetodoPago
	left join genEntidadesBasicasValor EntidadBasica on EntidadBasica.Entidad_Id=6 and EntidadBasica.Dominio_Id='MX' and EntidadBasica.Clave=venMovimientosMetodoPago.MetodoPago
	left join genEntidadesBasicasValor Usos on Usos.Entidad_Id=4 and Usos.Dominio_Id='MX' and Usos.Clave=venMovimientosMetodoPago.UsoCfdi
	inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
	LEFT Join venCondFiscal On venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
	LEFT Join venCondPago On venCondPago.venCondPago = venMovimientos.CondPagoCli_Id
	Left Join #FacImpuestos Imp1 On Imp1.N = 1
	Left Join #FacImpuestos Imp2 On Imp2.N = 2
	Left Join #FacImpuestos Imp3 On Imp3.N = 3
	Left Join #FacImpuestos Imp4 On Imp4.N = 4
	Left Join #FacImpuestos Imp5 On Imp5.N >= 5
	LEFT join ((SELECT DISTINCT venMovConStockCrPed.venMovimientos, 
		venMovConStockCrPed.venPedidos  FROM venMovConStockCrPed) as venMovConStockCrPed 
		inner join venPedidos ON  venMovConStockCrPed.venPedidos = venPedidos.venPedidos
		INNER JOIN venPediSegmentos ON 	venPediSegmentos.venPedidos = venPedidos.venPedidos) ON
		venMovConStockCrPed.venMovimientos = venMovimientos.venMovimientos
	CROSS JOIN genInstalacion
	Left Join genTiposDoc On genTiposDoc.TipoDoc = genEntidades.TipoDoc and 
		genTiposDoc.Dominio_Id =genInstalacion.Dominio_Id
	left join genEntidadesBasicasValor Regimenes on 
		Regimenes.Entidad_Id = 505 and 
		Regimenes.Clave = venClientes.Regimen and 
		Regimenes.Dominio_Id = 'MX'
	/*
	Left Join _FacImpuestos Imp1 On Imp1.N = 1
	Left Join _FacImpuestos Imp2 On Imp2.N = 2
	Left Join _FacImpuestos Imp3 On Imp3.N = 3
	Left Join _FacImpuestos Imp4 On Imp4.N = 4
	Left Join _FacImpuestos Imp5 On Imp5.N >= 5
	*/
	left join conAsientosAnul on conAsientos.conAsientos= conAsientosAnul.Asiento_Id
	LEFT JOIN conMovCont ON venMovimientos.venMovimientos = conMovCont.conAsientos AND
		venMovimientos.RenglonCtaOtCargos = conMovCont.Renglon
	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  and 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
UNION ALL -- CARTA PORTE TRAE EL CLIENTE EN NUKK
	Select genAsiSegmentos.Asiento_Id, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	conAsientos.Fecha, conAsientos.FechaRegistro, conAsientos.Cambio, conAsientos.CambioMonedaOriginal,
	' ' Cliente_Id, genEmpresas.RazonSocial, genEmpresas.Cuit,
	genEmpresas.RazonSocial, genEmpresas.Calle, 
	genEmpresas.NoExterior, genEmpresas.NoInterior,
	genEmpresas.Colonia, genEmpresas.Localidad, 
	genEmpresas.CodigoPostal, genProvincias.Provincia_Id AS Provincia_Id_Fact,
	genProvincias.Descripcion AS DescripcionProvincia_Id_Fact, genProvincias.CodFiscal as CodFiscalProv,
	genPaises.Pais_Id as Pais_Id_Fact, genPaises.Descripcion as DescripcionPais_Id,
	genSucursalesEmpr.Direccion, 
	' ', ' ',
	' ', genSucursalesEmpr.Localidad, 
	genSucursalesEmpr.CodigoPostal, genProvinciasE.Provincia_Id AS Provincia_Id_Entr,
	genProvinciasE.Descripcion AS DescripcionProvincia_Id_Entr, 
	genPaisesE.Pais_Id as Pais_Id_Entr, genPaisesE.Descripcion as DescripcionPaisEntr,
	venSubTipoMov.SubTipoMov_Id, 
	venSubTipoMov.Descripcion as DescripcionSubTipoMov,
	venMovimientos.Importe, conAsientos.Observaciones, 
	venMovimientosFiscal.ClaveFiscal, venMovimientosFiscal.Fecha as FechaFiscal, venMovimientosMetodoPago.UsoCfdi, 
	venMovimientosMetodoPago.MetodoPago as FormaPago, EntidadBasica.Descripcion as DescripcionFormaPago
	, venMovimientosMetodoPago.NMetodoPago, NEntidadBasica.Descripcion as NMetodoPagoDescripcion,
	venMovimientosFiscal.SelloDigital, venMovimientosFiscal.FechaString as FechaTimbre, 
	venMovimientosFiscal.SelloFiscal, venMovimientosFiscal.NoCertificadoFiscal, 
	venMovimientosFiscal.NoCertificadoPropio, venMovimientosFiscal.RfcProvCertif, 
	venMovimientosFiscal.TipoProceso, venMovimientosFiscal.TipoComite, venMovimientosFiscal.idContabilidad,
	genAsiSegmentos.Segmento1N,venTipoMov.Signo, 'XXX' Moneda_Id, ' ' AS DescripcionMoneda, ' ' Simbolo,
	'XXX' as MonedaFiscal, ' ' CondFisc_Id, ' ' DescripcionCondFiscal, ' ' CodigoFiscal,
	IsNull(venMovimientosFiscal.Comprobante_Id, 0) TipoComprobante, ' ' CondPagoCli_Id,
	' ' DescripcionCondPago, venTipoMov.Descripcion DescripcionTipoMov,
		IsNull(Imp1.Impuesto_Id, '') Imp1,
		IsNull(Imp1.Descripcion, '') ImpDesc1,
		IsNull(Imp1.Importe, 0) ImpImporte1,
		IsNull(Imp2.Impuesto_Id, '') Imp2,
		IsNull(Imp2.Descripcion, '') ImpDesc2,
		IsNull(Imp2.Importe, 0) ImpImporte2,
		IsNull(Imp3.Impuesto_Id, '') Imp3,
		IsNull(Imp3.Descripcion, '') ImpDesc3,
		IsNull(Imp3.Importe, 0) ImpImporte3,
		IsNull(Imp4.Impuesto_Id, '') Imp4,
		IsNull(Imp4.Descripcion, '') ImpDesc4,
		IsNull(Imp4.Importe, 0) ImpImporte4,
		IsNull(Imp5.Impuesto_Id, '') Imp5,
		IsNull(Imp5.Descripcion, '') ImpDesc5,
		IsNull(Imp5.Importe, 0) ImpImporte5,
		venMovimientos.Bonificacion1 + venMovimientos.Bonificacion2 + venMovimientos.Bonificacion3 + venMovimientos.Bonificacion4 + venMovimientos.Bonificacion5 Bonificacion,
		' ' CbuBanco, (Select Max(FechaVencimiento) From genMovCuotas Where genMovCuotas.Asiento_Id = venMovimientos.venMovimientos) FechaVencimiento, 
		ISNULL(dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C,
		venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,
		venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,
		venPediSegmentos.Segmento4N), ' ') AS Pedido,
		ISNULL(venPedidos.CliOrdenCompra,' ') AS CliOrdenCompra,
		ISNULL(venPedidos.venNroPedido,' ') AS venNroPedido, 
		' ' Vendedor_Id, ' ' as NombreVendedor, 
		genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as NombreUsuario, genUsuarios.Email as eMailUsuario,
		' ' MailCliente, ' ' TelefonoCliente, 
		Usos.Descripcion as DescUsoCfdi, 0 TipoDoc,
		CAST(
             CASE
                  WHEN conAsientos.Anulado = 1 or conAsientosAnul.FechaAnulacion is not null
                     THEN 1
                  ELSE 0
             END AS bit) as Anulado, 
			 ISNULL(genEmpresas.Regimen,'') AS Regimen,
			 ISNULL(Regimenes.Descripcion,'') AS DescripcionRegimen,
			 isnull(stuff((
                SELECT ''+ A FROM (Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
                genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
                genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) a
                From stkRemitos
                INNER JOIN genAsiSegmentos ON genAsisegmentos.Asiento_Id = stkRemitos.stkMoviCabe
                INNER JOIN (SELECT DISTINCT venMovStkHist.venMovimientos, venMovStkHist.stkMoviCabe
                    FROM venMovStkHist
                    INNER JOIN venMovConStockcr ON venmovconstockcr.venmovimientos = venMovStkHist.venMovimientos) Rem ON
                    Rem.venMovimientos = venMovimientos.venMovimientos AND Rem.stkMoviCabe = stkRemitos.stkMoviCabe) b
                FOR XML PATH ('')),1,1,''),'') Remitos,
	venMovimientos.Dato1, venMovimientos.Dato2, venMovimientos.Dato3,
	ISNULL(conMovCont.LeyendaLibroMayor,'') DescOtrosCargos, ISNULL(conMovCont.ImporteMonedaOriginal,0) ImpOtCargos
	From genAsiSegmentos 
	Inner join genSegmentos on genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
	INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
	INNER JOIN genProvincias ON	genProvincias.genProvincias = genEmpresas.Provincia_Id
	INNER JOIN genPaises ON	genPaises.genPaises = genEmpresas.Pais_Id
	INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	INNER JOIN genProvincias genProvinciasE ON	genProvinciasE.genProvincias = genSucursalesEmpr.Provincia_Id
	INNER JOIN genPaises genPaisesE ON	genPaisesE.genPaises = genSucursalesEmpr.Pais_Id
	INNER JOIN venSubTipoMov ON	venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN genUsuarios ON  genUsuarios.genUsuarios = conAsientos.Usuario_Id
	LEFT JOIN venMovimientosFiscal ON venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
	left join venMovimientosMetodoPago on venMovimientosMetodoPago.venMovimientos=venMovimientos.venMovimientos
	left join genEntidadesBasicasValor NEntidadBasica on NEntidadBasica.Entidad_Id=7 and NEntidadBasica.Dominio_Id='MX' and NEntidadBasica.Clave=venMovimientosMetodoPago.NMetodoPago
	left join genEntidadesBasicasValor EntidadBasica on EntidadBasica.Entidad_Id=6 and EntidadBasica.Dominio_Id='MX' and EntidadBasica.Clave=venMovimientosMetodoPago.MetodoPago
	left join genEntidadesBasicasValor Usos on Usos.Entidad_Id=4 and Usos.Dominio_Id='MX' and Usos.Clave=venMovimientosMetodoPago.UsoCfdi
	inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
	--Inner Join venCondFiscal On venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
	--Inner Join venCondPago On venCondPago.venCondPago = venMovimientos.CondPagoCli_Id
	Left Join #FacImpuestos Imp1 On Imp1.N = 1
	Left Join #FacImpuestos Imp2 On Imp2.N = 2
	Left Join #FacImpuestos Imp3 On Imp3.N = 3
	Left Join #FacImpuestos Imp4 On Imp4.N = 4
	Left Join #FacImpuestos Imp5 On Imp5.N >= 5
	LEFT join ((SELECT DISTINCT venMovConStockCrPed.venMovimientos, 
		venMovConStockCrPed.venPedidos  FROM venMovConStockCrPed) as venMovConStockCrPed 
		inner join venPedidos ON  venMovConStockCrPed.venPedidos = venPedidos.venPedidos
		INNER JOIN venPediSegmentos ON 	venPediSegmentos.venPedidos = venPedidos.venPedidos) ON
		venMovConStockCrPed.venMovimientos = venMovimientos.venMovimientos
	CROSS JOIN genInstalacion
	/*
	Left Join _FacImpuestos Imp1 On Imp1.N = 1
	Left Join _FacImpuestos Imp2 On Imp2.N = 2
	Left Join _FacImpuestos Imp3 On Imp3.N = 3
	Left Join _FacImpuestos Imp4 On Imp4.N = 4
	Left Join _FacImpuestos Imp5 On Imp5.N >= 5
	*/
	left join conAsientosAnul on conAsientos.conAsientos= conAsientosAnul.Asiento_Id
	left join genEntidadesBasicasValor Regimenes on 
		Regimenes.Entidad_Id = 505 and 
		Regimenes.Clave = genEmpresas.Regimen and 
		Regimenes.Dominio_Id = 'MX'
	LEFT JOIN conMovCont ON venMovimientos.venMovimientos = conMovCont.conAsientos AND
		venMovimientos.RenglonCtaOtCargos = conMovCont.Renglon
	Where
		venMovimientos.Cliente_Id IS NULL AND 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  and 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id		
	Drop table #FacImpuestos

GO

-- AO: Dejo este Script para usarlo como cursor al modificar un Informe, obviamente hay que agregar el campo en la consulta del SP original
-- y luego en la de Abajo
--/*
--DROP PROCEDURE INF_venFactuCabe
--Go
--CREATE PROCEDURE INF_venFactuCabe
--(
--	@pEmpresa_Id int, 
--	@pSegmento_Id VarChar(10), 
--	@pSegmento1N int,
--	@pSegmento2N int,
--	@pSegmento3N int,
--	@pSegmento4N int,
--	@pSegmento1C VarChar(20),
--	@pSegmento2C VarChar(20),
--	@pSegmento3C VarChar(20),
--	@pSegmento4C VarChar(20)
--	)
--	as
--SELECT 0 Asiento_Id, '' SegmentoStr, '' Segmento_Id, '' Segmento1C,
--	'' Segmento2C, '' Segmento3C, '' Segmento4C, 0 Segmento1N, 0 Segmento2N, 0 Segmento3N, 0 Segmento4N, 
--	GETDATE() Fecha, GETDATE() FechaRegistro, 0.00 Cambio, 0.00 CambioMonedaOriginal,
--	'' Cliente_Id, '' RazonSocial, '' Cuit,'' NombreFantasia, '' Direccion1_Fact, 
--	'' NroExterior_Fact, '' NroInterior_Fact, '' Direccion2_Fact, '' Localidad_Fact, 
--	'' CodPostal_Fact, '' Provincia_Id_Fact, '' DescripcionProvincia_Id_Fact, '' CodFiscalProv,
--	0 Pais_Id_Fact, '' DescripcionPais_Id, '' Direccion1_Entr, 	'' NroExterior_Entr, '' NroInterior_Entr,
--	'' Direccion2_Entr, '' Localidad_Entr, '' CodPostal_Entr, '' Provincia_Id_Entr,
--	'' DescripcionProvincia_Id_Entr, '' Pais_Id_Entr, '' DescripcionPaisEntr, '' SubTipoMov_Id, 
--	'' DescripcionSubTipoMov, 0.00 Importe, '' Observaciones, 	'' ClaveFiscal, GETDATE() FechaFiscal, '' UsoCfdi, 
--	'' FormaPago, '' DescripcionFormaPago, '' NMetodoPago, '' NMetodoPagoDescripcion,
--	'' SelloDigital, '' FechaTimbre, '' SelloFiscal, '' NoCertificadoFiscal, 
--	'' NoCertificadoPropio, '' RfcProvCertif, '' TipoProceso, '' TipoComite, 0.00 idContabilidad,
--	0 Segmento1N,0 Signo, '' Moneda_Id, '' DescripcionMoneda, '' Simbolo, '' MonedaFiscal, '' CondFisc_Id, '' DescripcionCondFiscal, 
--	'' CodigoFiscal, 0 TipoComprobante, '' CondPagoCli_Id, '' DescripcionCondPago, '' DescripcionTipoMov,
--	'' Imp1, 	'' ImpDesc1, 	0.00 ImpImporte1, 	'' Imp2, 	'' ImpDesc2, 	0.00 ImpImporte2, 	'' Imp3, 	'' ImpDesc3, 0.00 ImpImporte3,
--	'' Imp4, 	'' ImpDesc4, 	0.00 ImpImporte4, 	'' Imp5, 	'' ImpDesc5, 	0.00 ImpImporte5, 	0.00 Bonificacion,
--	''  CbuBanco, GETDATE() FechaVencimiento, '' Pedido,
--	'' CliOrdenCompra, 	'' venNroPedido, '' Vendedor_Id, '' NombreVendedor, 
--	'' Usuario_Id, '' NombreUsuario, '' eMailUsuario, '' MailCliente, '' TelefonoCliente, 
--	'' DescUsoCfdi, '' TipoDoc, 0 Anulado, '' Regimen, 
--	'' DescripcionRegimen, '' Remitos, 0 Dato1, 0 Dato2, 0 Dato3, DescOtrosCargos, ImpOtCargos
--GO
--*/

DROP PROCEDURE INF_venFactuCuerpo
GO
CREATE PROCEDURE INF_venFactuCuerpo (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)


	AS

	SELECT venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, 
		stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		MedidaMov.Medida_Id as MedidaMov, MedidaMov.CodigoFiscal as FiscalMedidaMov,
		Alterna.Medida_Id as MedidaAlterna,
		venMovConStockCr.CantFacturada, venMovConStockCr.CantOriginal, 
		venMovConStockCr.CantEntregada, venMovConStockCr.CantidadAlternaForm as CantidadAlterna, 
		venMovConStockCr.PrecioForm, venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta, 
		venMovConStockCr.PrecioFormImpuesto, venMovConStockCr.PrecioFormImpuestoBon, 
		venMovConStockCr.PrecioFormImpuestoTot, venMovConStockCr.Observaciones, 
		venMovconStockcr.Bonificacion,
		--Convert(Numeric(18,2), (CantFacturada*PrecioForm * (1-Bonificacion/100))) as SubTotal, FM Arreglamos con AJ volver a la vida el campo original
		venMovConStockCr.SubTotal,
		venMovConStockCr.SubTotalFormImpuesto, 
		stkProductos.CodigoFiscal as ClaveSat,
		/* para MEXICO */
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos AND 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '002'),0) as IVA,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos  and 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '001'),0) as ISR,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos  and 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '003'),0) as IEPS, 
				
		ISNULL((SELECT TOP 1
		ISNULL(comDespachos.Anio,'XX') + '  ' + ISNULL(comDespachos.Aduana_id,'XX')+'  '+
			ISNULL(comDespachos.Patente,'XXXX')	+ '  ' +
			left('0000000', 7-len(Ltrim(str(ISNULL(comDespachos.Pedimento,0),7))))+ Ltrim(str(ISNULL(comDespachos.Pedimento,0),7)) 
			From venMovStkHist INNER JOIN stkMoviDespa ON
				venMovConStockCr.venMovimientos =  venMovStkHist.venMovimientos and 
				venMovConStockCr.RenglonCuerpo = venMovStkHist.RenglonCuerpo and 
				stkMoviDespa.stkMoviCabe = venMovStkHist.stkMoviCabe and 
				stkMoviDespa.Renglon  = venMovStkHist.Renglon
				INNER JOIN comDespachos ON 
				comDespachos.comDespachos = stkMoviDespa.Despacho_Id
				Where
				comDespachos.Pedimento > 0 ),' ')  as Despacho, 
				' ' as Serie, '' Predial
				
		
	from venMovConStockCr inner join genAsiSegmentos ON
		venMovConStockCr.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON 
		stkProductos.stkProductos = venMovConStockCr.Producto_Id
		inner join stkUniMed on 
		stkUniMed.stkUniMed = stkProductos.Medida_Id
		inner join stkUniMed as MedidaMov on 
		MedidaMov.stkUniMed = venMovConStockCr.Medida_Id
		LEFT OUTER JOIN stkUniMed AS Alterna on
		Alterna.stkUniMed = stkProductos.MedidaAlterna

	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  AND 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id And
		NOT EXISTS(SELECT 1 FROM stkMoviSerie INNER JOIN venMovStkHist ON
			stkMoviSerie.stkMoviCabe = venMovStkHist.stkMoviCabe AND 
			stkMoviSerie.Renglon =venMovStkHist.Renglon AND 
			venMovStkHist.venMovimientos = venMovConStockCr.venMovimientos and 
			venMovStkHist.RenglonCuerpo = venMovConStockCr.RenglonCuerpo )
UNION ALL -- SERIE

	SELECT venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, 
		stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		MedidaMov.Medida_Id as MedidaMov, MedidaMov.CodigoFiscal as FiscalMedidaMov,
		Alterna.Medida_Id as MedidaAlterna,
		stkMoviSerie.Cantidad,  stkMoviSerie.Cantidad CantOriginal, 
		stkMoviSerie.Cantidad CantEntregada, venMovConStockCr.CantidadAlternaForm as CantidadAlterna, 
		venMovConStockCr.PrecioForm, venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta, 
		venMovConStockCr.PrecioFormImpuesto, venMovConStockCr.PrecioFormImpuestoBon, 
		venMovConStockCr.PrecioFormImpuestoTot, venMovConStockCr.Observaciones, 
		venMovconStockcr.Bonificacion, 
		venMovConStockCr.SubTotal, venMovConStockCr.SubTotalFormImpuesto,
		stkProductos.CodigoFiscal as ClaveSat,
		/* para MEXICO */
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '002'),0)/venMovConStockCr.CantFacturada * stkMoviSerie.Cantidad as IVA,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '001'),0)/venMovConStockCr.CantFacturada * stkMoviSerie.Cantidad as ISR,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '003'),0) /venMovConStockCr.CantFacturada * stkMoviSerie.Cantidad as IEPS, 
				
		ISNULL((SELECT TOP 1
		ISNULL(comDespachos.Anio,'XX') + '  ' + ISNULL(comDespachos.Aduana_id,'XX')+'  '+
			ISNULL(comDespachos.Patente,'XXXX')	+ '  ' +
			left('0000000', 7-len(Ltrim(str(ISNULL(comDespachos.Pedimento,0),7))))+ Ltrim(str(ISNULL(comDespachos.Pedimento,0),7)) 
			From venMovStkHist INNER JOIN stkMoviDespa ON
				venMovConStockCr.venMovimientos =  venMovStkHist.venMovimientos and 
				venMovConStockCr.RenglonCuerpo = venMovStkHist.RenglonCuerpo and 
				stkMoviDespa.stkMoviCabe = venMovStkHist.stkMoviCabe and 
				stkMoviDespa.Renglon  = venMovStkHist.Renglon
				INNER JOIN comDespachos ON 
				comDespachos.comDespachos = stkMoviDespa.Despacho_Id
				Where
				comDespachos.Pedimento > 0),' ') as Despacho, 
				stkMoviSerie.Serie, '' Predial
				
		
	from 
		venMovConStockCr inner join venMovStkHist ON
			venMovStkHist.venMovimientos = venMovConStockCr.venMovimientos and 
			venMovStkHist.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
			INNER JOIN stkMoviSerie ON
			stkMoviSerie.stkMoviCabe = venMovStkHist.stkMoviCabe AND 
			stkMoviSerie.Renglon =venMovStkHist.Renglon
		INNER JOIN  genAsiSegmentos ON
		venMovConStockCr.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON 
		stkProductos.stkProductos = venMovConStockCr.Producto_Id
		inner join stkUniMed on 
		stkUniMed.stkUniMed = stkProductos.Medida_Id
		inner join stkUniMed as MedidaMov on 
		MedidaMov.stkUniMed = venMovConStockCr.Medida_Id
		LEFT OUTER JOIN stkUniMed AS Alterna on
		Alterna.stkUniMed = stkProductos.MedidaAlterna

	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N And
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
	
union all
	SELECT venMovDetalle.conRenglon RenglonCuerpo, venMovDetalle.Producto_Id, 
		venMovDetalle.Detalle, venMovDetalle.Detalle DescripcionDetallada, venMovDetalle.Detalle Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		stkUniMed.Medida_Id as MedidaMov, stkUniMed.CodigoFiscal as FiscalMedidaMov,
		' ' MedidaAlterna,
		venMovDetalle.Cantidad, venMovDetalle.Cantidad CantOriginal, 
		venMovDetalle.Cantidad CantEntregada, 0 as CantidadAlterna, 
		venMovDetalle.ImporteUnitario as PrecioForm, venMovDetalle.ImporteUnitario PrecioLista, 
		venMovDetalle.ImporteUnitario PrecioVenta, 
		venMovDetalle.ImporteUnitarioDelImpuesto PrecioFormImpuesto, venMovDetalle.ImporteUnitarioDelImpuesto PrecioFormImpuestoBon, 
		venMovDetalle.ImporteUnitarioDelImpuesto * venMovDetalle.Cantidad PrecioFormImpuestoTot, 
		'' as Observaciones, 
		0.00 Bonificacion,
		Convert(Numeric(19,2),venMovDetalle.Cantidad * venMovDetalle.ImporteUnitario) as SubTotal  , 
		Convert(Numeric(19,2),venMovDetalle.ImporteUnitarioDelImpuesto * venMovDetalle.Cantidad) SubTotalFormImpuesto, 
		venMovDetalle.CodigoFiscal as ClaveSat, 
		/* para MEXICO */
		ISNULL((SELECT SUM(venMovSSImpuestos.Importe) 
			from venMovSSImpuestos inner join venImpuestos ON 
				venMovSSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovSSImpuestos.conRenglon = venmovDetalle.conRenglon and 
				venMovSSImpuestos.venMovimientos = venMovDetalle.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '002'),0) as IVA,
		ISNULL((SELECT SUM(venMovSSImpuestos.Importe) 
			from venMovSSImpuestos inner join venImpuestos ON 
				venMovSSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovSSImpuestos.conRenglon = venmovDetalle.conRenglon and 
				venMovSSImpuestos.venMovimientos = venMovDetalle.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '001'),0) as ISR,
		ISNULL((SELECT SUM(venMovSSImpuestos.Importe) 
			from venMovSSImpuestos inner join venImpuestos ON 
				venMovSSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovSSImpuestos.conRenglon = venmovDetalle.conRenglon and 
				venMovSSImpuestos.venMovimientos = venMovDetalle.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '003'),0) as IEPS, 
				' ' as Despacho, ' ' as Serie, isnull(venMoviPredial.CuentaPredial,'') as Predial
		
	from venMovDetalle inner join genAsiSegmentos ON
		venMovDetalle.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		Left outer join stkUniMed on 
		stkUniMed.stkUniMed = venMovDetalle.Medida_Id
		LEFT JOIN venMoviPredial ON 
		venMoviPredial.venMovimientos = venMovDetalle.venMovimientos and 
		venMoviPredial.conRenglon  = 	venMovDetalle.conRenglon
		
	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
		-- CARTA PORTE
UNION ALL
SELECT venCompCartaPorteMercancia.Renglon RenglonCuerpo, ' ' Producto_Id, 
		venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Descripcion, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		stkUniMed.Medida_Id as MedidaMov, stkUniMed.CodigoFiscal as FiscalMedidaMov,
		' ' as MedidaAlterna,
		venCompCartaPorteMercancia.Cantidad CantFacturada, venCompCartaPorteMercancia.Cantidad CantOriginal, 
		venCompCartaPorteMercancia.Cantidad CantEntregada, 0 as CantidadAlterna, 
		0 PrecioForm, 0 PrecioLista, 0 PrecioVenta, 
		0 PrecioFormImpuesto, 0 PrecioFormImpuestoBon, 
		0 PrecioFormImpuestoTot, '' Observaciones, 
		0 Bonificacion,
		--Convert(Numeric(18,2), (CantFacturada*PrecioForm * (1-Bonificacion/100))) as SubTotal, FM Arreglamos con AJ volver a la vida el campo original
		0 SubTotal,
		0 SubTotalFormImpuesto, 
		venCompCartaPorteMercancia.BienesTransp as ClaveSat,
		/* para MEXICO */
		0 as IVA,
		0 as ISR,
		0 as IEPS, 	''	 as Despacho, 
				' ' as Serie, '' Predial
		
	from venCompCartaPorteMercancia inner join genAsiSegmentos ON
		venCompCartaPorteMercancia.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		inner join stkUniMed on 
		stkUniMed.stkUniMed = venCompCartaPorteMercancia.Medida_Id
		inner join venMovimientos ON  venMovimientos.venMovimientos = venCompCartaPorteMercancia.venmovimientos
	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  AND 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id AND 
		venMovimientos.venTipomov = 'M'
	ORDER BY 1

GO


DROP PROCEDURE INF_venFactuImpuestos
GO
CREATE PROCEDURE INF_venFactuImpuestos(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)


	AS
	Select * From (
		Select ROW_NUMBER() OVER( ORDER BY TipoImpuesto ) as N, SPOrig.* From
		(SELECT venImpuestos.Impuesto_Id, venImpuestos.Descripcion, venImpuestos.TipoImpuesto,
		venMovImpuestos.BaseImponible, venMovImpuestos.Porcentaje, venMovImpuestos.Importe
		FROM venMovImpuestos 
		INNER JOIN venImpuestos ON venMovImpuestos.Impuesto_Id = venImpuestos.venImpuestos
		inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovImpuestos.venMovimientos
		INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id ) SpOrig
	) a
	order by 1



GO

DROP PROCEDURE INF_venFactuComRel
GO
CREATE PROCEDURE INF_venFactuComRel (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)


	AS



	SELECT TipoRelacion, venMovimientosFiscal.ClaveFiscal UUID 
	FROM venMovimientosCFDIR INNER JOIN venMovimientosFiscal ON
		venMovimientosCFDIR.venMovimientosR = venMovimientosFiscal.venMovimientos
		INNER JOIN genAsiSegmentos ON 
		genAsiSegmentos.Asiento_Id =venMovimientosCFDIR.venMovimientos
		INNER JOIN genSegmentos ON 
		genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		Where 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  and 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
		order by 2

GO


DROP PROCEDURE INF_venFactuINE
GO
CREATE PROCEDURE INF_venFactuINE (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)


	AS



	SELECT Ambito, ClaveIdentidad , idContabilidad 
		FROM venMovimientosFiscalINE	INNER JOIN genAsiSegmentos ON 
		genAsiSegmentos.Asiento_Id =venMovimientosFiscalINE.venMovimientos
		INNER JOIN genSegmentos ON 
		genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		Where 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
		order by 2

GO


DROP PROCEDURE INF_venFactuExpedicion
GO
CREATE PROCEDURE INF_venFactuExpedicion (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)


	AS



	SELECT genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion, genSucursalesEmpr.Serie,
		genSucursalesEmpr.Direccion, genSucursalesEmpr.Localidad, 
		genProvincias.Provincia_Id,genProvincias.Descripcion as DescripcionProvincia,
		genPaises.Pais_Id, genPaises.Descripcion as DescripcionPais,
		genSucursalesEmpr.CodigoPostal, genSucursalesEmpr.Telefono
		FROM genAsiSegmentos INNER JOIN conAsientos ON 	genAsiSegmentos.Asiento_Id =conAsientos.conAsientos 
		INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
		INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		INNER JOIN genProvincias ON  genProvincias.genProvincias = genSucursalesEmpr.Provincia_Id 
		INNER JOIN genPaises ON  genPaises.genPaises = genSucursalesEmpr.Pais_Id
		Where 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
		order by 2

GO



DROP PROCEDURE INF_venFactuCartaPorte
GO
CREATE PROCEDURE INF_venFactuCartaPorte (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)
as

SELECT venCamiones.Patente_Id as Camion_Id,  venCamiones.ConfVehicular, venCamiones.Marca, venCamiones.Modelo, 
	venCamiones.NroPermisoSCT, venCamiones.NroPoliza, venCamiones.NombreAseg,
	ISNULL(venCamiones.AseguraMedAmb,'') AseguraMedAmb, ISNULL(venCamiones.PolizaMedAmbiente,'') PolizaMedAmbiente,
	ISNULL(venCamiones.AseguraCarga,'') AseguraCarga, ISNULL(venCamiones.PolizaCarga,'') PolizaCarga,
	ISNULL(venCamiones.PrimaSeguro,0) PrimaSeguro,
	ISNULL(Remolque1.Patente_Id,'') Remolque1, Remolque1.Marca MarcaR1, Remolque1.Modelo ModeloR1, Remolque1.ConfVehicular ConfVehicularR1,
	ISNULL(Remolque1.AseguraMedAmb,'') AseguraMedAmbR1, ISNULL(Remolque1.PolizaMedAmbiente,'') PolizaMedAmbienteR1,
	ISNULL(Remolque1.AseguraCarga,'') AseguraCargaR1, ISNULL(Remolque1.PolizaCarga,'') PolizaCargaR1,
	ISNULL(Remolque1.PrimaSeguro,0) PrimaSeguroR1,
	ISNULL(Remolque2.Patente_Id,'') Remolque2, Remolque2.Marca MarcaR2, Remolque2.Modelo ModeloR2, Remolque2.ConfVehicular ConfVehicularR2,
	ISNULL(Remolque2.AseguraMedAmb,'') AseguraMedAmbR2, ISNULL(Remolque2.PolizaMedAmbiente,'') PolizaMedAmbienteR2,
	ISNULL(Remolque2.AseguraCarga,'') AseguraCargaR2, ISNULL(Remolque2.PolizaCarga,'') PolizaCargaR2,
	ISNULL(Remolque2.PrimaSeguro,0) PrimaSeguroR2,
	venOperadores.Operador_Id, venOperadores.RfcOperador, venOperadores.NombreOperador, 
	venOperadores.NumLicencia, venOperadores.Calle, venOperadores.NumeroExterior, venOperadores.Numerointerior, 
	venOperadores.Colonia, venOperadores.Localidad, venOperadores.Municipio, venOperadores.Estado, genPaises.CodFiscal Pais
FROM venCompCartaPorte 
	inner join venCamiones ON  venCamiones.venCamiones = venCompCartaPorte.Camion_Id
	left join venCamiones Remolque1 ON  Remolque1.venCamiones = venCompCartaPorte.Remolque1
	left join venCamiones Remolque2 ON  Remolque2.venCamiones = venCompCartaPorte.Remolque2
	inner join venOperadores ON venOperadores.venOperadores =venCompCartaPorte.Operador_Id
	INNER JOIN genPaises ON genPaises.genPaises = venOperadores.Pais
	inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venCompCartaPorte.venmovimientos
	inner join genSegmentos on genSegmentos.genSegmentos  = genAsiSegmentos.Segmento_Id
WHERE 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id

go


drop procedure INF_venFactuOrigenes
go
create procedure INF_venFactuOrigenes
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS

select  venCompCartaPorteOrigen.venMovimientos, venCompCartaPorteOrigen.Ubicacion, venCompCartaPorteOrigen.idOrigen, 
venCompCartaPorteOrigen.RFCRemitente, venCompCartaPorteOrigen.NombreRemitente, 
venCompCartaPorteOrigen.NumRegIdTrib, genPaises.CodFiscal as ResidenciaFiscal, venCompCartaPorteOrigen.NumEstacion, 
venCompCartaPorteOrigen.FechaHoraSalida, venCompCartaPorteOrigen.Calle, venCompCartaPorteOrigen.NumeroExterior, 
venCompCartaPorteOrigen.Numerointerior, venCompCartaPorteOrigen.Colonia as c_Colonia, 
	isnull(genColonias.NombreAsentamiento,'') as NombreAsentamiento, 
	venCompCartaPorteOrigen.Localidad as c_Localidad, ISNULL(genlocalidades.Descripcion,'') AS Localidad, 
	venCompCartaPorteOrigen.Municipio as c_Municipio, ISNULL(genMunicipios.Descripcion,'')  as Municipio,
	venCompCartaPorteOrigen.Estado, venCompCartaPorteOrigen.CodigoPostal, 
	genPaisesD.Descripcion Pais
from venCompCartaPorteOrigen
	inner join  genPaises on  genPaises.genPaises = venCompCartaPorteOrigen.ResidenciaFiscal
	left join genColonias on  genColonias.c_Colonia = venCompCartaPorteOrigen.Colonia and 
			genColonias.c_CodigoPostal = venCompCartaPorteOrigen.CodigoPostal
	left join  genlocalidades ON  genlocalidades.c_Localidad = venCompCartaPorteOrigen.Localidad and 
		genlocalidades.c_Estado = venCompCartaPorteOrigen.Estado
	LEFT JOIN genMunicipios ON  genMunicipios.c_Municipio = venCompCartaPorteOrigen.Municipio and 
			genMunicipios.c_Estado = venCompCartaPorteOrigen.Estado
	inner join  genPaises genPaisesD ON genPaisesD.genPaises = venCompCartaPorteOrigen.Pais
	inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venCompCartaPorteOrigen.venmovimientos
	inner join genSegmentos on genSegmentos.genSegmentos  = genAsiSegmentos.Segmento_Id
WHERE 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id


go


drop procedure INF_venFactuDestinos
go
create procedure INF_venFactuDestinos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS

select  venCompCartaPorteDestino.venMovimientos, venCompCartaPorteDestino.Ubicacion, venCompCartaPorteDestino.IdDestino, 
venCompCartaPorteDestino.RFCDestinatario, venCompCartaPorteDestino.NombreDestinatario, 
venCompCartaPorteDestino.NumRegIdTrib, genPaises.CodFiscal as ResidenciaFiscal, venCompCartaPorteDestino.NumEstacion, 
venCompCartaPorteDestino.FechaHoraProgLlegada, venCompCartaPorteDestino.Calle, venCompCartaPorteDestino.NumeroExterior, 
venCompCartaPorteDestino.Numerointerior, venCompCartaPorteDestino.Colonia as c_Colonia, 
	isnull(genColonias.NombreAsentamiento,'') as NombreAsentamiento, 
	venCompCartaPorteDestino.Localidad as c_Localidad, ISNULL(genlocalidades.Descripcion,'') AS Localidad, 
	venCompCartaPorteDestino.Municipio as c_Municipio, ISNULL(genMunicipios.Descripcion,'')  as Municipio,
	venCompCartaPorteDestino.Estado, venCompCartaPorteDestino.CodigoPostal, 
	genPaisesD.Descripcion Pais
from venCompCartaPorteDestino
	inner join  genPaises on  genPaises.genPaises = venCompCartaPorteDestino.ResidenciaFiscal
	left join genColonias on  genColonias.c_Colonia = venCompCartaPorteDestino.Colonia AND 
			genColonias.c_CodigoPostal = venCompCartaPorteDestino.CodigoPostal
	left join  genlocalidades ON  genlocalidades.c_Localidad = venCompCartaPorteDestino.Localidad and 
			genlocalidades.c_Estado = venCompCartaPorteDestino.Estado
	LEFT JOIN genMunicipios ON  genMunicipios.c_Municipio = venCompCartaPorteDestino.Municipio and 
		genMunicipios.c_Estado = venCompCartaPorteDestino.Estado
	inner join  genPaises genPaisesD ON genPaisesD.genPaises = venCompCartaPorteDestino.Pais
inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venCompCartaPorteDestino.venmovimientos
	inner join genSegmentos on genSegmentos.genSegmentos  = genAsiSegmentos.Segmento_Id
WHERE 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
go



drop procedure INF_venFactuCPMercancias
go
create procedure INF_venFactuCPMercancias
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS

select venCompCartaPorteMercancia.Renglon, venCompCartaPorteMercancia.BienesTransp, venCompCartaPorteMercancia.ClaveSTCC,
	venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Cantidad, stkUniMed.CodigoFiscal, 
	venCompCartaPorteMercancia.Dimensiones, venCompCartaPorteMercancia.MaterialPeligroso, venCompCartaPorteMercancia.Embalaje, 
	venCompCartaPorteMercancia.CveMaterialPeligroso,
	venCompCartaPorteMercancia.PesoEnKg, venCompCartaPorteMercancia.ValorMercancia, 
		venCompCartaPorteMercancia.FraccionArancelaria, venCompCartaPorteMercancia.UUIDComercioExt
	from venCompCartaPorteMercancia 
	inner join stkUniMed ON stkUniMed.stkUniMed = venCompCartaPorteMercancia.Medida_id
	inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venCompCartaPorteMercancia.venmovimientos
	inner join genSegmentos on genSegmentos.genSegmentos  = genAsiSegmentos.Segmento_Id
	WHERE 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
	order by 1
go


