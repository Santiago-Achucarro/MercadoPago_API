
Drop Procedure genGlobalesGuardar
GO
Create Procedure genGlobalesGuardar
(
@pEmpresa_Id int, 
@pNombre_Var char(25), 
@pDescripcion varchar(100), 
@pTipo char(1), 
@pLongitud smallint, 
@pDecimales numeric(5), 
@pnValor numeric(18,4) = null,
@pcValor varchar(200) = null, 
@pfValor DateTime=NULL ,
@pmValor varChar(max) = null,
@pSubSistema char(3), 
@pSoloLectura numeric(5), 
@plupIdentidad varchar(30), 
@pWhereF10 VarChar(max)=NULL
) 
AS 
SET NOCOUNT ON  
IF (EXISTS (SELECT 1 FROM genGlobales WHERE 
	Empresa_Id = @pEmpresa_Id and 
	Nombre_Var = @pNombre_Var
))
BEGIN 
	UPDATE genGlobales SET 
	Descripcion = @pDescripcion, 
	Tipo = @pTipo, 
	Longitud = @pLongitud, 
	Decimales = @pDecimales, 
	nValor = @pnValor, 
	cValor = @pcValor, 
	fValor = @pfValor,
	mValor = @pmValor, 
	SubSistema = @pSubSistema, 
	SoloLectura = @pSoloLectura, 
	lupIdentidad = @plupIdentidad, 
	WhereF10 = @pWhereF10
	WHERE 
	Empresa_Id = @pEmpresa_Id and 
	Nombre_Var = @pNombre_Var
 
END 
ELSE
BEGIN
	INSERT INTO  genGlobales
	(Empresa_Id , 
	Nombre_Var , 
	Descripcion , 
	Tipo , 
	Longitud , 
	Decimales , 
	nValor , 
	cValor ,
	fValor,
	mValor, 
	SubSistema , 
	SoloLectura , 
	lupIdentidad , 
	WhereF10) 
	Values 
	(@pEmpresa_Id , 
	@pNombre_Var , 
	@pDescripcion , 
	@pTipo , 
	@pLongitud , 
	@pDecimales , 
	@pnValor , 
	@pcValor , 
	@pfValor,
	@pmValor,
	@pSubSistema , 
	@pSoloLectura , 
	@plupIdentidad , 
	@pWhereF10) 
END
RETURN @@Error 

GO
Drop Procedure genGlobalesDatos
GO
CREATE PROCEDURE genGlobalesDatos(
@pEmpresa_Id int,
@pNombre_Var char (25)
)
AS
SELECT genGlobales.Empresa_Id, genGlobales.Nombre_Var, genGlobales.Descripcion, 
genGlobales.Tipo, genGlobales.Longitud, genGlobales.Decimales, 
genGlobales.nValor, genGlobales.cValor, genGlobales.fValor, genGlobales.mValor,
genGlobales.SubSistema, genGlobales.SoloLectura, genGlobales.lupIdentidad, 
genGlobales.WhereF10, genEmpresas.Detalle as DescripcionEmpresa
 FROM genGlobales  INNER JOIN genEmpresas
	ON genEmpresas.genEmpresas=genGlobales.Empresa_Id
 Where 
	genGlobales.Empresa_Id = @pEmpresa_Id and 
	genGlobales.Nombre_Var = @pNombre_Var

GO
Drop Procedure genGlobalesEliminar
GO
Create Procedure genGlobalesEliminar(
@pEmpresa_Id int, 
@pNombre_Var char (25)
 
) 
AS 
SET NOCOUNT ON  
DELETE FROM genGlobales 
	 Where 
	genGlobales.Empresa_Id = @pEmpresa_Id and 
	genGlobales.Nombre_Var = @pNombre_Var
 
 RETURN @@Error 

GO

Drop Procedure genGlobalesSet
Go
Create Procedure genGlobalesSet(
@pEmpresa_Id int,
@pNombre_Var char(25),
@pnValor Numeric(18,4) = Null,
@pcValor varChar(200) = Null,
@pfValor Datetime = Null,
@pmValor varChar(max) = Null
)
As
Update genGlobales Set nValor = @pnValor, cValor = @pcValor, fValor = @pfValor, mValor = @pmValor Where Nombre_Var = @pNombre_Var and 
	Empresa_Id = @pEmpresa_Id  
Go

