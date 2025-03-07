-- inf_comMovProvPrincipal 1, 'FPRO', 4773,0,0,0,'','F','P027',' '
drop procedure inf_comMovProvPrincipal
go
create procedure inf_comMovProvPrincipal
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
-- Cabecera

select commovprov.comMovProv, 
	dbo.Segmento( genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento_str, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial, genEntidades.Cuit, 
	conAsientos.Fecha, conAsientos.FechaRegistro, 
		disFormularios.Descripcion as DescripcionForm, 
		ISNULL(commovprov.ClaveFiscal,' ') AS ClaveFiscal, 
		genUsuarios.Usuario_Id, 
			commovprov.Importe, genMonedas.Simbolo, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, 
			comConPago.CondPago_Id, comConPago.Descripcion as DescripcionCondPago , 
				genMovCuotas.FechaVencimiento, 
			comOrigenesFiscales.Origen_Id, comOrigenesFiscales.Descripcion as DescripcionOrigen, 
			conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta
	from commovprov inner join conAsientos ON
		commovprov.comMovProv = conAsientos.conAsientos
		inner join genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		inner join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		inner join comProveedores ON
		comProveedores.genEntidades = commovprov.Proveed_Id 
		inner join genEntidades ON
		genEntidades.genEntidades = comProveedores.genEntidades
		inner join disFormularios ON
		disFormularios.disFormularios = conAsientos.Formulario_Id
		inner join genUsuarios ON
		genUsuarios.genUsuarios = conAsientos.Usuario_Id
		INNER JOIN genMonedas ON
		genMonedas.genMonedas = conAsientos.Moneda_Id
		INNER JOIN comConPago ON
		comConPago.comConPago = comMovprov.ComCondPago_Id
		INNER JOIN comOrigenesFiscales ON
		comOrigenesFiscales.comOrigenesFiscales = comMovprov.Origen_Id
		LEFT JOIN (SELECT  genMovCuotas.Asiento_Id, MIN(FechaVencimiento) as FechaVencimiento
		from genMovCuotas group by genMovCuotas.Asiento_Id) genMovCuotas  ON
		genMovCuotas.Asiento_Id = comMovprov.comMovProv 
		LEFT join (conMovCont INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas) 
			ON conMovCont.conAsientos = comMovProv.comMovProv and 
		conMovCont.Clase = 'PRO'
		Where
			genSegmentos.Segmento_Id = 'FPRO' AND 
			genAsiSegmentos.Segmento1N = @Segmento1N and 
			genAsiSegmentos.Segmento2N = @Segmento2N and 
			genAsiSegmentos.Segmento3N = @Segmento3N and 
			genAsiSegmentos.Segmento4N = @Segmento4N and 
			genAsiSegmentos.Segmento1C = @Segmento1C and 
			genAsiSegmentos.Segmento2C = @Segmento2C and 
			genAsiSegmentos.Segmento3C = @Segmento3C and 
			genAsiSegmentos.Segmento4C = @Segmento4C
go

-- Asiento
drop procedure inf_comMovProvAsiento
go
create Procedure inf_comMovProvAsiento
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
select commovprov.comMovProv, 
		comMovDetalle.Renglon , comMovDetalle.Detalle,
		conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
		ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_id, 
		ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_id, 
		case when Signo=-1 then comMovDetalle.Importe else 0 end as Debe,
		case when Signo=1 then comMovDetalle.Importe else 0 end as Haber,
		conBaseDistri.Base_Id
	from commovprov inner join conAsientos ON
		commovprov.comMovProv = conAsientos.conAsientos
		inner join genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		inner join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		inner join comMovDetalle ON
		comMovDetalle.comMovProv = COMMOVPROV.comMovProv
		inner join conCuentas ON
		comMovDetalle.Cuenta_Id = conCuentas.conCuentas
		left join conCentro1 on 
		 conCentro1.conCentro1 = comMovDetalle.Centro1_Id
		 left join conCentro2 on 
		 conCentro2.conCentro2 = comMovDetalle.Centro2_Id
		 left join conBaseDistri ON
		 conBaseDistri.conBaseDistri = comMovDetalle.Base_Id
		 inner join comMovTipos on comMovTipos.TipoMov=comMovProv.TipoMov
Where
			genSegmentos.Segmento_Id = 'FPRO' AND 
			genAsiSegmentos.Segmento1N = @Segmento1N and 
			genAsiSegmentos.Segmento2N = @Segmento2N and 
			genAsiSegmentos.Segmento3N = @Segmento3N and 
			genAsiSegmentos.Segmento4N = @Segmento4N and 
			genAsiSegmentos.Segmento1C = @Segmento1C and 
			genAsiSegmentos.Segmento2C = @Segmento2C and 
			genAsiSegmentos.Segmento3C = @Segmento3C and 
			genAsiSegmentos.Segmento4C = @Segmento4C
union all
select commovprov.comMovProv, 
		conMovCont.Renglon , ' ' as Detalle,
		conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
		ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_id, 
		ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_id, 
		case when Signo=-1 then comMovImpuestos.Importe_Impuesto else 0 end as Debe,
		case when Signo=1 then comMovImpuestos.Importe_Impuesto else 0 end as Haber,
		'' as Base_Id
	from commovprov inner join conAsientos ON
		commovprov.comMovProv = conAsientos.conAsientos
		inner join genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		inner join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		inner join comMovImpuestos ON
		comMovImpuestos.comMovProv = COMMOVPROV.comMovProv
		inner join conMovCont on 
		comMovImpuestos.comMovProv=conMovCont.conAsientos and comMovImpuestos.conRenglon=conMovCont.Renglon
		inner join conCuentas ON
		conMovCont.Cuenta_Id = conCuentas.conCuentas
		left join conCentro1 on 
		 conCentro1.conCentro1 = conMovCont.Centro1_Id
		 left join conCentro2 on 
		 conCentro2.conCentro2 = conMovCont.Centro2_Id
		
		 inner join comMovTipos on comMovTipos.TipoMov=comMovProv.TipoMov
Where
			genSegmentos.Segmento_Id = 'FPRO' AND 
			genAsiSegmentos.Segmento1N = @Segmento1N and 
			genAsiSegmentos.Segmento2N = @Segmento2N and 
			genAsiSegmentos.Segmento3N = @Segmento3N and 
			genAsiSegmentos.Segmento4N = @Segmento4N and 
			genAsiSegmentos.Segmento1C = @Segmento1C and 
			genAsiSegmentos.Segmento2C = @Segmento2C and 
			genAsiSegmentos.Segmento3C = @Segmento3C and 
			genAsiSegmentos.Segmento4C = @Segmento4C
UNION ALL
select commovprov.comMovProv, 
		9999 , ' ' Detalle,
		conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
		ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_id, 
		ISNULL(conCentro2.Centro2_Id,' ') AS Centro2_id, 
		case when Signo=1 then comMovProv.Importe else 0 end as Debe,
		case when Signo=-1 then comMovProv.Importe else 0 end as Haber,
		  ' ' as Base_Id
	from commovprov inner join conAsientos ON
		commovprov.comMovProv = conAsientos.conAsientos
		inner join genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		inner join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		inner join conMovCont ON
		conMovCont.conAsientos = COMMOVPROV.comMovProv and 
		conMovCont.Clase = 'PRO' 
		inner join conCuentas ON
		conMovCont.Cuenta_Id = conCuentas.conCuentas
		left join conCentro1 on 
		 conCentro1.conCentro1 = conMovCont.Centro1_Id
		 left join conCentro2 on 
		 conCentro2.conCentro2 = conMovCont.Centro2_Id
		  inner join comMovTipos on comMovTipos.TipoMov=comMovProv.TipoMov
Where
			genSegmentos.Segmento_Id = 'FPRO' AND 
			genAsiSegmentos.Segmento1N = @Segmento1N and 
			genAsiSegmentos.Segmento2N = @Segmento2N and 
			genAsiSegmentos.Segmento3N = @Segmento3N and 
			genAsiSegmentos.Segmento4N = @Segmento4N and 
			genAsiSegmentos.Segmento1C = @Segmento1C and 
			genAsiSegmentos.Segmento2C = @Segmento2C and 
			genAsiSegmentos.Segmento3C = @Segmento3C and 
			genAsiSegmentos.Segmento4C = @Segmento4C
ORDER BY 2
go
-- impuestos
drop procedure inf_comMovProvImpuestos
go
create Procedure inf_comMovProvImpuestos
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
select comImpuestos.Impuesto_Id, comImpuestos.Descripcion, 
		comMovImpuestos.Base_Imponible, comMovImpuestos.Porcentaje, 
		comMovImpuestos.Importe_Impuesto, 
		conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta
	from comMovImpuestos inner join conAsientos ON
		comMovImpuestos.comMovProv = conAsientos.conAsientos
		inner join genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		inner join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		Inner join comImpuestos ON
		comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
		inner join conMovCont on 
		conMovCont.conAsientos = comMovImpuestos.comMovProv and 
		conMovCont.Renglon = comMovImpuestos.conRenglon
		inner join conCuentas on conCuentas.conCuentas = conMovCont.Cuenta_Id

Where
			genSegmentos.Segmento_Id = 'FPRO' AND 
			genAsiSegmentos.Segmento1N = @Segmento1N and 
			genAsiSegmentos.Segmento2N = @Segmento2N and 
			genAsiSegmentos.Segmento3N = @Segmento3N and 
			genAsiSegmentos.Segmento4N = @Segmento4N and 
			genAsiSegmentos.Segmento1C = @Segmento1C and 
			genAsiSegmentos.Segmento2C = @Segmento2C and 
			genAsiSegmentos.Segmento3C = @Segmento3C and 
			genAsiSegmentos.Segmento4C = @Segmento4C
ORDER BY 1
go
-- STOCK
drop Procedure inf_comMovProvStock
go
create procedure inf_comMovProvStock
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
SELECT stkMoviCuerpo.Renglon, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkUniMed.Medida_Id, stkMoviCuerpo.CantidadForm, 
		stkMoviCuerpo.PrecioOriginal, stkMoviCuerpo.Descuento, 
		stkMoviCuerpo.CostoUnitario, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta
	from commovprov inner join conAsientos ON
		commovprov.comMovProv = conAsientos.conAsientos
		inner join genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		inner join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		inner join stkMoviCuerpo ON
		stkMoviCuerpo.stkMoviCabe = comMovprov.comMovProv
		INNER JOIN stkMoviCabe ON
		stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
		inner join stkProductos ON
		stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
		inner join stkUniMed ON
		stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
		inner join stkSubTipoMov ON
		stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
		INNER JOIN stkTiposMov ON
		stkTiposMov.TipoMov = stkSubTipoMov.TipoMov
		inner join conMovCont ON 
		conMovCont.conAsientos = conasientos.conAsientos and 
		conMovCont.Renglon = case when stkTiposMov.Signo = 1 THEN 
				stkMoviCuerpo.conRenglonDebe  ELSE
				stkMoviCuerpo.conRenglonHaber END
		INNER JOIN conCuentas ON
			conCuentas.conCuentas = conMovCont.Cuenta_Id
Where
			genSegmentos.Segmento_Id = @Segmento_Id AND 
			genAsiSegmentos.Segmento1N = @Segmento1N and 
			genAsiSegmentos.Segmento2N = @Segmento2N and 
			genAsiSegmentos.Segmento3N = @Segmento3N and 
			genAsiSegmentos.Segmento4N = @Segmento4N and 
			genAsiSegmentos.Segmento1C = @Segmento1C and 
			genAsiSegmentos.Segmento2C = @Segmento2C and 
			genAsiSegmentos.Segmento3C = @Segmento3C and 
			genAsiSegmentos.Segmento4C = @Segmento4C
ORDER BY 1

go
drop procedure inf_comMovProvOc
go
create procedure inf_comMovProvOC
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @Empresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_id) and
	Segmento1N =@Segmento1N and
	Segmento2N = @Segmento2N and
	Segmento3N = @Segmento3N and
	Segmento4N = @Segmento4N and
	Segmento1C = @Segmento1C and
	Segmento2C = @Segmento2C and 
	Segmento3C = @Segmento3C and 
	Segmento4C = @Segmento4C )

