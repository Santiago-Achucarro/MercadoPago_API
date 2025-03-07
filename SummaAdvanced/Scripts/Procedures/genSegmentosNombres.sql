Drop Procedure genSegmentosNombresGuardar
GO

Create Procedure genSegmentosNombresGuardar
(
@pSegmento_Id int, 
@pNombre1N varchar(35), 
@pNombre2N varchar(35), 
@pNombre3N varchar(35), 
@pNombre4N varchar(35), 
@pNombre1C varchar(35), 
@pNombre2C varchar(35), 
@pNombre3C varchar(35), 
@pNombre4C varchar(35), 
@pUsuario_Id int 
) 
AS 
SET NOCOUNT ON  
IF (EXISTS (SELECT 1 FROM genSegmentosNombres WHERE 
	Segmento_Id = @pSegmento_Id
))
BEGIN 
	UPDATE genSegmentosNombres SET 
	Nombre1N = @pNombre1N, 
	Nombre2N = @pNombre2N, 
	Nombre3N = @pNombre3N, 
	Nombre4N = @pNombre4N, 
	Nombre1C = @pNombre1C, 
	Nombre2C = @pNombre2C, 
	Nombre3C = @pNombre3C, 
	Nombre4C = @pNombre4C, 
	Usuario_Id = @pUsuario_Id 
	WHERE 
	Segmento_Id =  @pSegmento_id
 
END 
ELSE
BEGIN
	INSERT INTO  genSegmentosNombres
	(Segmento_Id , 
	Nombre1N , 
	Nombre2N , 
	Nombre3N , 
	Nombre4N , 
	Nombre1C , 
	Nombre2C , 
	Nombre3C , 
	Nombre4C , 
	Usuario_Id ) 
	Values 
	(@pSegmento_Id , 
	@pNombre1N , 
	@pNombre2N , 
	@pNombre3N , 
	@pNombre4N , 
	@pNombre1C , 
	@pNombre2C , 
	@pNombre3C , 
	@pNombre4C , 
	@pUsuario_Id ) 
END
RETURN @@Error 

GO
Drop Procedure genSegmentosNombresDatos
GO
CREATE PROCEDURE genSegmentosNombresDatos(
@pSegmento_id int
)
AS
SELECT genSegmentos.Segmento_id, genSegmentos.Descripcion, 
genSegmentosNombres.Nombre1N, genSegmentosNombres.Nombre2N, 
genSegmentosNombres.Nombre3N, genSegmentosNombres.Nombre4N, genSegmentosNombres.Nombre1C, genSegmentosNombres.Nombre2C, 
genSegmentosNombres.Nombre3C, genSegmentosNombres.Nombre4C, genSegmentosNombres.Usuario_Id 
 ,genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genSegmentos.genSegmentos
 FROM genSegmentosNombres  INNER JOIN genSegmentos
	ON genSegmentos.genSegmentos=genSegmentosNombres.Segmento_Id
 INNER JOIN genUsuarios
	ON genUsuarios.genUsuarios=genSegmentosNombres.Usuario_Id
 Where 
	genSegmentos.Segmento_id = @pSegmento_id

GO
Drop Procedure genSegmentosNombresEliminar
GO
Create Procedure genSegmentosNombresEliminar(
@pSegmento_id int
) 
AS 
SET NOCOUNT ON  
DELETE FROM genSegmentosNombres 
	 Where 
	genSegmentosNombres.Segmento_Id = @pSegmento_id
 
 RETURN @@Error 

GO

GO
