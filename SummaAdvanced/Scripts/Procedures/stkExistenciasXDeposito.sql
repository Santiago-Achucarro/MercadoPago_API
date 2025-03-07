-- stkExistenciasXDeposito 1,' ','ZZZ',' ','ZZZ',' ','zzz',' ','ZZ',' ','zz'

drop procedure stkExistenciasXDeposito
go


create procedure stkExistenciasXDeposito
(
@pEmpresa_Id Int = Null,
@pProductoDesde varchar(25),
@pProductoHasta varchar(25),
@pDepositoDesde varchar(15),
@pDepositoHasta varchar(15), 
@pFamiliaDesde varchar(15), 
@pFamiliaHasta varchar(15), 
@pGrupoDesde varchar(15), 
@pGrupoHasta varchar(15),
@pTipoDesde VarChar(5),
@pTipoHasta VarChar(5)
)
as
select '' as ProductoDesde, 'ZZZZZZZZZZZZZZZ' as ProductoHasta, '' as DepositoDesde, 'ZZZZZ' as DepositoHasta, 
	' ' FamiliaDesde, 'ZZZZZZZZZZZZZZZ' FamiliaHasta, ' ' GrupoDesde, 'ZZZZZZZZZZZZZZZ' GrupoHasta, ' ' TipoDesde, 
	'ZZZZZ' TipoHasta


SELECT distinct stkDepositos.Deposito_Id
FROm stkExistencia inner join stkProductos ON
stkExistencia.Producto_Id = stkProductos.stkProductos
INNER JOIN stkDepositos ON
stkDepositos.stkDepositos = stkExistencia.Deposito_Id
where Cantidad <> 0 AND 
stkExistencia.Empresa_Id = ISNULL(@pEmpresa_Id, stkExistencia.Empresa_Id)
and (stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta)
and (stkDepositos.Deposito_Id between @pDepositoDesde and @pDepositoHasta)
union ALL
SELECT distinct
	'zEnTransito' as Deposito_Id

FROM
	stkEnTransito INNER JOIN stkMoviCabe ON
	stkEnTransito.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkMoviCuerpo ON 
	stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
	INNER JOIN conAsientos ON
	conAsientos.conAsientos =stkMoviCabe.stkMoviCabe 
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = stkMoviCabe.stkMoviCabe 
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	LEFT OUTER JOIN (stkMoviCabe stkMoviCabeEntr INNER JOIN conAsientos conAsientosEntr ON
		stkMoviCabeEntr.stkMoviCabe =conAsientosEntr.conAsientos) ON
	stkMoviCabeEntr.stkMoviCabe = stkEnTransito.stkMoviCabeEntr 
	inner join stkDepositos  as stkDepositosD ON
	stkDepositosD.stkDepositos = stkEnTransito.Deposito_Id
	inner join stkDepositos  ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
    INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
	WHERE
		conAsientos.Anulado = 0 and 
		conAsientosEntr.Fecha IS NULL and 
		conAsientos.Empresa_Id = ISNULL(@pEmpresa_Id,conAsientos.Empresa_Id) and
        stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta and 
		ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta and 
		ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @pGrupoDesde and @pGrupoHasta and 
		stkTipos.Tipo_Id between @pTipoDesde and @pTipoHasta
        --group by genEmpresas.Empresa_Id
UNION  -- COMPRAS
SELECT  Distinct 'zPorRecibir' as Deposito_Id
		from 	comOrdenComp inner join comOcCuerpo ON
		comOrdenComp.comOrdenComp = comOcCuerpo.comOrdenComp 
		INNER JOIN comOCArticulo ON
		comOcCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
		comOcCuerpo.Renglon_OC = comOCArticulo.Renglon_OC 
		INNER JOIN comOCSegmentos ON
		comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp 
		INNER JOIN stkProductos ON
		comOCArticulo.Producto_Id = stkProductos.stkProductos 
		INNER JOIN stkDepositos ON 
		stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
		LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
		LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
		INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
		Where

			stkDepositos.Deposito_Id BETWEEN @pDepositoDesde and @pDepositoHasta and
			stkProductos.Producto_Id between @pProductoDesde AND  @pProductoHasta and
			comOcCuerpo.Pendiente = 1 AND 
			ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta and 
			ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @pGrupoDesde and @pGrupoHasta and
			(comOcCuerpo.Cantidad > case when stkDepositos.consCompra_Venta = 1 then comOcCuerpo.CantidadConsignada else 
			 comOcCuerpo.Cantidad_Recibida end) and 
			NOT EXISTS(SELECT 1 FROM comEmbcuerpo WHERE
				comEmbcuerpo.comOrdenComp = comOcCuerpo.comOrdenComp and 
				comEmbcuerpo.Renglon_OC = comOcCuerpo.Renglon_OC) AND
			comOrdenComp.Estado_Id in ( 'A','P' ) AND 
			@pFamiliaDesde = ' ' and
			comOCSegmentos.Empresa_Id = ISNULL(@pEmpresa_Id,comOCSegmentos.Empresa_Id) and 
			stkTipos.Tipo_Id between @pTipoDesde and @pTipoHasta
