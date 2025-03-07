

--select * from vcomImpPagados where commovprov = 10543
-- comCompras_Pagadas '20191001','20191130', 1
--	
DROP PROCEDURE inf_comComprasPagadas
GO
CREATE PROCEDURE inf_comComprasPagadas( 
	@FechaDesde DATETIME, 
	@FechaHasta DATETIME, 
	@Empresa_id int)
AS
select XXX.Pais, XXX.Origen AS Origen_id, XXX.RFC, XXX.RazonSocial, XXX.idFiscal,
	XXX.NACIONALIDAD, SUM(BASE16) AS BASE16, 
	SUM(IVA16) AS IVA16, SUM(BASE0) AS BASE0, 
	SUM(BaseExe) AS BaseExe, 
	SUM(RISR) AS RISR, SUM(RIVA) AS RIVA, 
	SUM(IVAIM) AS IVAIM, SUM(OTROS) AS OTROS, 
	SUM(BASEFront) BASEFront , SUM(IVAFront) IVAFront
from (

SELECT genPaises.Dominio_Id AS Pais, 
	CASE WHEN genPaises.Dominio_Id<>'MX' THEN genEntidades.IDFISCAL ELSE '' END  idFiscal,
	comOrigenesFiscales.Origen_id as Origen,
	isnull(genEntidades.Cuit, 'XAXX010101000') RFC,  
	ISNULL(COMPROVEEDORES.NOMBRELEGAL, 'PROVEEDOR GLOBAL') AS RazonSocial ,
	genPaises.DESCRIPCION Nacionalidad,
	vComImpPagados.Fecha, commovprov.comMovProv, 
	
ISNULL((SELECT SUM(BaseImponible) from comMovImpAcredita, comImpuestos, impTipoImpuesto  Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'I7' ),0) as Base16, 
ISNULL((SELECT SUM(Monto) from comMovImpAcredita, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'I7'),0) as IVA16, 
ISNULL((SELECT SUM(BaseImponible) from comMovImpAcredita, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'T0'),0) as Base0, 	
ISNULL((SELECT SUM(BaseImponible) from comMovImpAcredita, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'EX'),0) as BaseExe, 
-(ISNULL((SELECT SUM(Monto) from comMovImpAcredita, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'RS'),0) +

ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = vcomImpPagados.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	comImpuestos.PorAcreditacion = 0 and
	impTipoImpuesto.CodigoFiscal = 'RS'),0)) as RISR, 
	
-(ISNULL((SELECT SUM(Monto) from comMovImpAcredita, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'R1'),0) + 
	ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = vcomImpPagados.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	comImpuestos.PorAcreditacion = 0 and
	impTipoImpuesto.CodigoFiscal = 'R1'),0))  as RIVA, 

ISNULL((SELECT SUM(Monto) from comMovImpAcredita, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'I5'),0) +
	ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = vcomImpPagados.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	comImpuestos.PorAcreditacion = 0 and
	impTipoImpuesto.CodigoFiscal = 'I5'),0) as IVAIM,	
abs(ISNULL((SELECT SUM(Monto) from comMovImpAcredita, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo  NOT IN ('IF','I7','I5','R1','RS','T0','EX')),0) +
	ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = vcomImpPagados.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	comImpuestos.PorAcreditacion = 0 and
	impTipoImpuesto.CodigoFiscal NOT IN ('IF','I7','I5','R1','RS','T0','EX')),0)) as Otros, 
	ISNULL((SELECT SUM(BaseImponible) from comMovImpAcredita, comImpuestos, impTipoImpuesto  Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'IF' ),0)  as BASEFront,
		ISNULL((SELECT SUM(comMovImpAcredita.Monto) from comMovImpAcredita, comImpuestos, impTipoImpuesto  Where
	comImpuestos.comImpuestos = comMovImpAcredita.Impuesto_id and
	comMovImpAcredita.tesMovimientos = vcomImpPagados.tesMovimientos and
	comMovImpAcredita.comMovprov = vcomImpPagados.comMovprov and 
	comMovImpAcredita.Asiento_Id =vcomImpPagados.Asiento_id and
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto AND 
	impTipoImpuesto.CodigoFiscal = vcomImpPagados.Tipo AND 
	vcomImpPagados.Tipo = 'IF' ),0)  as IVAFront,
	@FechaDesde FechaDesde, @FechaHasta FechaHasta
 from  vcomImpPagados 
	inner JOIN comProveedores ON
	comProveedores.Proveed_id = vcomImpPagados.Proveed_id 
	INNER JOIN genEntidades ON
	genEntidades.genEntidades = comProveedores.genEntidades
	INNER JOIN comMovprov ON 
	comMovprov.comMovprov = vcomImpPagados.comMovprov 
	INNER JOIN conAsientos ON
    conAsientos.conAsientos  = comMovprov.comMovProv
	INNER JOIN conAsientos conAsientosT ON
    conAsientosT.conAsientos  = vcomImpPagados.tesMovimientos
	INNER JOIN genPaises ON 
		genPaises.genPaises = comProveedores.Pais
		inner join comOrigenesFiscales on comOrigenesFiscales.comOrigenesFiscales=commovprov.Origen_Id
