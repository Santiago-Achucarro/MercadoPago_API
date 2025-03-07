DROP PROCEDURE venListasVersionGuardar
GO
CREATE PROCEDURE venListasVersionGuardar
(
@pListaPrecio_Id VarChar(5),
@pVersion int,
@pVigenciaDesde datetime,
@pVigenciaHasta datetime,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venListasVersion 
	INNER JOIN venListasPrecios ON
	venListasVersion.ListaPrecio_Id = venListasPrecios.venListasPrecios
	WHERE 
	(venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id) AND 
	(Version = @pVersion)))
BEGIN 
	UPDATE venListasVersion
	SET		VigenciaDesde = @pVigenciaDesde,
		VigenciaHasta = @pVigenciaHasta,
		Usuario_Id = @pUsuario_Id
	WHERE (ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id)) AND 
		(Version = @pVersion)
END 
ELSE 
BEGIN 
	INSERT INTO venListasVersion
	(
		ListaPrecio_Id,
		Version,
		VigenciaDesde,
		VigenciaHasta,
		Usuario_Id
	)
	VALUES 
	(
		dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		@pVersion,
		@pVigenciaDesde,
		@pVigenciaHasta,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE venListasVersionDatos
GO
CREATE PROCEDURE venListasVersionDatos
(
@pListaPrecio_Id VarChar(5),
@pVersion int
)
AS
SET NOCOUNT ON 

SELECT venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, 
	venListasVersion.Version, venListasVersion.VigenciaDesde,
	venListasVersion.VigenciaHasta, venListasVersion.Usuario_Id
FROM venListasVersion 
INNER JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venListasVersion.ListaPrecio_Id)
WHERE (venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id)
AND (Version = @pVersion)
 
RETURN @@Error 

GO

DROP PROCEDURE venListasVersionEliminar
GO
CREATE PROCEDURE venListasVersionEliminar
(
@pListaPrecio_Id varchar(5),
@pVersion int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venListasVersion 
WHERE (ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id))
AND (Version = ISNULL(@pVersion, Version))
 
 RETURN @@Error 

GO

GO
