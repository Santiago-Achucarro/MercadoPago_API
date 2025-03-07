
Create Table venBonifTemporal(
	venBonifTemporal Int Identity NOT NULL, 
	Descripcion VarChar(150) NOT NULL,
	Empresa_Id Int ,
	FechaDesde DateTime Not NULL, 
	FechaHasta DateTime Not NULL, 
	SucursalDesde VarChar(15) NOT NULL,
	SucursalHasta VarChar(15) NOT NULL,
	ClienteDesde VarChar(15) NOT NULL,
	ClienteHasta VarChar(15) NOT NULL,
	SucursalClieDesde Int NOT NULL,
	SucursalClieHasta Int NOT NULL,
	TipoClieDesde VarChar(5) Not Null,
	TipoClieHasta VarChar(5) Not Null,
	ProductoDesde VarChar(25) Not NULL, 
	ProductoHasta VarChar(25) Not NULL, 
	TipoProductoDesde VarChar(5) Not Null,
	TipoProductoHasta VarChar(5) Not Null,
	Bonificacion VarChar(Max) Not NULL, 
	FamiliaDesde VarChar(15) NOT NULL,
	FamiliaHasta VarChar(15) NOT NULL,
	GrupoDesde VarChar(15) NOT NULL,
	GrupoHasta VarChar(15) NOT NULL,
	Inactivo Bit NOT NULL, 
	Posteado Bit NOT NULL,
	Prioridad Int NOT NULL,
	FechaRegistro DateTime Default dbo.FechaActual() NOT NULL,
	Usuario_Id Int NOT NULL
	Primary Key(venBonifTemporal))
GO

Create Table venBonifTemporalSegmento(
	Empresa_Id           integer  NOT NULL ,
	Segmento_Id          integer  NOT NULL ,
	Segmento1N           integer  NOT NULL ,
	Segmento2N           integer  NOT NULL ,
	Segmento3N           integer  NOT NULL ,
	Segmento4N           integer  NOT NULL ,
	Segmento1C           varchar(20)  NOT NULL ,
	Segmento2C           varchar(20)  NOT NULL ,
	Segmento3C           varchar(20)  NOT NULL ,
	Segmento4C           varchar(20)  NOT NULL ,
	venBonifTemporal	 Int NOT NULL,
	Primary Key (Empresa_Id ,Segmento_Id ,Segmento1N ,Segmento2N ,Segmento3N ,Segmento4N ,Segmento1C ,Segmento2C ,Segmento3C ,Segmento4C ))
GO

ALTER TABLE venBonifTemporalSegmento Add Constraint 
	fkvenBonifTemporalSegmentoEm Foreign Key (Empresa_Id) 
	REFERENCES genEmpresas
GO

ALTER TABLE venBonifTemporalSegmento Add Constraint 
	fkvenBonifTemporalSegmentoSeg Foreign Key (Segmento_Id) 
	REFERENCES genSegmentos
GO

ALTER TABLE venBonifTemporal Add Constraint 
	fkvenBonifTemporalVT Foreign Key (venBonifTemporal) 
	REFERENCES genSegmentos
GO

ALTER TABLE venBonifTemporal ADD Constraint fkvenBonifTemporalE 
	Foreign Key(Empresa_Id ) references genEmpresas

GO

ALTER TABLE venBonifTemporal ADD 
	Constraint fkvenBonifTemporalUsu
	Foreign Key(Usuario_Id) references genUsuarios

GO

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
Values('VENBONIFLEXICO','ATRI','Atributo <n> del Articulo',100,'N')

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
Values('VENBONIFLEXICO','CANTFAM','Cantidad Facturada de la Familia X ',123,'N')

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
Values('VENBONIFLEXICO','CANTOFE','Cantidad de la Oferta ',103,'N')

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
Values('VENBONIFLEXICO','CANTPROD','Cantidad Facturada Producto (''x'')',123,'N')

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
Values('VENBONIFLEXICO','CANTRENG','Cantidad Facturada renglon',103,'N')

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
Values('VENBONIFLEXICO','LPRECIO','Lista de Precios',103,'C')

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato)
Values('VENBONIFLEXICO','SUCUEMPR','Sucursal Empresa',103,'C')

GO


EXECUTE genSegmentosGuardar
   @pSegmento_Id = 'BT'
  ,@pSegmento_Id_Nuevo = 'BT'
  ,@pDescripcion = 'Bonificacion Temporal'
  ,@pDigitos1N = 8
  ,@pDigitos2N = 0
  ,@pDigitos3N = 0
  ,@pDigitos4N = 0
  ,@pTieneColumnaAutomatica = 1
  ,@pDigitos1C = 4
  ,@pDigitos2C = 0
  ,@pDigitos3C = 0
  ,@pDigitos4C = 0
  ,@pOrigen1N = 1
  ,@pOrigen2N = 0
  ,@pOrigen3N = 0
  ,@pOrigen4N = 0
  ,@pOrigen1C = 11
  ,@pOrigen2C = 0
  ,@pOrigen3C = 0
  ,@pOrigen4C = 0
  ,@pOrden1N = 2
  ,@pOrden2N = 0
  ,@pOrden3N = 0
  ,@pOrden4N = 0
  ,@pOrden1C = 1
  ,@pOrden2C = 0
  ,@pOrden3C = 0
  ,@pOrden4C = 0
  ,@pHabilitaEdicion = 0
  ,@pTamanioVariable = '1N'
  ,@pInactivo = 0
  ,@pUsuario_Id = 1
  ,@pPosteado = 1
  ,@pEsSueldos  = 0
GO

DECLARE @pSegmento_Id int 
set @pSegmento_Id = dbo.FuncFKgenSegmentos('BT')
EXEC genSegmentosNombresGuardar
   @pSegmento_Id 
  ,@pNombre1N = 'Bonif'
  ,@pNombre2N = ''
  ,@pNombre3N= ''
  ,@pNombre4N= ''
  ,@pNombre1C = 'Suc'
  ,@pNombre2C= ''
  ,@pNombre3C= ''
  ,@pNombre4C= ''
  ,@pUsuario_Id=1
GO



INSERT INTO genVersion (Version) Values(1031.00)
GO
