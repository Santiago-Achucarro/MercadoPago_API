
DROP PROCEDURE genContadorSegmentoGuardar
GO
CREATE PROCEDURE genContadorSegmentoGuardar
(
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pSegmento_Id VarChar(10),
@pEmpresa_Id int,
@pPrimerNumero int ,
@pCai varChar(20),
@pFechaCai qFecha=Null,
@pNumeroDesde int,
@pNumeroHasta int,
@pFechaAutoSRI qFecha=Null,
@pFechaDesde qFecha=Null,
@pUsuario_Id int, 
@pTieneColumnaAutomatica bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genContadorSegmento WHERE
	Empresa_Id = @pEmpresa_Id and 
  (Segmento2N = @pSegmento2N) AND
 (Segmento3N = @pSegmento3N) AND (Segmento4N = @pSegmento4N) AND (Segmento1C = @pSegmento1C) AND 
 (Segmento2C = @pSegmento2C) AND (Segmento3C = @pSegmento3C) AND (Segmento4C = @pSegmento4C) AND 
 (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)))) 
BEGIN 
	UPDATE genContadorSegmento
	SET		PrimerNumero = @pPrimerNumero ,
			Cai = @pCai ,
			FechaCai = @pFechaCai ,
			NumeroDesde = @pNumeroDesde ,
			NumeroHasta = @pNumeroHasta ,
			FechaAutoSRI = @pFechaAutoSRI ,
			FechaDesde = @pFechaDesde ,
		    Usuario_Id = @pUsuario_Id,
			TieneColumnaAutomatica = @pTieneColumnaAutomatica

	WHERE 
	Empresa_Id = @pEmpresa_Id and 
	(Segmento2N = @pSegmento2N) AND (Segmento3N = @pSegmento3N) AND (Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND (Segmento2C = @pSegmento2C) AND (Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C) AND (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
END 
ELSE 
BEGIN 
	INSERT INTO genContadorSegmento
	(
		Segmento2N,
		Segmento3N,
		Segmento4N,
		Segmento1C,
		Segmento2C,
		Segmento3C,
		Segmento4C,
		Segmento_Id,
		PrimerNumero  ,
		Cai ,
		FechaCai ,
		NumeroDesde ,
		NumeroHasta ,
		FechaAutoSRI ,
		FechaDesde ,
		Usuario_Id,
		Empresa_Id, 
		TieneColumnaAutomatica
	)
	VALUES 
	(
		@pSegmento2N,
		@pSegmento3N,
		@pSegmento4N,
		@pSegmento1C,
		@pSegmento2C,
		@pSegmento3C,
		@pSegmento4C,
		dbo.FuncFKgenSegmentos(@pSegmento_Id),
		@pPrimerNumero  ,
		@pCai ,
		@pFechaCai ,
		@pNumeroDesde ,
		@pNumeroHasta ,
		@pFechaAutoSRI ,
		@pFechaDesde ,
		@pUsuario_Id,
		@pEmpresa_Id,
		@pTieneColumnaAutomatica
	)
END 

GO

DROP PROCEDURE genContadorSegmentoDatos
GO
CREATE PROCEDURE genContadorSegmentoDatos
(
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pSegmento_Id VarChar(10), 
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT genContadorSegmento.Segmento2N, genContadorSegmento.Segmento3N, genContadorSegmento.Segmento4N, genContadorSegmento.Segmento1C,
	genContadorSegmento.Segmento2C, genContadorSegmento.Segmento3C, genContadorSegmento.Segmento4C, genSegmentos.Segmento_Id,
	genSegmentos.Descripcion as DescripcionSegmentos, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genContadorSegmento.Empresa_Id,
	genContadorSegmento.PrimerNumero  , genContadorSegmento.Cai , genContadorSegmento.FechaCai ,
	genContadorSegmento.NumeroDesde , genContadorSegmento.NumeroHasta ,
	genContadorSegmento.FechaAutoSRI , genContadorSegmento.FechaDesde , genContadorSegmento.TieneColumnaAutomatica
FROM genContadorSegmento 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = genContadorSegmento.Segmento_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genContadorSegmento.Usuario_Id)
WHERE 
genContadorSegmento.Empresa_Id = @pEmpresa_Id
AND (genContadorSegmento.Segmento2N = @pSegmento2N)
AND (genContadorSegmento.Segmento3N = @pSegmento3N)
AND (genContadorSegmento.Segmento4N = @pSegmento4N)
AND (genContadorSegmento.Segmento1C = @pSegmento1C)
AND (genContadorSegmento.Segmento2C = @pSegmento2C)
AND (genContadorSegmento.Segmento3C = @pSegmento3C)
AND (genContadorSegmento.Segmento4C = @pSegmento4C)
AND (genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))

 
 RETURN @@Error 

GO

DROP PROCEDURE genContadorSegmentoEliminar
GO
CREATE PROCEDURE genContadorSegmentoEliminar
(
@pSegmento2N int = NULL,
@pSegmento3N int = NULL,
@pSegmento4N int = NULL,
@pSegmento1C varchar(20) = NULL,
@pSegmento2C varchar(20) = NULL,
@pSegmento3C varchar(20) = NULL,
@pSegmento4C varchar(20) = NULL,
@pSegmento_Id varchar(10)
)
AS
SET NOCOUNT ON 

DELETE FROM genContadorSegmento 
WHERE (Segmento2N = ISNULL(@pSegmento2N, Segmento2N))
AND (Segmento3N = ISNULL(@pSegmento3N, Segmento3N))
AND (Segmento4N = ISNULL(@pSegmento4N, Segmento4N))
AND (Segmento1C = ISNULL(@pSegmento1C, Segmento1C))
AND (Segmento2C = ISNULL(@pSegmento2C, Segmento2C))
AND (Segmento3C = ISNULL(@pSegmento3C, Segmento3C))
AND (Segmento4C = ISNULL(@pSegmento4C, Segmento4C))
AND (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id))
 