SELECT comMovPOC.comMovProv, comMovPOC.Renglon_OC as Renglon, 0 RenglonReferencia, 	
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	comOCArticulo.Factor, comMovPOC.Cantidad as Cantidad,
	comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
	comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
	 comOcCuerpo.Cantidad as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada +comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
	comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta
FROM comMovPOC inner join comOCSegmentos on comMovPOC.comOrdenComp = comOCSegmentos.comOrdenComp
INNER JOIN comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and 
						   comMovPOC.Renglon_OC=comOCCuerpo.Renglon_OC
INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and 
							comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
inner join (SELECT conAsientos, MAX(Cuenta_Id) AS Cuenta_Id from   conMovCont		
			WHERE
				conMovCont.Clase in ('FACAR','OEFAR')
			Group by conAsientos) as conMovCont ON  comMovPOC.comMovProv=conMovCont.conAsientos 
inner join conCuentas on conMovCont.Cuenta_Id=conCuentas.conCuentas
WHERE 
	comMovPOC.comMovProv = @pComMovProv
UNION ALL
SELECT comMovPOC.comMovProv, comMovPOC.Renglon_OC as Renglon, 0 RenglonReferencia, 	
	' ' Producto_Id, comOCMemo.Detalle as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	1 Factor, comMovPOC.Cantidad as Cantidad,
	comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
	comOCCuerpo.Precio AS PrecioOriginal, 0 as conRenglonDebe, 
	 comOcCuerpo.Cantidad as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada +comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
	comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta
