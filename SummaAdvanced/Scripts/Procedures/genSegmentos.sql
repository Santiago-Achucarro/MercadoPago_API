DROP PROCEDURE genSegmentosGuardar
GO
CREATE PROCEDURE genSegmentosGuardar
(
@pSegmento_Id VarChar(10),
@pSegmento_Id_Nuevo VarChar(10),
@pDescripcion varchar(60),
@pDigitos1N int,
@pDigitos2N int,
@pDigitos3N int,
@pDigitos4N int,
@pTieneColumnaAutomatica Sino,
@pDigitos1C int,
@pDigitos2C int,
@pDigitos3C int,
@pDigitos4C int,
@pOrigen1N smallint ,
@pOrigen2N smallint ,
@pOrigen3N smallint ,
@pOrigen4N smallint ,
@pOrigen1C smallint ,
@pOrigen2C smallint ,
@pOrigen3C smallint ,
@pOrigen4C smallint ,
@pOrden1N smallint,
@pOrden2N smallint,
@pOrden3N smallint,
@pOrden4N smallint,
@pOrden1C smallint,
@pOrden2C smallint,
@pOrden3C smallint,
@pOrden4C smallint,
@pHabilitaEdicion Sino,
@pTamanioVariable char(2),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino, 
@pEsSueldos Bit,
@pEmpiezaEnUno Bit

)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM genSegmentos WHERE (Segmento_Id = @pSegmento_Id)))
BEGIN 
	UPDATE genSegmentos
	SET		@lIdentidad = genSegmentos,
		Segmento_Id = @pSegmento_Id_Nuevo,
		Descripcion = @pDescripcion,
		Digitos1N = @pDigitos1N,
		Digitos2N = @pDigitos2N,
		Digitos3N = @pDigitos3N,
		Digitos4N = @pDigitos4N,
		TieneColumnaAutomatica = @pTieneColumnaAutomatica,
		Digitos1C = @pDigitos1C,
		Digitos2C = @pDigitos2C,
		Digitos3C = @pDigitos3C,
		Digitos4C = @pDigitos4C,
		Origen1N = @pOrigen1N,
		Origen2N = @pOrigen2N,
		Origen3N = @pOrigen3N,
		Origen4N = @pOrigen4N,
		Origen1C = @pOrigen1C,
		Origen2C = @pOrigen2C,
		Origen3C = @pOrigen3C,
		Origen4C = @pOrigen4C,
		Orden1N = @pOrden1N,
		Orden2N = @pOrden2N,
		Orden3N = @pOrden3N,
		Orden4N = @pOrden4N,
		Orden1C = @pOrden1C,
		Orden2C = @pOrden2C,
		Orden3C = @pOrden3C,
		Orden4C = @pOrden4C,
		HabilitaEdicion = @pHabilitaEdicion,
		TamanioVariable = @pTamanioVariable,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		EsSueldos = @pEsSueldos,
		EmpiezaEnUno=@pEmpiezaEnUno
	WHERE (Segmento_Id = @pSegmento_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genSegmentos
	(
		Segmento_Id,
		Descripcion,
		Digitos1N,
		Digitos2N,
		Digitos3N,
		Digitos4N,
		TieneColumnaAutomatica,
		Digitos1C,
		Digitos2C,
		Digitos3C,
		Digitos4C,
		Origen1N,
		Origen2N,
		Origen3N,
		Origen4N,
		Origen1C,
		Origen2C,
		Origen3C,
		Origen4C,
		Orden1N,
		Orden2N,
		Orden3N,
		Orden4N,
		Orden1C,
		Orden2C,
		Orden3C,
		Orden4C,
		HabilitaEdicion,
		TamanioVariable,
		Inactivo,
		Usuario_Id,
		Posteado, 
		EsSueldos,
		EmpiezaEnUno
	)
	VALUES 
	(
		@pSegmento_Id_Nuevo,
		@pDescripcion,
		@pDigitos1N,
		@pDigitos2N,
		@pDigitos3N,
		@pDigitos4N,
		@pTieneColumnaAutomatica,
		@pDigitos1C,
		@pDigitos2C,
		@pDigitos3C,
		@pDigitos4C,
		@pOrigen1N,
		@pOrigen2N,
		@pOrigen3N,
		@pOrigen4N,
		@pOrigen1C,
		@pOrigen2C,
		@pOrigen3C,
		@pOrigen4C,
		@pOrden1N,
		@pOrden2N,
		@pOrden3N,
		@pOrden4N,
		@pOrden1C,
		@pOrden2C,
		@pOrden3C,
		@pOrden4C,
		@pHabilitaEdicion,
		@pTamanioVariable,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pEsSueldos,
		@pEmpiezaEnUno
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 
RETURN @lIdentidad
GO

DROP PROCEDURE genSegmentosDatos
GO
CREATE PROCEDURE genSegmentosDatos
(
@pSegmento_Id VarChar(10)
)
AS
SET NOCOUNT ON 

SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_Id, 
	genSegmentos.Descripcion,
	genSegmentos.Digitos1N, genSegmentos.Digitos2N, genSegmentos.Digitos3N, genSegmentos.Digitos4N,
	genSegmentos.TieneColumnaAutomatica, genSegmentos.Digitos1C, genSegmentos.Digitos2C, genSegmentos.Digitos3C,
	genSegmentos.Digitos4C, 
	genSegmentos.Origen1N, genSegmentoOrigenes.Descripcion as DescripcionSegmentosOrigenes1N, 
	genSegmentos.Origen2N, genSegmentoOrigenes2.Descripcion as DescripcionSegmentosOrigenes2N, 
	genSegmentos.Origen3N, genSegmentoOrigenes3.Descripcion as DescripcionSegmentosOrigenes3N, 
	genSegmentos.Origen4N, genSegmentoOrigenes4.Descripcion as DescripcionSegmentosOrigenes4N, 
	genSegmentos.Origen1C, genSegmentoOrigenes5.Descripcion as DescripcionSegmentosOrigenes1C, 
	genSegmentos.Origen2C, 	genSegmentoOrigenes6.Descripcion as DescripcionSegmentosOrigenes2C, 
	genSegmentos.Origen3C, genSegmentoOrigenes7.Descripcion as DescripcionSegmentosOrigenes3C, 
	genSegmentos.Origen4C, genSegmentoOrigenes8.Descripcion as DescripcionSegmentosOrigenes4C, 
	genSegmentos.Orden1N, genSegmentos.Orden2N, genSegmentos.Orden3N,
	genSegmentos.Orden4N, genSegmentos.Orden1C, genSegmentos.Orden2C, genSegmentos.Orden3C,
	genSegmentos.Orden4C, genSegmentos.HabilitaEdicion, genSegmentos.TamanioVariable,
	genSegmentos.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	genSegmentos.Posteado, genSegmentosNombres.Nombre1N, genSegmentosNombres.Nombre2N, genSegmentosNombres.Nombre3N,
		genSegmentosNombres.Nombre4N, genSegmentosNombres.Nombre1C, genSegmentosNombres.Nombre2C, genSegmentosNombres.Nombre3C,
			genSegmentosNombres.Nombre4C, genSegmentos.EsSueldos,genSegmentos.EmpiezaEnUno
FROM genSegmentos 
LEFT JOIN genSegmentoOrigenes  ON (genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen1N)
LEFT JOIN genSegmentoOrigenes genSegmentoOrigenes2 ON (genSegmentoOrigenes2.OriSeg_id = genSegmentos.Origen2N)
LEFT JOIN genSegmentoOrigenes genSegmentoOrigenes3 ON (genSegmentoOrigenes3.OriSeg_id = genSegmentos.Origen3N)
LEFT JOIN genSegmentoOrigenes genSegmentoOrigenes4 ON (genSegmentoOrigenes4.OriSeg_id = genSegmentos.Origen4N)
LEFT JOIN genSegmentoOrigenes genSegmentoOrigenes5 ON (genSegmentoOrigenes5.OriSeg_id = genSegmentos.Origen1C)
LEFT JOIN genSegmentoOrigenes genSegmentoOrigenes6 ON (genSegmentoOrigenes6.OriSeg_id = genSegmentos.Origen2C)
LEFT JOIN genSegmentoOrigenes genSegmentoOrigenes7 ON (genSegmentoOrigenes7.OriSeg_id = genSegmentos.Origen3C)
LEFT JOIN genSegmentoOrigenes genSegmentoOrigenes8 ON (genSegmentoOrigenes8.OriSeg_id = genSegmentos.Origen4C)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genSegmentos.Usuario_Id)
LEFT OUTER JOIN genSegmentosNombres on genSegmentosNombres.Segmento_Id = genSegmentos.genSegmentos
WHERE (genSegmentos.Segmento_Id = @pSegmento_Id)

 RETURN @@Error 

GO

DROP PROCEDURE genSegmentosEliminar
GO
CREATE PROCEDURE genSegmentosEliminar
(
@pSegmento_Id VarChar(10)
)
AS
SET NOCOUNT ON 

DELETE FROM genSegmentos 
WHERE (Segmento_Id = @pSegmento_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKgenSegmentos
GO

CREATE FUNCTION FuncFKgenSegmentos
(
@pSegmento_Id VarChar(10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genSegmentos FROM genSegmentos WHERE 
	Segmento_Id = @pSegmento_Id
  RETURN @pIdentity
END


GO

