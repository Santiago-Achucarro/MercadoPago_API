DROP PROCEDURE sueConcAcumGuardar
GO
CREATE PROCEDURE sueConcAcumGuardar
(
@psueConcAcum int, 
@pConcepto_Id int,
@pLegajo bigint,
@pFecha datetime,
@pMontoTope qMonedaD2,
@pDescuento qMonedaD2,
@pAcumulado qMonedaD2,
@pUsuario_Id int , 
@pAnulado Bit
)
AS
SET NOCOUNT ON 

IF (EXISTS (SELECT 1 FROM sueConcAcum WHERE sueConcAcum = @psueConcAcum ))
BEGIN 
	UPDATE sueConcAcum
	SET	Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id),
		Legajo = dbo.FuncFKsuePersonal(@pLegajo),
		Fecha = @pFecha,
		MontoTope = @pMontoTope,
		Descuento = @pDescuento,
		Acumulado = @pAcumulado,
		Usuario_Id = @pUsuario_Id, 
		Anulado = @pAnulado
	WHERE 
		sueConcAcum = @psueConcAcum
END 
ELSE 
BEGIN 
	INSERT INTO sueConcAcum
	(
		Concepto_Id,
		Legajo,
		Fecha,
		MontoTope,
		Descuento,
		Acumulado,
		Usuario_Id, 
		Anulado
	)
	VALUES 
	(
		dbo.FuncFKsueConceptos(@pConcepto_Id),
		dbo.FuncFKsuePersonal(@pLegajo),
		@pFecha,
		@pMontoTope,
		@pDescuento,
		@pAcumulado,
		@pUsuario_Id, 
		@pAnulado
	)
	SET @psueConcAcum =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @psueConcAcum as RetVal 

GO

DROP PROCEDURE sueConcAcumDatos
GO
CREATE PROCEDURE sueConcAcumDatos
(
	@pSegmento_Id VarChar(10), 
	@pSegmento1N INT, 
	@pSegmento2N INT, 
	@pSegmento3N INT, 
	@pSegmento4N INT, 
	@pSegmento1C VarChar(20), 
	@pSegmento2C VarChar(20), 
	@pSegmento3C VarChar(20), 
	@pSegmento4C VarChar(20), 
	@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT sueConcAcum.sueConcAcum, genSegmentos.Segmento_Id, sueConcAcumSegmento.Segmento1N, 
sueConcAcumSegmento.Segmento2N,sueConcAcumSegmento.Segmento3N, 
sueConcAcumSegmento.Segmento4N, sueConcAcumSegmento.Segmento1C, sueConcAcumSegmento.Segmento2C,
	sueConcAcumSegmento.Segmento3C, sueConcAcumSegmento.Segmento4C,
	sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConceptos, 
	suePersonal.Legajo, suePersonal.ApellidoPaterno+','+ suePersonal.ApellidoMaterno+','+
	suePersonal.Nombres as DescripcionPersonal, 
	sueConcAcum.Fecha, sueConcAcum.MontoTope, sueConcAcum.Descuento,
	sueConcAcum.Acumulado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	sueConcAcum.Anulado
FROM sueConcAcum 
INNER JOIN sueConcAcumSegmento on sueConcAcumSegmento.sueConcAcum = sueConcAcum.sueConcAcum
INNER JOIN sueConceptos  ON sueConceptos.sueConceptos = sueConcAcum.Concepto_Id
INNER JOIN suePersonal  ON suePersonal.genEntidades = sueConcAcum.Legajo
INNER JOIN genUsuarios  ON genUsuarios.genUsuarios = sueConcAcum.Usuario_Id
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = sueConcAcumSegmento.Segmento_Id
WHERE  
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	sueConcAcumSegmento.Segmento1N = @PSegmento1N AND 
	sueConcAcumSegmento.Segmento2N = @PSegmento2N AND 
	sueConcAcumSegmento.Segmento3N = @PSegmento3N AND 
	sueConcAcumSegmento.Segmento4N = @PSegmento4N AND 
	sueConcAcumSegmento.Segmento1C = @PSegmento1C AND 
	sueConcAcumSegmento.Segmento2C = @PSegmento2C AND 
	sueConcAcumSegmento.Segmento3C = @PSegmento3C AND 
	sueConcAcumSegmento.Segmento4C = @PSegmento4C AND 
	sueConcAcumSegmento.Empresa_Id = @pEmpresa_Id

RETURN @@Error 

GO

DROP PROCEDURE sueConcAcumEliminar
GO
CREATE PROCEDURE sueConcAcumEliminar
(
	@psueConcAcum int 
)
AS
SET NOCOUNT ON 

DELETE FROM sueConcAcum 
WHERE  
	sueConcAcum = @psueConcAcum 
 RETURN @@Error 

GO