FROM comMovPOC inner join comOCSegmentos on comMovPOC.comOrdenComp = comOCSegmentos.comOrdenComp
INNER JOIN comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and comMovPOC.Renglon_OC=comOCCuerpo.Renglon_OC
INNER JOIN comOCMemo ON comOcCuerpo.comOrdenComp = comOCMemo.comOrdenComp and 
	comOcCuerpo.Renglon_OC = comOCMemo.Renglon_OC
inner join (SELECT conAsientos, MAX(Cuenta_Id) AS Cuenta_Id from   conMovCont		
			WHERE
				conMovCont.Clase in ('FACAR','OEFAR')
			Group by conAsientos) as conMovCont ON comMovPOC.comMovProv=conMovCont.conAsientos 
inner join conCuentas on conMovCont.Cuenta_Id=conCuentas.conCuentas
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
WHERE 
	comMovPOC.comMovProv = @pComMovProv
go

drop procedure inf_comMovProvSTR
go
create procedure inf_comMovProvSTR
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @Empresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_id) and
	Segmento1N =@Segmento1N and
	Segmento2N = @Segmento2N and
	Segmento3N = @Segmento3N and
	Segmento4N = @Segmento4N and
	Segmento1C = @Segmento1C and
	Segmento2C = @Segmento2C and 
	Segmento3C = @Segmento3C and 
	Segmento4C = @Segmento4C )
