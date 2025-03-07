-- Cambio Lupas parametros Adicionales
DROP FUNCTION FuncFKlupIdentidades
GO

CREATE FUNCTION FuncFKlupIdentidades
(
@pIdentidad_Id varchar (30)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = lupIdentidades FROM lupIdentidades WHERE 
	Identidad_Id = @pIdentidad_Id
  RETURN @pIdentity
END


GO

DROP PROCEDURE lupIdentidadesDatos
GO
CREATE PROCEDURE lupIdentidadesDatos
(
@pIdentidad_Id varchar(30)
)
AS
	SET NOCOUNT ON 
	
	DECLARE @lIdentity int
	DECLARE @lDescripcion varchar(50)
	DECLARE @lCamposClaves varchar(30)
	DECLARE @lCampoDescripcion varchar(50)
	DECLARE @lCamposSelect varchar(max)
	DECLARE @lFromSelect varchar(max)
	DECLARE @lWhereSelect varchar(max)
	DECLARE @lOrderByDefault varchar(100)
	DECLARE @lCampoFKTablaSeg varchar(50)
	DECLARE @lVistaSeg varchar(50) 
	DECLARE @lCampoPKVistaSeg varchar(50) 
	DECLARE @Sql1 NVarchar(max)
	DECLARE @ParmDefinition nVarChar(max)
	DECLARE @lCharCasing varchar(6)
	DECLARE @lMascara varchar(40)
	DECLARE @lMaximaLongitud int

	DECLARE @pP1 VarChar(50)=null,@pP2 VarChar(50)=null, @pP3 VarChar(50)=null,
			@pP4 VarChar(50)=null,@pP5 VarChar(50)=null, @pP6 VarChar(50)=null,
			@pP7 VarChar(50)=null,@pP8 VarChar(50)=null, @pP9 VarChar(50)=null,
			@pP10 VarChar(50)=null 

	-- Almaceno los datos en variables, para no tener que realizar mas de una vez la misma consulta
	SELECT @lIdentity = lupIdentidades.lupIdentidades, @lDescripcion = lupIdentidades.Descripcion, 
		@lCamposSelect = CamposSelect, @lFromSelect = FromSelect, @lWhereSelect = WhereSelect,
		@lCamposClaves = lupIdentidades.CamposClaves, @lCampoDescripcion = lupIdentidades.CampoDescripcion,
		@lOrderByDefault = OrderByDefault, 	@lCampoFKTablaSeg = CampoFKTablaSeg, 
	    @lVistaSeg = VistaSeg, 	@lCampoPKVistaSeg = CampoPKVistaSeg, 
		@lCharCasing = CharCasing, @lMascara = Mascara, @lMaximaLongitud = MaximaLongitud
	FROM lupIdentidades 
	WHERE (Identidad_Id = @pIdentidad_Id)
 
	-- Retorno los datos de la identidad
	SELECT @lIdentity lupIdentidades, @pIdentidad_Id Identidad_Id,  @lDescripcion Descripcion, 
		@lCamposClaves CamposClaves, @lCampoDescripcion CampoDescripcion,
		@lCamposSelect CamposSelect, @lFromSelect FromSelect, @lWhereSelect WhereSelect,
		@lOrderByDefault OrderByDefault, @lCampoFKTablaSeg CampoFKTablaSeg,
		@lVistaSeg VistaSeg, @lCampoPKVistaSeg CampoPKVistaSeg, 
		@lCharCasing CharCasing, @lMascara Mascara, @lMaximaLongitud MaximaLongitud
 

    --Campos Visible
	SELECT lupIdentidadesColVisibles.Campo, lupIdentidadesColVisibles.Longitud, lupIdentidadesColVisibles.CondicionInicial
	FROM lupIdentidadesColVisibles 
	WHERE Identidad_Id = @lIdentity 

	--Parametros del SP
	--SELECT sysColumns.name AS Parametro, sysColumns.name as NombreParametro, sysTypes.name as TipoParametro 
	--FROM sysColumns 
	--inner join sysobjects on sysobjects.id = sysColumns.id
	--inner join systypes on systypes.xusertype = sysColumns.xusertype 	
	--WHERE sysobjects.name = @lNombreIdentificatorio
	--AND sysobjects.type = 'P' AND sysobjects.category <> 2
	
	SELECT 	Orden, NombreParametro as Parametro, NombreParametro, TipoParametro
	FROM lupIdentidadesParam
	WHERE Identidad_Id = @lIdentity 

	--Campos retornados por la Vista
	--SELECT sysColumns.name AS Campo, sysColumns.name as NombreCampo, sysTypes.name as TipoCampo 
	--FROM sysColumns
	--INNER JOIN sysObjects ON sysColumns.id = sysObjects.id
	--INNER JOIN sysTypes ON sysColumns.xtype = sysTypes.xUserType
	--WHERE ((sysObjects.name = @lNombreIdentificatorio) AND (@lTipoVista = 'V'))
	---- Los campos de los sps, se obtienen en el DAL
	----OR ((sysObjects.name = Rtrim(@lNombreIdentificatorio)+'Lupa') AND (@lTipoVista = 'P')) 

	SET @ParmDefinition = N'@pPar1 VarChar(50), @pPar2 VarChar(50), @pPar3 VarChar(50), @pPar4 VarChar(50), @pPar5 VarChar(50), @pPar6 VarChar(50), @pPar7 VarChar(50), @pPar8 VarChar(50), @pPar9 VarChar(50), @pPar10 VarChar(50)';  
	--Obtengo los campos retornados por la vista o sp.
	SET @Sql1 = ' SELECT ' + @lCamposSelect + ' FROM ' + @lFromSelect +  	' WHERE 1=0 '
	
	EXEC sp_executesql @SQL1, @ParmDefinition, @pPar1=@pP1,@pPar2=@pP2,@pPar3=@pP3,@pPar4=@pP4,
	@pPar5=@pP5,@pPar6=@pP6,@pPar7=@pP7,@pPar8=@pP8,@pPar9=@pP9,@pPar10=@pP10


 RETURN @@Error 

GO


DROP PROCEDURE lupIdentidadesTodas
GO
CREATE PROCEDURE lupIdentidadesTodas
AS
SET NOCOUNT ON 

SELECT lupIdentidades.Identidad_Id, lupIdentidades.Descripcion, 
CAST(CASE LTRIM(RTRIM(lupIdentidades.CamposClaves)) 
  WHEN '' THEN 1 
  ELSE 0 
END as bit) as EsSegmento 
FROM lupIdentidades 
ORDER BY lupIdentidades.Identidad_id
 
RETURN @@Error 

GO

DROP PROCEDURE [dbo].[Lup_EjecutarConsulta]
GO
CREATE PROCEDURE [dbo].[Lup_EjecutarConsulta](@pidentidad_id VarChar(30), @pWhereSP VarChar(max)=NULL, @pWhere VarChar(max)=NULL, @pOrderBy VarChar(max)=NULL,
										@pDesde int, @pHasta int, @pDominio Char(2), 
										@pP1 VarChar(50)=null,@pP2 VarChar(50)=null, @pP3 VarChar(50)=null,
										@pP4 VarChar(50)=null,@pP5 VarChar(50)=null, @pP6 VarChar(50)=null,
										@pP7 VarChar(50)=null,@pP8 VarChar(50)=null, @pP9 VarChar(50)=null,
										@pP10 VarChar(50)=null )
AS

DECLARE @Sql1 nVarchar(max)
DECLARE @lCamposSelect varchar(max)
DECLARE @lFromSelect varchar(max)
DECLARE @lOrderByDefault varchar(max)
DECLARE @WhereSelect VarChar(max)
DECLARE @ParmDefinition nVarChar(max)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET @ParmDefinition = N'@pPar1 VarChar(50), @pPar2 VarChar(50), @pPar3 VarChar(50), @pPar4 VarChar(50), @pPar5 VarChar(50), @pPar6 VarChar(50), @pPar7 VarChar(50), @pPar8 VarChar(50), @pPar9 VarChar(50), @pPar10 VarChar(50)';  
-- AJ NOV 2016
-- Obtengo los datos para armar la consulta
SELECT @lCamposSelect = CamposSelect, @lFromSelect = FromSelect, @lOrderByDefault = CASE WHEN OrderByDefault='' THEN CamposSelect ELSE OrderByDefault END, 
	@WhereSelect = Replace(WhereSelect, '@Dominio_id', ''''+@pDominio+'''')
FROM lupIdentidades 
WHERE (Identidad_Id = @pIdentidad_Id)



SET @Sql1 =  'SELECT  * FROM (' +
					' SELECT ROW_NUMBER() OVER( ORDER BY ' + isnull(@pOrderBy, @lOrderByDefault)  + ' ) as N, SPOrig.* ' +
					' FROM (' +
							' SELECT ' + @lCamposSelect +
							' FROM ' + @lFromSelect  + ') as SPOrig ' +
					' WHERE ' + 
					+  isnull(@pWhereSP, '1=1') + ' and ' +
					case when @WhereSelect !='' then  @WhereSelect+  ' and ' else '' end   + 
					isnull(@pWhere, '1=1') + ' ) as spNumerado' +
      ' WHERE N BETWEEN '+str(@pDesde,8)+' AND '+str(@pHasta,8)

--PRINT @SQL1
EXEC sp_executesql @SQL1, @ParmDefinition, @pPar1=@pP1,@pPar2=@pP2,@pPar3=@pP3,@pPar4=@pP4,
	@pPar5=@pP5,@pPar6=@pP6,@pPar7=@pP7,@pPar8=@pP8,@pPar9=@pP9,@pPar10=@pP10
GO


DROP PROCEDURE Lup_EjecutarCantidadReg
GO

CREATE PROCEDURE [dbo].[Lup_EjecutarCantidadReg](@pidentidad_id VarChar(30), @pWhereSP VarChar(max)=NULL, @pWhere VarChar(max)=NULL, @pDominio char(2), 
										@pP1 VarChar(50)=null,@pP2 VarChar(50)=null, @pP3 VarChar(50)=null,
										@pP4 VarChar(50)=null,@pP5 VarChar(50)=null, @pP6 VarChar(50)=null,
										@pP7 VarChar(50)=null,@pP8 VarChar(50)=null, @pP9 VarChar(50)=null,
										@pP10 VarChar(50)=null )
AS

DECLARE @Sql1 nVarchar(max)
DECLARE @lCamposSelect varchar(max)
DECLARE @lFromSelect varchar(max)
DECLARE @lOrderByDefault varchar(max)
DECLARE @WhereSelect VarChar(max)
DECLARE @ParmDefinition nVarChar(max)

SET @ParmDefinition = N'@pPar1 VarChar(50), @pPar2 VarChar(50), @pPar3 VarChar(50), @pPar4 VarChar(50), @pPar5 VarChar(50), @pPar6 VarChar(50), @pPar7 VarChar(50), @pPar8 VarChar(50), @pPar9 VarChar(50), @pPar10 VarChar(50)';  
-- AJ NOV 2016
-- Obtengo los datos para armar la consulta
SELECT @lCamposSelect = CamposSelect, @lFromSelect = FromSelect, @lOrderByDefault = CASE WHEN OrderByDefault='' THEN CamposSelect ELSE OrderByDefault END, 
	@WhereSelect = Replace(WhereSelect, '@Dominio_id', ''''+@pDominio+'''')
FROM lupIdentidades 
WHERE (Identidad_Id = @pIdentidad_Id)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET @Sql1 = 'SELECT COUNT(1) ' + 
			' FROM ' +
			' (SELECT ' + @lCamposSelect +
				' FROM ' + @lFromSelect  + ') as SPOrig ' +
			' WHERE ' + isnull(@pWhereSP, '1=1') +
			' AND ' +  case when @WhereSelect  !='' then  @WhereSelect+  ' and ' else '' end   + 
					isnull(@pWhere, '1=1')

--PRINT @SQL1
EXEC sp_executesql @SQL1, @ParmDefinition, @pPar1=@pP1,@pPar2=@pP2,@pPar3=@pP3,@pPar4=@pP4,
	@pPar5=@pP5,@pPar6=@pP6,@pPar7=@pP7,@pPar8=@pP8,@pPar9=@pP9,@pPar10=@pP10
GO	


DROP PROCEDURE Lup_EjecutarConsultaSeg
GO

CREATE PROCEDURE [dbo].[Lup_EjecutarConsultaSeg] (@pSegmento_Id VarChar(10), @pIdentidad_Id VarChar(30), @pCamposSelect VarChar(250),
												@pWhereSP VarChar(max)=NULL, @pWhere VarChar(max)=NULL, @pOrderBy VarChar(250),
												@pDesde int, @pHasta int, @pEmpresa int)
AS

DECLARE @SQL1 Varchar(max)
DECLARE @lVistaJoin varchar(max)
DECLARE @lFromSelect varchar(max)
DECLARE @lCamposVistaSelect VarChar(max)
DECLARE @lCampoFKTabla VarChar(40)
DECLARE @lCampoPKVista VarChar(40)
DECLARE @lOrderByDefault VarChar(max)
DECLARE @lOrderByAUsar varchar(max)
DECLARE @lPosComa int = 0

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED


-- Obtengo los datos para armar la consulta
SELECT @lCamposVistaSelect = CamposSelect, @lFromSelect = FromSelect, @lVistaJoin= VistaSeg,  
	   @lCampoFKTabla = CampoFKTablaSeg, @lCampoPKVista = CampoPKVistaSeg, 
	   --@lOrderByDefault = ISNULL(OrderByDefault,@pOrderBy)
	   @lOrderByDefault = OrderByDefault 
FROM lupIdentidades 
WHERE (Identidad_Id = @pIdentidad_Id)

-- que el parametro @pOrderBy traiga un * al comienzo, significa que el usuario ordenó por una columna en especial
-- Si no viene el * entonces, si tiene definido en la lupa un ordenamiento, uso ese ordenamiento, sino uso el que envía el BE que lo arma en base a las partes del segmento y sus posiciones
IF (CHARINDEX('*', @pOrderBy)<>1)
	set @lOrderByAUsar = ISNULL(@lOrderByDefault,@pOrderBy)
-- Si viene el *, y no tiene definido en la lupa un ordenamiento, entonces uso el ordenamiento del usuario (que tiene concatenado detras el ordenamiento que arma el BE con las partes y posiciones del segmento)
ELSE IF (@lOrderByDefault IS NULL)
	set @lOrderByAUsar = SUBSTRING(@pOrderBy, 2, LEN(@pOrderBy))
-- Si viene el *, y tiene definido en la lupa un ordenamiento, entonces debo usar la columna que utliza el usuario para ordenar y concatenado con el ordenamiento definido en la lupa
ELSE
BEGIN
	--uso solo la primer columna	
	set @lPosComa = CHARINDEX(',', @pOrderBy)
	set @lOrderByAUsar = SUBSTRING(@pOrderBy, 2, @lPosComa) + @lOrderByDefault
END


SET @SQL1 =  'SELECT  * FROM ('  +
					--' SELECT ROW_NUMBER() OVER( ORDER BY ' + @lOrderByDefault + ' ) as N, SPOrig.* ' +
					' SELECT ROW_NUMBER() OVER( ORDER BY ' + @lOrderByAUsar + ' ) as N, SPOrig.* ' +
					' FROM (' +
							' SELECT ' + @pCamposSelect + case when @pCamposSelect !='' THEN ', ' ELSE '' END + @lCamposVistaSelect +
							' FROM ' + @lFromSelect + 
							' INNER JOIN ' + @lVistaJoin + ' ON ' + @lVistaJoin + '.' + @lCampoPKVista + ' = ' + @lFromSelect + '.' + @lCampoFKTabla +
							' WHERE ' + @lVistaJoin + '.Segmento_Id = dbo.FuncFKgenSegmentos(''' + @pSegmento_Id + ''')' +
							' AND ' + @lVistaJoin + '.Empresa_Id = ' + str(@pEmpresa, 8) + 
							' AND ' + isnull(@pWhereSP, '1=1') + ') as SPOrig ' +
					' WHERE ' + isnull(@pWhere, '1=1') + ' ) as spNumerado' +
      ' WHERE N BETWEEN '+str(@pDesde,8)+' AND '+str(@pHasta,8) 
      
      

--PRINT @SQL1
EXEC sp_sqlExec @SQL1

GO



DROP PROCEDURE Lup_EjecutarCantidadRegSeg
GO
CREATE PROCEDURE Lup_EjecutarCantidadRegSeg(@pSegmento_Id VarChar(10), @pidentidad_id VarChar(30), @pCamposSelect VarChar(250),
										@pWhereSP VarChar(max)=NULL, @pWhere VarChar(max)=NULL, @pEmpresa int)
AS
DECLARE @Sql1 Varchar(max)
DECLARE @lFromSelect varchar(max)
DECLARE @lVistaJoin varchar(max)
DECLARE @lCampoFKTabla VarChar(40)
DECLARE @lCampoPKVista VarChar(40)
DECLARE @lCamposVistaSelect VarChar(max)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
-- Obtengo los datos para armar la consulta
SELECT @lCamposVistaSelect = CamposSelect, @lFromSelect = FromSelect, @lVistaJoin= VistaSeg,  
	   @lCampoFKTabla = CampoFKTablaSeg, @lCampoPKVista = CampoPKVistaSeg
FROM lupIdentidades 
WHERE (Identidad_Id = @pIdentidad_Id)

SET @Sql1 = 'SELECT COUNT(1) FROM ( ' + 
			' SELECT '+@pCamposSelect + ', ' + @lCamposVistaSelect +
			' FROM ' + @lFromSelect + 
			' INNER JOIN ' + @lVistaJoin + ' ON ' + @lVistaJoin + '.' + @lCampoPKVista + ' = ' + @lFromSelect + '.' + @lCampoFKTabla +
			' WHERE ' + @lVistaJoin + '.Segmento_Id = dbo.FuncFKgenSegmentos(''' + @pSegmento_Id + ''')' +
			' AND ' + @lVistaJoin + '.Empresa_Id = ' + str(@pEmpresa, 8) + 
			' AND ' + isnull(@pWhereSP, '1=1') +
			' ) AS XXX WHERE ' + isnull(@pWhere, '(1=1)')

--PRINT @SQL1
EXEC sp_sqlExec @SQL1
GO


DROP PROCEDURE Lup_BrowserDatos
GO
CREATE PROCEDURE Lup_BrowserDatos
(
@pidentidad_id VarChar(30), 
@pCodigo VarChar(250), 
@pWhereSP VarChar(250)=NULL, 
@pWhere VarChar(250)=NULL, 
@pDominio Char(2), 
@pP1 VarChar(50)=null,
@pP2 VarChar(50)=null, 
@pP3 VarChar(50)=null,
@pP4 VarChar(50)=null,
@pP5 VarChar(50)=null, 
@pP6 VarChar(50)=null,
@pP7 VarChar(50)=null,
@pP8 VarChar(50)=null, 
@pP9 VarChar(50)=null,
@pP10 VarChar(50)=null 
)
AS
DECLARE @Sql1 nVarchar(max)
DECLARE @Sql2 nVarchar(max)
DECLARE @Sql3 nVarchar(max)
DECLARE @lCamposClave varchar(max)
DECLARE @lFromSelect varchar(max)
DECLARE @lCamposSelect varchar(max)
DECLARE @lOrderByDefault varchar(max)
DECLARE @WhereSelect VarChar(max)
DECLARE @ParmDefinition nVarChar(max)

SET @ParmDefinition = N'@pPar1 VarChar(50), @pPar2 VarChar(50), @pPar3 VarChar(50), @pPar4 VarChar(50), @pPar5 VarChar(50), @pPar6 VarChar(50), @pPar7 VarChar(50), @pPar8 VarChar(50), @pPar9 VarChar(50), @pPar10 VarChar(50)';  
-- AJ NOV 2016
-- Obtengo los datos para armar la consulta
SELECT @lCamposSelect = CamposSelect, @lCamposClave = CamposClaves, @lFromSelect = FromSelect, @lOrderByDefault = CamposClaves, 
	@WhereSelect = Replace(WhereSelect, '@Dominio_id', ''''+@pDominio+'''')
FROM lupIdentidades 
WHERE (Identidad_Id = @pIdentidad_Id)


SET @Sql1 = ' SELECT TOP 10 ' + @lCamposClave + ' as Codigo ' +
			' FROM (' +
			' SELECT ' + @lCamposSelect +
			' FROM ' + @lFromSelect  + ') as SPOrig ' +
			' WHERE ' + @lCamposClave + '<=' + '''' + @pCodigo + ''' and ' +
			isnull(@pWhereSP, '1=1') + ' and ' +
			case when @WhereSelect !='' then  @WhereSelect+  ' and ' else '' end   + 
			isnull(@pWhere, '1=1') +
			' ORDER BY ' + @lCamposClave + ' DESC'

SET @Sql2 = ' SELECT TOP 10 ' + @lCamposClave + ' as Codigo ' +
			' FROM (' +
			' SELECT ' + @lCamposSelect +
			' FROM ' + @lFromSelect  + ') as SPOrig ' +
			' WHERE ' + @lCamposClave + '>' + '''' + @pCodigo + ''' and ' +
			isnull(@pWhereSP, '1=1') + ' and ' +
			case when @WhereSelect !='' then  @WhereSelect+  ' and ' else '' end   + 
			isnull(@pWhere, '1=1') +
			' ORDER BY ' + @lCamposClave
			
SET @Sql3 = ' SELECT MIN(' + @lCamposClave + ') as Primero, MAX(' + @lCamposClave + ') as Ultimo ' +
			' FROM (' +
			' SELECT ' + @lCamposSelect +
			' FROM ' + @lFromSelect  + ') as SPOrig ' +
			' WHERE '+isnull(@pWhereSP, '1=1') + ' and ' +
			case when @WhereSelect !='' then  @WhereSelect+  ' and ' else '' end   + 
			isnull(@pWhere, '1=1')


--PRINT @SQL1
--PRINT @SQL2
--PRINT @SQL3
EXEC sp_executesql @SQL1, @ParmDefinition, @pPar1=@pP1,@pPar2=@pP2,@pPar3=@pP3,@pPar4=@pP4,
	@pPar5=@pP5,@pPar6=@pP6,@pPar7=@pP7,@pPar8=@pP8,@pPar9=@pP9,@pPar10=@pP10

EXEC sp_executesql @SQL2, @ParmDefinition, @pPar1=@pP1,@pPar2=@pP2,@pPar3=@pP3,@pPar4=@pP4,
	@pPar5=@pP5,@pPar6=@pP6,@pPar7=@pP7,@pPar8=@pP8,@pPar9=@pP9,@pPar10=@pP10

EXEC sp_executesql @SQL3, @ParmDefinition, @pPar1=@pP1,@pPar2=@pP2,@pPar3=@pP3,@pPar4=@pP4,
	@pPar5=@pP5,@pPar6=@pP6,@pPar7=@pP7,@pPar8=@pP8,@pPar9=@pP9,@pPar10=@pP10

GO