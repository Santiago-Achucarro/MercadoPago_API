DROP PROCEDURE genUsuariosLogueadosGuardar
GO
CREATE PROCEDURE genUsuariosLogueadosGuardar
(
@pUsuario_Id int,
@pUltEmpresa int,
@pFechaLogin datetime,
@pToken varchar(36)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genUsuariosLogueados WHERE (Token = @pToken)))
BEGIN 
	UPDATE genUsuariosLogueados
	SET		Usuario_Id = @pUsuario_Id,
		UltEmpresa = @pUltEmpresa,
		FechaLogin = @pFechaLogin,
		Caduca = Dateadd(mi, 5, getdate())
	WHERE (Token = @pToken)
END 
ELSE 
BEGIN 
	INSERT INTO genUsuariosLogueados
	(
		Usuario_Id,
		UltEmpresa,
		FechaLogin,
		Caduca,
		Token
	)
	VALUES 
	(
		@pUsuario_Id,
		@pUltEmpresa,
		@pFechaLogin,
		Dateadd(mi, 5, getdate()),
		@pToken
	)
END 

GO

DROP PROCEDURE genUsuariosLogueadosDatos
GO
CREATE PROCEDURE genUsuariosLogueadosDatos
(
@pUsuario_Id int
)
AS
SET NOCOUNT ON 

SELECT genUsuariosLogueados.Usuario_Id, genUsuariosLogueados.UltEmpresa, genUsuariosLogueados.FechaLogin, genUsuariosLogueados.Caduca,
	genUsuariosLogueados.Token, genUsuarios.MultiplesLogins
FROM genUsuariosLogueados inner join genUsuarios ON
genUsuarios.genUsuarios = genUsuariosLogueados.Usuario_Id
WHERE (genUsuariosLogueados.Usuario_Id = @pUsuario_Id and Caduca >= getdate())
 
RETURN @@Error 

GO

DROP PROCEDURE genUsuariosLogueadosEliminar
GO
CREATE PROCEDURE genUsuariosLogueadosEliminar
(
@pToken varchar(36) 
)
AS
SET NOCOUNT ON 

DELETE FROM genUsuariosLogueados 
WHERE (Token = @pToken)
 
 RETURN @@Error 

GO

DROP PROCEDURE genUsuariosLogueadosCuantosDatos
GO
CREATE PROCEDURE genUsuariosLogueadosCuantosDatos
as

SELECT count(*) Cantidad
FROM genUsuariosLogueados 
WHERE 
	Caduca >= getdate()
 
RETURN @@Error 

GO

DROP PROCEDURE genUsuariosLogueadosCaduca
GO
CREATE PROCEDURE genUsuariosLogueadosCaduca
(
@pToken varchar(36)
)
AS
SET NOCOUNT ON 
UPDATE genUsuariosLogueados
	SET	Caduca = Dateadd(mi, 5, getdate())
	WHERE (Token = @pToken)

GO