UNION
SELECT  'zPorRecibir' as Deposito_Id 
Union
SELECT  'zEnReparto' as Deposito_Id 
order by 1


SELECT stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_id UniMed, 
stkDepositos.Deposito_Id, stkExistencia.Cantidad, 
ISNULL(stkExistencia.CantidadAlterna,0) CantidadAlterna, ISNULL(UniMed2.Medida_Id,'') UniMedAlt, 
stkProductos.Inactivo Inactivo
FROm stkExistencia inner join stkProductos ON
stkExistencia.Producto_Id = stkProductos.stkProductos
INNER JOIN stkDepositos ON
stkDepositos.stkDepositos = stkExistencia.Deposito_Id
LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
LEFT JOIN stkUniMed UniMed2 ON UniMed2.stkUniMed = stkProductos.MedidaAlterna
Where Cantidad <> 0 AND 
stkExistencia.Empresa_Id = ISNULL(@pEmpresa_Id,stkExistencia.Empresa_Id)
and (stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta)
and (stkDepositos.Deposito_Id between @pDepositoDesde and @pDepositoHasta)
and	ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta 
and	ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @pGrupoDesde and @pGrupoHasta and 
			stkTipos.Tipo_Id between @pTipoDesde and @pTipoHasta
union all
SELECT 
	stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_id,
	'zEnTransito' as Deposito_Id, sum(stkMoviCuerpo.Cantidad) as Cantidad,  
	SUM(ISNULL(stkMoviCuerpo.CantidadAlternaForm,0)) CantidadAlterna, ISNULL(UniMed2.Medida_Id,'') MedidaAlterna,
	stkProductos.Inactivo
FROM
	stkEnTransito INNER JOIN stkMoviCabe ON
	stkEnTransito.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkMoviCuerpo ON stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
	INNER JOIN conAsientos ON conAsientos.conAsientos =stkMoviCabe.stkMoviCabe 
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = stkMoviCabe.stkMoviCabe 
	INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
	LEFT JOIN stkUniMed UniMed2 ON UniMed2.stkUniMed = stkProductos.MedidaAlterna
	LEFT OUTER JOIN (stkMoviCabe stkMoviCabeEntr INNER JOIN conAsientos conAsientosEntr ON
		stkMoviCabeEntr.stkMoviCabe =conAsientosEntr.conAsientos) ON
	stkMoviCabeEntr.stkMoviCabe = stkEnTransito.stkMoviCabeEntr 
	inner join stkDepositos as stkDepositosD ON stkDepositosD.stkDepositos = stkEnTransito.Deposito_Id
	inner join stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
	WHERE
		conAsientos.Anulado = 0 and 
		conAsientosEntr.Fecha IS NULL and 
		conAsientos.Empresa_Id = ISNULL(@pEmpresa_Id,conAsientos.Empresa_Id) and
        stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta and 
		ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta and 
		ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @pGrupoDesde and @pGrupoHasta and 
		stkTipos.Tipo_Id between @pTipoDesde and @pTipoHasta
        group by stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_id, UniMed2.Medida_Id,stkProductos.Inactivo
