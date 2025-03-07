DROP PROCEDURE conAsientosTipoGuardar
GO
CREATE PROCEDURE conAsientosTipoGuardar
(
@pAsiTipo_Id int,
@pEmpresa_Id int = NULL,
@pLeyendaLibroDiario varchar(100),
@pReservada Sino,
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conAsientosTipo WHERE (AsiTipo_Id = @pAsiTipo_Id)))
BEGIN 
	UPDATE conAsientosTipo
	SET		Empresa_Id = @pEmpresa_Id,
		LeyendaLibroDiario = @pLeyendaLibroDiario,
		Reservada = @pReservada,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (AsiTipo_Id = @pAsiTipo_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conAsientosTipo
	(
		AsiTipo_Id,
		Empresa_Id,
		LeyendaLibroDiario,
		Reservada,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pAsiTipo_Id,
		@pEmpresa_Id,
		@pLeyendaLibroDiario,
		@pReservada,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
END 

GO

DROP PROCEDURE conAsientosTipoDatos
GO
CREATE PROCEDURE conAsientosTipoDatos
(
@pAsiTipo_Id int
)
AS
SET NOCOUNT ON 

SELECT conAsientosTipo.AsiTipo_Id, conAsientosTipo.Empresa_Id, Cast( Case When conAsientosTipo.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, conAsientosTipo.LeyendaLibroDiario,
	conAsientosTipo.Reservada, conAsientosTipo.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	conAsientosTipo.Posteado
FROM conAsientosTipo 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = conAsientosTipo.Usuario_Id)
WHERE (AsiTipo_Id = @pAsiTipo_Id)

exec conAsieTipoCuerpoDatos @pAsiTipo_id
RETURN @@Error 

GO

DROP PROCEDURE conAsientosTipoEliminar
GO
CREATE PROCEDURE conAsientosTipoEliminar
(
@pAsiTipo_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conAsientosTipo 
WHERE (AsiTipo_Id = ISNULL(@pAsiTipo_Id, AsiTipo_Id))
 
 RETURN @@Error 

GO

GO