SELECT dbo.Segmento(comOCSegmentos.Segmento_Id,
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, 
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as SegmentoSTR

From comOCSegmentos 
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
WHERE 
	Exists(select 1 from comMovPOC where
		comMovPOC.comMovProv = @pComMovProv and 
		comMovPOC.comOrdenComp =	comOCSegmentos.comOrdenComp)
go

drop procedure inf_comMovProvVOC
go
create procedure inf_comMovProvVOC
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @Empresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_id) and
	Segmento1N =@Segmento1N and
	Segmento2N = @Segmento2N and
	Segmento3N = @Segmento3N and
	Segmento4N = @Segmento4N and
	Segmento1C = @Segmento1C and
	Segmento2C = @Segmento2C and 
	Segmento3C = @Segmento3C and 
	Segmento4C = @Segmento4C )

SELECT comMovPOC.comMovProv, comMovPOC.Renglon_OC as Renglon, 0 RenglonReferencia, 	
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	comOCArticulo.Factor, comMovPOC.Cantidad as Cantidad,
	comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
	comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
	 comOcCuerpo.Cantidad as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada +comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
	comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	dbo.Segmento(comOCSegmentos.Segmento_Id,
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, 
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as SegmentoSTR
FROM comMovPOC inner join comOCSegmentos on comMovPOC.comOrdenComp = comOCSegmentos.comOrdenComp
INNER JOIN comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and comMovPOC.Renglon_OC=comOCCuerpo.Renglon_OC
INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and 
	comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC

INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
inner join (SELECT conAsientos, MAX(Cuenta_Id) AS Cuenta_Id from   conMovCont		
			WHERE
				conMovCont.Clase in ('FACAR','OEFAR')
			Group by conAsientos) as conMovCont ON 
			conMovCont.conAsientos = comMovPOC.comMovProv
inner join conCuentas on conMovCont.Cuenta_Id=conCuentas.conCuentas


WHERE 
	comMovPOC.comMovProv = @pComMovProv
UNION ALL
SELECT comMovPOC.comMovProv, comMovPOC.Renglon_OC as Renglon, 0 RenglonReferencia, 	
	' ' Producto_Id, comOCMemo.Detalle as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	1 Factor, comMovPOC.Cantidad as Cantidad,
	comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
	comOCCuerpo.Precio AS PrecioOriginal, 0 as conRenglonDebe, 
	 comOcCuerpo.Cantidad as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada +comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
	comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	dbo.Segmento(comOCSegmentos.Segmento_Id,
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, 
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as SegmentoSTR
FROM comMovPOC inner join comOCSegmentos on comMovPOC.comOrdenComp = comOCSegmentos.comOrdenComp
INNER JOIN comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and comMovPOC.Renglon_OC=comOCCuerpo.Renglon_OC
INNER JOIN comOCMemo ON comOcCuerpo.comOrdenComp = comOCMemo.comOrdenComp and 
	comOcCuerpo.Renglon_OC = comOCMemo.Renglon_OC
inner join (SELECT conAsientos, MAX(Cuenta_Id) AS Cuenta_Id from   conMovCont		
			WHERE
				conMovCont.Clase in ('FACAR','OEFAR')
			Group by conAsientos) as conMovCont ON comMovPOC.comMovProv=conMovCont.conAsientos 
inner join conCuentas on conMovCont.Cuenta_Id=conCuentas.conCuentas
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)

WHERE 

	comMovPOC.comMovProv = @pComMovProv
go

drop procedure inf_comMovProvEMBSTR
go
create procedure inf_comMovProvEMBSTR
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @Empresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_id) and
	Segmento1N =@Segmento1N and
	Segmento2N = @Segmento2N and
	Segmento3N = @Segmento3N and
	Segmento4N = @Segmento4N and
	Segmento1C = @Segmento1C and
	Segmento2C = @Segmento2C and 
	Segmento3C = @Segmento3C and 
	Segmento4C = @Segmento4C )