UNION ALL
SELECT 
	stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_id, 'zPorRecibir' as Deposito_Id, 
		SUM(comOcCuerpo.Cantidad-case when stkDepositos.consCompra_Venta = 1 then comOcCuerpo.CantidadConsignada else 
			 comOcCuerpo.Cantidad_Recibida end )  as Cantidad, 
		0 CantidadAlterna, ISNULL(UniMed2.Medida_Id,'') MedidaAlterna,
		stkProductos.Inactivo
		from comOrdenComp inner join comOcCuerpo ON
		comOrdenComp.comOrdenComp = comOcCuerpo.comOrdenComp 
		INNER JOIN comOCArticulo ON comOcCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
		comOcCuerpo.Renglon_OC = comOCArticulo.Renglon_OC 
		INNER JOIN comOCSegmentos ON comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp 
		INNER JOIN stkProductos ON comOCArticulo.Producto_Id = stkProductos.stkProductos 
		INNER JOIN stkDepositos ON stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
		INNER JOIN stkUniMed ON stkProductos.Medida_id = stkUniMed.stkUniMed
		LEFT JOIN stkUniMed UniMed2 ON UniMed2.stkUniMed = stkProductos.MedidaAlterna
		LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
		LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
		INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
		Where
			stkDepositos.Deposito_Id BETWEEN @pDepositoDesde and @pDepositoHasta and
			stkProductos.Producto_Id between @pProductoDesde AND  @pProductoHasta and			
			comOcCuerpo.Pendiente = 1 AND 
			ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta and 
			ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @pGrupoDesde and @pGrupoHasta and 
			stkTipos.Tipo_Id between @pTipoDesde and @pTipoHasta	and 
			comOcCuerpo.Cantidad > comOcCuerpo.Cantidad_Recibida and 
			NOT EXISTS(SELECT 1 FROM comEmbcuerpo WHERE
				comEmbcuerpo.comOrdenComp = comOcCuerpo.comOrdenComp and 
				comEmbcuerpo.Renglon_OC = comOcCuerpo.Renglon_OC) AND
			comOrdenComp.Estado_Id in ( 'A','P' ) AND 
			comOCSegmentos.Empresa_Id = ISNULL(@pEmpresa_Id,comOCSegmentos.Empresa_Id)
	GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_id, UniMed2.Medida_Id,stkProductos.Inactivo
union all
select stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_id,
	'zPorRecibir' as Deposito_id, 0 as Cantidad, 0 CantidadAlterna, ISNULL(UniMed2.Medida_Id,'') MedidaAlterna,
	stkProductos.Inactivo
from stkProductos 
		LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
		LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
		INNER JOIN stkUniMed ON stkProductos.Medida_id = stkUniMed.stkUniMed
		LEFT JOIN stkUniMed UniMed2 ON UniMed2.stkUniMed = stkProductos.MedidaAlterna
		INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
where
			@pFamiliaDesde > ' ' and 
			stkProductos.Producto_Id between @pProductoDesde AND  @pProductoHasta and			
			ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta and 
			ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @pGrupoDesde and @pGrupoHasta and 
			stkTipos.Tipo_Id between @pTipoDesde and @pTipoHasta	and 
			not exists(select 1 from comOrdenComp inner join comOcCuerpo ON
					comOrdenComp.comOrdenComp = comOcCuerpo.comOrdenComp 
					INNER JOIN comOCArticulo ON
					comOcCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and  
					comOcCuerpo.Renglon_OC = comOCArticulo.Renglon_OC and
					comOCArticulo.Producto_Id = stkProductos.stkProductos 
					INNER JOIN comOCSegmentos ON
					comOrdenComp.comOrdenComp = comOCSegmentos.comOrdenComp 
					INNER JOIN stkDepositos ON 
					stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
					where
					stkDepositos.Deposito_Id BETWEEN @pDepositoDesde and @pDepositoHasta and
					comOcCuerpo.Pendiente = 1 AND 
					comOcCuerpo.Cantidad > comOcCuerpo.Cantidad_Recibida )
UNION ALL
select stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_id,
	'zEnReparto' as Deposito_id, SUM(venRepaPedi.CantidadForm*venPediCuerpo.Factor) as Cantidad, SUM(venRepaPedi.CantidadAlternaForm) CantidadAlterna, ISNULL(UniMed2.Medida_Id,'') MedidaAlterna,
	stkProductos.Inactivo

from venReparto
	INNER JOIN venRepaPedi ON  venRepaPedi.venReparto = venReparto.venReparto
	INNER JOIN venPediCuerpo ON venPediCuerpo.venPedidos = venRepaPedi.venPedidos and 
		venPediCuerpo.Renglon_Pe = venRepaPedi.Renglon_Pe
	inner join stkProductos ON  stkProductos.stkProductos = venPediCuerpo.Producto_Id
	inner join stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
	left join stkUniMed UniMed2 ON UniMed2.stkUniMed = stkProductos.MedidaAlterna
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	INNER JOIN stkTipos ON stkTipos.stkTipos = stkProductos.Tipo_Id
where
	venRepaPedi.Remitido = 0 and 
	venReparto.Cerrado = 0 and 
	venPediCuerpo.Pendiente = 1 AND 
	stkProductos.Producto_Id between @pProductoDesde AND  @pProductoHasta and			
	ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta and 
	ISNULL(stkGrupos.Grupo_Id,' ') BETWEEN @pGrupoDesde and @pGrupoHasta and 
	stkTipos.Tipo_Id between @pTipoDesde and @pTipoHasta	and 
	venReparto.Empresa_Id = @pEmpresa_Id
GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_id,
	ISNULL(UniMed2.Medida_Id,'') ,	stkProductos.Inactivo
	ORDER BY 1,3
	OPTION	(RECOMPILE)
go
