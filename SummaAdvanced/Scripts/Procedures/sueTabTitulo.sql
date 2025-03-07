DROP PROCEDURE sueTabTituloGuardar
GO
CREATE PROCEDURE sueTabTituloGuardar
(
@pTabla_Id int,
@pDescripcion varchar(60),
@pUsuario_Id int = NULL,
@pFechaRegistro qFechaHora,
@pCodigo varchar(20) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueTabTitulo WHERE (Tabla_Id = @pTabla_Id)))
BEGIN 
	UPDATE sueTabTitulo
	SET		Descripcion = @pDescripcion,
		Usuario_Id = @pUsuario_Id,
		FechaRegistro = dbo.FechaActual(),
		Codigo =@pCodigo
	WHERE (Tabla_Id = @pTabla_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueTabTitulo
	(
		Tabla_Id,
		Descripcion,
		Usuario_Id,
		FechaRegistro,
		Codigo
	)
	VALUES 
	(
		@pTabla_Id,
		@pDescripcion,
		@pUsuario_Id,
		dbo.FechaActual(),
		@pCodigo 
	)
END 

GO

DROP PROCEDURE sueTabTituloDatos
GO
CREATE PROCEDURE sueTabTituloDatos
(
@pTabla_Id int
)
AS
SET NOCOUNT ON 

SELECT sueTabTitulo.Tabla_Id, sueTabTitulo.Descripcion, sueTabTitulo.Usuario_Id,
	sueTabTitulo.FechaRegistro,sueTabTitulo.Codigo,GETDATE() as FechaCodigo
FROM sueTabTitulo 
WHERE (Tabla_Id = @pTabla_Id)
select Tabla_Id, Fila, Valor,Ver from sueTabla
where Tabla_Id=@pTabla_Id
 RETURN @@Error 

GO

DROP PROCEDURE sueTabTituloEliminar
GO
CREATE PROCEDURE sueTabTituloEliminar
(
@pTabla_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueTabTitulo 
WHERE (Tabla_Id = ISNULL(@pTabla_Id, Tabla_Id))
 
 RETURN @@Error 

GO

GO
