/*
DROP TABLE mstrGruposSitios
DROP TABLE mstrDominios
DROP TABLE mstrGrupos
DROP TABLE mstrSitios
DROP TABLE mstrMaster
*/

IF OBJECT_ID(N'dbo.mstrMaster', N'U') IS NULL  
CREATE TABLE mstrMaster(
	Licencia varchar(36) NOT NULL,
	PathSitio varchar(150) NOT NULL,
	PathActualizacion varchar(150) NOT NULL,
	PathActions varchar(150) NOT NULL,
	PathQBI varchar(150) NOT NULL,
	NombreQBI varchar(100) NOT NULL,
	Especializacion varchar(100),
	NombreBDModelo varchar(50) Not Null Default ('SummaAdvModelo'),
	PathEnServerSQL varchar(150)
)
GO

IF OBJECT_ID(N'dbo.mstrSitios', N'U') IS NULL  
CREATE TABLE mstrSitios(
	Sitio varchar(100) NOT NULL,
	Servidor varchar(100) NOT NULL,
	BaseDatos varchar(100) NOT NULL,
	Usuario varchar(60) NOT NULL,
	ClaveUsuario varchar(100) NOT NULL,
	Licencias int,
	Clave varchar(max),
	FechaVencimiento datetime,
	Especializacion varchar(150) NULL,
    CONSTRAINT XPKmstrSitios PRIMARY KEY (Sitio)
)
GO
IF OBJECT_ID(N'dbo.mstrGrupos', N'U') IS NULL  
CREATE TABLE mstrGrupos(
	Grupo varchar(100) NOT NULL,
	Licencias int,
	Clave varchar(max),
	FechaVencimiento datetime NULL,
	CONSTRAINT XPKmstrGrupos PRIMARY KEY (Grupo)
)
GO
IF OBJECT_ID(N'dbo.mstrDominios', N'U') IS NULL  
BEGIN
CREATE TABLE mstrDominios(
	Dominio varchar(200) NOT NULL,
	Sitio varchar(100) NOT NULL,
	CONSTRAINT XPKmstrDominios PRIMARY KEY (Dominio)
)


ALTER TABLE mstrDominios  ADD CONSTRAINT fkDominioSitio FOREIGN KEY(Sitio)
REFERENCES mstrSitios (Sitio)
END
GO

IF OBJECT_ID(N'dbo.mstrGruposSitios', N'U') IS NULL  
BEGIN
CREATE TABLE mstrGruposSitios(
	Grupo varchar(100) NOT NULL,
	Sitio varchar(100) NOT NULL,
	Orden int NOT NULL,
	CONSTRAINT XPKmstrGruposSitios PRIMARY KEY (Grupo, Sitio)
)
ALTER TABLE mstrGrupos  ADD CONSTRAINT fkGrupoGrupo FOREIGN KEY(Grupo)
REFERENCES mstrGrupos (Grupo)

ALTER TABLE mstrGruposSitios  ADD CONSTRAINT fkGrupoSitio FOREIGN KEY(Sitio)
REFERENCES mstrSitios (Sitio)
END
GO


--Cambios en Estructura de Tablas
-- 2/3/2022

IF (NOT EXISTS( SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'mstrGruposSitios' and COLUMN_NAME = 'Orden'))
BEGIN
ALTER TABLE mstrGruposSitios Add Orden int Not Null Default (1)
END
GO

--Cambios en Estructura de Tablas
-- 4/3/2022
IF (NOT EXISTS( SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'mstrMaster' and COLUMN_NAME = 'NombreBDModelo'))
BEGIN
ALTER TABLE mstrMaster Add NombreBDModelo varchar(50) Not Null Default ('SummaAdvModelo')
END
GO


--Cambios en Estructura de Tablas
-- 8/4/2022
IF (NOT EXISTS( SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'mstrMaster' and COLUMN_NAME = 'PathEnServerSQL'))
BEGIN
ALTER TABLE mstrMaster Add PathEnServerSQL varchar(150) NULL
END
GO


--Cambios en Estructura de Tablas
-- 6/10/2022
IF (NOT EXISTS( SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'mstrSitios' and COLUMN_NAME = 'Especializacion'))
BEGIN
ALTER TABLE mstrSitios Add Especializacion varchar(150) NULL
END
GO



IF OBJECT_ID(N'mstrSitiosConfigDatos') IS NOT NULL 
DROP PROCEDURE mstrSitiosConfigDatos
GO
CREATE PROCEDURE mstrSitiosConfigDatos
AS
SET NOCOUNT ON 
	SELECT 	Licencia, PathSitio, PathActualizacion, PathActions, PathQBI, NombreQBI, ISNULL(Especializacion, '') Especializacion,
			NombreBDModelo, ISNULL(PathEnServerSQL, '') PathEnServerSQL
	FROM mstrMaster

	SELECT Sitio, ISNULL(Licencias, 0) Licencias, ISNULL(Clave, '') Clave, ISNULL(FechaVencimiento, getDate()) FechaVencimiento
	FROM mstrSitios

	SELECT Grupo, ISNULL(Licencias, 0) Licencias, ISNULL(Clave, '') Clave, ISNULL(FechaVencimiento, getDate()) FechaVencimiento
	FROM mstrGrupos
	
	SELECT Dominio,	Sitio
	FROM mstrDominios

	SELECT Grupo, Sitio, Orden
	FROM mstrGruposSitios
	ORDER BY Grupo, Orden, Sitio


RETURN @@Error 

GO

