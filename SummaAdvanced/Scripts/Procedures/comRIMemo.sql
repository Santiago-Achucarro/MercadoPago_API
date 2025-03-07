DROP PROCEDURE comRIMemoGuardar
GO
CREATE PROCEDURE comRIMemoGuardar
(
@pcomReqInterno int,
@pRenglon_RI int,
@pSubCategoria_Id varchar(5) = NULL,
@pDetalle QMemo = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comRIMemo WHERE (comReqInterno = @pcomReqInterno) AND (Renglon_RI = @pRenglon_RI)))
BEGIN 
	UPDATE comRIMemo
	SET		SubCategoria_Id = dbo.FuncFKcomSubCategorias(@pSubCategoria_Id),
		Detalle = @pDetalle
	WHERE (comReqInterno = @pcomReqInterno) AND (Renglon_RI = @pRenglon_RI)
END 
ELSE 
BEGIN 
	INSERT INTO comRIMemo
	(
		comReqInterno,
		Renglon_RI,
		SubCategoria_Id,
		Detalle
	)
	VALUES 
	(
		@pcomReqInterno,
		@pRenglon_RI,
		dbo.FuncFKcomSubCategorias(@pSubCategoria_Id),
		@pDetalle
	)
END 

GO

DROP PROCEDURE comRIMemoDatos
GO
CREATE PROCEDURE comRIMemoDatos
(
@pcomReqInterno int,
@pRenglon_RI int=null
)
AS
SET NOCOUNT ON 

SELECT  comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad,
	comRICuerpo.Precio, comRICuerpo.CantidadRecibida, comRICuerpo.Observaciones, comRICuerpo.Pendiente,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed,

comRIMemo.comReqInterno, comSubCategorias.SubCategoria_Id,
	comSubCategorias.Descripcion as DescripcionSubCategorias, comRIMemo.Detalle, comCategorias.Categoria_Id, comCategorias.Descripcion as DescripcionCategoria
FROM comRIMemo 
INNER JOIN comRICuerpo  ON (comRICuerpo.comReqInterno = comRIMemo.comReqInterno) AND (comRICuerpo.Renglon_RI = comRIMemo.Renglon_RI)
LEFT JOIN comSubCategorias  ON (comSubCategorias.comSubCategorias = comRIMemo.SubCategoria_Id)
INNER JOIN comReqInterno  ON (comReqInterno.comReqInterno = comRICuerpo.comReqInterno)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comRICuerpo.Cuenta_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comRICuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comRICuerpo.Centro2_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comRICuerpo.Medida_Id)
left join comCategorias on comCategorias.comCategorias=comSubCategorias.Categoria_Id
WHERE (comReqInterno.comReqInterno = @pcomReqInterno)
AND (comRIMemo.Renglon_RI = isnull(@pRenglon_RI, comRIMemo.Renglon_RI))
 
 RETURN @@Error 

GO

DROP PROCEDURE comRIMemoEliminar
GO
CREATE PROCEDURE comRIMemoEliminar
(
@pcomReqInterno int,
@pRenglon_RI int=null
)
AS
SET NOCOUNT ON 

DELETE FROM comRIMemo 
WHERE (comReqInterno = @pcomReqInterno)
AND (Renglon_RI = isnull(@pRenglon_RI, Renglon_RI))
 
 RETURN @@Error 

GO

GO