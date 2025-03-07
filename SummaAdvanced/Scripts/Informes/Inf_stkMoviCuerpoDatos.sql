/*El sp se Modificó para agergar las ubicaciones y se cre+o otro para los remitos */
DROP PROCEDURE Inf_stkMoviCuerpoDatos
GO
CREATE PROCEDURE Inf_stkMoviCuerpoDatos
(
@pstkMoviCabe bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

Declare @lItemsXRemito int
Set @lItemsXRemito = 0

SELECT qryinterno.*,
	ISNULL(stkMoviserie.Serie,'') Serie, ISNULL(ISNULL(ISNULL(stkMoviSerieUbicacion.Cantidad,stkMoviUbicacion.Cantidad),stkMoviserie.Cantidad),0) CantidadSerie, 
	ISNULL(ISNULL(stkUbicacionesSerie.Ubicacion_Id,stkUbicaciones.Ubicacion_Id),'') Ubicacion, isnull(stkSerieVencimiento.Vencimiento,'') FVencimiento, qryinterno.RenglonRenum as Renglon	
FROM (
		Select Case When @lItemsXRemito = 0 Then 1 Else 
		((Row_Number() Over (Order by RenglonRenum))-1)/@lItemsXRemito + 1 End Remito ,* From (
		/** query Original **/
		SELECT ROW_NUMBER() OVER( ORDER BY stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon) as RenglonRenum /*Agregado */, conAsientos.Empresa_Id,
		    stkMoviCuerpo.stkMoviCabe, stkMoviCuerpo.Renglon as Renglon_Orig /*Renombrado para join externo*/ , 0 RenglonReferencia, stkMoviCuerpo.Fecha,
			stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, 
			stkProductos.stkProductos /*agregado para join externo*/, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
			stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkMoviCuerpo.Factor, stkMoviCuerpo.Cantidad,
			stkMoviCuerpo.CantidadForm, stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.PrecioOriginal,
			stkMedidaAlterna.Medida_Id MedidaAlterna, stkMedidaAlterna.Descripcion as DescripcionMedidaAlterna,
			stkMoviCuerpo.CantidadAlternaForm,
			stkMoviCuerpo.Observaciones, 0.00 AS Descuento, stkMoviCuerpo.conRenglonDebe, 
			conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCuentaDebe,
			conCentro1Debe.Centro1_id as Centro1Debe, conCentro1Debe.Descripcion as DescripcionCentro1Debe,
			conCentro2Debe.Centro2_id as Centro2Debe, conCentro2Debe.Descripcion as DescripcionCentro2Debe,
			conMovContDebe.Clase as ClaseDebe, 
			IsNull(venPediRemitidos.Precio, conMovContDebe.Importe) as ImporteContableDebe, 
			stkMoviCuerpo.conRenglonHaber, 
			conCuentasHaber.Cuenta_id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCuentaHaber,
			conCentro1Haber.Centro1_id as Centro1Haber, conCentro1Haber.Descripcion as DescripcionCentro1Haber,
			conCentro2Haber.Centro2_id as Centro2Haber, conCentro2Haber.Descripcion as DescripcionCentro2Haber,
			conMovContHaber.Clase as ClaseHaber, conMovContDebe.Importe as ImporteContableHaber, '' Despacho_Id, --comDespachos.Despacho_Id,
				stuff((
			SELECT ''+ A FROM (SELECT DISTINCT ';'+ltrim(rtrim(COMDESPACHOS.Despacho_id))+'/'+ltrim(rtrim(COMDESPACHOS.Origen)) + convert(char(10),comDespachos.Fecha,103) a FROM COMDESPACHOS 
			INNER JOIN STKMOVIDESPA ON COMDESPACHOS.COMDESPACHOS = STKMOVIDESPA.DESPACHO_ID 
			WHERE STKMOVIDESPA.STKMOVICABE = @pstkMoviCabe) B 
			FOR XML PATH ('')),1,1,'') DESPACHOS,
			--comDespachos.Fecha Fechadespacho,comDespachos.Aduana, comDespachos.Origen
			GETDATE() Fechadespacho, '' Aduana, '' Origen, 
				stkProductos.MaterialPeligroso, stkProductos.CveMaterialPeligroso, 
					stkProductos.Embalaje
		FROM stkMoviCuerpo 
		Inner Join conAsientos On conAsientos.conAsientos = stkMoviCuerpo.stkMoviCabe
		INNER JOIN stkMoviCabe  ON (stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe)
		LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id)
		LEFT JOIN stkProductos  ON (stkProductos.stkProductos = stkMoviCuerpo.Producto_Id)
		LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id)
		INNER JOIN conMovCont  ON (conMovCont.conAsientos = stkMoviCuerpo.stkMoviCabe) AND (conMovCont.Renglon = stkMoviCuerpo.conRenglonDebe)
		INNER JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = stkMoviCuerpo.stkMoviCabe) AND (conMovCont2.Renglon = stkMoviCuerpo.conRenglonHaber)
		INNER JOIN conMovCont as conMovContDebe ON conMovContDebe.conAsientos = stkMoviCuerpo.stkMoviCabe And
			conMovContDebe.Renglon = stkMoviCuerpo.conRenglonDebe
		INNER JOIN conCuentas as conCuentasDebe ON conCuentasDebe.conCuentas = conMovContDebe.cuenta_id 
		LEFT JOIN conCentro1 as conCentro1Debe ON conCentro1Debe.conCentro1 = conMovContDebe.Centro1_id
		LEFT  JOIN conCentro2  as conCentro2Debe ON conCentro2Debe.conCentro2 = conMovContDebe.Centro2_id
		INNER JOIN conMovCont as conMovContHaber ON conMovContHaber.conAsientos = stkMoviCuerpo.stkMoviCabe And
			conMovContHaber.Renglon = stkMoviCuerpo.conRenglonHaber
		INNER JOIN conCuentas as conCuentasHaber ON conCuentasHaber.conCuentas = conMovContHaber.cuenta_id 
		LEFT JOIN conCentro1 as conCentro1Haber ON conCentro1Haber.conCentro1 = conMovContHaber.Centro1_id
		LEFT JOIN conCentro2  as conCentro2Haber ON conCentro2Haber.conCentro2 = conMovContHaber.Centro2_id
		LEFT JOIN stkUniMed stkMedidaAlterna ON stkMedidaAlterna.stkUniMed = stkMoviCuerpo.MedidaAlterna
		Left Join (Select stkMoviCabe, Renglon, venPediCuerpo.venPedidos, venPediCuerpo.Renglon_Pe, PrecioForm * venPediCuerpo.CantidadOriginal Precio
			From venPediCuerpo 
			Inner Join venPediRemitidos On venPediCuerpo.venPedidos = venPediRemitidos.venPedidos And venPediCuerpo.Renglon_Pe = venPediRemitidos.Renglon_Pe) venPediRemitidos
			On venPediRemitidos.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And venPediRemitidos.Renglon = stkMoviCuerpo.Renglon

		--Left Join stkMoviDespa On stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And stkMoviDespa.Renglon = stkMoviCuerpo.Renglon
		--Left Join comDespachos On comDespachos.comDespachos = stkMoviDespa.Despacho_Id
		/** Se puso fuera de este query interno. Se hacen los joins despues de haber renumerado los renglones
		left outer join stkMoviSerie on stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe and stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
		left join stkSerieVencimiento on stkSerieVencimiento.Serie = stkmoviserie.Serie and stkSerieVencimiento.Producto_Id = stkmovicuerpo.Producto_Id
		**/
		WHERE (stkMoviCuerpo.stkMoviCabe = @pstkMoviCabe)
		AND (stkMoviCuerpo.Renglon = ISNULL(@pRenglon, stkMoviCuerpo.Renglon))
		) subqryinterno
  ) qryinterno
  left outer join stkMoviSerie on qryinterno.stkMoviCabe = stkMoviSerie.stkMoviCabe and qryinterno.Renglon_Orig = stkMoviSerie.Renglon
LEFT JOIN stkSerieVencimiento on stkSerieVencimiento.Serie = stkmoviserie.Serie and stkSerieVencimiento.Producto_Id = qryinterno.stkProductos And
	stkSerieVencimiento.Empresa_Id = qryinterno.Empresa_Id
LEFT JOIN (stkMoviUbicacion INNER JOIN stkUbicaciones ON stkMoviUbicacion.Ubicacion_Id = stkUbicaciones.stkUbicaciones)
	ON qryinterno.stkMoviCabe = stkMoviUbicacion.stkMoviCabe and qryinterno.Renglon_Orig = stkMoviUbicacion.Renglon
LEFT JOIN (stkMoviSerieUbicacion INNER JOIN stkUbicaciones stkUbicacionesSerie ON stkMoviSerieUbicacion.Ubicacion_Id = stkUbicacionesSerie.stkUbicaciones)
	ON qryinterno.stkMoviCabe = stkMoviSerieUbicacion.stkMoviCabe and qryinterno.Renglon_Orig = stkMoviSerieUbicacion.Renglon AND
	stkMoviSerie.Serie = stkMoviSerieUbicacion.Serie
ORDER BY 2 
RETURN @@Error 
GO