IF OBJECT_ID(N'mstrSitiosGuardar') IS NOT NULL 
DROP PROCEDURE mstrSitiosGuardar
GO
CREATE PROCEDURE mstrSitiosGuardar (
	@pSitio varchar(100),
	@pLicencias int,
	@pClave varchar(max),
	@pFechaVencimiento datetime
)
AS
SET NOCOUNT ON 
	UPDATE mstrSitios
	SET Licencias = @pLicencias,
		Clave = @pClave,
		FechaVencimiento = @pFechaVencimiento
	WHERE Sitio = @pSitio


RETURN @@Error 

GO

IF OBJECT_ID(N'mstrSitiosInsertar') IS NOT NULL 
DROP PROCEDURE mstrSitiosInsertar
GO
CREATE PROCEDURE mstrSitiosInsertar (
	@pSitio varchar(100),
	@pServidor varchar(100),
	@pBaseDatos varchar(100),
	@pUsuario varchar(60),
	@pClaveUsuario varchar(100),
	@pLicencias int,
	@pClave varchar(max),
	@pFechaVencimiento datetime
)
AS
SET NOCOUNT ON 
	INSERT INTO mstrSitios (Sitio, Servidor, BaseDatos, Usuario, ClaveUsuario, Licencias, Clave, FechaVencimiento)
	VALUES (@pSitio, @pServidor, @pBaseDatos, @pUsuario, @pClaveUsuario, @pLicencias, @pClave, @pFechaVencimiento)

RETURN @@Error 

GO

IF OBJECT_ID(N'mstrGruposGuardar') IS NOT NULL 
DROP PROCEDURE mstrGruposGuardar
GO
CREATE PROCEDURE mstrGruposGuardar (
	@pGrupo varchar(100),
	@pLicencias int,
	@pClave varchar(max),
	@pFechaVencimiento datetime
)
AS
SET NOCOUNT ON 
	UPDATE mstrGrupos
	SET Licencias = @pLicencias,
		Clave = @pClave,
		FechaVencimiento = @pFechaVencimiento
	WHERE Grupo = @pGrupo


RETURN @@Error 

GO

IF OBJECT_ID(N'mstrGruposSitiosGuardar') IS NOT NULL 
DROP PROCEDURE mstrGruposSitiosGuardar
GO
CREATE PROCEDURE mstrGruposSitiosGuardar (
	@pGrupo varchar(100),
	@pSitio varchar(100),
	@pOrden int
)
AS
SET NOCOUNT ON 
INSERT INTO mstrGruposSitios (Grupo, Sitio, Orden) VALUES (@pGrupo, @pSitio, @pOrden)

RETURN @@Error 

GO

IF OBJECT_ID(N'mstrSitiosTodosUsuariosLogueados') IS NOT NULL 
DROP Procedure mstrSitiosTodosUsuariosLogueados 
go
Create Procedure mstrSitiosTodosUsuariosLogueados 
as
 
DECLARE @lUsuariosLog VARCHAR(max) 

SELECT @lUsuariosLog = COALESCE(@lUsuariosLog + ' ; ', '') + 
	' select ''' + mstrSitios.BaseDatos  + ''' as BaseDatos , * from ' +  mstrSitios.BaseDatos + '.dbo.vgenUsuariosLogueados'
from mstrSitios
where mstrSitios.Servidor = @@SERVERNAME

--select @lUsuariosLog

exec (@lUsuariosLog)

GO


/*
DELETE FROM mstrGruposSitios
DELETE FROM mstrSitios
DELETE FROM mstrGrupos
DELETE FROM mstrMaster

INSERT INTO mstrMaster(Licencia, PathSitio, PathActualizacion, PathActions, PathQBI, NombreQBI, Especializacion)
VALUES ('BB3E13C0-30FF-4789-B680-7BEA594497CD', '', '', '', '', '', '')

INSERT INTO mstrSitios (Sitio,	Servidor, BaseDatos, Usuario, ClaveUsuario, Licencias, Clave, FechaVencimiento)
VALUES ('Standard', 'NTBLEN\SQLEXPRESS2019', 'SummaAdvXX', 'sa', 'tatinga', 50, 'AhQACAAEQlQAAAAGAlQACAEKDkBABAUOCAQCBAQMBARATAUCAhACAAQABBACSEAM', '28-12-2021')

INSERT INTO mstrSitios (Sitio,	Servidor, BaseDatos, Usuario, ClaveUsuario, Licencias, Clave, FechaVencimiento)
VALUES ('Standard1', 'NTBLEN\SQLEXPRESS2019', 'ferrepreciosAdv', 'sa', 'tatinga', 50, 'AhQACAAEQlQAAAAGAlQACAEKDkBABAUOCAQCBAQMBARATAUCAhACAAQABBACSEAM', '01-01-2999')

INSERT INTO mstrSitios (Sitio,	Servidor, BaseDatos, Usuario, ClaveUsuario, Licencias, Clave, FechaVencimiento)
VALUES ('Standard2', 'NTBLEN\SQLEXPRESS2019', 'SummaAdvQA', 'sa', 'tatinga', 50, 'AhQACAAEQlQAAAAGAlQACAEKDkBABAUOCAQCBAQMBARATAUCAhACAAQABBACSEAM', '27-12-2021')

INSERT INTO mstrGrupos (Grupo, Licencias, Clave, FechaVencimiento)
VALUES ('UNO', 30, 'AxUACAIFQ1UBAAIHAlQBCAIKD0BBBAYPCAQCBAYMBQRBTAYDAhADAQYABRADSUIM', '01-01-2999')
INSERT INTO mstrGrupos (Grupo, Licencias, Clave, FechaVencimiento)
VALUES ('DOS', null, null, null)
INSERT INTO mstrGruposSitios (Grupo, Sitio)
VALUES ('UNO', 'Standard')
INSERT INTO mstrGruposSitios (Grupo, Sitio)
VALUES ('UNO', 'Standard2')

*/