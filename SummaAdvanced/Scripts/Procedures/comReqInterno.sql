DROP PROCEDURE comReqInternoGuardar
GO
CREATE PROCEDURE comReqInternoGuardar
(
@pSegmento_Id varchar(5),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int,
@pFecha qFecha,
@pTipoPermi_Id varchar(5) = NULL,
@pObservaciones QMemo = NULL,
@pProveed_Id varchar(15) = NULL,
@pEstadoRI_Id char(1),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int=(select comRISegmento.comReqInterno from comRISegmento where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and Empresa_Id=@pEmpresa_Id and
Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N and Segmento3N= @pSegmento3N and Segmento4N=@pSegmento4N and
Segmento1C=@pSegmento1C and Segmento2C=@pSegmento2C and Segmento3C= @pSegmento3C and Segmento4C= @pSegmento4C)
IF (EXISTS (SELECT 1 FROM comRISegmento WHERE comReqInterno=@lIdentidad))
BEGIN 
	UPDATE comReqInterno
	SET		@lIdentidad = comReqInterno,
		Fecha = @pFecha,
		TipoPermi_Id = dbo.FuncFKcomTipoPermiRI(@pTipoPermi_Id),
		Observaciones = @pObservaciones,
		Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id),
		EstadoRI_Id = @pEstadoRI_Id,
		Usuario_Id = @pUsuario_Id
	WHERE 
	comReqInterno=@lIdentidad
END 
ELSE 
BEGIN 
	INSERT INTO comReqInterno
	(
		Fecha,
		TipoPermi_Id,
		Observaciones,
		Proveed_Id,
		EstadoRI_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pFecha,
		dbo.FuncFKcomTipoPermiRI(@pTipoPermi_Id),
		@pObservaciones,
		dbo.FuncFKcomProveedores(@pProveed_Id),
		@pEstadoRI_Id,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO
--select * from genadjuntos
--comReqInternoDatos 'REQIN',13,0,0,0,'0008','','','',1
--select * from 
DROP PROCEDURE comReqInternoDatos
GO
CREATE PROCEDURE comReqInternoDatos
(
@pSegmento_Id varchar(5),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad bigint=(select comRISegmento.comReqInterno from comRISegmento where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and Empresa_Id=@pEmpresa_Id and
Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N and Segmento3N= @pSegmento3N and Segmento4N=@pSegmento4N and
Segmento1C=@pSegmento1C and Segmento2C=@pSegmento2C and Segmento3C= @pSegmento3C and Segmento4C= @pSegmento4C)

SELECT genSegmentos.Segmento_Id, Segmento1N, Segmento2N, Segmento3N, Segmento4N, Segmento1C, Segmento2C, Segmento3C, Segmento4C, comRISegmento.Empresa_Id,
comReqInterno.comReqInterno, comReqInterno.Fecha, comTipoPermiRI.TipoPermiRI_Id, 
	comTipoPermiRI.Descripcion as DescripcionTipoPermiRI,
	comReqInterno.Observaciones, comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores, comReqInterno.EstadoRI_Id,
	comRIEstados.Descripcion as DescripcionRIEstados, genUsuarios.Usuario_Id
FROM comReqInterno 
LEFT JOIN comTipoPermiRI  ON (comTipoPermiRI.comTipoPermiRI = comReqInterno.TipoPermi_Id)
LEFT JOIN comProveedores  ON (comProveedores.genEntidades = comReqInterno.Proveed_Id)
INNER JOIN comRIEstados  ON (comRIEstados.EstadoRI_Id = comReqInterno.EstadoRI_Id)
inner join comRISegmento on comRISegmento.comReqInterno=comReqInterno.comReqInterno
inner join genSegmentos on genSegmentos.genSegmentos=comRISegmento.Segmento_Id
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comReqInterno.Usuario_Id
WHERE  
comReqInterno.comReqInterno=@lIdentidad

exec comRIArticuloDatos @lIdentidad
exec comRIMemoDatos @lIdentidad
exec comRIAutorizandoDatos @lIdentidad


Exec genAtributosGeneralesIdentityDatos @lIdentidad, 'comReqInterno'
-- Solo necesito la estructura porque se llama a demanda desde otra acción --
-- Lo cambié porque en lugar del 0 estaba @lIdentidad (EMP)
exec genAdjuntosIdentityDatos 'comReqInterno', 0
 RETURN @@Error 

GO


DROP PROCEDURE comReqInternoDatosInt
GO
CREATE PROCEDURE comReqInternoDatosInt
(
@pReqInterno int
)
AS
SET NOCOUNT ON 

SELECT genSegmentos.Segmento_Id, Segmento1N, Segmento2N, Segmento3N, Segmento4N, Segmento1C, Segmento2C, Segmento3C, Segmento4C, comRISegmento.Empresa_Id,
comReqInterno.comReqInterno, comReqInterno.Fecha, comTipoPermiRI.TipoPermiRI_Id, comTipoPermiRI.Descripcion as DescripcionTipoPermiRI,
	comReqInterno.Observaciones, comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores, comReqInterno.EstadoRI_Id,
	comRIEstados.Descripcion as DescripcionRIEstados, genUsuarios.Usuario_Id
FROM comReqInterno 
LEFT JOIN comTipoPermiRI  ON (comTipoPermiRI.comTipoPermiRI = comReqInterno.TipoPermi_Id)
LEFT JOIN comProveedores  ON (comProveedores.genEntidades = comReqInterno.Proveed_Id)
INNER JOIN comRIEstados  ON (comRIEstados.EstadoRI_Id = comReqInterno.EstadoRI_Id)
inner join comRISegmento on comRISegmento.comReqInterno=comReqInterno.comReqInterno
inner join genSegmentos on genSegmentos.genSegmentos=comRISegmento.Segmento_Id
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = comReqInterno.Usuario_Id
WHERE  
comReqInterno.comReqInterno=@pReqInterno
exec comRIArticuloDatos @pReqInterno
exec comRIMemoDatos @pReqInterno
exec comRIAutorizandoDatos @pReqInterno

 Exec genAtributosGeneralesIdentityDatos @pReqInterno, 'comReqInterno'
 RETURN @@Error 

GO


DROP PROCEDURE comRICambiarEstado
GO
CREATE PROCEDURE comRICambiarEstado
(
	@pReqInterno int, 
	@pEstado Char(1)
)
as
Update comReqInterno set EstadoRI_Id = @pEstado where comReqInterno = @pReqInterno
GO


DROP PROCEDURE comReqInternoCompTienePendEntrega
GO
CREATE PROCEDURE comReqInternoCompTienePendEntrega (
	@comReqInerno Int 
)

AS

DECLARE @Cant INT

SET @Cant = (SELECT COUNT(1) FROM comRICuerpo where 
	comRICuerpo.comReqInterno = @comReqInerno and 
	comRICuerpo.Pendiente = 1
	)
	
SELECT @comReqInerno as comReqInterno , cast(CASE WHEN @Cant > 0 then 1 else 0 end	as Bit) Pendiente
GO