SELECT dbo.Segmento(genSegmentos.Segmento_Id,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR

From genAsiSegmentos 
INNER JOIN comEmbarques on comEmbarques.comEmbarques = genAsiSegmentos.Asiento_Id
inner join comMovProvEmb on comMovProvEmb.comEmbarques = comEmbarques.comEmbarques
inner join comMovProv ON  comMovProv.comMovProv = comMovProvEmb.comMovProv
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE 
comMovProv.comMovProv = @pComMovProv
go

drop procedure inf_comMovProvEMBCuerpo
go
create procedure inf_comMovProvEMBCuerpo
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @Empresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_id) and
	Segmento1N =@Segmento1N and
	Segmento2N = @Segmento2N and
	Segmento3N = @Segmento3N and
	Segmento4N = @Segmento4N and
	Segmento1C = @Segmento1C and
	Segmento2C = @Segmento2C and 
	Segmento3C = @Segmento3C and 
	Segmento4C = @Segmento4C )

SELECT comMovProvEmb.comMovProv, comOCCuerpo.Renglon_OC as Renglon, 0 RenglonReferencia, 	
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	comOCArticulo.Factor, comMovPOC.Cantidad as Cantidad,
	comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
	comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
	comEmbCuerpo.Cantidad as CantidadOC, comEmbCuerpo.CantidadRecibida - comEmbCuerpo.CantidadFacturada as CantidadPendiente,
	comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp
