DROP PROCEDURE sueVezActivaGuardar
GO
CREATE PROCEDURE sueVezActivaGuardar
(
@pEmpresa_Id int,
@pAnio int,
@pMes int,
@pQuin int,
@pDecena int,
@pSemana int,
@pVez int, 
@pGrupo_Id Int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueVezActiva WHERE (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE sueVezActiva
	SET	Anio = @pAnio,
		Mes = @pMes,
		Quin = @pQuin,
		Decena = @pDecena,
		Semana = @pSemana,
		Vez = @pVez, 
		Grupo_Id = dbo.FuncFKsueGrupos(@pGrupo_Id)
	WHERE (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueVezActiva
	(
		Empresa_Id,
		Anio,
		Mes,
		Quin,
		Decena,
		Semana,
		Vez, 
		Grupo_Id
	)
	VALUES 
	(
		@pEmpresa_Id,
		@pAnio,
		@pMes,
		@pQuin,
		@pDecena,
		@pSemana,
		@pVez, 
		dbo.FuncFKsueGrupos(@pGrupo_Id)
	)
END 

GO

DROP PROCEDURE sueVezActivaDatos
GO
CREATE PROCEDURE sueVezActivaDatos
(
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT sueVezActiva.Empresa_Id, sueVezActiva.Anio, sueVezActiva.Mes, sueVezActiva.Quin,
	sueVezActiva.Decena, sueVezActiva.Semana, sueVezActiva.Vez, 
		sueGrupos.Grupo_Id, sueGrupos.Descripcion, isnull(sueGrupos.Periodo_Id,'') Periodo_Id
FROM sueVezActiva 
	inner join sueGrupos ON  sueGrupos.sueGrupos = sueVezActiva.Grupo_Id
WHERE (sueVezActiva.Empresa_Id = @pEmpresa_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE sueVezActivaEliminar
GO
CREATE PROCEDURE sueVezActivaEliminar
(
@pEmpresa_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueVezActiva 
WHERE (Empresa_Id = ISNULL(@pEmpresa_Id, Empresa_Id))
 
 RETURN @@Error 

GO


