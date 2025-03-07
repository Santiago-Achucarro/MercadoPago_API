IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 34.00)
begin


CREATE TABLE stkProductosCostoCierreSucursal
( 
	Empresa_Id           integer  NOT NULL ,
	Fecha                qFecha ,
	Sucursal			 Integer NOT NULL , 
	Producto_Id          integer  NOT NULL ,
	Costo                qMonedaD8 ,
	CONSTRAINT XPKstkProductosCostosCierreSucursal PRIMARY KEY  CLUSTERED (Empresa_Id ASC,Fecha ASC,Sucursal ASC,  Producto_Id ASC)
);


Alter table stkProductosCostoCierreSucursal add Foreign Key(Empresa_Id) References genEmpresas;


Alter table stkProductosCostoCierreSucursal add Foreign Key(Sucursal) References genSucursalesEmpr;


Alter table stkProductosCostoCierreSucursal add Foreign Key(Producto_Id) References stkProductos;



CREATE TABLE stkProductosCostosSucursal
( 
	Sucursal			 integer  NOT NULL ,
	Producto_Id          integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	MonedaUltCompra      integer  NULL ,
	CostoPromPond        qMonedaD8 ,
	CostoUltCompra       qMonedaD8 ,
	CostoStandard        qMonedaD8 ,
	FechaUltModif        qFechaHora ,
	PrecioUltCompra      qMonedaD8 ,
	Fecha_Ult_Compra     qFechaHora ,
	Usuario_Id           integer  NULL ,
	CONSTRAINT XPKstkProductosCostosSucursal PRIMARY KEY  CLUSTERED (Sucursal ASC , Producto_Id ASC,Empresa_Id ASC)
);


Alter table stkProductosCostosSucursal add Foreign Key(Empresa_Id) References genEmpresas;


Alter table stkProductosCostosSucursal add Foreign Key(Sucursal) References genSucursalesEmpr;


Alter table stkProductosCostosSucursal add Foreign Key(Producto_Id) References stkProductos;


Alter table stkProductosCostosSucursal add Foreign Key(Usuario_Id) References genUsuarios;


INSERT INTO genVersion(Version) Values(34.00);

END

GO