FROM comMovProvEmb INNER JOIN comMovPOC ON comMovPOC.comMovProv = comMovProvEmb.comMovProv 
INNER JOIN  comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp  and 
						   comMovPOC.Renglon_OC = comOCCuerpo.Renglon_OC	
INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and 
					 		comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
INNER JOIN comEmbCuerpo ON comEmbCuerpo.comEmbarques = comMovProvEmb.comEmbarques and 
						  comEmbCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and 
						  comEmbCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)

WHERE 
	comMovProvEmb.comMovProv = @pComMovProv
go

drop procedure inf_comMovProvEMBGastos
go
create procedure inf_comMovProvEMBGastos
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @Empresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_id) and
	Segmento1N =@Segmento1N and
	Segmento2N = @Segmento2N and
	Segmento3N = @Segmento3N and
	Segmento4N = @Segmento4N and
	Segmento1C = @Segmento1C and
	Segmento2C = @Segmento2C and 
	Segmento3C = @Segmento3C and 
	Segmento4C = @Segmento4C )

SELECT comEmbGastos.Renglon, comEmbGastos.Detalle, comEmbGastos.ImporteOriginal, 
		genMonedas.Moneda_Id , comMovDetalle.Importe AS Monto,
		comEmbGastoMovProv.comRenglon, conCuentas.Cuenta_Id,conCuentas.Descripcion as DescripcionCuenta
	FROM comEmbGastos inner join genMonedas ON comEmbGastos.Moneda_Id = genMonedas.genMonedas
		INNER JOIN comEmbGastoMovProv ON 
		comEmbGastoMovProv.comEmbarques = comEmbGastos.comEmbarques and 
		comEmbGastoMovProv.Renglon = comEmbGastos.Renglon
		INNER JOIN comMovDetalle ON
		comMovDetalle.comMovProv =  comEmbGastoMovProv.comMovProv and
		comMovDetalle.Renglon =comEmbGastoMovProv.comRenglon
		inner join conMovCont on comMovDetalle.comMovProv =  conMovCont.conAsientos and
		comMovDetalle.Renglon =conMovCont.Renglon
		inner join conCuentas on conCuentas.conCuentas=conMovCont.Cuenta_Id
		Where
		comEmbGastoMovProv.comMovProv = @pComMovProv
		ORDER BY 1
go



drop procedure inf_comMovProvDifP
go
create procedure inf_comMovProvDifP
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @Empresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_id) and
	Segmento1N =@Segmento1N and
	Segmento2N = @Segmento2N and
	Segmento3N = @Segmento3N and
	Segmento4N = @Segmento4N and
	Segmento1C = @Segmento1C and
	Segmento2C = @Segmento2C and 
	Segmento3C = @Segmento3C and 
	Segmento4C = @Segmento4C )

SELECT comMovProvDPreFactDir.Renglon, 
	comMovProvDPreFactDir.RenglonStk as RenglonOrig,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr ,
	comMovProvDPreFactDir.CantidadOriginal as CantidadForm, comMovProvDPreFactDir.Cantidad, 
	comMovProvDPreFactDir.Descuento, comMovProvDPreFactDir.Monto, 
	comMovProvDPreFactDir.Monto *comMovProvDPreFactDir.CantidadOriginal as Total, 
	' ' as SegmentoStrOC, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkMoviCuerpo.CantidadForm as CantidadOriginal, stkUniMed.Medida_Id, 
	stkMoviCuerpo.Factor, stkMoviCuerpo.PrecioOriginal 
