DROP PROCEDURE sueGanTituloGuardar
GO
CREATE PROCEDURE sueGanTituloGuardar
(
@pTabGan_Id int,
@pDescripcion varchar(60),
@pUsuario_Id int = NULL,
@pFechaRegistro qFechaHora,
@pCodigo varchar(20) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueGanTitulo WHERE (TabGan_Id = @pTabGan_Id)))
BEGIN 
	UPDATE sueGanTitulo
	SET		Descripcion = @pDescripcion,
		Usuario_Id = @pUsuario_Id,
		FechaRegistro = dbo.FechaActual(),
		Codigo=@pCodigo
	WHERE (TabGan_Id = @pTabGan_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueGanTitulo
	(
		TabGan_Id,
		Descripcion,
		Usuario_Id,
		FechaRegistro,
		Codigo
	)
	VALUES 
	(
		@pTabGan_Id,
		@pDescripcion,
		@pUsuario_Id,
		getDate(),
		@pCodigo
	)
END 

GO

DROP PROCEDURE sueGanTituloDatos
GO
CREATE PROCEDURE sueGanTituloDatos
(
@pTabGan_Id int
)
AS
SET NOCOUNT ON 

SELECT sueGanTitulo.TabGan_Id, sueGanTitulo.Descripcion, sueGanTitulo.Usuario_Id,
	sueGanTitulo.FechaRegistro,sueGanTitulo.Codigo, GetDate() as FechaCodigo
	
FROM sueGanTitulo 
WHERE (TabGan_Id = @pTabGan_Id)
select TabGan_Id, Hasta, Porcentaje, Minimo,Ver
from sueGanancias
where TabGan_Id=@pTabGan_Id
 
 RETURN @@Error 

GO

DROP PROCEDURE sueGanTituloEliminar
GO
CREATE PROCEDURE sueGanTituloEliminar
(
@pTabGan_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueGanTitulo 
WHERE (TabGan_Id = ISNULL(@pTabGan_Id, TabGan_Id))
 
 RETURN @@Error 

GO

GO
