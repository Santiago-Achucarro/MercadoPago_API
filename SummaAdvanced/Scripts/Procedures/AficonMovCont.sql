DROP PROCEDURE AficonMovcontGuardar
GO
CREATE PROCEDURE AficonMovcontGuardar
(
@pconAsientos bigint,
@pRenglon int,
@pActivoFijo_Id VarChar(15) = NULL,
@pInactivo Sino,
@Empresa_Id Int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM AficonMovcont WHERE (conAsientos = @pconAsientos) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE AficonMovcont
	SET		ActivoFijo_Id = dbo.FuncFKafiActivoFijo(@pActivoFijo_Id, @Empresa_Id),
		Inactivo = @pInactivo
	WHERE (conAsientos = @pconAsientos) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO AficonMovcont
	(
		conAsientos,
		Renglon,
		ActivoFijo_Id,
		Inactivo
	)
	VALUES 
	(
		@pconAsientos,
		@pRenglon,
		dbo.FuncFKafiActivoFijo(@pActivoFijo_Id, @Empresa_Id),
		@pInactivo
	)
END 

GO

DROP PROCEDURE AficonMovcontDatos
GO
CREATE PROCEDURE AficonMovcontDatos
(
@pconAsientos bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

SELECT AficonMovcont.conAsientos, AficonMovcont.Renglon, conMovCont.LeyendaLibroMayor as DescripcionMovCont, 
	afiActivoFijo.Empresa_Id, 	afiActivoFijo.ActivoFijo_Id, afiActivoFijo.Descripcion as DescripcionActivoFijo, 
	AficonMovcont.Inactivo
FROM AficonMovcont 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = AficonMovcont.conAsientos) AND (conMovCont.Renglon = AficonMovcont.Renglon)
LEFT JOIN afiActivoFijo  ON (afiActivoFijo.afiActivoFijo = AficonMovcont.ActivoFijo_Id)
WHERE (AficonMovcont.conAsientos = @pconAsientos)
AND (AficonMovcont.Renglon = ISNULL(@pRenglon,AficonMovcont.Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE AficonMovcontEliminar
GO
CREATE PROCEDURE AficonMovcontEliminar
(
@pconAsientos bigint,
@pRenglon int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM AficonMovcont 
WHERE (conAsientos = @pconAsientos)
AND (Renglon = isnull(@pRenglon, AficonMovcont.Renglon)) and 
AficonMovcont.ActivoFijo_Id  IS NULL
 
RETURN @@Error 

GO

DROP PROCEDURE [dbo].[AficonMovcontPendDatos]
GO
CREATE PROCEDURE [dbo].[AficonMovcontPendDatos]
(
	@Empresa_id INT
)
AS
SET NOCOUNT ON 

SELECT AficonMovcont.conAsientos, AficonMovcont.Renglon, 
	ISNULL(comMovDetalle.Detalle, conMovCont.LeyendaLibroMayor) as DescripcionMovCont, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante,
	conAsientos.Fecha, 	conAsientos.Empresa_Id , conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conMovCont.Importe ,  ISNULL(comOcReceCuerpo.Cantidad, 1.00) as Cantidad,conCentro1.Centro1_Id,conCentro1.Descripcion as DescripcionCentro1,conCentro2.Centro2_Id,conCentro2.Descripcion as DescripcionCentro2,100 as Porcentaje
FROM AficonMovcont 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = AficonMovcont.conAsientos) AND 
	(conMovCont.Renglon = AficonMovcont.Renglon)
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
LEFT JOIN comMovDetalle ON comMovDetalle.comMovProv = conMovCont.conAsientos and 
	comMovDetalle.Renglon = conMovCont.Renglon
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
left join conCentro1 on conMovCont.Centro1_Id=conCentro1.conCentro1
left join conCentro2 on conMovCont.Centro2_Id=conCentro2.conCentro2
LEFT JOIN comOcReceCuerpo ON comOcReceCuerpo.comOcRecepcion =  conMovCont.conAsientos and 
comOcReceCuerpo.conRenglon = conMovCont.Renglon
WHERE 
	AficonMovcont.ActivoFijo_Id  IS NULL AND
	AficonMovcont.Inactivo = 0 AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and
	genAsiSegmentos.Empresa_Id = @Empresa_id 
ORDER BY 1
 
RETURN @@Error 

GO




DROP PROCEDURE [dbo].[AficonMovcontAsiInsertar]
GO


CREATE PROCEDURE [dbo].[AficonMovcontAsiInsertar]
(
	@pconAsientos bigint
)
AS
	INSERT INTO AficonMovcont
	(
		conAsientos,
		Renglon,
		ActivoFijo_Id,
		Inactivo
	)
	SELECT conMovCont.conAsientos, conMovCont.Renglon, NULL, 0
	FROM conMovCont 
	INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
	INNER JOIN conTipoEspecialesCuerpo ON conTipoEspecialesCuerpo.Tipo_Id =  conCuentas.Tipo_Id
	INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
	Where
		conAsientos.Especial NOT IN ('APE','CIR','CCP') AND
		conMovCont.Clase != 'VO' AND 
		conMovCont.conAsientos = @pconAsientos and 
		conTipoEspecialesCuerpo.TipoEspe_Id = 'AFVO'
	


GO