RETURN @@Error 

GO

DROP PROCEDURE genContadorSegmentoDatosTodos
GO
CREATE PROCEDURE genContadorSegmentoDatosTodos
(
@pSegmento_id VarChar(10),
@pEmpresa_id Int
)
AS
SET NOCOUNT ON 
SELECT genSegmentos.Segmento_Id, genSegmentos.Descripcion , @pEmpresa_id as Empresa_Id,
	genSegmentosNombres.Nombre1C, genSegmentosNombres.Nombre2C, genSegmentosNombres.Nombre3C, genSegmentosNombres.Nombre4C, 
	genSegmentosNombres.Nombre1N, genSegmentosNombres.Nombre2N, genSegmentosNombres.Nombre3N, genSegmentosNombres.Nombre4N
From genSegmentos 
Inner Join genSegmentosNombres On genSegmentosNombres.Segmento_Id = genSegmentos.genSegmentos
WHERE genSegmentos.Segmento_Id = @pSegmento_Id

SELECT genContadorSegmento.Segmento2N, genContadorSegmento.Segmento3N, genContadorSegmento.Segmento4N, genContadorSegmento.Segmento1C,
	genContadorSegmento.Segmento2C, genContadorSegmento.Segmento3C, genContadorSegmento.Segmento4C, genSegmentos.Segmento_Id,
	genSegmentos.Descripcion as DescripcionSegmentos, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genContadorSegmento.Empresa_Id,
	genContadorSegmento.PrimerNumero  , genContadorSegmento.Cai , genContadorSegmento.FechaCai ,
	genContadorSegmento.NumeroDesde , genContadorSegmento.NumeroHasta, genContadorSegmento.FechaAutoSRI, genContadorSegmento.FechaDesde,
	genContadorSegmento.TieneColumnaAutomatica
FROM genContadorSegmento 
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = genContadorSegmento.Segmento_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genContadorSegmento.Usuario_Id)
WHERE 
	 genContadorSegmento.Empresa_id = @pEmpresa_Id and 
	 genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)
	 
 
 RETURN @@Error 

GO


DROP PROCEDURE genContadorSegmentoEliminarTodos
GO
CREATE PROCEDURE genContadorSegmentoEliminarTodos
(
	@pSegmento_id VarChar(10),
	@pEmpresa_Id Int
)
AS
SET NOCOUNT ON 

DELETE FROM genContadorSegmento 
WHERE Empresa_Id = @pEmpresa_Id and 
	Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_id)
RETURN @@Error 

GO