FROM comMovProvDPreFactDir INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = comMovProvDPreFactDir.stkMoviCabe
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN stkMoviCuerpo ON 
stkMoviCuerpo.stkMoviCabe = comMovProvDPreFactDir.stkMoviCabe AND 
stkMoviCuerpo.Renglon = comMovProvDPreFactDir.RenglonStk
INNER JOIN stkProductos ON
stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkUniMed ON
stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
Where 
	comMovProvDPreFactDir.comMovProv = @pComMovProv

UNION ALL
SELECT comMovProvDPreOC.Renglon, 
	comMovProvDPreOC.Renglon_OC,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr ,
	comMovProvDPreOC.CantidadOriginal as CantidadForm, comMovProvDPreOC.Cantidad, 
	comMovProvDPreOC.Descuento, comMovProvDPreOC.Monto, 
	comMovProvDPreOC.Monto *comMovProvDPreOC.CantidadOriginal as Total, 
	dbo.Segmento(comOCSegmentos.Segmento_Id, 
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, 
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N, 
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) as SegmentoStrOC,
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	comMovPOC.Cantidad , stkUniMed.Medida_Id, 
	comMovpOC.Factor, comOCArticulo.PrecioOriginal

FROM comMovProvDPreOC INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = comMovProvDPreOC.comMovProvFactOrig
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN comOCArticulo ON
comOCArticulo.comOrdenComp = comMovProvDPreOC.comOrdenComp and 
comOCArticulo.Renglon_OC =comMovProvDPreOC.Renglon_OC
INNER JOIN comOCCuerpo ON
comOCCuerpo.comOrdenComp = comMovProvDPreOC.comOrdenComp and 
comOCCuerpo.Renglon_OC =comMovProvDPreOC.Renglon_OC
INNER JOIN comMovpOC ON 
comMovpOC.comMovProv = comMovProvDPreOC.comMovProvFactOrig AND 
comMovpOC.comOrdenComp = comMovProvDPreOC.comOrdenComp AND 
comMovpOC.Renglon_OC = comMovProvDPreOC.Renglon_OC
INNER JOIN stkProductos ON
stkProductos.stkProductos = comOCArticulo.Producto_Id
INNER JOIN stkUniMed ON
stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
INNER JOIN comOCSegmentos ON 
comOCSegmentos.comOrdenComp = comMovProvDPreOC.comOrdenComp
Where 
	comMovProvDPreOC.comMovProv = @pComMovProv
ORDER BY 2



GO

drop procedure inf_comMovProvRemi
go
create procedure inf_comMovProvRemi
(
@Empresa_Id int,
@Segmento_Id varchar(10),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C varchar(20),
@Segmento2C varchar(20),
@Segmento3C varchar(20),
@Segmento4C varchar(20)
)
as
DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @Empresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_id) and
	Segmento1N =@Segmento1N and
	Segmento2N = @Segmento2N and
	Segmento3N = @Segmento3N and
	Segmento4N = @Segmento4N and
	Segmento1C = @Segmento1C and
	Segmento2C = @Segmento2C and 
	Segmento3C = @Segmento3C and 
	Segmento4C = @Segmento4C )


-- Cuerpo
SELECT comRemiPendFact.Renglon, comRemiPendFact.RenglonCuerpo, comRemiPendFact.CantidadFacturado,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
	comRemiPendFact.CantidadOriginalFact, comRemiPendFact.PrecioFacturado,
	stkMoviCuerpo.PrecioOriginal, stkUniMed.Medida_Id, stkMoviCuerpo.Cantidad, 
	stkMoviCuerpo.Factor, stkMoviCuerpo.CantidadForm as CantidadOriginal,
	dbo.Segmento(genAsiSegmentos.Segmento_Id,  
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr, 
	stkMoviCuerpo.stkMoviCabe
from comRemiPendFact inner join stkMoviCuerpo ON
	comRemiPendFact.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
	inner join stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = comRemiPendFact.stkMoviCabe
	left JOIN conCuentas ON 
	conCuentas.conCuentas = stkProductos.CtaCompra
Where
	comRemiPendFact.comMovprov = @pComMovProv
GO
