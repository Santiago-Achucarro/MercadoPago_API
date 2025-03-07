DROP Function dbo.QueT3Cantidad
GO
CREATE Function dbo.QueT3Cantidad(
	@Producto_Id int, 
	@Medida_Id int
)
returns Numeric(18,8) 
as
begin
declare @Ret Numeric(18,8)

	IF (select medida_id from stkProductos where stkProductos = @Producto_Id ) = @Medida_Id 
	begin
			return 1.000
	end
	set @Ret = (select Factor from stkArtiUM where
				stkArtiUM.Producto_Id = @Producto_Id and 
				Medida_Id = @Medida_Id)

	return ISNULL(@Ret,1)

end
GO
-- proOrdenCerrarrDatos 'OPRO',4,0,0,0,'0001',' ', ' ', ' ',1
DROP PROCEDURE proOrdenCerrarrDatos
GO

CREATE PROCEDURE proOrdenCerrarrDatos
(
	@pSegmento_Id varchar(10),
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C varchar(20),
	@pSegmento2C varchar(20),
	@pSegmento3C varchar(20),
	@pSegmento4C varchar(20),
	@pEmpresa_Id int

)
AS
DECLARE @proMovCierreOrden int

set @proMovCierreOrden = (select proMovCierreOrden.proMovCierreOrden
	from proMovCierreOrden 
	inner join genAsiSegmentos ON proMovCierreOrden.proMovCierreOrden =  genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	Where
	genSegmentos.Segmento_Id = @pSegmento_Id AND
	genAsiSegmentos.Segmento1N = @pSegmento1N AND 
	genAsiSegmentos.Segmento2N = @pSegmento2N AND 
	genAsiSegmentos.Segmento3N = @pSegmento3N AND 
	genAsiSegmentos.Segmento4N = @pSegmento4N AND 
	genAsiSegmentos.Segmento1C = @pSegmento1C AND 
	genAsiSegmentos.Segmento2C = @pSegmento2C AND 
	genAsiSegmentos.Segmento3C = @pSegmento3C AND 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

SELECT 
	proMovCierreOrden.proOrden, 
	genSegmentos.Segmento_Id Segmento_Id, genAsiSegmentos.Segmento1N , 
	genAsiSegmentos.Segmento2N , genAsiSegmentos.Segmento3N , 	genAsiSegmentos.Segmento4N ,
	genAsiSegmentos.Segmento1C , genAsiSegmentos.Segmento2C , genAsiSegmentos.Segmento3C , 	
	genAsiSegmentos.Segmento4C , conasientos.Observaciones,
	conAsientos.Fecha  FechaFin,
	proMovCierreOrden.Cantidad as CantIngPendiente,
	conAsientos.Anulado, case when proMovCierreOrden.Parcial=1 then '2' ELSE '1' END  TipoCierre, 
	proCausas.Causa_Id , proCausas.Descripcion DescripcionCausa, 
	proTurnos.Turno_Id , proTurnos.Descripcion DescripcionTurno, 
	proMovCierreOrden.proMovCierreOrden
FROM proMovCierreOrden Inner join genAsiSegmentos on 
proMovCierreOrden.proMovCierreOrden = genAsiSegmentos.Asiento_Id
INNER JOIN conAsientos ON 
conAsientos.conAsientos = proMovCierreOrden.proMovCierreOrden
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
LEFT JOIN proCausas ON proCausas.proCausas = proMovCierreOrden.Causa_Id
LEFT JOIN proTurnos ON proTurnos.proTurnos = proMovCierreOrden.Turno_Id
where 
genSegmentos.Segmento_Id = @pSegmento_Id AND
genAsiSegmentos.Segmento1N = @pSegmento1N AND 
genAsiSegmentos.Segmento2N = @pSegmento2N AND 
genAsiSegmentos.Segmento3N = @pSegmento3N AND 
genAsiSegmentos.Segmento4N = @pSegmento4N AND 
genAsiSegmentos.Segmento1C = @pSegmento1C AND 
genAsiSegmentos.Segmento2C = @pSegmento2C AND 
genAsiSegmentos.Segmento3C = @pSegmento3C AND 
genAsiSegmentos.Segmento4C = @pSegmento4C 

-- orden de produccion
SELECT 
	genSegmentos.Segmento_Id, proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N,
	proOrdenSegmento.Segmento1C, proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 	
	proRecetas.Receta_Id, 	proRecetas.Descripcion as DescripcionReceta, 
	proOrden.Cantidad, proOrden.CantidadIngresada, 
	proOrden.FechaEmision, proOrden.FechaNecesidad, proOrden.FechaProduccion,
	proOrden.CantidadTerminada, (proOrden.Cantidad - proOrden.CantidadTerminada)/proOrden.Factor as CantPendiente,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida, Factor 
FROM proMovCierreOrden 
INNER JOIN proOrden ON proOrden.proOrden = promovCierreOrden.proOrden
inner join proOrdenSegmento on proOrdenSegmento.proOrden=proOrden.proOrden
inner join stkProductos on stkProductos=proOrden.Producto_Id
inner join proRecetas on proRecetas=proOrden.Receta_Id
inner join genSegmentos on genSegmentos.genSegmentos=proOrdenSegmento.Segmento_Id
INNER join stkUniMed on stkUniMed.stkUniMed=proOrden.Medida_Id
Where
	proMovCierreOrden.proMovCierreOrden = @proMovCierreOrden



SELECT proMovCierreOrden.proOrden, stkMoviCuerpo.Renglon, 
	'C' EntradaSalida, 
	stkUniMed.Medida_Id, 
	stkProductos.Producto_Id, stkProductos.Descripcion,
	stkMoviCuerpo.Cantidad,
	stkDepositos.Deposito_Id
From proMovCierreOrden 
inner join proOrdenStock ON proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
inner join proOrden ON proMovCierreOrden.proOrden = proOrden.proOrden
inner join stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkUniMed ON  stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
INNER JOIN stkMoviCabe on  stkMoviCabe.stkMoviCabe = proOrdenStock.stkMoviCabe
WHERE
	proMovCierreOrden.proMovCierreOrden = @proMovCierreOrden and 
	stkMoviCabe.Signo = -1

ORDER BY 3,2

-- Trbajos de 3
SELECT proMovCierreOrden.proOrden, proMovCierreTrabajos3.Renglon, 
	proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	proMovCierreTrabajos3.Cantidad, 
	proMovCierreTrabajos3.PrecioOriginal as Preciouni, 
	genMonedas.Moneda_Id, 
	CASE WHEN proMovCierreTrabajos3.PrecioOriginal != 0 THEN 
		ROUND(proMovCierreTrabajos3.Precio/proMovCierreTrabajos3.PrecioOriginal,4) ELSE 1 END as Cambio
FROM proMovCierreOrden 
INNER JOIN proMovCierreTrabajos3 on proMovCierreTrabajos3.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN proTrabajo3 ON proTrabajo3.proTrabajo3 =  proMovCierreTrabajos3.Trabajo3_Id
inner join proTrabajo3Prov on proTrabajo3Prov.Trabajo3_Id =  proMovCierreTrabajos3.Trabajo3_Id and 
			proTrabajo3Prov.Proveedor_Id = proMovCierreTrabajos3.Proveed_Id
INNER JOIN comProveedores  on comProveedores.genEntidades =  proMovCierreTrabajos3.Proveed_Id
inner join genMonedas ON proTrabajo3Prov.Moneda_Id = proMovCierreTrabajos3.Moneda_Id
WHERE
	proMovCierreTrabajos3.proMovCierreOrden = @proMovCierreOrden
ORDER BY 2
-- Recursos
select proMovCierreOrden.proOrden, proMovCierreRecursos.Renglon, 
	proRecursos.Recurso_Id, proRecursos.Descripcion,
	proSubRecursos.SubRecurso_Id as SubRecurso_Id, proSubRecursos.Descripcion as DescripcionSubRecurso, 
	Cast(case when proSubRecursos.SubRecurso_Id is null then 0 else  1 end  as bit) as UsaSubRecurso,
	proMovCierreRecursos.Cantidad, proMovCierreRecursos.Costo
From proMovCierreOrden 
INNER JOIN proMovCierreRecursos ON proMovCierreRecursos.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN proRecursos ON  proRecursos.proRecursos = proMovCierreRecursos.Recurso_Id
LEFT JOIN proSubRecursos ON proSubRecursos.proSubRecursos = proMovCierreRecursos.SubRecurso_Id
Where
	proMovCierreOrden.proMovCierreOrden = @proMovCierreOrden
ORDER BY 2

-- Produccciones 
SELECT proMovCierreOrden.proOrden, stkMoviCuerpo.Renglon AS Renglon, 
	'P' EntradaSalida, 
	stkUniMed.Medida_Id, 
	stkProductos.Producto_Id, stkProductos.Descripcion,
	stkMoviCuerpo.Cantidad,
	proOrdenStockCosto.PorcentajeCosto , 
	stkDepositos.Deposito_Id, '' ParaPegar
From proMovCierreOrden 
inner join proOrdenStock ON proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
inner join proOrden ON proMovCierreOrden.proOrden = proOrden.proOrden
inner join stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkUniMed ON  stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
INNER JOIN stkMoviCabe on  stkMoviCabe.stkMoviCabe = proOrdenStock.stkMoviCabe
LEFT JOIN proOrdenStockCosto ON proOrdenStockCosto.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
		proOrdenStockCosto.Renglon = stkMoviCuerpo.Renglon and 
		proOrdenStockCosto.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden

WHERE
	proMovCierreOrden.proMovCierreOrden = @proMovCierreOrden and 
	stkMoviCabe.Signo = 1
ORDER BY 2,3

-- SERIES consumo
SELECT stkMoviSerie.stkMoviCabe, stkMoviSerie.Renglon, stkMoviSerie.Serie, stkMoviSerie.Cantidad / stkMoviCuerpo.Factor Cantidad, stkSerieVencimiento.Vencimiento,
	ISNULL(stkUbicaciones.Ubicacion_Id,' ') AS Ubicacion_Id, Cast(0 As Numeric(18,8)) Existencia,
	Case @proMovCierreOrden When 0 Then Cast(0 As bit) Else Cast(1 As bit) End Marcado
FROM proOrdenStock INNER JOIN 
stkMoviSerie ON stkMoviSerie.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
INNER JOIN stkMoviCabe ON  stkMoviCabe.stkMoviCabe =  stkMoviCuerpo.stkMoviCabe
Inner Join conAsientos On conAsientos.conAsientos = stkMoviCuerpo.stkMoviCabe
Left Join stkSerieVencimiento On stkSerieVencimiento.Serie = stkMoviSerie.Serie And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
		stkSerieVencimiento.Empresa_Id = conAsientos.Empresa_Id
LEFT Join (stkMoviSerieUbicacion INNER JOIN stkUbicaciones ON 
		stkMoviSerieUbicacion.Ubicacion_Id = stkUbicaciones.stkUbicaciones) ON 
		stkMoviSerieUbicacion.stkMoviCabe = stkMoviSerie.stkMoviCabe and 
		stkMoviSerieUbicacion.Renglon = stkMoviSerie.Renglon and 
		stkMoviSerieUbicacion.Serie = stkMoviSerie.Serie

WHERE proOrdenStock.proMovCierreOrden = @proMovCierreOrden and 
stkMoviCabe.Signo= -1 

-- SERIES Produccion
SELECT stkMoviSerie.stkMoviCabe, stkMoviSerie.Renglon AS Renglon , stkMoviSerie.Serie, stkMoviSerie.Cantidad, stkSerieVencimiento.Vencimiento,
	stkUbicaciones.Ubicacion_Id
FROM proOrdenStock INNER JOIN 
stkMoviSerie ON stkMoviSerie.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
INNER JOIN stkMoviCabe ON  stkMoviCabe.stkMoviCabe =  stkMoviCuerpo.stkMoviCabe
Inner Join conAsientos On conAsientos.conAsientos = stkMoviCuerpo.stkMoviCabe
Left Join stkSerieVencimiento On stkSerieVencimiento.Serie = stkMoviSerie.Serie And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
		stkSerieVencimiento.Empresa_Id = conAsientos.Empresa_Id
LEFT Join (stkMoviSerieUbicacion INNER JOIN stkUbicaciones ON 
		stkMoviSerieUbicacion.Ubicacion_Id = stkUbicaciones.stkUbicaciones) ON 
		stkMoviSerieUbicacion.stkMoviCabe = stkMoviSerie.stkMoviCabe and 
		stkMoviSerieUbicacion.Renglon = stkMoviSerie.Renglon and 
		stkMoviSerieUbicacion.Serie = stkMoviSerie.Serie
WHERE proOrdenStock.proMovCierreOrden = @proMovCierreOrden and 
stkMoviCabe.Signo= 1 

-- UBICACIONES Consumo

select stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id, Cast(0 As Numeric(19,8)) Cantidad, Cast(0 As Numeric(19,8)) CantidadAlterna,
	stkMoviUbicacion.Cantidad / stkMoviCuerpo.Factor as Existencia, stkMoviUbicacion.CantidadAlterna ExistenciaAlterna
from proOrdenStock INNER JOIN stkMoviUbicacion  ON stkMoviUbicacion.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkMoviCuerpo ON stkMoviUbicacion.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
							stkMoviUbicacion.Renglon = stkMoviCuerpo.Renglon
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkMoviCabe ON stkMoviCabe.stkMoviCabe= stkMoviCuerpo.stkMoviCabe
INNER JOIN stkUbicaciones ON  stkUbicaciones.stkUbicaciones= stkMoviUbicacion.Ubicacion_Id
WHERE
	proOrdenStock.proMovCierreOrden = @proMovCierreOrden and 
	stkMoviCabe.Signo = -1 
	


Select stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id, 
		stkMoviUbicacion.Cantidad, stkMoviUbicacion.CantidadAlterna
from proOrdenStock INNER JOIN stkMoviUbicacion  ON stkMoviUbicacion.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkMoviCuerpo ON stkMoviUbicacion.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
							stkMoviUbicacion.Renglon = stkMoviCuerpo.Renglon
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkMoviCabe ON stkMoviCabe.stkMoviCabe= stkMoviCuerpo.stkMoviCabe
INNER JOIN stkUbicaciones ON  stkUbicaciones.stkUbicaciones= stkMoviUbicacion.Ubicacion_Id
WHERE
	proOrdenStock.proMovCierreOrden = @proMovCierreOrden and 
	stkMoviCabe.Signo = 1

GO


DROP  PROCEDURE proOrdenCerrarrCalcular
GO
CREATE PROCEDURE proOrdenCerrarrCalcular(
	@pproOrden INT,
	@pCantidad Decimal
)
as

SELECT @pproOrden as proOrden, @pCantidad Cantidad

--Update proOrden set Factor = 1 where Factor = 0 and proOrden = @pproOrden

SELECT 
	genSegmentos.Segmento_Id, proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N,
	proOrdenSegmento.Segmento1C, proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 	
	proRecetas.Receta_Id, 	proRecetas.Descripcion as DescripcionReceta, 
	proOrden.Cantidad, proOrden.CantidadIngresada, 
	proOrden.FechaEmision, proOrden.FechaNecesidad, proOrden.FechaProduccion,
	proOrden.CantidadTerminada, (proOrden.Cantidad - proOrden.CantidadTerminada)/proOrden.Factor as CantPendiente,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida, Factor 
FROM proOrden 
inner join proOrdenSegmento on proOrdenSegmento.proOrden=proOrden.proOrden
inner join stkProductos on stkProductos=proOrden.Producto_Id
inner join proRecetas on proRecetas=proOrden.Receta_Id
inner join genSegmentos on genSegmentos.genSegmentos=proOrdenSegmento.Segmento_Id
INNER join stkUniMed on stkUniMed.stkUniMed=proOrden.Medida_Id
Where
	proOrden.proOrden = @pproOrden

-- CONSUMOS
SELECT proOrdenProd.proOrden, proOrdenProd.Renglon, 
	proOrdenProd.EntradaSalida, 
	stkUniMed.Medida_Id, 
	stkProductos.Producto_Id, stkProductos.Descripcion,
	Convert(numeric(18,4) , proOrdenProd.Cantidad / proOrden.Cantidad * @pCantidad) as Cantidad,
	case when proOrdenProd.TomaDepoT3 = 0 THEN 	stkDepositos.Deposito_Id ELSE
		(SELECT MAX( stkDepistosT3.Deposito_Id) FROM stkDepositos  stkDepistosT3, proOrdenTrabajos3, proTrabajo3Prov 
			WHERE
				proOrdenTrabajos3.proOrden = proOrden.proOrden AND 
				proTrabajo3Prov.Trabajo3_Id = proOrdenTrabajos3.proTrabajo3 AND 
				proTrabajo3Prov.Proveedor_Id = proOrdenTrabajos3.Proveed_Id AND 
				stkDepistosT3.stkDepositos = proTrabajo3Prov.Deposito_Id) END as Deposito_Id
From proOrdenProd inner join proOrden ON 
proOrdenProd.proOrden = proOrden.proOrden
INNER JOIN stkProductos ON stkProductos.stkProductos = proOrdenProd.Producto_Id
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = proOrdenProd.Deposito_Id
INNER JOIN stkUniMed ON  stkUniMed.stkUniMed = proOrdenProd.Medida_Id
WHERE
	proOrden.proOrden = @pproOrden  and 
	proOrdenProd.EntradaSalida = 'C'

SELECT proOrdenTrabajos3.proOrden, proOrdenTrabajos3.Renglon, 
	proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	Convert(numeric(18,4) , proOrden.Cantidad / dbo.QueT3Cantidad(proOrden.Producto_id, 
		proTrabajo3Prov.Medida_Id)  * @pCantidad / proOrden.Cantidad) as Cantidad, 
		Convert(numeric(18,4),proTrabajo3Prov.Precio /  proTrabajo3Prov.Cantidad) as Preciouni, 
		 genMonedas.Moneda_Id
FROM proOrdenTrabajos3 inner join proTrabajo3 ON
proTrabajo3.proTrabajo3 =  proOrdenTrabajos3.proTrabajo3
inner join proTrabajo3Prov on 
proTrabajo3Prov.Trabajo3_Id =  proOrdenTrabajos3.proTrabajo3  and 
proTrabajo3Prov.Proveedor_Id = proOrdenTrabajos3.Proveed_Id
INNER JOIN comProveedores  on 
comProveedores.genEntidades =  proTrabajo3Prov.Proveedor_Id
INNER JOIN proOrden on 
proOrden.proOrden = proOrdenTrabajos3.proOrden
inner join genMonedas ON
proTrabajo3Prov.Moneda_Id = genMonedas.genMonedas
WHERE
	proOrden.proOrden = @pproOrden

select proOrdenRecursos.proOrden, proOrdenRecursos.Renglon, 
	proRecursos.Recurso_Id, proRecursos.Descripcion,
	' ' as SubRecurso_Id, ' ' as DescripcionSubRecurso, proRecursos.UsaSubRecurso,
	Convert(numeric(18,2), proOrdenRecursos.Cantidad * @pCantidad/ proOrden.Cantidad) as Cantidad
	, proRecursos.Costo
From proOrdenRecursos
INNER JOIN proRecursos ON 
proRecursos.proRecursos = proOrdenRecursos.Recurso_Id
INNER JOIN proOrden ON
proOrden.proOrden = proOrdenRecursos.proOrden
Where
	proRecursos.UsaSubRecurso = 0 and 
	proOrden.proOrden = @pproOrden
UNION ALL
select proOrdenRecursos.proOrden, proOrdenRecursos.Renglon, 
	proRecursos.Recurso_Id, proRecursos.Descripcion,
	proSubRecursos.SubRecurso_Id, proSubRecursos.Descripcion as DescripcionSubRecurso,
	proRecursos.UsaSubRecurso,
	Convert(numeric(18,2), proOrdenSubRecurso.Cantidad * @pCantidad/ proOrden.Cantidad) as Cantidad
	, proSubRecursos.Costo
From proOrdenRecursos
INNER JOIN proRecursos ON 
proRecursos.proRecursos = proOrdenRecursos.Recurso_Id
INNER JOIN proOrden ON
proOrden.proOrden = proOrdenRecursos.proOrden
INNER JOIN proOrdenSubRecurso ON
proOrdenSubRecurso.proOrden = proOrdenRecursos.proOrden AND 
proOrdenSubRecurso.Renglon = proOrdenRecursos.Renglon
inner join proSubRecursos on 
proSubRecursos.proSubRecursos = proOrdenSubRecurso.SubRecurso_Id
Where
	proRecursos.UsaSubRecurso = 1 and 
	proOrden.proOrden = @pproOrden


-- producciones
SELECT proOrdenProd.proOrden, proOrdenProd.Renglon, 
	proOrdenProd.EntradaSalida, 
	stkUniMed.Medida_Id, 
	stkProductos.Producto_Id, stkProductos.Descripcion,
	Convert(numeric(18,4) , proOrdenProd.Cantidad / proOrden.Cantidad * @pCantidad) as Cantidad,
	proOrdenProd.PorcentajeCosto, 
	case when proOrdenProd.TomaDepoT3 = 0 THEN 	stkDepositos.Deposito_Id ELSE
		(SELECT MAX( stkDepistosT3.Deposito_Id) FROM stkDepositos  stkDepistosT3, proOrdenTrabajos3, proTrabajo3Prov 
			WHERE
				proOrdenTrabajos3.proOrden = proOrden.proOrden AND 
				proTrabajo3Prov.Trabajo3_Id = proOrdenTrabajos3.proTrabajo3 AND 
				proTrabajo3Prov.Proveedor_Id = proOrdenTrabajos3.Proveed_Id AND 
				stkDepistosT3.stkDepositos = proTrabajo3Prov.Deposito_Id) END as Deposito_Id
From proOrdenProd inner join proOrden ON 
proOrdenProd.proOrden = proOrden.proOrden
INNER JOIN stkProductos ON stkProductos.stkProductos = proOrdenProd.Producto_Id
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = proOrdenProd.Deposito_Id
INNER JOIN stkUniMed ON  stkUniMed.stkUniMed = proOrdenProd.Medida_Id
WHERE
	proOrden.proOrden = @pproOrden  and 
	proOrdenProd.EntradaSalida = 'P'


GO


-- proOrdenCerrarrCalcular 62, 100

