DROP PROCEDURE genFechasAplicacion
GO
CREATE PROCEDURE genFechasAplicacion(@Asiento_id bigint, @Asiento_Id_Ap bigint)

as

Select conAsientos.Fecha, conAsientosAp.Fecha as Fecha_Ap, 
	genEmpresas.FechaCierreCompras, genEmpresas.FechaCierreVentas, 
	case when comMovProv.comMovProv IS NULL Or conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmcomProvSaldoIni') THEN 'N' ELSE 'S' END AS EsCompras,
	case when venMovimientos.venMovimientos IS NULL Or conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmvenClientesSaldoIni') THEN 'N' ELSE 'S' END AS EsVentas,
	case when comMovProvAP.comMovProv IS NULL Or conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmcomProvSaldoIni') THEN 'N' ELSE 'S' END AS EsCompras_Ap,
	case when venMovimientosAP.venMovimientos IS NULL Or conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmvenClientesSaldoIni') THEN 'N' ELSE 'S' END AS EsVentas_AP,
	conAsientos.conAsientos as Asiento_Id,
	conAsientosAp.conAsientos as Asiento_Id_Ap,
	conAsientos.Cambio, conAsientosAp.Cambio Cambio_Ap
From conAsientos
Cross Join conAsientos as conAsientosAp
Inner Join genEmpresas ON genEmpresas.genEmpresas = conAsientosAp.Empresa_Id
Left Join comMovProv on comMovProv.comMovProv = conAsientos.conAsientos
Left Join venMovimientos on venMovimientos.venMovimientos = conAsientos.conAsientos
Left Join comMovProv comMovProvAP on comMovProvAP.comMovProv = conAsientosAp.conAsientos
Left Join venMovimientos as venMovimientosAP on venMovimientosAP.venMovimientos = conAsientosAp.conAsientos

Where
conAsientos.conAsientos = @Asiento_id and 
conAsientosAp.conAsientos = @Asiento_Id_Ap

GO
