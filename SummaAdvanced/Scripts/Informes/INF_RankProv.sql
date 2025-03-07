-- INF_RankProv '20180901','20180930',1
DROP PROCEDURE INF_RankProv 
GO
CREATE PROCEDURE INF_RankProv 
(
@FechaDesde DateTime, 
@FechaHasta DateTime, 
@Empresa int, 
@TipoProvDesde VarChar(5),
@TipoProvHasta VarChar(5)
)
AS
SELECT comProveedores.Proveed_id, comProveedores.RazonSocial, 
	Convert(Numeric(18,2), -SUM((Proveedores.Importe - IsNull(Impuestos.Importe, 0)) * comMovTipos.Signo)) as Monto
FROm comMovProv 
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
Inner Join conMovCont Proveedores On Proveedores.conAsientos = conAsientos.conAsientos And Proveedores.Clase = 'PRO'
Left Join (Select conAsientos, Sum(Importe*(-2*conMovCont.TipoMov+3)) Importe From conMovCont Where Clase = 'FPIMP' Group By conAsientos) Impuestos On Impuestos.conAsientos = conAsientos.conAsientos
INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id 
INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovProv.Tipomov
LEFT JOIN comProvTipos ON  comProvTipos.comProvTipos = comProveedores.ProvTipo_Id
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa and 
	comMovTipos.Tipomov NOT IN ('P','C','V','W','X','Y') and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta  and 
	ISNULL(comProvTipos.ProvTipo_Id,' ') between @TipoProvDesde  and @TipoProvHasta
GROUP BY comProveedores.Proveed_id, comProveedores.RazonSocial
ORDER BY 3 DESC
GO
