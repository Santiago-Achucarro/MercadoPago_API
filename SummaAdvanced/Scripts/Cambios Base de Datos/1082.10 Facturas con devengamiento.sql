CREATE TABLE comMovProvDevenga
( 
	comMovProv           bigint  NOT NULL ,
	VigenciaDesde        qFecha ,
	VigenciaHasta        qFecha ,
	ImporteADevengar     qMonedaD2 ,
	CtaADevengar         integer  NULL ,
	CONSTRAINT XPKcomMovProvDevenga PRIMARY KEY  CLUSTERED (comMovProv ASC)
)
go



CREATE TABLE comMovProvDevengaCtas
( 
	comMovProv           bigint  NOT NULL ,
	Cuenta_Id            integer  NOT NULL ,
	Centro1_Id           integer  NOT NULL ,
	Centro2_Id           integer  NOT NULL ,
	Porcentaje           qPorcentaje ,
	CONSTRAINT XPKcomMovProvDevengaCtas PRIMARY KEY  CLUSTERED (comMovProv ASC,Cuenta_Id ASC,Centro1_Id ASC,Centro2_Id ASC)
)
go

CREATE TABLE comMovProvDevengaCont
( 
	comMovProv           bigint  NOT NULL ,
	conAsientos          bigint  NOT NULL ,
	CONSTRAINT XPKcomMovProvDevengaCont PRIMARY KEY  CLUSTERED (comMovProv ASC,conAsientos ASC)
)
go



ALTER TABLE comMovProvDevenga
	ADD CONSTRAINT V2R_4755 FOREIGN KEY (comMovProv) REFERENCES comMovProv(comMovProv)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE comMovProvDevenga
	ADD CONSTRAINT V2R_4756 FOREIGN KEY (CtaADevengar) REFERENCES conCuentas(conCuentas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE comMovProvDevengaCtas
	ADD CONSTRAINT V2R_4757 FOREIGN KEY (comMovProv) REFERENCES comMovProvDevenga(comMovProv)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE comMovProvDevengaCtas
	ADD CONSTRAINT V2R_4758 FOREIGN KEY (Cuenta_Id) REFERENCES conCuentas(conCuentas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE comMovProvDevengaCtas
	ADD CONSTRAINT V2R_4759 FOREIGN KEY (Centro1_Id) REFERENCES conCentro1(conCentro1)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE comMovProvDevengaCtas
	ADD CONSTRAINT V2R_4760 FOREIGN KEY (Centro2_Id) REFERENCES conCentro2(conCentro2)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE comMovProvDevengaCont
	ADD CONSTRAINT V2R_4761 FOREIGN KEY (comMovProv) REFERENCES comMovProvDevenga(comMovProv)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE comMovProvDevengaCont
	ADD CONSTRAINT V2R_4762 FOREIGN KEY (conAsientos) REFERENCES conAsientos(conAsientos)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


EXECUTE genSegmentosGuardar
   @pSegmento_Id = 'DEVENGA'
  ,@pSegmento_Id_Nuevo = 'DEVENGA'
  ,@pDescripcion = 'Facturas de Proveedores con devengamiento'
  ,@pDigitos1N = 8
  ,@pDigitos2N = 3
  ,@pDigitos3N = 0
  ,@pDigitos4N = 0
  ,@pTieneColumnaAutomatica = 0
  ,@pDigitos1C = 4
  ,@pDigitos2C = 1
  ,@pDigitos3C = 15
  ,@pDigitos4C = 1
  ,@pOrigen1N = 1
  ,@pOrigen2N = 1
  ,@pOrigen3N = 0
  ,@pOrigen4N = 0
  ,@pOrigen1C = 1
  ,@pOrigen2C = 8
  ,@pOrigen3C = 9
  ,@pOrigen4C = 6
  ,@pOrden1N = 5
  ,@pOrden2N = 6
  ,@pOrden3N = 0
  ,@pOrden4N = 0
  ,@pOrden1C = 4
  ,@pOrden2C = 2
  ,@pOrden3C = 1
  ,@pOrden4C = 3
  ,@pHabilitaEdicion = 0
  ,@pTamanioVariable = '3N'
  ,@pInactivo = 0
  ,@pUsuario_Id = 1
  ,@pPosteado = 1
  ,@pEsSueldos  = 0
  ,@pEmpiezaEnUno = 0
GO

DECLARE @pSegmento_Id int 
set @pSegmento_Id = dbo.FuncFKgenSegmentos('DEVENGA')
EXEC genSegmentosNombresGuardar
   @pSegmento_Id 
  ,@pNombre1N = 'Comprobante'
  ,@pNombre2N = 'Orden'
  ,@pNombre3N= ''
  ,@pNombre4N= ''
  ,@pNombre1C = 'Suc'
  ,@pNombre2C= 'TM'
  ,@pNombre3C= 'Proveedor'
  ,@pNombre4C= 'L'
  ,@pUsuario_Id=1
GO


Insert into genVersion (Version) Values (1082.10)
Go
