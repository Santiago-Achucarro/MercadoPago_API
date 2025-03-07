DROP PROCEDURE sueArchivosTxtGuardar
GO
CREATE PROCEDURE sueArchivosTxtGuardar
(
@pArchivo_Id varchar(15),
@pDescripcion varchar(100),
@pResumen1Archivo_Id varchar(15)= NULL,
@pPosicionResumen1 char(1),
@pResumen2Archivo_Id varchar(15) = NULL,
@pPosicionResumen2 char(1),
@pUsuario_Id int,
@pEmpresa_Id int = NULL,
@pInactivo Sino,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueArchivosTxt WHERE @pArchivo_Id =Archivo_Id ))
BEGIN 
	UPDATE sueArchivosTxt
	SET		@lIdentidad = sueArchivosTxt,
		Archivo_Id = @pArchivo_Id,
		Descripcion = @pDescripcion,
		Resumen1 = dbo.FuncFksueArchivosTxt(@pResumen1Archivo_Id),
		PosicionResumen1 = @pPosicionResumen1,
		Resumen2 =  dbo.FuncFksueArchivosTxt(@pResumen2Archivo_Id),
		PosicionResumen2 = @pPosicionResumen2,
		Usuario_Id = @pUsuario_Id,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado
	WHERE 
	@pArchivo_Id =Archivo_Id


	
END 
ELSE 
BEGIN 
	INSERT INTO sueArchivosTxt
	(
		Archivo_Id,
		Descripcion,
		Resumen1,
		PosicionResumen1,
		Resumen2,
		PosicionResumen2,
		Usuario_Id,
		Empresa_Id,
		Inactivo,
		Posteado
	)
	VALUES 
	(
		@pArchivo_Id,
		@pDescripcion,
		dbo.FuncFksueArchivosTxt(@pResumen1Archivo_Id),
		@pPosicionResumen1,
		dbo.FuncFksueArchivosTxt(@pResumen2Archivo_Id),
		@pPosicionResumen2,
		@pUsuario_Id,
		@pEmpresa_Id,
		@pInactivo,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueArchivosTxtDatos
GO
CREATE PROCEDURE sueArchivosTxtDatos
(
@pArchivo_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT sueArchivosTxt.sueArchivosTxt,
sueArchivosTxt.Archivo_id, sueArchivosTxt.Archivo_Id as Archivo_Id_Nueva, sueArchivosTxt.Descripcion,Res1.Archivo_Id as Res1Archivo_Id,Res1.Descripcion as Res1Descripcion,
sueArchivosTxt.PosicionResumen1,Res2.Archivo_Id as Res2Archivo_Id,Res2.Descripcion as Res2Descripcion,sueArchivosTxt.PosicionResumen2,sueArchivosTxt.Inactivo,sueArchivosTxt.Posteado
From sueArchivosTxt
left join sueArchivosTxt as Res1 on Res1.sueArchivosTxt=sueArchivosTxt.Resumen1
left join sueArchivosTxt as Res2 on Res2.sueArchivosTxt=sueArchivosTxt.Resumen2
	WHERE 
	@pArchivo_Id =sueArchivosTxt.Archivo_Id

	

SELECT sueArchivosTxt.Archivo_Id,sueArchivosTxt.Descripcion as DescripcionCabecera,Columna,Formula,Tipo,Longitud,Decimales,Relleno,sueArchivosTxtCuerpo.Descripcion,Orden,Formato
From sueArchivosTxtCuerpo
inner join sueArchivosTxt on sueArchivosTxt.sueArchivosTxt=sueArchivosTxtCuerpo.sueArchivosTxt 
where
@pArchivo_Id =sueArchivosTxt.Archivo_Id



Declare @pidentity bigint= dbo.FuncFKsueArchivosTxt( @pArchivo_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueArchivosTxt'




RETURN @@Error 




GO



DROP PROCEDURE sueArchivosTxtEliminar
GO
CREATE PROCEDURE sueArchivosTxtEliminar
(
@pArchivo_Id varchar(15)
)
AS
SET NOCOUNT ON 

DELETE FROM sueArchivosTxt 
WHERE  Archivo_Id = @pArchivo_Id
 RETURN @@Error 








GO







DROP FUNCTION FuncFKsueArchivosTxt
GO

CREATE FUNCTION FuncFKsueArchivosTxt
(
@pArchivo_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueArchivosTxt FROM sueArchivosTxt WHERE 
	Archivo_Id = @pArchivo_Id
  RETURN @pIdentity
END


GO