WHERE
		vcomImpPagados.Empresa_id = @Empresa_id and 
		vcomImpPagados.Fecha Between @FechaDesde And @FechaHasta
UNION ALL -- PROVEEDORES MENORES

SELECT DISTINCT  genPaises.Dominio_Id AS Pais, 
	CASE WHEN genPaises.Dominio_Id<>'MX' THEN genEntidades.IDFISCAL ELSE '' END  idFiscal,
	comOrigenesFiscales.Origen_id as Origen,
	isnull(genEntidades.Cuit, 'XAXX010101000') RFC,  
	ISNULL(COMPROVEEDORES.NOMBRELEGAL, 'PROVEEDOR GLOBAL') AS RazonSocial ,
	genPaises.DESCRIPCION NACIONALIDAD,
	conAsientos.Fecha, commovprov.commovprov, 
	
ISNULL((SELECT SUM(comMovImpuestos.Base_Imponible) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'I7' ),0) as Base16, 
	ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'I7' ),0) as IVA16, 
ISNULL((SELECT SUM(comMovImpuestos.Base_Imponible) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'T0' ),0) as Base0, 	
ISNULL((SELECT SUM(comMovImpuestos.Base_Imponible) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'EX' ),0) as BaseExe, 
-ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'RS' ),0) as  RISR, 
	
-ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'R1' ),0) as RIVA, 

ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'I5' ),0)  as IVAIM,	

abs(ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal NOT IN ('IF','I7','I5','R1','RS','T0','EX') ),0)) as Otros, 
ISNULL((SELECT SUM(comMovImpuestos.Base_Imponible) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'IF' ),0) as BaseFont, 
	ISNULL((SELECT SUM(comMovImpuestos.Importe_Impuesto) from comMovImpuestos, comImpuestos, impTipoImpuesto Where
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id and
	comMovImpuestos.comMovprov = comMovprov.comMovprov and 
	impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
	impTipoImpuesto.CodigoFiscal = 'IF' ),0) as IVAFront, 
	
	@FechaDesde FechaDesde, @FechaHasta FechaHasta
 from comMovImpuestos
	INNER JOIN comMovprov ON 
	comMovprov.comMovprov = comMovImpuestos.comMovprov 
	inner JOIN comProveedores ON
	comProveedores.genEntidades = comMovProv.Proveed_id 
	INNER JOIN genEntidades ON
	genEntidades.genEntidades = comProveedores.genEntidades
	LEFT JOIN genPaises ON 
			(comProveedores.Pais IS NULL and genPaises.Dominio_id = 'MX') or
			genPaises.genPaises = comProveedores.Pais 
	inner join comOrigenesFiscales on comOrigenesFiscales.comOrigenesFiscales=commovprov.Origen_Id
	INNER JOIN conAsientos ON 
	conAsientos.conAsientos = commovprov.comMovProv
	inner join tesRengMovicomMovProv on
	tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
WHERE
		conAsientos.Empresa_id = @Empresa_id and 
		conAsientos.Fecha Between @FechaDesde And @FechaHasta and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 

		 ) as XXX
GROUP BY XXX.Pais, XXX.Origen, XXX.RFC, XXX.RazonSocial, 
	XXX.NACIONALIDAD, XXX.idFiscal 

GO
	