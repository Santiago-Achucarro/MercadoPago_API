/*TODOS.SQL Generado el dia 3/12/2021 16:41:01 */

/* C:\V3\SummaAdvanced\Scripts\Lupas\afiActivoFijo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'afiActivoFijo')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('afiActivoFijo','Activo Fijo','ActivoFijo_Id,Descripcion,Tipo,FechaAlta,Empresa_Id','afiActivoFijo','','ActivoFijo_Id','ActivoFijo_Id','Descripcion','8110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Activo Fijo', CamposSelect='ActivoFijo_Id,Descripcion,Tipo,FechaAlta,Empresa_Id', FromSelect='afiActivoFijo', WhereSelect='', OrderByDefault='ActivoFijo_Id', CamposClaves='ActivoFijo_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '8110'
     WHERE Identidad_Id='afiActivoFijo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('afiActivoFijo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('afiActivoFijo'),'ActivoFijo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('afiActivoFijo'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('afiActivoFijo'),'FechaAlta')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\afiResponsables.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'afiResponsables')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('afiResponsables','Responsables','Responsable_Id,Descripcion,Posteado,Inactivo','afiResponsables','','','Responsable_Id','Descripcion', 'Upper', '',15)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Responsables', CamposSelect='Responsable_Id,Descripcion,Posteado,Inactivo', FromSelect='afiResponsables', WhereSelect='', OrderByDefault='', CamposClaves='Responsable_Id', CampoDescripcion='Descripcion', CharCasing='Upper', Mascara='', MaximaLongitud=15
     WHERE Identidad_Id='afiResponsables'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('afiResponsables')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('afiResponsables'),'Responsable_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('afiResponsables'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('afiResponsables'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('afiResponsables'),'Inactivo')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\afiRubros.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'afiRubros')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('afiRubros','Rubros Activo Fijo',
		'Rubro_Id,Descripcion,Tipo,Empresa_Id,VidaUtil,VidaUtilFiscal,CtaValorOrigen_id,CtaAmortAcum_Id,CtaAmortizacion_id,Posteado',
		'vafiRubros','','Rubro_Id','Rubro_Id','Descripcion','8120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Rubros Activo Fijo', 
	 CamposSelect='Rubro_Id,Descripcion,Tipo,Empresa_Id,VidaUtil,VidaUtilFiscal,CtaValorOrigen_id,CtaAmortAcum_Id,CtaAmortizacion_id,Posteado', 
	 FromSelect='vafiRubros', WhereSelect='', OrderByDefault='Rubro_Id', CamposClaves='Rubro_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '8120'
     WHERE Identidad_Id='afiRubros'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('afiRubros')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('afiRubros'),'Rubro_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('afiRubros'),'Descripcion')


--SELECT * FROM vAfiRubros
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\ClieCtasAnticipo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'ClieCtasAnticipo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('ClieCtasAnticipo','Cuentas Anticipo','Cliente_Id,Moneda_Id,CtaAnticipo,DescripcionCtaAnticipo','vvenClientesCtas','','','CtaAnticipo','DescripcionCtaAnticipo')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Anticipo', CamposSelect='Cliente_Id,Moneda_Id,CtaAnticipo,DescripcionCtaAnticipo', FromSelect='vvenClientesCtas', WhereSelect='', OrderByDefault='', CamposClaves='CtaAnticipo', CampoDescripcion='DescripcionCtaAnticipo'
     WHERE Identidad_Id='ClieCtasAnticipo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('ClieCtasAnticipo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('ClieCtasAnticipo'),'CtaAnticipo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('ClieCtasAnticipo'),'DescripcionCtaAnticipo')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comCategorias.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comCategorias')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comCategorias','Categorias','Categoria_Id,Descripcion,Posteado,Inactivo','comCategorias','','','Categoria_Id','Descripcion','1430')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Categorias', CamposSelect='Categoria_Id,Descripcion,Posteado,Inactivo', FromSelect='comCategorias', WhereSelect='', OrderByDefault='', CamposClaves='Categoria_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '1430'
     WHERE Identidad_Id='comCategorias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comCategorias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCategorias'),'Categoria_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCategorias'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCategorias'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCategorias'),'Inactivo')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comCFDISat.sql*/


IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comCFDISat')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comCFDISat','XML DEL SAT','UUID,RFCEmisor,Fecha,Monto,Folio,Serie,Subido,Empresa_Id,TipoDeComprobante','comCFDISat','','UUID','UUID','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='XML DEL SAT', 
	 CamposSelect='UUID,RFCEmisor,Fecha,Monto,Folio,Serie,Subido,Empresa_Id,TipoDeComprobante', 
	 FromSelect='comCFDISat', WhereSelect='', OrderByDefault='UUID', CamposClaves='UUID', CampoDescripcion=''
     WHERE Identidad_Id='comCFDISat'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comCFDISat')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'UUID')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'RFCEmisor')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'Monto')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'Folio')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comCFDISat'),'Serie')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comCondFiscal.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comCondFiscal')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comCondFiscal','Condicion Fiscal Compras','CondFiscal_Id,Descripcion,Inactivo,Posteado,Empresa_Id','comCondFiscal','','','CondFiscal_Id','Descripcion', '411030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Condicion Fiscal Compras', CamposSelect='CondFiscal_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='comCondFiscal', WhereSelect='', OrderByDefault='', CamposClaves='CondFiscal_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '411030'
     WHERE Identidad_Id='comCondFiscal'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comCondFiscal')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comCondFiscal'),'CondFiscal_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comCondFiscal'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comCondFiscal'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comCondFiscal'),'Posteado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comConPago.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comConPago')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comConPago','Condicion_de_Pago','CondPago_Id,Descripcion,Dias,CantidadCuotas,Inactivo,Posteado,Empresa_Id','comConPago','','','CondPago_Id','Descripcion', '1120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Condicion_de_Pago', CamposSelect='CondPago_Id,Descripcion,Dias,CantidadCuotas,Inactivo,Posteado,Empresa_Id', FromSelect='comConPago', 
	 WhereSelect='', OrderByDefault='', CamposClaves='CondPago_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '1120'
     WHERE Identidad_Id='comConPago'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comConPago')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comConPago'),'CondPago_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comConPago'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comConPago'),'Dias')

GO
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comDespachos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comDespachos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comDespachos','Despachos_de_importacion','Despacho_Id,Origen,Aduana,Fecha,Empresa_Id,Cambio,Moneda_Id','vcomDespachos','','','Despacho_Id','Origen','122010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Despachos_de_importacion', 
	 CamposSelect='Despacho_Id,Origen,Aduana,Fecha,Empresa_Id,Cambio,Moneda_Id', FromSelect='vcomDespachos', WhereSelect='', OrderByDefault='', CamposClaves='Despacho_Id', CampoDescripcion='Origen', 
	 OrdenMenuFormulario = '122010'
     WHERE Identidad_Id='comDespachos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comDespachos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comDespachos'),'Despacho_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comDespachos'),'Origen')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comDespachos'),'Aduana')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comDespachos'),'Fecha')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comEmbarques.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comEmbarques')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('comEmbarques', 'Embarques de Compras', 'FechaEmbarque,Empresa,Estado_Id,Anulado', 'vcomEmbarques', '', 'FechaEmbarque', '', '', 'comEmbarques', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Embarques de Compras', 
	 CamposSelect='FechaEmbarque,Empresa,Estado_Id, Anulado', 
	 FromSelect='vcomEmbarques', 
	 WhereSelect='', 
	 OrderByDefault='FechaEmbarque DESC', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'comEmbarques',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='comEmbarques'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comEmbarques')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comEmbarques'),'FechaEmbarque')
GO

--select * from comEmbarques


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comEmbEstado.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comEmbEstado')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comEmbEstado','Estados Embarques','Estado_Id,Descripcion','comEmbEstado','','Estado_Id','Estado_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estados Embarques', CamposSelect='Estado_Id,Descripcion', FromSelect='comEmbEstado', WhereSelect='', OrderByDefault='Estado_Id', CamposClaves='Estado_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comEmbEstado'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comEmbEstado')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comEmbEstado'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comEmbEstado'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comEsquemaAuto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comEsquemaAuto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comEsquemaAuto','','EsquemaAuto_Id,Descripcion,Empresa_Id,Inactivo,Posteado','comEsquemaAuto','','','EsquemaAuto_Id','Descripcion','1337')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='', CamposSelect='EsquemaAuto_Id,Descripcion,Empresa_Id,Inactivo,Posteado', FromSelect='comEsquemaAuto', WhereSelect='', OrderByDefault='', CamposClaves='EsquemaAuto_Id', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '1337'
     WHERE Identidad_Id='comEsquemaAuto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comEsquemaAuto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comEsquemaAuto'),'EsquemaAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comEsquemaAuto'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comForEntre.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comForEntre')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comForEntre','Forma de Entrega Compras','FormaEnt_Id,Descripcion,Inactivo,Posteado,Empresa_Id','comForEntre','','','FormaEnt_Id','Descripcion', '1130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Forma de Entrega Compras', CamposSelect='FormaEnt_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='comForEntre', 
	 WhereSelect='', OrderByDefault='', CamposClaves='FormaEnt_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '1130'
     WHERE Identidad_Id='comForEntre'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comForEntre')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'FormaEnt_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comForEntre'),'Empresa_Id')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comImpuestos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comImpuestos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comImpuestos','Impuestos de Compras','Impuesto_Id,Descripcion,Inactivo,Posteado,Empresa_Id,Porcentaje','comImpuestos','','','Impuesto_Id','Descripcion', '411010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Impuestos de Compras', CamposSelect='Impuesto_Id,Descripcion,Inactivo,Posteado,Empresa_Id, Porcentaje', FromSelect='comImpuestos', 
	 WhereSelect='', OrderByDefault='', CamposClaves='Impuesto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '411010'
     WHERE Identidad_Id='comImpuestos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comImpuestos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comImpuestos'),'Impuesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comImpuestos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comImpuestos'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comImpuestos'),'Posteado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comLibros.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comLibros')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comLibros','libros compras','Libro_Id,Descripcion,Empresa_Id','comLIbros','','','Libro_Id','Descripcion', '411020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='libros compras', CamposSelect='Libro_Id,Descripcion,Empresa_Id', FromSelect='comLIbros', WhereSelect='', OrderByDefault='', 
	 CamposClaves='Libro_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '411020'
     WHERE Identidad_Id='comLibros'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comLibros')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comLibros'),'Libro_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comLibros'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comMovPAnexo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comMovPAnexo')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('comMovPAnexo', 'Movimientos de Compras Menores', 'Fecha_Ane, Cuit, RazonSocial, Tipomov', 'vComMovPAnexo', '', 'Fecha_Ane', '', '', 'Asiento_Id', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras Menores', 
	 CamposSelect='Fecha_Ane, Cuit, RazonSocial, Tipomov', 
	 FromSelect='vComMovPAnexo', 
	 WhereSelect='', 
	 OrderByDefault='Fecha', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'Asiento_Id',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='comMovPAnexo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comMovPAnexo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovPAnexo'),'Fecha_Ane')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovPAnexo'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovPAnexo'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovPAnexo'),'Tipomov')
GO


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comMovProv.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comMovprov')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('comMovprov', 'Movimientos de Compras', 'Fecha, Proveed_Id, RazonSocial, Tipomov, Formulario_Id, Empresa', 'vcomMovprov', '', 'Fecha', '', '', 'comMovprov', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras', 
	 CamposSelect='Fecha, Proveed_Id, RazonSocial, Tipomov, Formulario_Id, Empresa', 
	 FromSelect='vComMovProv', 
	 WhereSelect='', 
	 OrderByDefault='Fecha', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'comMovprov',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='comMovprov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comMovprov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovprov'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovprov'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovprov'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovprov'),'Tipomov')
GO
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comMovTipos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comMovTipos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comMovTipos','','TipoMov,Descripcion','comMovTipos','','TipoMov','TipoMov','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='', CamposSelect='TipoMov,Descripcion', FromSelect='comMovTipos', WhereSelect='', OrderByDefault='TipoMov', CamposClaves='TipoMov', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comMovTipos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comMovTipos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovTipos'),'TipoMov')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comMovTipos'),'Descripcion')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comNivelesAuto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comNivelesAuto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('comNivelesAuto','Niveles_de_Autorizacion_OC','NivelAuto_Id,Descripcion,Empresa_Id,Inactivo','comNivelesAuto','','','NivelAuto_Id','Descripcion','1336')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Niveles_de_Autorizacion_OC', CamposSelect='NivelAuto_Id,Descripcion,Empresa_Id,Inactivo', FromSelect='comNivelesAuto', WhereSelect='', OrderByDefault='', CamposClaves='NivelAuto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '1336'
     WHERE Identidad_Id='comNivelesAuto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comNivelesAuto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comNivelesAuto'),'NivelAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comNivelesAuto'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comOcEstados.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comOCEstados')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comOCEstados','Estados Orden de Compra','Estado_Id,Descripcion','comOcEstados','','','Estado_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estados Orden de Compra', CamposSelect='Estado_Id,Descripcion', FromSelect='comOcEstados', WhereSelect='', OrderByDefault='', CamposClaves='Estado_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comOCEstados'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comOCEstados')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOCEstados'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOCEstados'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comOCEstadosAR.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comocestadosar')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comocestadosar','Estados Orden de Compra A y R','Estado_Id,Descripcion','comOcEstados','Estado_Id in (''P'',''A'',''R'')','','Estado_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estados Orden de Compra A y R', CamposSelect='Estado_Id,Descripcion', FromSelect='comOcEstados', WhereSelect='Estado_Id in (''P'',''A'',''R'')', OrderByDefault='', CamposClaves='Estado_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comocestadosar'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comocestadosar')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comocestadosar'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comocestadosar'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comOrCredFisc.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comOrCredFisc')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comOrCredFisc','Origen de Creditos Fiscales','Origen_Id,Descripcion','comOrigenesFiscales','','','Origen_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Origen de Creditos Fiscales', CamposSelect='Origen_Id,Descripcion', FromSelect='comOrigenesFiscales', WhereSelect='', OrderByDefault='', CamposClaves='Origen_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comOrCredFisc'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comOrCredFisc')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOrCredFisc'),'Origen_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOrCredFisc'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comOrdenComp.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comordencomp')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('comordencomp','Ordenes de Compra','Proveed_Id,RazonSocial,Fecha,Estado_Id,CondPago_Id,TipoPermi_Id,TipoCuerpo,Empresa,Importaciones,vcomOrdencomp.comOrdenComp ','vcomOrdencomp','','Fecha Desc','','', 'comOrdenComp','comOCSegmentos', 'comOrdenComp')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ordenes de Compra', 
		CamposSelect='Proveed_Id,RazonSocial,Fecha,Estado_Id,CondPago_Id,TipoPermi_Id,TipoCuerpo,Empresa,Importaciones,vcomOrdencomp.comOrdenComp ', 
		FromSelect='vcomOrdencomp', 
		WhereSelect='', OrderByDefault='Fecha Desc, comOrdenComp Desc', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'comOrdenComp',
		 VistaSeg = 'comOCSegmentos', 
		 CampoPKVistaSeg = 'comOrdenComp'
		     WHERE Identidad_Id='comordencomp'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comordencomp')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'TipoPermi_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comordencomp'),'Estado_Id')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comOrigenesFiscales.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comOrigenesFiscales')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comOrigenesFiscales','Origenes Fiscales','Origen_Id,Descripcion','comOrigenesFiscales','','','Origen_Id','Descripcion', '411040')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Origenes Fiscales', CamposSelect='Origen_Id,Descripcion', FromSelect='comOrigenesFiscales', WhereSelect='', OrderByDefault='',
	 CamposClaves='Origen_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '411040'
     WHERE Identidad_Id='comOrigenesFiscales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comOrigenesFiscales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOrigenesFiscales'),'Origen_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comOrigenesFiscales'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProvAnexo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProvAnexo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProvAnexo','Prov Anexo','Codigo,CUIT,RazonSocial,TipoDoc,idFiscal,Direccion1,Direccion2,Cod_Postal,Provincia_Id,CondFiscal_Id,Localidad,Origen_Id,Empresa_Id,Inactivo,Posteado',
	   'vComprovAnexo','','','Codigo','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Prov Anexo', CamposSelect='Codigo,CUIT,RazonSocial,TipoDoc,idFiscal,Direccion1,Direccion2,Cod_Postal,Provincia_Id,CondFiscal_Id,Localidad,Origen_Id,Empresa_Id,Inactivo,Posteado',
	 FromSelect='vComprovAnexo', WhereSelect='', OrderByDefault='', CamposClaves='Codigo', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='comProvAnexo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProvAnexo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'Codigo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'TipoDoc')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvAnexo'),'idFiscal')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProvCtaAnti.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProvCtaAnti')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProvCtaAnti','Cuentas Anticipos a Proveedores','CtaAnticipo,DescripcionCtaAnticipo,Moneda_Id,Proveed_Id','vvcomProveedoresCtas','CtaAnticipo <> ''  ''','','CtaAnticipo','DescripcionCtaAnticipo')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Anticipos a Proveedores', 
	 CamposSelect='CtaAnticipo,DescripcionCtaAnticipo,Moneda_Id,Proveed_Id', 
	 FromSelect='vvcomProveedoresCtas', WhereSelect='CtaAnticipo <> ''  ''', OrderByDefault='', CamposClaves='CtaAnticipo', CampoDescripcion='DescripcionCtaAnticipo'
     WHERE Identidad_Id='comProvCtaAnti'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProvCtaAnti')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvCtaAnti'),'CtaAnticipo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvCtaAnti'),'DescripcionCtaAnticipo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvCtaAnti'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvCtaAnti'),'Proveed_Id')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProveedores.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario, CharCasing, Mascara, MaximaLongitud)
       Values('comProveedores','Proveedores','Proveed_id,RazonSocial,CUIT,CondPago_Id,Empresa_Id,NombreLegal,Origen_Id,Letra_Fact,TipoCtaProv,Inactivo,Posteado,ProvTipo_Id','vComproveedores','','','Proveed_id','RazonSocial', '1110','Upper','',15)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Proveedores', CamposSelect='Proveed_id,RazonSocial,CUIT,CondPago_Id,Empresa_Id,NombreLegal,Origen_Id,Letra_Fact,TipoCtaProv,Inactivo,Posteado,ProvTipo_Id', 
		 FromSelect='vComproveedores', WhereSelect='', OrderByDefault='', CamposClaves='Proveed_id', CampoDescripcion='RazonSocial', OrdenMenuFormulario = '1110',
		 CharCasing = 'Upper',
		 Mascara = '',
		 MaximaLongitud = 15
		 WHERE Identidad_Id='comProveedores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedores'),'Proveed_id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedores'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedores'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedores'),'NombreLegal')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProveedoresCtasPasivo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresCtasPasivo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresCtasPasivo','Cuentas Pasivo del Proveedor','TipoCtaProv,Descripcion,Moneda_Id,Cuenta_Id,DescripcionCuenta,Proveed_Id','vcomProveedoresCtasPasivo','','','TipoCtaProv','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Pasivo del Proveedor', CamposSelect='TipoCtaProv,Descripcion,Moneda_Id,Cuenta_Id,DescripcionCuenta,Proveed_Id', FromSelect='vcomProveedoresCtasPasivo', WhereSelect='', OrderByDefault='', CamposClaves='TipoCtaProv', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comProveedoresCtasPasivo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresCtasPasivo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivo'),'DescripcionCuenta')

GO


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProveedoresCtasPasivoCta.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresCtasPasivoCta')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresCtasPasivoCta','Cuentas Pasivo del Proveedor','TipoCtaProv,Descripcion,Moneda_Id,Cuenta_Id,DescripcionCuenta,Proveed_Id','vcomProveedoresCtasPasivo','','','Cuenta_Id','DescripcionCuenta')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Pasivo del Proveedor', CamposSelect='TipoCtaProv,Descripcion,Moneda_Id,Cuenta_Id,DescripcionCuenta,Proveed_Id', FromSelect='vcomProveedoresCtasPasivo', WhereSelect='', OrderByDefault='', CamposClaves='Cuenta_Id', CampoDescripcion='DescripcionCuenta'
     WHERE Identidad_Id='comProveedoresCtasPasivoCta'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresCtasPasivoCta'),'DescripcionCuenta')

GO


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProveedoresMonedas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresMonedas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresMonedas','Monedas_del_proveedor','Moneda_Id,DescripcionMoneda,Proveed_Id,TipoCtaProv','vComProveedoresMonedas','','','Moneda_Id','DescripcionMoneda')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Monedas_del_proveedor', CamposSelect='Moneda_Id,DescripcionMoneda,Proveed_Id,TipoCtaProv', FromSelect='vComProveedoresMonedas', WhereSelect='', OrderByDefault='', CamposClaves='Moneda_Id', CampoDescripcion='DescripcionMoneda'
     WHERE Identidad_Id='comProveedoresMonedas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresMonedas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresMonedas'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresMonedas'),'DescripcionMoneda')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresMonedas'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresMonedas'),'TipoCtaProv')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProveedoresTipoPasivo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresTipoPasivo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresTipoPasivo','Tipo de Cuenta Pasivo','TipoCtaProv,Descripcion','comProveedoresTipoPasivo','','Descripcion','TipoCtaProv','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo de Cuenta Pasivo', CamposSelect='TipoCtaProv,Descripcion', FromSelect='comProveedoresTipoPasivo', WhereSelect='', OrderByDefault='Descripcion', CamposClaves='TipoCtaProv', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comProveedoresTipoPasivo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresTipoPasivo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivo'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivo'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProveedoresTipoPasivoAnti.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveedoresTipoPasivoAnti')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveedoresTipoPasivoAnti','Tipos_de_pasivo_de_las_cuentas_anticipos','Proveed_Id,TipoCtaProv,Descripcion','vcomProveedoresTipoPasivoAnti','','','TipoCtaProv','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_de_pasivo_de_las_cuentas_anticipos', CamposSelect='Proveed_Id,TipoCtaProv,Descripcion', FromSelect='vcomProveedoresTipoPasivoAnti', WhereSelect='', OrderByDefault='', CamposClaves='TipoCtaProv', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comProveedoresTipoPasivoAnti'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveedoresTipoPasivoAnti')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivoAnti'),'TipoCtaProv')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProveedoresTipoPasivoAnti'),'Descripcion')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProveeT3.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProveeT3')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comProveeT3','Proveedor de Trabajo de Terceros','Proveed_Id,RazonSocial,Trabajo3_Id,Cantidad,Medida_Id,Precio,Moneda_Id,Inactivo,Posteado,Empresa_Id','vproTrabajo3Prov','','Proveed_Id','Proveed_Id','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Proveedor de Trabajo de Terceros', 
	 CamposSelect='Proveed_Id,RazonSocial,Trabajo3_Id,Cantidad,Medida_Id,Precio,Moneda_Id,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='vproTrabajo3Prov', 
	 WhereSelect='', 
	 OrderByDefault='Proveed_Id', CamposClaves='Proveed_Id', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='comProveeT3'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProveeT3')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Cantidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Precio')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comProveeT3'),'Moneda_Id')

GO


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comProvTipos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comProvTipos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comProvTipos','Tipos de Proveedores','ProvTipo_Id,Descripcion,Posteado,Inactivo,Empresa_Id','comProvTipos','','ProvTipo_Id','ProvTipo_Id','Descripcion','1140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos de Proveedores', CamposSelect='ProvTipo_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='comProvTipos', WhereSelect='', OrderByDefault='ProvTipo_Id', CamposClaves='ProvTipo_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '1140'
     WHERE Identidad_Id='comProvTipos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comProvTipos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvTipos'),'ProvTipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comProvTipos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comRegiones.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comRegiones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comRegiones','Origenes Fiscales','Region_Id,Descripcion,Inactivo,Posteado,Empresa_Id','comRegiones','','','Region_Id','Descripcion','1150')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Origenes Fiscales', CamposSelect='Region_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='comRegiones', WhereSelect='', OrderByDefault='', CamposClaves='Region_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '1150'
     WHERE Identidad_Id='comRegiones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comRegiones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comRegiones'),'Region_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comRegiones'),'Descripcion')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comReqInterno.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comReqInterno')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('comReqInterno','Requisitos Internos','Fecha,EstadoRI_Id,TipoPermiRI_Id,Empresa,Proveed_Id,RazonSocial,GeneraOC','vcomReqInterno','','Fecha Desc','','', 'comReqInterno','comRISegmento', 'comReqInterno')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Requisitos Internos', 
		CamposSelect='Fecha,EstadoRI_Id,TipoPermiRI_Id,Empresa,Proveed_Id,RazonSocial,GeneraOC', 
		FromSelect='vcomReqInterno', 
		WhereSelect='', OrderByDefault='Fecha Desc', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'comReqInterno',
		 VistaSeg = 'comRISegmento', 
		 CampoPKVistaSeg = 'comReqInterno'
		     WHERE Identidad_Id='comReqInterno'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comReqInterno')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comReqInterno'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comReqInterno'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comReqInterno'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comReqInterno'),'TipoPermiRI_Id')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comRIEstados.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comRIEstados')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comRIEstados','Estados de Requisitos Internos','EstadoRI_Id,Descripcion','comRIEstados','','','EstadoRI_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estados de Requisitos Internos', CamposSelect='EstadoRI_Id,Descripcion', FromSelect='comRIEstados', WhereSelect='', OrderByDefault='', CamposClaves='EstadoRI_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comRIEstados'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comRIEstados')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comRIEstados'),'EstadoRI_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comRIEstados'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comSubCategorias.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comSubCategorias')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comSubCategorias','SubCategorias','SubCategoria_Id,Descripcion,Categoria_Id','vcomSubCategoria','','','SubCategoria_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SubCategorias', CamposSelect='SubCategoria_Id,Descripcion,Categoria_Id', FromSelect='vcomSubCategoria', WhereSelect='', OrderByDefault='', CamposClaves='SubCategoria_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comSubCategorias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comSubCategorias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comSubCategorias'),'SubCategoria_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comSubCategorias'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comSubCategorias'),'Categoria_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comTipoPermi.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comTipoPermi')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('comTipoPermi','Tipo Orden de Compra','TipoPermi_Id,Descripcion,Empresa_Id,Posteado,Inactivo,Importaciones','comTipoPermi','','TipoPermi_Id','TipoPermi_Id','Descripcion','1330')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo Orden de Compra', CamposSelect='TipoPermi_Id,Descripcion,Empresa_Id,Posteado,Inactivo,Importaciones', FromSelect='comTipoPermi', WhereSelect='', OrderByDefault='TipoPermi_Id', CamposClaves='TipoPermi_Id', CampoDescripcion='Descripcion' ,
		OrdenMenuFormulario = '1330'
     WHERE Identidad_Id='comTipoPermi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comTipoPermi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermi'),'TipoPermi_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermi'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\comTipoPermiRI.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'comTipoPermiRI')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('comTipoPermiRI','comTipoPermiRI','TipoPermiRI_Id,Descripcion,TipoRI,EsquemaAuto_Id,Inactivo,Posteado','vcomTipoPermiRI','','','TipoPermiRI_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='comTipoPermiRI', CamposSelect='TipoPermiRI_Id,Descripcion,TipoRI,EsquemaAuto_Id,Inactivo,Posteado', FromSelect='vcomTipoPermiRI', WhereSelect='', OrderByDefault='', CamposClaves='TipoPermiRI_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='comTipoPermiRI'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('comTipoPermiRI')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'TipoPermiRI_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'TipoRI')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'EsquemaAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('comTipoPermiRI'),'Posteado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conAnexosGrupos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAnexosGrupos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conAnexosGrupos','Anexos Grupos','GrupoAne_Id,Descripcion,Origen,DescripcionOrigen,TipoRubro','vconAnexosGrupos','','','GrupoAne_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Anexos Grupos', CamposSelect='GrupoAne_Id,Descripcion,Origen,DescripcionOrigen,TipoRubro', FromSelect='vconAnexosGrupos', WhereSelect='', OrderByDefault='', CamposClaves='GrupoAne_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conAnexosGrupos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAnexosGrupos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'GrupoAne_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'Origen')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'DescripcionOrigen')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosGrupos'),'TipoRubro')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conAnexosOrigenes.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAnexosOrigenes')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conAnexosOrigenes','Anexos Origenes','Origen,Descripcion,TipoRubro','conAnexosOrigenes','','','Origen','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Anexos Origenes', CamposSelect='Origen,Descripcion,TipoRubro', FromSelect='conAnexosOrigenes', WhereSelect='', OrderByDefault='', CamposClaves='Origen', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conAnexosOrigenes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAnexosOrigenes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosOrigenes'),'Origen')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosOrigenes'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAnexosOrigenes'),'TipoRubro')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conAsientos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAsientos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('conAsientos','Asientos Contabilidad','Fecha,Formulario_Id,LeyendaLibroDiario,vconAsientosCon.Empresa,FechaRegistro,Anulado','vconAsientosCon','','Fecha','','', 'conAsientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Asientos Contabilidad', 
	 CamposSelect='Fecha,Formulario_Id,LeyendaLibroDiario,vconAsientosCon.Empresa,FechaRegistro,Anulado ', 
	 FromSelect='vconAsientosCon', 
	 WhereSelect='', 
	 OrderByDefault='Fecha', 
	 CamposClaves='', 
	 CampoDescripcion='',
	 CampoFKTablaSeg = 'conAsientos',  
	 VistaSeg = 'genAsiSegmentos', 
	 CampoPKVistaSeg = 'Asiento_Id'
	 WHERE Identidad_Id='conAsientos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAsientos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientos'),'LeyendaLibroDiario')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientos'),'FechaRegistro')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientos'),'Anulado')

GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conAsientosGen.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAsientosGen')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('conAsientosGen','Asientos de Contabilidad General','Fecha,Formulario_Id,Posteado,Anulado,Empresa','vconAsientosGen','','Fecha','','','Asiento_Id','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,Formulario_Id,Posteado,Anulado,Empresa', 
		FromSelect='vconAsientosGen', 
		WhereSelect='', OrderByDefault='Fecha', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='Asiento_Id',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='conAsientosGen'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAsientosGen')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosGen'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosGen'),'Posteado')

GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conAsientosT.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAsientosT')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('conAsientosT', 'Asientos Todos', 'Fecha, Formulario_Id, vconAsientos.Empresa_Id, FechaRegistro', 'vconAsientos', '', 'Fecha Desc', '', '', 'conAsientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Asientos Todos', 
	 CamposSelect='Fecha, Formulario_Id, vconAsientos.Empresa_Id, FechaRegistro', 
	 FromSelect='vconAsientos', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'conAsientos',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='conAsientosT'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAsientosT')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosT'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosT'),'LeyendaLibroDiario')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosT'),'FechaRegistro')

GO




Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conAsientosTipo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conAsientosTipos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conAsientosTipos','AsientosTipos','AsiTipo_Id,LeyendaLibroDiario','conAsientosTipo','','','AsiTipo_Id','LeyendaLibroDiario')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='AsientosTipos', CamposSelect='AsiTipo_Id,LeyendaLibroDiario', FromSelect='conAsientosTipo', WhereSelect='', OrderByDefault='', CamposClaves='AsiTipo_Id', CampoDescripcion='LeyendaLibroDiario'
     WHERE Identidad_Id='conAsientosTipos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conAsientosTipos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosTipos'),'AsiTipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conAsientosTipos'),'LeyendaLibroDiario')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conBaseDistri.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conBaseDistri')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conBaseDistri','Bases de Distribucion','Base_Id,Descripcion,Medida_Id,Inactivo,Posteado,Empresa_Id','conBaseDistri','','Base_Id','Base_Id','Descripcion','3140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Bases de Distribucion', CamposSelect='Base_Id,Descripcion,Medida_Id,Inactivo,Posteado,Empresa_Id', FromSelect='conBaseDistri', WhereSelect='', OrderByDefault='Base_Id', CamposClaves='Base_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '3140'
     WHERE Identidad_Id='conBaseDistri'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conBaseDistri')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conBaseDistri'),'Base_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conBaseDistri'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conBaseDistri'),'Medida_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCentro1.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCentro1')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCentro1','Centro de Costos','Centro1_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable','conCentro1','','','Centro1_Id','Descripcion','3125')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro de Costos', CamposSelect='Centro1_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable', FromSelect='conCentro1', WhereSelect='', OrderByDefault='', CamposClaves='Centro1_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '3125'
     WHERE Identidad_Id='conCentro1'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCentro1')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1'),'Centro1_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1'),'Nivel')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCentro1SinPorAster.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCentro1SinPorAster')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCentro1SinPorAster','Centro de Costos','Centro1_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable','conCentro1','Centro1_Id Not In (''%'', ''*'')','','Centro1_Id','Descripcion','3125')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro de Costos', CamposSelect='Centro1_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable', FromSelect='conCentro1', WhereSelect='Centro1_Id Not In (''%'', ''*'')', OrderByDefault='', CamposClaves='Centro1_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario= '3125'
     WHERE Identidad_Id='conCentro1SinPorAster'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCentro1SinPorAster')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1SinPorAster'),'Centro1_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1SinPorAster'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro1SinPorAster'),'Nivel')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCentro2.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCentro2')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCentro2','Centro de Aternativo','Centro2_Id,Descripcion,Nivel,Empresa_Id,Inactivo,Posteado','conCentro2','','','Centro2_Id','Descripcion','3130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro de Aternativo', CamposSelect='Centro2_Id,Descripcion,Nivel,Empresa_Id,Inactivo,Posteado', FromSelect='conCentro2', WhereSelect='', OrderByDefault='', CamposClaves='Centro2_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario= '3130'
     WHERE Identidad_Id='conCentro2'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCentro2')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2'),'Centro2_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2'),'Nivel')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCentro2SinPorAster.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCentro2SinPorAster')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCentro2SinPorAster','Centro de Costos Alternativo','Centro2_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable','conCentro2','Centro2_Id Not In (''%'', ''*'')','','Centro2_Id','Descripcion','3130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro de Costos Alternativo', CamposSelect='Centro2_Id,Descripcion,Nivel,Empresa_Id,Posteado,Inactivo,Imputable', FromSelect='conCentro2', WhereSelect='Centro2_Id Not In (''%'', ''*'')', OrderByDefault='', CamposClaves='Centro2_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '3130'
     WHERE Identidad_Id='conCentro2SinPorAster'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCentro2SinPorAster')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2SinPorAster'),'Centro2_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2SinPorAster'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCentro2SinPorAster'),'Nivel')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCuadro1Filas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuadro1Filas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuadro1Filas','Filas_Cuadro_Uno','Cuadro1Fila_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conCuadro1Filas','','Cuadro1Fila_Id','Cuadro1Fila_Id','Descripcion', '3165')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Filas_Cuadro_Uno', CamposSelect='Cuadro1Fila_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='conCuadro1Filas', WhereSelect='', OrderByDefault='Cuadro1Fila_Id', CamposClaves='Cuadro1Fila_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '3165'
     WHERE Identidad_Id='conCuadro1Filas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuadro1Filas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuadro1Filas'),'Cuadro1Fila_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuadro1Filas'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCuentas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuentas','Cuentas Contables',
	   'Cuenta_Id,Descripcion,Nivel,Imputable,Inactivo,Posteado,Empresa_Id, CASE WHEN RESERVADAPOR IS NULL THEN 0 ELSE 1 END AS Reservada',
	   'conCuentas','','Cuenta_Id','Cuenta_Id','Descripcion', '3110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Contables', 
	 CamposSelect='Cuenta_Id,Descripcion,Nivel,Imputable,Inactivo,Posteado,Empresa_Id, CASE WHEN RESERVADAPOR IS NULL THEN 0 ELSE 1 END AS Reservada', 
	 FromSelect='conCuentas', WhereSelect='', OrderByDefault='Cuenta_Id', CamposClaves='Cuenta_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '3110'
     WHERE Identidad_Id='conCuentas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, CondicionInicial) Values( dbo.FuncFklupIdentidades('conCuentas'),'Cuenta_Id', 'startsWith')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentas'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentas'),'Nivel')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentas'),'Imputable')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCuentasActualizacioni.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentasActualizacion')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuentasActualizacion','Cuentas Contables',
	   'Cuenta_Id,Descripcion,Nivel,Imputable,Inactivo,Posteado,Empresa_Id, CASE WHEN RESERVADAPOR IS NULL THEN 0 ELSE 1 END AS Reservada,SubCuenta_Id',
	   'vconCuentasActualizacion','SubCuenta_Id Is Null','Cuenta_Id','Cuenta_Id','Descripcion', '3110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Contables', 
	 CamposSelect='Cuenta_Id,Descripcion,Nivel,Imputable,Inactivo,Posteado,Empresa_Id, CASE WHEN RESERVADAPOR IS NULL THEN 0 ELSE 1 END AS Reservada,SubCuenta_Id', 
	 FromSelect='vconCuentasActualizacion', WhereSelect='SubCuenta_Id Is Null', OrderByDefault='Cuenta_Id', CamposClaves='Cuenta_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '3110'
     WHERE Identidad_Id='conCuentasActualizacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentasActualizacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, CondicionInicial) Values( dbo.FuncFklupIdentidades('conCuentasActualizacion'),'Cuenta_Id', 'startsWith')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasActualizacion'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasActualizacion'),'Nivel')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasActualizacion'),'Imputable')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCuentasImpPost.sql*/
IF not EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentasImpPost')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuentasImpPost','Cuentas Contables Imputables y Posteadas','Cuenta_Id,conCuentas.Descripcion,Imputable,conCuentas.Posteado,genMonedas.Moneda_Id,conCuentas.Tipo_Id,isnull(TipoEspe_Id,'' '') as TipoEspe_Id, conCuentas.Empresa_Id','conCuentas INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id LEFT OUTER JOIN conTipoEspecialesCuerpo ON conTipoEspecialesCuerpo.Tipo_Id = conCuentas.Tipo_Id','Imputable=1 and Posteado=1','Cuenta_Id','Cuenta_Id','Descripcion','3110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Contables Imputables y Posteadas', 
		CamposSelect='Cuenta_Id,conCuentas.Descripcion,Imputable,conCuentas.Posteado,genMonedas.Moneda_Id,conCuentas.Tipo_Id,isnull(TipoEspe_Id,'' '') as TipoEspe_Id, conCuentas.Empresa_Id,conCuentas.ReservadaPor', 
		FromSelect='conCuentas INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id LEFT OUTER JOIN conTipoEspecialesCuerpo ON conTipoEspecialesCuerpo.Tipo_Id = conCuentas.Tipo_Id', 
		WhereSelect='Imputable=1 and Posteado=1', OrderByDefault='Cuenta_Id', CamposClaves='Cuenta_Id', CampoDescripcion='Descripcion',
			OrdenMenuFormulario = '3110'
WHERE Identidad_Id='conCuentasImpPost'
DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentasImpPost')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, CondicionInicial) Values( dbo.FuncFklupIdentidades('conCuentasImpPost'),'Cuenta_Id','startsWith')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasImpPost'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasImpPost'),'Moneda_Id')

-- Exec Lup_EjecutarConsulta 'conCuentasImpPost', null, null, null, 0, 999, 'MX'

/*
exec Lup_EjecutarCantidadReg @pidentidad_Id='conCuentasImpPost',@pWhereSP='(Moneda_Id = ''pes'' AND TipoEspe_Id = ''CLIEN'')',@pWhere=NULL,@pDominio='MX'
exec Lup_EjecutarConsulta @pidentidad_Id='conCuentasImpPost',@pWhereSP='(Moneda_Id = ''pes'' AND TipoEspe_Id = ''CLIEN'')',@pWhere=NULL,@pDominio='MX', @pDesde=0, @pHasta=99
exec Lup_EjecutarCantidadReg @pidentidad_Id='venClientes',@pWhereSP=NULL,@pWhere=NULL,@pDominio='MX'
*/
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCuentasImpPostSinEspe.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentasImpPostSinEspe')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conCuentasImpPostSinEspe','Cuentas Imputables y Posteadas sin Especiales','Cuenta_Id,conCuentas.Descripcion,Imputable,conCuentas.Posteado,genMonedas.Moneda_Id,conCuentas.Tipo_Id,conCuentas.Empresa_Id,conCuentas.ReservadaPor','conCuentas INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id','Imputable=1 and Posteado=1','Cuenta_Id','Cuenta_Id','Descripcion','3110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Imputables y Posteadas sin Especiales', 
	 CamposSelect='Cuenta_Id,conCuentas.Descripcion,Imputable,conCuentas.Posteado,genMonedas.Moneda_Id,conCuentas.Tipo_Id,conCuentas.Empresa_Id,conCuentas.ReservadaPor', 
	 FromSelect='conCuentas INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id', 
	 WhereSelect='Imputable=1 and Posteado=1', 
	 OrderByDefault='Cuenta_Id', 
	 CamposClaves='Cuenta_Id', 
	 CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '3110'
     WHERE Identidad_Id='conCuentasImpPostSinEspe'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentasImpPostSinEspe')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, CondicionInicial) Values( dbo.FuncFklupIdentidades('conCuentasImpPostSinEspe'),'Cuenta_Id','startsWith')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasImpPostSinEspe'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasImpPostSinEspe'),'Moneda_Id')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conCuentasSC.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conCuentasSC')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conCuentasSC','Cuentas Sin SubCuenta','Cuenta_Id,Descripcion, Inactivo, Posteado, Empresa_Id','vconcuentasSinSc','','Cuenta_Id','Cuenta_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cuentas Sin SubCuenta', 
	 CamposSelect='Cuenta_Id,Descripcion, Inactivo, Posteado, Empresa_Id', 
	 FromSelect='vconCuentasSinSC', WhereSelect='', OrderByDefault='Cuenta_Id', CamposClaves='Cuenta_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conCuentasSC'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conCuentasSC')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasSC'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('conCuentasSC'),'Descripcion')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conEjercicio.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conEjercicio')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conEjercicio','Ejecicios Contables','Ejercicio,Fecha','conEjercicio','','','Ejercicio','Fecha', '325010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ejecicios Contables', CamposSelect='Ejercicio,Fecha', FromSelect='conEjercicio', WhereSelect='', OrderByDefault='', CamposClaves='Ejercicio', CampoDescripcion='Fecha',
		OrdenMenuFormulario = '325010'
     WHERE Identidad_Id='conEjercicio'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conEjercicio')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conEjercicio'),'Ejercicio')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conGruposCont.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conGruposCont')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conGruposCont','Grupos_de_Centros','Grupo_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conGruposCont','','Grupo_Id','Grupo_Id','Descripcion','3135')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Grupos_de_Centros', CamposSelect='Grupo_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='conGruposCont', WhereSelect='', OrderByDefault='Grupo_Id', CamposClaves='Grupo_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '3135'
     WHERE Identidad_Id='conGruposCont'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conGruposCont')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conGruposCont'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conGruposCont'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conIndicesAjustes.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conIndicesAjustes')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conIndicesAjustes','Indices de Ajuste','Indice_Id,Descripcion','conIndicesAjustes','','Indice_Id','Indice_Id','Descripcion','3155')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Indices de Ajuste', CamposSelect='Indice_Id,Descripcion', FromSelect='conIndicesAjustes', WhereSelect='', OrderByDefault='Indice_Id', CamposClaves='Indice_Id', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '3155'
     WHERE Identidad_Id='conIndicesAjustes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conIndicesAjustes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conIndicesAjustes'),'Indice_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conIndicesAjustes'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conInfDefinibles.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conInfDefinibles')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conInfDefinibles','Informes Definibles','Informe_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conInfDefinibles','','Informe_Id','Informe_Id','Descripcion','333020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Informes Definibles', CamposSelect='Informe_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='conInfDefinibles', WhereSelect='', OrderByDefault='Informe_Id', CamposClaves='Informe_Id', 
		CampoDescripcion='Descripcion', OrdenMenuFormulario = '333020'
     WHERE Identidad_Id='conInfDefinibles'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conInfDefinibles')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Informe_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Descripcion', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Inactivo', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Posteado', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conInfDefinibles'),'Empresa_Id', 0)

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conMetodos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'vconMetodos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('vconMetodos','Metodos de Ajuste Contable','Metodo_Id,Descripcion,Dominio_Id','vconMetodos','','Metodo_Id','Metodo_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Metodos de Ajuste Contable', CamposSelect='Metodo_Id,Descripcion,Dominio_Id', FromSelect='vconMetodos', WhereSelect='', OrderByDefault='Metodo_Id', CamposClaves='Metodo_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='vconMetodos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('vconMetodos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vconMetodos'),'Metodo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vconMetodos'),'Descripcion')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conOrigAplicReng.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conOrigAplicReng')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conOrigAplicReng','OrigAplicReng','GrupoOaf_Id,Descripcion','conOrigAplicReng','','','GrupoOaf_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='OrigAplicReng', CamposSelect='GrupoOaf_Id,Descripcion', FromSelect='conOrigAplicReng', WhereSelect='', OrderByDefault='', CamposClaves='GrupoOaf_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conOrigAplicReng'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conOrigAplicReng')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conOrigAplicReng'),'GrupoOaf_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conOrigAplicReng'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conRubros.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conRubros')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('conRubros','Rubros','Rubro_Id,Descripcion','conRubros','','','Rubro_Id','Descripcion','3160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Rubros', CamposSelect='Rubro_Id,Descripcion', FromSelect='conRubros', WhereSelect='', OrderByDefault='', CamposClaves='Rubro_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '3160'
     WHERE Identidad_Id='conRubros'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conRubros')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conRubros'),'Rubro_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conRubros'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conRubrosAxi.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conRubrosAxi')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conRubrosAxi','Rubros Axi','RubroAxi_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conRubrosAxi','','','RubroAxi_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Rubros Axi', CamposSelect='RubroAxi_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='conRubrosAxi', WhereSelect='', OrderByDefault='', CamposClaves='RubroAxi_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conRubrosAxi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conRubrosAxi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conRubrosAxi'),'RubroAxi_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('conRubrosAxi'),'Descripcion', 0)

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conRubrosPrevi.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'RubroPrevi_Id')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('RubroPrevi_Id','Anexo_de_Previsiones','RubroPrevi_Id,Descripcion','conRubrosPrevi','','','RubroPrevi_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Anexo_de_Previsiones', CamposSelect='RubroPrevi_Id,Descripcion', FromSelect='conRubrosPrevi', WhereSelect='', OrderByDefault='', CamposClaves='RubroPrevi_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='RubroPrevi_Id'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('RubroPrevi_Id')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('RubroPrevi_Id'),'RubroPrevi_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('RubroPrevi_Id'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conSituPatri.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conSituPatri')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('conSituPatri','Situacion Patrimo?al','Rubro_Balance,Descripcion,Rubro_Id','conSituPatri','','','Rubro_Balance','Descripcion','317010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Situacion Patrimo?al', CamposSelect='Rubro_Balance,Descripcion,Rubro_Id', FromSelect='conSituPatri', WhereSelect='', OrderByDefault='', CamposClaves='Rubro_Balance', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '317010'
     WHERE Identidad_Id='conSituPatri'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conSituPatri')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSituPatri'),'Rubro_Balance')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSituPatri'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSituPatri'),'Rubro_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conSubCuentas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conSubCuentas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conSubCuentas','SubCuentas','SubCuenta_Id,Descripcion,Inactivo,Posteado,Empresa_Id','conSubCuentas','','SubCuenta_Id','SubCuenta_Id','Descripcion','3120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SubCuentas', CamposSelect='SubCuenta_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
		FromSelect='conSubCuentas', WhereSelect='', OrderByDefault='SubCuenta_Id', CamposClaves='SubCuenta_Id', 
			CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '3120'
     WHERE Identidad_Id='conSubCuentas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conSubCuentas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSubCuentas'),'SubCuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conSubCuentas'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conTipoEspeciales.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conTipoEspeciales')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('conTipoEspeciales','Tipos_Especiales','TipoEspe_Id,Descripcion','conTipoEspeciales','','Descripcion','TipoEspe_Id','Descripcion','317030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_Especiales', CamposSelect='TipoEspe_Id,Descripcion', FromSelect='conTipoEspeciales', WhereSelect='', OrderByDefault='Descripcion', CamposClaves='TipoEspe_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario ='317030'
     WHERE Identidad_Id='conTipoEspeciales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conTipoEspeciales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTipoEspeciales'),'TipoEspe_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTipoEspeciales'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conTiposContables.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conTiposContables')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('conTiposContables','Tipos_Contables','Tipo_Id,Descripcion,Tipo,Rubro_Id','vconTiposContables','','','Tipo_Id','Descripcion','317020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_Contables', 
	 CamposSelect='Tipo_Id,Descripcion,Tipo,Rubro_Id', FromSelect='vconTiposContables', WhereSelect='', OrderByDefault='', CamposClaves='Tipo_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '317020'
     WHERE Identidad_Id='conTiposContables'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conTiposContables')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposContables'),'Tipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposContables'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposContables'),'Tipo')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\conTiposSAT.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conTiposSAT')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conTiposSAT','Tipos SAT','TipoSat_Id,Descripcion','conTiposSAT','','TipoSat_Id','TipoSat_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos SAT', CamposSelect='TipoSat_Id,Descripcion', FromSelect='conTiposSAT', WhereSelect='', OrderByDefault='TipoSat_Id', CamposClaves='TipoSat_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conTiposSAT'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conTiposSAT')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposSAT'),'TipoSat_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conTiposSAT'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\cteAnios.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'cteAnios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('cteAnios','Anios','Valor, Descripcion','vcteAnios','','Valor','Valor','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Anios', 
	 CamposSelect='Valor, Descripcion', 
	 FromSelect='vcteAnios', 
	 WhereSelect='', 
	 OrderByDefault='Valor', 
	 CamposClaves='Valor'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='cteAnios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('cteAnios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteAnios'),'Valor')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteAnios'),'Descripcion')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\cteMeses.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'cteMeses')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('cteMeses','Meses','Valor, Descripcion','vcteMeses','','Valor','Valor','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Meses', 
	 CamposSelect='Valor, Descripcion', 
	 FromSelect='vcteMeses', 
	 WhereSelect='', 
	 OrderByDefault='Valor', 
	 CamposClaves='Valor'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='cteMeses'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('cteMeses')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteMeses'),'Valor')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteMeses'),'Descripcion')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\cteNombreMeses.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'cteNombreMeses')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('cteNombreMeses','Meses','Valor, Descripcion','vcteNombreMeses','','Valor','Valor','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Meses', 
	 CamposSelect='Valor, Descripcion', 
	 FromSelect='vcteNombreMeses', 
	 WhereSelect='', 
	 OrderByDefault='Valor', 
	 CamposClaves='Valor'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='cteNombreMeses'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('cteNombreMeses')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteNombreMeses'),'Valor')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('cteNombreMeses'),'Descripcion')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\disControlesXFormulario.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'disControlesXFormulario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('disControlesXFormulario','Controles del Formulario',
		'vv.Solapa, vv.Control_Id, vv.Titulo, vv.TipoControl ',
		'vdisControlesXFormulario vv inner join disformularios ON disFormularios.Formulario_Id = vv.formulario_id and disFormularios.Formulario_Id = @pPar1',
		'','Solapa, Titulo','Control_Id','Titulo')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Controles del Formulario', 
	 CamposSelect='vv.Solapa, vv.Control_Id, vv.Titulo, vv.TipoControl', 
	 FromSelect='vdisControlesXFormulario vv inner join disformularios ON disFormularios.Formulario_Id = vv.formulario_id and disFormularios.Formulario_Id = @pPar1', 
	 WhereSelect='', 
	 OrderByDefault='Solapa, Titulo', 
	 CamposClaves='Control_Id'
	 , CampoDescripcion='Titulo'
     WHERE Identidad_Id='disControlesXFormulario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('disControlesXFormulario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('disControlesXFormulario'),'Solapa')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('disControlesXFormulario'),'Control_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('disControlesXFormulario'),'Titulo')
GO


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\Empresas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'Empresas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('Empresas','Empresas','Empresa_Id,Detalle','genEmpresas','','Detalle','Empresa_Id','Detalle')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Empresas', CamposSelect='Empresa_Id,Detalle', FromSelect='genEmpresas', WhereSelect='', OrderByDefault='Detalle', CamposClaves='Empresa_Id', CampoDescripcion='Detalle'
     WHERE Identidad_Id='Empresas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('Empresas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('Empresas'),'Empresa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('Empresas'),'Detalle')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\espCFD.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'espCFD')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('espCFD','FOLIOS CFDI','NroMOV,FechaRegistro,Proveed_Id','espCFD','','FechaRegistro,Proveed_Id','NroMOV','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='FOLIOS CFDI', CamposSelect='NroMOV,FechaRegistro,Proveed_Id', FromSelect='espCFD', WhereSelect='', OrderByDefault='FechaRegistro,Proveed_Id', CamposClaves='NroMOV', CampoDescripcion=''
     WHERE Identidad_Id='espCFD'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('espCFD')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('espCFD'),'NroMOV')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('espCFD'),'FechaRegistro')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genAtriGralesClases.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genAtriGralesClases')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genAtriGralesClases','Atributos Generales','Tabla_id,Descripcion','genAtriGralesClases','','','Tabla_id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Atributos Generales', CamposSelect='Tabla_id,Descripcion', FromSelect='genAtriGralesClases', WhereSelect='', OrderByDefault='', CamposClaves='Tabla_id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genAtriGralesClases'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genAtriGralesClases')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genAtriGralesClases'),'Tabla_id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genAtriGralesClases'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genColonias.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genColonias')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genColonias','Colonias Mx','c_Colonia,c_CodigoPostal,NombreAsentamiento','genColonias','','','c_Colonia','NombreAsentamiento', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Colonias Mx', CamposSelect='c_Colonia,c_CodigoPostal,NombreAsentamiento', FromSelect='genColonias', WhereSelect='', OrderByDefault='', CamposClaves='c_Colonia', CampoDescripcion='NombreAsentamiento', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genColonias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genColonias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genColonias'),'c_Colonia')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genColonias'),'c_CodigoPostal')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genColonias'),'NombreAsentamiento')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genContadores.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genContadores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genContadores','Contadores','Contador,Descripcion,Empresa_Id','genContadores','','','Contador','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Contadores', CamposSelect='Contador,Descripcion,Empresa_Id', FromSelect='genContadores', WhereSelect='', OrderByDefault='', CamposClaves='Contador', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genContadores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genContadores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genContadores'),'Contador')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genContadores'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genContadores'),'Empresa_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genCulturas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genCulturas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genCulturas','Culturas','Cultura,Descripcion','genCulturas','','','Cultura','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Culturas', CamposSelect='Cultura,Descripcion', FromSelect='genCulturas', WhereSelect='', OrderByDefault='', CamposClaves='Cultura', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genCulturas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genCulturas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genCulturas'),'Cultura')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genCulturas'),'Descripcion')
Go

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genDominios.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genDominios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genDominios','Dominos','Dominio_Id,Descripcion','genDominios','','Descripcion','Dominio_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Dominos', CamposSelect='Dominio_Id,Descripcion', FromSelect='genDominios', WhereSelect='', OrderByDefault='Descripcion', CamposClaves='Dominio_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genDominios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genDominios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genDominios'),'Dominio_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genDominios'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genEntidadesBasicas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genEntidadesBasicas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genEntidadesBasicas','Entidades Basicas','Clave,Descripcion,Dominio_Id,Entidad_Id','genEntidadesBasicasValor','','Clave','Clave','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Entidades Basicas', CamposSelect='Clave,Descripcion,Dominio_Id,Entidad_Id', FromSelect='genEntidadesBasicasValor', WhereSelect='', OrderByDefault='Clave', CamposClaves='Clave', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genEntidadesBasicas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genEntidadesBasicas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genEntidadesBasicas'),'Clave')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genEntidadesBasicas'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genGrupos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genGrupos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genGrupos','Grupos','Usuario_Id,Apellido_Y_Nombres,TipoUsuario,Empresa_Id,Posteado,Inactivo','genUsuarios','TipoUsuario=''G''','','Usuario_Id','Apellido_Y_Nombres','7130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Grupos', CamposSelect='Usuario_Id,Apellido_Y_Nombres,TipoUsuario,Empresa_Id,Posteado,Inactivo', FromSelect='genUsuarios', WhereSelect='TipoUsuario=''G''', OrderByDefault='', CamposClaves='Usuario_Id', CampoDescripcion='Apellido_Y_Nombres',
		OrdenMenuFormulario = '7130'
     WHERE Identidad_Id='genGrupos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genGrupos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genGrupos'),'Usuario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genGrupos'),'Apellido_Y_Nombres')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genLetraCompras.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genLetraCompras')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genLetraCompras','Letras Compras','Valor,Descripcion','vgenLetraCompras','','','Valor','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Letras Compras', CamposSelect='Valor,Descripcion', FromSelect='vgenLetraCompras', WhereSelect='', OrderByDefault='', CamposClaves='Valor', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genLetraCompras'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genLetraCompras')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLetraCompras'),'Valor')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLetraCompras'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genLexico.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genLexico')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genLexico','Formulas','Funcion,Descripcion,SetFunciones','genLexico','','','Funcion','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Formulas', CamposSelect='Funcion,Descripcion,SetFunciones', FromSelect='genLexico', WhereSelect='', OrderByDefault='', CamposClaves='Funcion', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genLexico'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genLexico')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLexico'),'Funcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genLexico'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genlocalidades.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genlocalidades')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genlocalidades','Localidades Mx','c_Localidad,Descripcion,c_Estado','genlocalidades','','','c_Localidad','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Localidades Mx', CamposSelect='c_Localidad,Descripcion,c_Estado', FromSelect='genlocalidades', WhereSelect='', OrderByDefault='', CamposClaves='c_Localidad', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genlocalidades'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genlocalidades')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genlocalidades'),'c_Localidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genlocalidades'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genlocalidades'),'c_Estado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genMenusFormularios.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genMenusFormularios')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('genMenusFormularios', 'Formularios', 
		'Formulario_Id, Opcion', 
		'vgenMenusFormularios', '', 'Opcion asc', 'Formulario_Id', 'Opcion', '', '',  '')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Formularios', 
	 CamposSelect='Formulario_Id, Opcion', 
	 FromSelect='vgenMenusFormularios', 
	 WhereSelect='', 
	 OrderByDefault='Opcion asc', 
	 CamposClaves='Formulario_Id', CampoDescripcion='Opcion', 
	 CampoFKTablaSeg = '',  VistaSeg = '', CampoPKVistaSeg = ''
     WHERE Identidad_Id='genMenusFormularios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genMenusFormularios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMenusFormularios'),'Formulario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMenusFormularios'),'Opcion')
GO
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genMonedaProv.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genMonedaProv')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genMonedaProv','Moneda Proveedor','Moneda_Id,DescripcionMoneda,Proveed_Id,TipoCtaProv','vcomProveedoresCtasPasivo','','Moneda_Id','Moneda_Id','DescripcionMoneda')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Moneda Proveedor', CamposSelect='Moneda_Id,DescripcionMoneda,Proveed_Id,TipoCtaProv', FromSelect='vcomProveedoresCtasPasivo', WhereSelect='', OrderByDefault='Moneda_Id', CamposClaves='Moneda_Id', CampoDescripcion='DescripcionMoneda'
     WHERE Identidad_Id='genMonedaProv'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genMonedaProv')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMonedaProv'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMonedaProv'),'DescripcionMoneda')
GO
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genMonedas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genMonedas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genMonedas','Monedas','Moneda_Id,Descripcion,Posteado,Inactivo,Empresa_Id','genMonedas','','Moneda_Id','Moneda_Id','Descripcion','7180')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Monedas', CamposSelect='Moneda_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='genMonedas', WhereSelect='', OrderByDefault='Moneda_Id', CamposClaves='Moneda_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7180'
     WHERE Identidad_Id='genMonedas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genMonedas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMonedas'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMonedas'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genMunicipios.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genMunicipios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('genMunicipios','Municipios Mx','c_Municipio,Descripcion,c_Estado','genMunicipios','','','c_Municipio','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Municipios Mx', CamposSelect='c_Municipio,Descripcion,c_Estado', FromSelect='genMunicipios', WhereSelect='', OrderByDefault='', CamposClaves='c_Municipio', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='genMunicipios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genMunicipios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMunicipios'),'c_Municipio')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMunicipios'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genMunicipios'),'c_Estado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genPaises.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genPaises')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genPaises','Dominos','Pais_Id,Descripcion,Posteado,Inactivo,Empresa_Id','genPaises','','Pais_Id','Pais_Id','Descripcion','7140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Dominos', CamposSelect='Pais_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='genPaises', WhereSelect='', OrderByDefault='Pais_Id', CamposClaves='Pais_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7140'
     WHERE Identidad_Id='genPaises'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genPaises')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genPaises'),'Pais_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genPaises'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genPaises'),'Empresa_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genProvincias.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genProvincias')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genProvincias','Dominos','Provincia_Id,Descripcion,Posteado,Inactivo,Empresa_Id','genProvincias','','Provincia_Id','Provincia_Id','Descripcion','7150')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Dominos', CamposSelect='Provincia_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='genProvincias', WhereSelect='', OrderByDefault='Provincia_Id', CamposClaves='Provincia_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7150'
     WHERE Identidad_Id='genProvincias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genProvincias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genProvincias'),'Provincia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genProvincias'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genReportes.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genReportes')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genReportes','Reportes','Reporte_Id,Titulo,TipoReporte','genReportes','','Reporte_Id','Reporte_Id','Titulo')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Reportes', CamposSelect='Reporte_Id,Titulo,TipoReporte', FromSelect='genReportes', WhereSelect='', OrderByDefault='Reporte_Id', CamposClaves='Reporte_Id', CampoDescripcion='Titulo'
     WHERE Identidad_Id='genReportes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genReportes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genReportes'),'Reporte_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genReportes'),'Titulo')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genSegmentoOrigenes.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genSegmentoOrigenes')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genSegmentoOrigenes','Origenes de Segmentos','OriSeg_Id,Descripcion','genSegmentoOrigenes','','','OriSeg_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Origenes de Segmentos', CamposSelect='OriSeg_Id,Descripcion', FromSelect='genSegmentoOrigenes', WhereSelect='', OrderByDefault='', CamposClaves='OriSeg_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genSegmentoOrigenes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genSegmentoOrigenes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSegmentoOrigenes'),'OriSeg_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSegmentoOrigenes'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genSegmentos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genSegmentos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('genSegmentos','Segmentos','Segmento_Id,Descripcion,Inactivo,Posteado, EsSueldos','genSegmentos','','','Segmento_Id','Descripcion','7230')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Segmentos', CamposSelect='Segmento_Id,Descripcion,Inactivo,Posteado,EsSueldos', FromSelect='genSegmentos', WhereSelect='', OrderByDefault='', CamposClaves='Segmento_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7230'
     WHERE Identidad_Id='genSegmentos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genSegmentos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSegmentos'),'Segmento_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSegmentos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genSucursalesEmpr.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genSucursalesEmpr')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('genSucursalesEmpr','Sucursal','Sucursal,Descripcion,Posteado,Inactivo,Empresa_Id,EmpresaSTR','vgenSucursalesEmpr','','','Sucursal','Descripcion','7160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Sucursal', CamposSelect='Sucursal,Descripcion,Posteado,Inactivo,Empresa_Id,EmpresaSTR', FromSelect='vgenSucursalesEmpr', WhereSelect='', OrderByDefault='', CamposClaves='Sucursal', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '7160'
     WHERE Identidad_Id='genSucursalesEmpr'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genSucursalesEmpr')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSucursalesEmpr'),'Sucursal')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genSucursalesEmpr'),'Descripcion')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genTamanioHoja.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTamanioHoja')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genTamanioHoja','TamanioHoja','TamanioHoja,Descripcion','genTamanioHoja','','','TamanioHoja','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='TamanioHoja', CamposSelect='TamanioHoja,Descripcion', FromSelect='genTamanioHoja', WhereSelect='', OrderByDefault='', CamposClaves='TamanioHoja', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genTamanioHoja'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTamanioHoja')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('genTamanioHoja'),'TamanioHoja')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('genTamanioHoja'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genTareas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTareas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genTareas','Tareas','Tarea_Id,Descripcion','genTareas','','Tarea_Id','Tarea_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tareas', CamposSelect='Tarea_Id,Descripcion', FromSelect='genTareas', WhereSelect='', OrderByDefault='Tarea_Id', CamposClaves='Tarea_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genTareas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTareas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTareas'),'Tarea_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTareas'),'Descripcion')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genTareasProgramadas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTareasProgramadas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
      Values('genTareasProgramadas','Tareas_Programadas','TareaProgramada_Id,Descripcion,Posteado,Inactivo,Empresa_Id','genTareasProgramadas','','TareaProgramada_Id','TareaProgramada_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades 
	 SET Descripcion ='Tareas_Programadas', 
		CamposSelect='TareaProgramada_Id,Descripcion,Posteado,Inactivo,Empresa_Id', 
		FromSelect='genTareasProgramadas', WhereSelect='', OrderByDefault='TareaProgramada_Id', 
		CamposClaves='TareaProgramada_Id', CampoDescripcion='Descripcion'
	 WHERE Identidad_Id='genTareasProgramadas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTareasProgramadas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTareasProgramadas'),'TareaProgramada_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTareasProgramadas'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genTipoDoc.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTipoDoc')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genTipoDoc','Tipo_de_Documento','TipoDoc,Descripcion,Dominio_Id','genTiposDoc','Dominio_Id = @Dominio_Id','','TipoDoc','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo_de_Documento', CamposSelect='TipoDoc,Descripcion,Dominio_Id', FromSelect='genTiposDoc', WhereSelect='Dominio_Id = @Dominio_Id', OrderByDefault='', CamposClaves='TipoDoc', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genTipoDoc'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTipoDoc')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTipoDoc'),'TipoDoc')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTipoDoc'),'Descripcion')
Go

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genTiposCompAfip.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTiposCompAfip')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genTiposCompAfip','Tipos de comprobantes de Afip','Comprobante_Id,Descripcion,Segmento1N,Segmento2N,Segmento3N,Segmento4N,Segmento1C,Segmento2C,Segmento3C,Segmento4C','genTiposCompAfip','','','Comprobante_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos de comprobantes de Afip', CamposSelect='Comprobante_Id,Descripcion,Segmento1N,Segmento2N,Segmento3N,Segmento4N,Segmento1C,Segmento2C,Segmento3C,Segmento4C', FromSelect='genTiposCompAfip', WhereSelect='', OrderByDefault='', CamposClaves='Comprobante_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genTiposCompAfip'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTiposCompAfip')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTiposCompAfip'),'Comprobante_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTiposCompAfip'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genTiposEjecucionTarea.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genTiposEjecucionTarea')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
      Values('genTiposEjecucionTarea','Tipos_Ejecucion_tareas','TipoEjecucionTarea_Id, Descripcion','genTiposEjecucionTarea','','TipoEjecucionTarea_Id','TipoEjecucionTarea_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades 
	 SET Descripcion ='Tareas_Programadas', 
		CamposSelect='TipoEjecucionTarea_Id, Descripcion', 
		FromSelect='genTiposEjecucionTarea', 
		WhereSelect='', 
		OrderByDefault='TipoEjecucionTarea_Id', 
		CamposClaves='TipoEjecucionTarea_Id', 
		CampoDescripcion='Descripcion'
	WHERE Identidad_Id='genTiposEjecucionTarea'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genTiposEjecucionTarea')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTiposEjecucionTarea'),'TipoEjecucionTarea_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genTiposEjecucionTarea'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genUsuarios.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genUsuarios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('genUsuarios','Usuarios','Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario','genUsuarios','','Usuario_Id','Usuario_Id','Apellido_y_Nombres','7120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Usuarios', 
	 CamposSelect='Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario', 
	 FromSelect='genUsuarios', 
	 WhereSelect='', OrderByDefault='Usuario_Id', CamposClaves='Usuario_Id', CampoDescripcion='Apellido_y_Nombres', 
	 OrdenMenuFormulario = '7120'
     WHERE Identidad_Id='genUsuarios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genUsuarios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genUsuarios'),'Usuario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genUsuarios'),'Apellido_y_Nombres')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\genWSFactElec.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'genWSFactElec')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('genWSFactElec','WS_de_factura_electronica','TipoFE,Descripcion','genWSFactElec','','','TipoFE','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='WS_de_factura_electronica', CamposSelect='TipoFE,Descripcion', FromSelect='genWSFactElec', WhereSelect='', OrderByDefault='', CamposClaves='TipoFE', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='genWSFactElec'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('genWSFactElec')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genWSFactElec'),'TipoFE')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('genWSFactElec'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\impImpuestos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impImpuestos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('impImpuestos','Impuetos','Impuesto_Id,Descripcion,Posteado,Inactivo','impImpuestos','','','Impuesto_Id','Descripcion','41430')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Impuetos', CamposSelect='Impuesto_Id,Descripcion,Posteado,Inactivo', FromSelect='impImpuestos', WhereSelect='', OrderByDefault='', CamposClaves='Impuesto_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '41430'
     WHERE Identidad_Id='impImpuestos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impImpuestos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impImpuestos'),'Impuesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impImpuestos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impImpuestos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impImpuestos'),'Inactivo')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\impJurisdicciones.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impJurisdicciones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('impJurisdicciones','Jurisdicciones','Juris_Id,Descripcion,Inactivo,Posteado,Empresa_Id','impJurisdicciones','','','Juris_Id','Descripcion','414010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Jurisdicciones', CamposSelect='Juris_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='impJurisdicciones', WhereSelect='', OrderByDefault='', CamposClaves='Juris_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '414010'
     WHERE Identidad_Id='impJurisdicciones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impJurisdicciones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impJurisdicciones'),'Juris_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impJurisdicciones'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\impLibrosTipoRenglon.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impLibrosTiposRenglon')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('impLibrosTiposRenglon','tipos renglon libros','TipoRenglon,Descripcion','impLibrosTiposRenglon','','','TipoRenglon','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='tipos renglon libros', CamposSelect='TipoRenglon,Descripcion', FromSelect='impLibrosTiposRenglon', WhereSelect='', OrderByDefault='', CamposClaves='TipoRenglon', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='impLibrosTiposRenglon'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impLibrosTiposRenglon')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLibrosTiposRenglon'),'TipoRenglon')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLibrosTiposRenglon'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\impLiquidacion.sql*/




IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impLiquidacion')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('impLiquidacion','Liquidacion Impuestos','conAsientos,Impuesto_Id,FechaPago,FechaDesde,FechaHasta,TotalaPagar,SePaga,Empresa,Pendiente,Descripcion','vimpLiquidacion','','FechaPago Desc','','', 'conAsientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Liquidacion Impuestos', 
		CamposSelect='conAsientos,Impuesto_Id,FechaPago,FechaDesde,FechaHasta,TotalaPagar,SePaga,Empresa,Pendiente,Descripcion', 
		FromSelect='vimpLiquidacion', 
		WhereSelect='', OrderByDefault='FechaPago Desc', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'conAsientos',
		 VistaSeg = 'genAsiSegmentos', 
		 CampoPKVistaSeg = 'Asiento_Id'
		     WHERE Identidad_Id='impLiquidacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impLiquidacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLiquidacion'),'FechaPago')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLiquidacion'),'Impuesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLiquidacion'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impLiquidacion'),'TotalaPagar')





Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\impPadron.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impPadron')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('impPadron','Padrones','Padron_Id,Descripcion,Empresa_Id,Posteado,Inactivo','impPadron','','','Padron_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Padrones', CamposSelect='Padron_Id,Descripcion,Empresa_Id,Posteado,Inactivo', FromSelect='impPadron', WhereSelect='', OrderByDefault='', CamposClaves='Padron_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='impPadron'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impPadron')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impPadron'),'Padron_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impPadron'),'Descripcion')
Go

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\impRetencionesCFDI.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impRetencionesCFDI')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('impRetencionesCFDI','','Folio,RazonSocial,RFC,FechaExp,Cancelado','impRetencionesCfdi','','Folio,RazonSocial,RFC','Folio','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='', CamposSelect='Folio,RazonSocial,RFC,FechaExp,Cancelado', FromSelect='impRetencionesCfdi', WhereSelect='', OrderByDefault='Folio,RazonSocial,RFC', CamposClaves='Folio', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='impRetencionesCFDI'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impRetencionesCFDI')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'Folio')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'RFC')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'FechaExp')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('impRetencionesCFDI'),'Cancelado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\impTipoImpuesto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'impTipoImpuesto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('impTipoImpuesto','Tipo_de_Impuesto','TipoImpuesto,Descripcion,Dominio_Id','impTipoImpuesto','Dominio_Id = @Dominio_Id','','TipoImpuesto','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo_de_Impuesto', CamposSelect='TipoImpuesto,Descripcion,Dominio_Id', FromSelect='impTipoImpuesto', WhereSelect='Dominio_Id = @Dominio_Id', OrderByDefault='', CamposClaves='TipoImpuesto', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='impTipoImpuesto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('impTipoImpuesto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impTipoImpuesto'),'TipoImpuesto')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impTipoImpuesto'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('impTipoImpuesto'),'Dominio_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\OafDestinos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'conDestino')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('conDestino','Destino','Destino,Descripcion','vconOAFDestinos','','','Destino','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Destino', CamposSelect='Destino,Descripcion', FromSelect='vconOAFDestinos', WhereSelect='', OrderByDefault='', CamposClaves='Destino', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='conDestino'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('conDestino')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conDestino'),'Destino')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('conDestino'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\OCS.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'OCS')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('OCS','Orden de Compra SUMMA++','espOrdenComp.Proveed_Id,espOrdenComp.Fecha,espOrdenComp.Moneda_Id,espOrdenComp.Monto,espOrdenComp.Clave','espOrdenComp','','','','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Orden de Compra SUMMA++', CamposSelect='espOrdenComp.Proveed_Id,espOrdenComp.Fecha,espOrdenComp.Moneda_Id,espOrdenComp.Monto,espOrdenComp.Clave', FromSelect='espOrdenComp', WhereSelect='', OrderByDefault='', CamposClaves='', CampoDescripcion=''
     WHERE Identidad_Id='OCS'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('OCS')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('OCS'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('OCS'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('OCS'),'Monto')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('OCS'),'Clave')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proCausas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proCausas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('proCausas','Causas','Causa_Id,Descripcion,Inactivo,Posteado','proCausas','','','Causa_Id','Descripcion','9160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Causas', CamposSelect='Causa_Id,Descripcion,Inactivo,Posteado', FromSelect='proCausas', WhereSelect='', OrderByDefault='', CamposClaves='Causa_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '9160'
     WHERE Identidad_Id='proCausas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proCausas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proCausas'),'Causa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proCausas'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proCentroProductivo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proCentroProductivo')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('proCentroProductivo','Centro Productivo','CtroProd_Id,Descripcion,Inactivo,Posteado','proCentroProductivo','','','CtroProd_Id','Descripcion','9120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Centro Productivo', CamposSelect='CtroProd_Id,Descripcion,Inactivo,Posteado', FromSelect='proCentroProductivo', WhereSelect='', OrderByDefault='', CamposClaves='CtroProd_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario='9120'
     WHERE Identidad_Id='proCentroProductivo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proCentroProductivo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proCentroProductivo'),'CtroProd_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proCentroProductivo'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proOrden.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proOrdenes')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, CamposClaves, CampoFKTablaSeg,CampoPKVistaSeg,VistaSeg, OrderByDefault, CampoDescripcion)
       Values('proOrdenes','Ordenes Produccion','Producto_Id, DescripcionProducto, FechaNecesidad, FechaEmision, Observaciones,Cantidad, FechaFin, Anulado, Empresa','vproOrden','','', 'proOrden','proOrden','proOrdenSegmento', 'FechaEmision','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ordenes Produccion', 
	 CamposSelect='Producto_Id, DescripcionProducto, FechaNecesidad, FechaEmision, Observaciones,Cantidad, FechaFin, Anulado, Empresa', 
	 FromSelect='vproOrden', 
	 WhereSelect='', 
	 OrderByDefault='FechaEmision',
	 CamposClaves='', 
	 CampoFKTablaSeg='proOrden',
	 VistaSeg='proOrdenSegmento',
	 CampoPKVistaSeg='proOrden'
     WHERE Identidad_Id='proOrdenes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proOrdenes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'DescripcionProducto')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'FechaNecesidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'FechaEmision')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'Observaciones')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'FechaFin')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'Cantidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proOrdenes'),'Anulado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proProgramas.sql*/

IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proProgramas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, CampoDescripcion, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoFKTablaSeg,VistaSeg,CampoPKVistaSeg)
       Values('proProgramas','Programas de Produccion','Descripcion, Fecha, Deposito_Id, Usuario_Id, Empresa',
	   '','vproProgramas','', 'Fecha Desc','', 'proProgramas','proProgramasSegmentos','proProgramas')
ELSE

Begin
     UPDATE lupIdentidades SET Descripcion ='Programas de Produccion', 
	 CamposSelect=' Descripcion, Fecha, Deposito_Id, Usuario_Id, Empresa', 
	 FromSelect='vproProgramas', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc',
	 CamposClaves='', 
	 CampoFKTablaSeg='proProgramas',
	 VistaSeg='proProgramasSegmento',
	 CampoPKVistaSeg='proProgramas'
     WHERE Identidad_Id='proProgramas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proProgramas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proProgramas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proProgramas'),'Deposito_Id')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proRecetas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proRecetas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('proRecetas','Recetas','Receta_Id,Descripcion,Inactivo,Posteado,Empresa_Id','proRecetas','','','Receta_Id','Descripcion','9110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Recetas', CamposSelect='Receta_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='proRecetas', WhereSelect='', OrderByDefault='', CamposClaves='Receta_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '9110'
     WHERE Identidad_Id='proRecetas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proRecetas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetas'),'Receta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetas'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proRecetasProductos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proRecetaProd')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('proRecetaProd','Recetas por Producto','Receta_Id,Descripcion,Producto_Id','vproRecetasProductos','','Receta_Id','Receta_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Recetas por Producto', CamposSelect='Receta_Id,Descripcion,Producto_Id', FromSelect='vproRecetasProductos', WhereSelect='', OrderByDefault='Receta_Id', CamposClaves='Receta_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='proRecetaProd'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proRecetaProd')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetaProd'),'Receta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecetaProd'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proRecursos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proRecursos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('proRecursos','Recursos','Recurso_Id,Descripcion,Inactivo,Posteado,Empresa_Id,UsaSubRecurso','proRecursos','','','Recurso_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Recursos', 
	 CamposSelect='Recurso_Id,Descripcion,Inactivo,Posteado,Empresa_Id,UsaSubRecurso', 
	 FromSelect='proRecursos', WhereSelect='', OrderByDefault='', CamposClaves='Recurso_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='proRecursos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proRecursos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecursos'),'Recurso_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proRecursos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proSubRecursos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proSubRecursos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('proSubRecursos','SubRecursos','SubRecurso_Id,Descripcion,Recurso_Id,Inactivo','vproSubRecursos','','','SubRecurso_Id','Descripcion','9130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SubRecursos', 
	 CamposSelect='SubRecurso_Id,Descripcion,Recurso_Id,Inactivo', 
	 FromSelect='vproSubRecursos', WhereSelect='', OrderByDefault='', CamposClaves='SubRecurso_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '9130'
     WHERE Identidad_Id='proSubRecursos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proSubRecursos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proSubRecursos'),'SubRecurso_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proSubRecursos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proTrabajo3.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proTrabajo3')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('proTrabajo3','Trabajo Tercero','Trabajo3_Id,Descripcion,Inactivo,Posteado,Empresa_Id','proTrabajo3','','','Trabajo3_Id','Descripcion','9140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Trabajo Tercero', 
	 CamposSelect='Trabajo3_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='proTrabajo3', WhereSelect='', OrderByDefault='', CamposClaves='Trabajo3_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario= '9140'
     WHERE Identidad_Id='proTrabajo3'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proTrabajo3')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proTrabajo3'),'Trabajo3_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proTrabajo3'),'Descripcion')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\proVarGlobales.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'proVarGlobales')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('proVarGlobales','Variables Globales','Variable_Id,Descripcion','proVarGlobales','','','Variable_Id','Descripcion','9150')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Variables Globales', CamposSelect='Variable_Id,Descripcion', FromSelect='proVarGlobales', WhereSelect='', OrderByDefault='', CamposClaves='Variable_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '9150'
     WHERE Identidad_Id='proVarGlobales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('proVarGlobales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proVarGlobales'),'Variable_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('proVarGlobales'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\ProveedS.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'ProveedS')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('ProveedS','Proveedores SUMMA++','Proveed_Id,RazonSocial','comProveedores','','RazonSocial','Proveed_Id','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Proveedores SUMMA++', CamposSelect='Proveed_Id,RazonSocial', FromSelect='comProveedores', WhereSelect='', OrderByDefault='RazonSocial', CamposClaves='Proveed_Id', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='ProveedS'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('ProveedS')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('ProveedS'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('ProveedS'),'RazonSocial')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkCausasMovi.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkCausasMovi')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkCausasMovi','Causa_de_Movimiento','Causa_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkCausasMovi','','','Causa_Id','Descripcion','2160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Causa_de_Movimiento', CamposSelect='Causa_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkCausasMovi', WhereSelect='', OrderByDefault='', CamposClaves='Causa_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2160'
     WHERE Identidad_Id='stkCausasMovi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkCausasMovi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCausasMovi'),'Causa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCausasMovi'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkCausasMoviXUsuario.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkCausasMoviXUsuario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkCausasMoviXUsuario','Causa_de_Movimiento','Causa_Id,Descripcion,Inactivo,Posteado,EntSalAmb,Empresa_Id','stkCausasMovi Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = stkCausasMovi .UsuarioAutorizado','','','Causa_Id','Descripcion','2160')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Causa_de_Movimiento', CamposSelect='Causa_Id,Descripcion,Inactivo,Posteado,EntSalAmb,Empresa_Id', FromSelect='stkCausasMovi Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = stkCausasMovi .UsuarioAutorizado', WhereSelect='', OrderByDefault='', CamposClaves='Causa_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2160'
     WHERE Identidad_Id='stkCausasMoviXUsuario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkCausasMoviXUsuario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCausasMoviXUsuario'),'Causa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCausasMoviXUsuario'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkCondfisCompra.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkCondfisCompra')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkCondfisCompra','CF Producto - Impuestos Compras','CFComp_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkCondfisCompra','','CFComp_Id','CFComp_Id','Descripcion','413020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='CF Producto - Impuestos Compras', CamposSelect='CFComp_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkCondfisCompra', WhereSelect='', OrderByDefault='CFComp_Id', CamposClaves='CFComp_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '413020'
     WHERE Identidad_Id='stkCondfisCompra'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkCondfisCompra')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCondfisCompra'),'CFComp_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCondfisCompra'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkCondfisVenta.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkCondfisVenta')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkCondfisVenta','CF Producto - Impuestos Ventas','CFVenta_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkCondfisVenta','','','CFVenta_Id','Descripcion','413010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='CF Producto - Impuestos Ventas', CamposSelect='CFVenta_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkCondfisVenta', WhereSelect='', OrderByDefault='', CamposClaves='CFVenta_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '413010'
     WHERE Identidad_Id='stkCondfisVenta'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkCondfisVenta')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCondfisVenta'),'CFVenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkCondfisVenta'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkDepositos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkDepositos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario, CharCasing, MaximaLongitud)
       Values('stkDepositos','Depositos','Deposito_Id,Descripcion,Inactivo,Posteado,Empresa_Id,AdmiteVentas,UsaUbicacion, Centro1_Id, Centro2_Id','vstkDepositos','','Deposito_Id','Deposito_Id','Descripcion','2140','Upper',5)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Depositos', 
	 CamposSelect='Deposito_Id,Descripcion,Inactivo,Posteado,Empresa_Id,AdmiteVentas,UsaUbicacion, Centro1_Id, Centro2_Id', 
		FromSelect='vstkDepositos', WhereSelect='', OrderByDefault='Deposito_Id', CamposClaves='Deposito_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '2140', 
		CharCasing= 'Upper',
		MaximaLongitud= 5
     WHERE Identidad_Id='stkDepositos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkDepositos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositos'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkDepositosProducto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkDepositosExistencia')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkDepositosExistencia','Depositos con Existencia','Deposito_Id,Descripcion,Cantidad, CantidadReservada, Inactivo,Posteado,Empresa_Id,AdmiteVentas,UsaUbicacion, Producto_Id','vStkDepoExistencia','','Deposito_Id','Deposito_Id','Descripcion','2140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Depositos con Existencia', 
	 CamposSelect='Deposito_Id,Descripcion,Cantidad,CantidadReservada, Inactivo,Posteado,Empresa_Id,AdmiteVentas,UsaUbicacion,Producto_Id', 
	 FromSelect='vStkDepoExistencia', WhereSelect='', OrderByDefault='Deposito_Id', CamposClaves='Deposito_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '2140'
     WHERE Identidad_Id='stkDepositosExistencia'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkDepositosExistencia')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosExistencia'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosExistencia'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosExistencia'),'Cantidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosExistencia'),'CantidadReservada')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkDepositosxUsuario.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkDepositosxUsuario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkDepositosxUsuario','Depositos_del_Usuario','Deposito_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkDepositos Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = stkDepositos.GrupoUsuarios','','Deposito_Id','Deposito_Id','Descripcion','2140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Depositos_del_Usuario', CamposSelect='Deposito_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkDepositos Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = stkDepositos.GrupoUsuarios', WhereSelect='', OrderByDefault='Deposito_Id', CamposClaves='Deposito_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2140'
     WHERE Identidad_Id='stkDepositosxUsuario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkDepositosxUsuario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuario'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuario'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkDepositosxUsuarioProducto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkDepositosxUsuarioProd')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkDepositosxUsuarioProd',
	   'Depositos_del_Usuario_Producto',
	   'Deposito_Id,Descripcion,Cantidad,Inactivo,Posteado,Empresa_Id, Producto_Id,AdmiteVentas',
		'vStkDepoExistencia Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = vStkDepoExistencia.GrupoUsuarios',
		'','Deposito_Id','Deposito_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Depositos_del_Usuario', 
	 CamposSelect='Deposito_Id,Descripcion,Cantidad, Inactivo,Posteado,Empresa_Id, Producto_Id,AdmiteVentas',
	  FromSelect=		'vStkDepoExistencia Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = vStkDepoExistencia.GrupoUsuarios',
		  WhereSelect='', OrderByDefault='Deposito_Id', CamposClaves='Deposito_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='stkDepositosxUsuarioProd'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkDepositosxUsuarioProd')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuarioProd'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuarioProd'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkDepositosxUsuarioProd'),'Cantidad')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkExistenciaSerie.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkExistenciaSerie')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkExistenciaSerie','Existencia_serie_lote_vencimiento','Serie,Cantidad/isnull(@pPar1,1) as Cantidad,Producto_Id,Deposito_Id,Vencimiento,Empresa_Id','vstkExistenciaSerieVto','','Vencimiento','Serie','Cantidad')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Existencia_serie_lote_vencimiento', CamposSelect='Serie,Cantidad/isnull(@pPar1,1) as Cantidad,Producto_Id,Deposito_Id,Vencimiento,Empresa_Id', 
	 FromSelect='vstkExistenciaSerieVto', WhereSelect='', OrderByDefault='Vencimiento', CamposClaves='Serie', CampoDescripcion='Cantidad'
     WHERE Identidad_Id='stkExistenciaSerie'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkExistenciaSerie')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerie'),'Serie')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerie'),'Cantidad')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerie'),'Vencimiento')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkExistenciaSerieSinVto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkExistenciaSerieSinVto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkExistenciaSerieSinVto','Existencia_serie_lote_vencimiento',
	   'Serie,Cantidad/isnull(@pPar1,1) as Cantidad,Producto_Id,Deposito_Id,Vencimiento,Empresa_Id','vstkExistenciaSerieVto','','Serie','Serie','Cantidad')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Existencia_serie_lote_vencimiento', 
	 CamposSelect='Serie,Cantidad/isnull(@pPar1,1) as Cantidad,Producto_Id,Deposito_Id,Vencimiento,Empresa_Id', 
	 FromSelect='vstkExistenciaSerieVto', WhereSelect='', 
	 OrderByDefault='Serie', CamposClaves='Serie', CampoDescripcion='Cantidad'
     WHERE Identidad_Id='stkExistenciaSerieSinVto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkExistenciaSerieSinVto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerieSinVto'),'Serie')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkExistenciaSerieSinVto'),'Cantidad')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkExistenciaUbi.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkExistenciaUbi')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkExistenciaUbi','Ubicacion','Ubicacion_Id,Producto_Id,Deposito_Id,Cantidad,Empresa_Id','vstkExistenciaUbi','','Ubicacion_Id','Ubicacion_Id','Producto_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ubicacion', CamposSelect='Ubicacion_Id,Producto_Id,Deposito_Id,Cantidad,Empresa_Id', FromSelect='vstkExistenciaUbi', WhereSelect='', OrderByDefault='Ubicacion_Id', CamposClaves='Ubicacion_Id', CampoDescripcion='Producto_Id'
     WHERE Identidad_Id='stkExistenciaUbi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkExistenciaUbi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbi'),'Ubicacion_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbi'),'Cantidad', 0)

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkExistenciaUbiSerie.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkExistenciaUbiSerie')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkExistenciaUbiSerie','Ubicacion con Serie','Ubicacion_Id,Serie,Producto_Id,Deposito_Id,Cantidad,Empresa_Id','vstkExistenciaUbiSerie','','Ubicacion_Id','Ubicacion_Id','Serie')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ubicacion con Serie', CamposSelect='Ubicacion_Id,Serie,Producto_Id,Deposito_Id,Cantidad,Empresa_Id', 
	 FromSelect='vstkExistenciaUbiSerie', WhereSelect='', OrderByDefault='Ubicacion_Id', CamposClaves='Ubicacion_Id', CampoDescripcion='Serie'
     WHERE Identidad_Id='stkExistenciaUbiSerie'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkExistenciaUbiSerie')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbiSerie'),'Ubicacion_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbiSerie'),'Cantidad', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkExistenciaUbiSerie'),'Serie', 0)

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkFamilias.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkFamilias')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkFamilias','Familias','Familia_Id,Descripcion,Empresa_Id,Inactivo,Posteado','stkFamilias','','','Familia_Id','Descripcion','2135')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Familias', CamposSelect='Familia_Id,Descripcion,Empresa_Id,Inactivo,Posteado', FromSelect='stkFamilias', WhereSelect='', OrderByDefault='', CamposClaves='Familia_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '2135'
     WHERE Identidad_Id='stkFamilias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkFamilias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkFamilias'),'Familia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkFamilias'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkGrupos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkGrupos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('stkGrupos','Grupos','Grupo_Id,Descripcion,Empresa_Id,Inactivo,Posteado','stkGrupos','','','Grupo_Id','Descripcion','2137')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Grupos', CamposSelect='Grupo_Id,Descripcion,Empresa_Id,Inactivo,Posteado', FromSelect='stkGrupos', WhereSelect='', OrderByDefault='', CamposClaves='Grupo_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario='2137'
     WHERE Identidad_Id='stkGrupos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkGrupos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkGrupos'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkGrupos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkHojaDeRuta.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkHojaDeRuta')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('stkHojaDeRuta','Hojas_de_Ruta','FechaRegistro,Estado,FormaEntrega_id,Patente_Id,PatenteAcoplado,Reparto','vstkHojaDeRuta','','FechaRegistro Desc','','','stkHojaDeRuta','stkHojaDeRuta','stkHojaSegmentos')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Hojas_de_Ruta', 
	 CamposSelect='FechaRegistro,Estado,FormaEntrega_id,Patente_Id,PatenteAcoplado,Reparto', 
	 FromSelect='vstkHojaDeRuta', 
	 WhereSelect='', 
	 OrderByDefault='FechaRegistro Desc', 
	 CamposClaves='', 
	 CampoDescripcion='',
	 CampoFKTablaSeg='stkHojaDeRuta', 
	 CampoPKVistaSeg='stkHojaDeRuta', 
	 VistaSeg = 'stkHojaSegmentos'
     WHERE Identidad_Id='stkHojaDeRuta'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkHojaDeRuta')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'FechaRegistro')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'FormaEntrega_id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'Estado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'Patente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkHojaDeRuta'),'PatenteAcoplado')
GO




Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkInventarios.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkInventarios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkInventarios','Inventarios','FechaInventario,Deposito_Id,Descripcion, Empresa','vstkInventarios','','FechaInventario','','', 'stkInventarios','stkInvenSegmentos', 'stkInventarios')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Inventarios', 
		CamposSelect='FechaInventario,Deposito_Id,Descripcion,Empresa', 
		FromSelect='vstkInventarios', 
		WhereSelect='', OrderByDefault='FechaInventario', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'stkInventarios',
		 VistaSeg = 'stkInvenSegmentos', 
		 CampoPKVistaSeg = 'stkInventarios'
		     WHERE Identidad_Id='stkInventarios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkInventarios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkInventarios'),'FechaInventario')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkInventarios'),'Deposito_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkInventarios'),'Descripcion')

go


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkMoviCabe.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkMoviCabe')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkMoviCabe','Movimientos de Stock','Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vstkMoviCabe.stkMoviCabe,Signo ','vstkMoviCabe','','Fecha Desc,stkMoviCabe Desc','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Stock', 
		CamposSelect='Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vstkMoviCabe.stkMoviCabe,Signo', 
		FromSelect='vstkMoviCabe', 
		WhereSelect='', OrderByDefault='Fecha Desc, stkMoviCabe Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkMoviCabe'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkMoviCabe')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabe'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabe'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkMoviCabe'), 'SubTipomov_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkMoviCabeCD.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkMoviCabeCD')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkMoviCabeCD','Cambios_de_Deposito','Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado','vstkMoviCabeCD','exists(select 1 from stkEnTransito where stkEntransito.stkMoviCabe=vstkMoviCabe.stkMoviCabe and  stkEnTransito.stkMoviCabeEntr is null)','Fecha','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cambios_de_Deposito', 
		CamposSelect='Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado', 
		FromSelect='vstkMoviCabeCD', 
		WhereSelect='', OrderByDefault='Fecha', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkMoviCabeCD'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkMoviCabeCD')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabeCD'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabeCD'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkMoviCabeCD'), 'SubTipomov_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkMoviCabeCDEntr.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkMoviCabeEntr')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, 
		WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkMoviCabeEntr','Cambios_de_Deposito','Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,SegmentoSal,Anulado','vstkMoviCabeEntr','','Fecha','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cambios_de_Deposito', 
		CamposSelect='Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,SegmentoSal,Anulado', 
		FromSelect='vstkMoviCabeEntr', 
		WhereSelect='', OrderByDefault='Fecha', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkMoviCabeEntr'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkMoviCabeEntr')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabeEntr'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkMoviCabeEntr'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkMoviCabeEntr'), 'SegmentoSal')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkMoviCabeEntr'), 'SubTipomov_Id')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkProductos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductos','Productos','Producto_Id,Descripcion,codigoBarra,Familia_Id,Inactivo,Posteado,Acepta_Ventas,Acepta_Compras,Medida_Id,MedidaAlterna,Clase,Empresa_Id,TrabajaPorLotes,Serializable,UsaDespachoImportacion,Observaciones','vstkProductos','','','Producto_Id','Descripcion','2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos', 
	 CamposSelect='Producto_Id,Descripcion,codigoBarra,Familia_Id,Inactivo,Posteado,Acepta_Ventas,Acepta_Compras,Medida_Id,MedidaAlterna,Clase,Empresa_Id,TrabajaPorLotes,Serializable,UsaDespachoImportacion,Observaciones', 
	 FromSelect='vstkProductos', WhereSelect='', OrderByDefault='', 
	 CamposClaves='Producto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='stkProductos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'codigoBarra')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductos'),'Familia_Id')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkProductosCom.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosCom')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductosCom','Productos','Producto_Id,Descripcion,Empresa_Id,Posteado,Acepta_Compras,UMCompra,Costo,Moneda_Id,MedidaAlterna,Inactivo, Familia_Id, Grupo_Id,CodigoBarra','vstkProductosCom','Acepta_Compras=1','Producto_Id','Producto_Id','Descripcion','2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos', 
	 CamposSelect='Producto_Id,Descripcion,Empresa_Id,Posteado,Acepta_Compras,UMCompra,Costo,Moneda_Id,MedidaAlterna,Inactivo,Familia_Id,Grupo_Id,CodigoBarra', 
	 FromSelect='vstkProductosCom', 
	 WhereSelect='Acepta_Compras=1', OrderByDefault='Producto_Id', CamposClaves='Producto_Id', 
	 CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='stkProductosCom'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosCom')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'Familia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCom'),'CodigoBarra')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkProductosComU.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosComU')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductosComU','Productos','Producto_Id,stkProductos.Descripcion,stkProductos.Empresa_Id,stkProductos.Posteado,stkProductos.Acepta_Compras,stkUniMed.Medida_Id,stkProductos.Inactivo','stkProductos inner join stkUniMed ON stkProductos.UMCompra  = stkUniMed.stkUniMed','Acepta_Compras=1','','Producto_Id','Descripcion','2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos', 
	 CamposSelect='Producto_Id,stkProductos.Descripcion,stkProductos.Empresa_Id,stkProductos.Posteado,stkProductos.Acepta_Compras,stkUniMed.Medida_Id,stkProductos.Inactivo', 
	 FromSelect='stkProductos inner join stkUniMed ON stkProductos.UMCompra  = stkUniMed.stkUniMed', WhereSelect='Acepta_Compras=1', 
	 OrderByDefault='', CamposClaves='Producto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='stkProductosComU'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosComU')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosComU'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosComU'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosComU'),'Medida_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkProductosCReceta.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosCReceta')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkProductosCReceta','Productos','Producto_Id,Descripcion,Inactivo,Posteado,Medida_Id,Empresa_Id,Receta_Id','vstkProductosCReceta','','','Producto_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos', 
	 CamposSelect='Producto_Id,Descripcion,Inactivo,Posteado,Medida_Id,Empresa_Id,Receta_Id', 
	 FromSelect='vstkProductosCReceta', WhereSelect='', OrderByDefault='', CamposClaves='Producto_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='stkProductosCReceta'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosCReceta')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCReceta'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCReceta'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosCReceta'),'Medida_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkProductosPlantilla.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosPlantilla')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductosPlantilla','Plantillas','Plantilla_Id,Descripcion,Inactivo,Posteado,Acepta_Ventas,Acepta_Compras,Medida_Id,MedidaAlterna,Clase,Empresa_Id,TrabajaPorLotes,Serializable,UsaDespachoImportacion','stkProductosPlantilla','','','Plantilla_Id','Descripcion','21a0')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Plantillas', CamposSelect='Plantilla_Id,Descripcion,Inactivo,Posteado,Acepta_Ventas,Acepta_Compras,Medida_Id,MedidaAlterna,Clase,Empresa_Id,TrabajaPorLotes,Serializable,UsaDespachoImportacion', FromSelect='stkProductosPlantilla', WhereSelect='', OrderByDefault='', CamposClaves='Plantilla_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '21a0'
     WHERE Identidad_Id='stkProductosPlantilla'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosPlantilla')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosPlantilla'),'Plantilla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosPlantilla'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosPlantilla'),'Medida_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkProductosVen.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkProductosVen')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkProductosVen','Productos de Ventas',
	   'Producto_Id,Descripcion,Familia_Id,Medida_Id,ListaPrecio_Id,PrecioLista*Convert(Numeric(15,4),isnull(@pPar1,1)) as PrecioLista,CFVenta_Id,vStkProductosVen.Inactivo,vStkProductosVen.Posteado,vStkProductosVen.Empresa_Id,MedidaAlterna,Clase,Observaciones,VigenciaDesde, VigenciaHasta','vStkProductosVen','','Producto_Id','Producto_Id','Descripcion', '2110')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Productos de Ventas', 
	 CamposSelect='Producto_Id,Descripcion,Familia_Id,Medida_Id,ListaPrecio_Id,PrecioLista*Convert(Numeric(15,4),isnull(@pPar1,1)) as PrecioLista,CFVenta_Id,vStkProductosVen.Inactivo,vStkProductosVen.Posteado,vStkProductosVen.Empresa_Id,MedidaAlterna,Clase,Observaciones,VigenciaDesde, VigenciaHasta', 
	 FromSelect='vStkProductosVen', WhereSelect='', OrderByDefault='Producto_Id', 
	 CamposClaves='Producto_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '2110'
     WHERE Identidad_Id='stkProductosVen'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkProductosVen')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'Producto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'Familia_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkProductosVen'),'PrecioLista')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkRemitos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkRemitos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkRemitos','Remitos','Fecha,Cliente_Id, RazonSocial, SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vStkRemitos.stkMoviCabe, Estado ','vStkRemitos','',
		'Fecha Desc , stkMoviCabe Desc','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Stock', 
		CamposSelect='Fecha,Cliente_Id, RazonSocial, SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro, vStkRemitos.stkMoviCabe, Estado', 
		FromSelect='vStkRemitos', 
		WhereSelect='', OrderByDefault='Fecha Desc, stkMoviCabe Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkRemitos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkRemitos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitos'),'Anulado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitos'), 'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitos'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitos'), 'Estado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkRemitosPend.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkRemitosPend')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkRemitosPend','Remitos Pendientes','Fecha,Cliente_Id, RazonSocial, SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vStkRemitosPend.stkMoviCabe',
	   'vstkRemitosPend', '', 'Fecha Desc , stkMoviCabe Desc','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Remitos Pendientes', 
		CamposSelect='Fecha,Cliente_Id, RazonSocial, SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro, vStkRemitosPend.stkMoviCabe', 
		FromSelect='vStkRemitosPend', 
		WhereSelect='', 
		OrderByDefault='Fecha Desc, stkMoviCabe Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkRemitosPend'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkRemitosPend')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosPend'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosPend'),'Anulado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitosPend'), 'SubTipomov_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitosPend'), 'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('stkRemitosPend'), 'RazonSocial')
 
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkRemitosProv.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkRemitosProv')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkRemitosProv','Movimientos de Stock','Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vstkRemitosProv.stkMoviCabe, Proveed_Id, RazonSocial ','vstkRemitosProv','','Fecha Desc,stkMoviCabe Desc','','','stkMoviCabe','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Stock', 
		CamposSelect='Fecha,SubTipomov_Id,Formulario_Id,Posteado,Empresa,Anulado,SucursalFiltro,vstkRemitosProv.stkMoviCabe,Proveed_Id, RazonSocial ', 
		FromSelect='vstkRemitosProv', 
		WhereSelect='', OrderByDefault='Fecha Desc, stkMoviCabe Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='stkMoviCabe',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='stkRemitosProv'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkRemitosProv')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkRemitosProv'),'Anulado')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkSolicitudCD.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkSolicitudCD')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('stkSolicitudCD','Solicitud Cambio Depositos','Fecha,vstkSolicitudCD.stkSolicitudCD,Estado','vstkSolicitudCD','','Fecha Desc','','', 'stkSolicitudCD','stkSolicitudCDSegmento', 'stkSolicitudCD')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SolicitudesSegmento', 
		CamposSelect='Fecha,vstkSolicitudCD.stkSolicitudCD,Estado', 
		FromSelect='vstkSolicitudCD', 
		WhereSelect='', OrderByDefault='Fecha Desc, stkSolicitudCD Desc', CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'stkSolicitudCD',
		 VistaSeg = 'stkSolicitudCDSegmento', 
		 CampoPKVistaSeg = 'stkSolicitudCD'
		     WHERE Identidad_Id='stkSolicitudCD'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkSolicitudCD')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkSolicitudCD'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkSolicitudCD'),'Estado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkSubTipoMov.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkSubTipoMov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkSubTipoMov','Sub Tipo de Movimiento de Stock','SubTipoMov_Id,Descripcion','stkSubTipoMov','','SubTipoMov_Id','SubTipoMov_Id','Descripcion','2180')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Sub Tipo de Movimiento de Stock', CamposSelect='SubTipoMov_Id,Descripcion', FromSelect='stkSubTipoMov', WhereSelect='', OrderByDefault='SubTipoMov_Id', CamposClaves='SubTipoMov_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '2180'
     WHERE Identidad_Id='stkSubTipoMov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkSubTipoMov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkSubTipoMov'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkSubTipoMov'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkTipos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkTipos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkTipos','Tipos','Tipo_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkTipos','','Tipo_Id','Tipo_Id','Descripcion','2130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos', CamposSelect='Tipo_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='stkTipos', WhereSelect='', OrderByDefault='Tipo_Id', CamposClaves='Tipo_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2130'
     WHERE Identidad_Id='stkTipos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkTipos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkTipos'),'Tipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkTipos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkTiposMov.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkTiposMov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkTiposMov','Tipo de Movimientos','Tipomov,Descripcion','stkTiposMov','','Tipomov','Tipomov','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo de Movimientos', CamposSelect='Tipomov,Descripcion', FromSelect='stkTiposMov', WhereSelect='', OrderByDefault='Tipomov', CamposClaves='Tipomov', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='stkTiposMov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkTiposMov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkTiposMov'),'Tipomov')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkTiposMov'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkubicaciones.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkubicaciones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('stkubicaciones','Ubicaciones','Ubicacion_Id,Capacidad','stkubicaciones','','Ubicacion_Id','Ubicacion_Id','Capacidad')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ubicaciones', CamposSelect='Ubicacion_Id,Capacidad', FromSelect='stkubicaciones', WhereSelect='', OrderByDefault='Ubicacion_Id', CamposClaves='Ubicacion_Id', CampoDescripcion='Capacidad'
     WHERE Identidad_Id='stkubicaciones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkubicaciones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkubicaciones'),'Ubicacion_Id', 0)
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo, Longitud) Values( dbo.FuncFklupIdentidades('stkubicaciones'),'Capacidad', 0)

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\stkUniMed.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'stkUniMed')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('stkUniMed','Unidades_De_Medida','Medida_Id,Descripcion,Inactivo,Posteado,Empresa_Id','stkUniMed','','Medida_Id','Medida_Id','Descripcion','2120')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Unidades_De_Medida', CamposSelect='Medida_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='stkUniMed', WhereSelect='', OrderByDefault='Medida_Id', CamposClaves='Medida_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '2120'
     WHERE Identidad_Id='stkUniMed'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('stkUniMed')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkUniMed'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('stkUniMed'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueArchivosTxt.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueArchivosTxt')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueArchivosTxt','ArchivosTxt','Archivo_Id,Descripcion','sueArchivosTxt','','','Archivo_Id','Descripcion','S14050')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='ArchivosTxt', CamposSelect='Archivo_Id,Descripcion', FromSelect='sueArchivosTxt', WhereSelect='', OrderByDefault='', CamposClaves='Archivo_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario= 'S14050'
     WHERE Identidad_Id='sueArchivosTxt'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueArchivosTxt')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueArchivosTxt'),'Archivo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueArchivosTxt'),'Descripcion')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueCategorias.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueCategorias')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueCategorias','Categorias','Categoria_Id,Descripcion,Periodo_Id','vsueCategorias','','','Categoria_Id','Descripcion','S11020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Categorias', CamposSelect='Categoria_Id,Descripcion,Periodo_Id', FromSelect='vsueCategorias', WhereSelect='', OrderByDefault='', CamposClaves='Categoria_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S11020'
     WHERE Identidad_Id='sueCategorias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueCategorias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCategorias'),'Categoria_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCategorias'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCategorias'),'Periodo_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueCateNombre.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueCateNombre')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('sueCateNombre','Nombre Categoria','CateNombre_Id,Descripcion','sueCateNombre','','','CateNombre_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Nombre Categoria', CamposSelect='CateNombre_Id,Descripcion', FromSelect='sueCateNombre', WhereSelect='', OrderByDefault='', CamposClaves='CateNombre_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='sueCateNombre'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueCateNombre')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCateNombre'),'CateNombre_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueCateNombre'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueConcAcum.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueConcAcum')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, VistaSeg, 
		CampoPKVistaSeg,CampoDescripcion)
       Values('sueConcAcum','Descuento por Tope','Legajo,Nombres,Concepto_Id,DescripcionConcepto,Fecha,MontoTope,Anulado,Empresa',
		'vsueConcAcum','','','','sueConcAcumSegmento','sueConcAcum','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Descuento por Tope', 
	 CamposSelect='Legajo,Nombres,Concepto_Id,DescripcionConcepto,Fecha,MontoTope,Anulado,Empresa ', 
	 FromSelect='vsueConcAcum', 
	 WhereSelect='', 
	 OrderByDefault='Fecha desc', 
	 CamposClaves='', 
	 CampoFKTablaSeg='sueConcAcum',
	 VistaSeg='sueConcAcumSegmento',
	 CampoPKVistaSeg='sueConcAcum'
     WHERE Identidad_Id='sueConcAcum'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueConcAcum')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'Legajo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'Nombres')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'Concepto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'DescripcionConcepto')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConcAcum'),'MontoTope')
GO




Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueConceptos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueConceptos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueConceptos','Conceptos','Concepto_Id,Descripcion,Inactivo,Posteado','sueConceptos','','','Concepto_Id','Descripcion','S12020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Conceptos', CamposSelect='Concepto_Id,Descripcion,Inactivo,Posteado', FromSelect='sueConceptos', WhereSelect='', OrderByDefault='', CamposClaves='Concepto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S12020'
     WHERE Identidad_Id='sueConceptos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueConceptos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConceptos'),'Concepto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConceptos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConceptos'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConceptos'),'Posteado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueConvenio.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueConvenio')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueConvenio','Convenio','Convenio_Id,Descripcion,Posteado,Inactivo','sueConvenio','','','Convenio_Id','Descripcion','S11040')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Convenio', CamposSelect='Convenio_Id,Descripcion,Posteado,Inactivo', FromSelect='sueConvenio', WhereSelect='', OrderByDefault='', CamposClaves='Convenio_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S11040'
     WHERE Identidad_Id='sueConvenio'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueConvenio')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConvenio'),'Convenio_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConvenio'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConvenio'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueConvenio'),'Inactivo')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueGanancias.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueGanancias')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('sueGanancias','Ganancias','TabGan_Id,Descripcion,FechaRegistro','sueGanTitulo','','','TabGan_Id','Descripcion','S14040')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Ganancias', CamposSelect='TabGan_Id,Descripcion,FechaRegistro', FromSelect='sueGanTitulo', WhereSelect='', OrderByDefault='', CamposClaves='TabGan_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S14040'
     WHERE Identidad_Id='sueGanancias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueGanancias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGanancias'),'TabGan_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGanancias'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGanancias'),'FechaRegistro')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueGrupos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueGrupos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueGrupos','Grupos','Grupo_Id,Descripcion,Posteado,Inactivo, Periodo_Id, Empresa_Id,Segmento_Id','vsueGrupos','','','Grupo_Id','Descripcion','S12010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Grupos', 
	 CamposSelect='Grupo_Id,Descripcion,Posteado,Inactivo, Periodo_Id, Empresa_Id,Segmento_Id', 
	 FromSelect='vsueGrupos', 
	 WhereSelect='', OrderByDefault='', 
	 CamposClaves='Grupo_Id', 
	 CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = 'S12010'
     WHERE Identidad_Id='sueGrupos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueGrupos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueGrupos'),'Periodo_Id')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueImpNombre.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueImpNombre')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueImpNombre','Nombre Importe','Importe_Id,Descripcion','sueImpNombre','','','Importe_Id','Descripcion','S1401020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Nombre Importe', CamposSelect='Importe_Id,Descripcion', FromSelect='sueImpNombre', WhereSelect='', OrderByDefault='', CamposClaves='Importe_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S1401020'
     WHERE Identidad_Id='sueImpNombre'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueImpNombre')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueImpNombre'),'Importe_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueImpNombre'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueInfDefinibles.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueInfDefinibles')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('sueInfDefinibles','Informes Definibles','Informe_Id,Descripcion,Posteado,Inactivo','sueInfDefinibles','','','Informe_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Informes Definibles', CamposSelect='Informe_Id,Descripcion,Posteado,Inactivo', FromSelect='sueInfDefinibles', WhereSelect='', OrderByDefault='', CamposClaves='Informe_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='sueInfDefinibles'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueInfDefinibles')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Informe_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueInfDefinibles'),'Inactivo')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueLiquidacion.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueLiquidacion')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, 
	 OrderByDefault, CamposClaves, VistaSeg, 	CampoPKVistaSeg,CampoDescripcion, CampoFKTablaSeg)
       Values('sueLiquidacion','Liquidacion','vsueLiquidacion,Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado',
		'vsueLiquidaciones','','FechaInicial','','genAsiSegmentos','Asiento_Id','','vsueLiquidacion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Liquidacion', 
	 CamposSelect='Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado', 
	 FromSelect='vsueLiquidaciones', 
	 WhereSelect='', 
	 OrderByDefault='FechaInicial desc', 
	 CamposClaves='', 
	 CampoFKTablaSeg='vsueLiquidacion',
	 VistaSeg='genAsiSegmentos',
	 CampoPKVistaSeg='Asiento_Id'
     WHERE Identidad_Id='sueLiquidacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueLiquidacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacion'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacion'),'FechaInicial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacion'),'FechaFinal')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueLiquidacionHabi.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueLiquidacionHabi')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, VistaSeg, 
		CampoPKVistaSeg,CampoDescripcion)
       Values('sueLiquidacionHabi','Liquidacion','vsueLiquidacion,Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado',
		'vsueLiquidacionesHabi','','','','genAsiSegmentos','Asiento_Id','')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Liquidacion', 
	 CamposSelect='Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado', 
	 FromSelect='vsueLiquidacionesHabi', 
	 WhereSelect='', 
	 OrderByDefault='FechaInicial', 
	 CamposClaves='', 
	 CampoFKTablaSeg='vsueLiquidacion',
	 VistaSeg='genAsiSegmentos',
	 CampoPKVistaSeg='Asiento_Id'
     WHERE Identidad_Id='sueLiquidacionHabi'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueLiquidacionHabi')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionHabi'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionHabi'),'FechaInicial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionHabi'),'FechaFinal')
GO
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueLiquidacionLega.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueLiquidacionLega')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, 
	 OrderByDefault, CamposClaves, VistaSeg, CampoPKVistaSeg,CampoDescripcion, CampoFKTablaSeg)
       Values('sueLiquidacionLega', 'Liquidacion', 'Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado,Legajo',
		'vsueLiquidacionesLega', '', 'FechaInicial Desc', '', 'genAsiSegmentos', 'Asiento_Id', '', 'vsueLiquidacion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Liquidacion', 
	 CamposSelect = 'Grupo_Id,vAnio,vMes,vQuincena,vSemana,vDecena,vVez,FechaInicial,FechaFinal,Empresa,Anulado,Legajo', 
	 FromSelect = 'vsueLiquidacionesLega', 
	 WhereSelect = '', 
	 OrderByDefault = 'FechaInicial Desc', 
	 CamposClaves = '', 
	 CampoFKTablaSeg = 'vsueLiquidacion',
	 VistaSeg = 'genAsiSegmentos',
	 CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id = 'sueLiquidacionLega'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id = dbo.FuncFklupIdentidades('sueLiquidacionLega')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionLega'),'Grupo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionLega'),'FechaInicial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueLiquidacionLega'),'FechaFinal')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\suePeriodicidad.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'suePeriodos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('suePeriodos','Periodos','Periodo_Id,Descripcion','suePeriodicidad','','','Periodo_Id','Descripcion','S11070')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Periodos', CamposSelect='Periodo_Id,Descripcion', FromSelect='suePeriodicidad', WhereSelect='', OrderByDefault='', CamposClaves='Periodo_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario='S11070'
     WHERE Identidad_Id='suePeriodos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('suePeriodos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePeriodos'),'Periodo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePeriodos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\suePersonal.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'suePersonal')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('suePersonal','Personal','Legajo, Nombres ,Inactivo,Posteado,Empresa_Id','vsuePersonal','','','Legajo','Nombres','S11010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Personal', 
		CamposSelect='Legajo, Nombres,Inactivo,Posteado,Empresa_Id', 
		FromSelect='vsuePersonal', WhereSelect='', OrderByDefault='', 
		CamposClaves='Legajo', 
		CampoDescripcion='Nombres',
		OrdenMenuFormulario = 'S11010'
     WHERE Identidad_Id='suePersonal'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('suePersonal')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePersonal'),'Legajo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePersonal'),'Nombres')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePersonal'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePersonal'),'Posteado')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\suePuestos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'suePuestos')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('suePuestos','Puesto','Puesto_Id,Descripcion,Inactivo,Posteado','suePuestos','','','Puesto_Id','Descripcion','S11050')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Puesto', CamposSelect='Puesto_Id,Descripcion,Inactivo,Posteado', FromSelect='suePuestos', WhereSelect='', OrderByDefault='', CamposClaves='Puesto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S11050'
     WHERE Identidad_Id='suePuestos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('suePuestos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePuestos'),'Puesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePuestos'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePuestos'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('suePuestos'),'Posteado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueTablas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueTablas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueTablas','Tablas','Tabla_Id,Descripcion,FechaRegistro','sueTabTitulo','','','Tabla_Id','Descripcion','S14030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tablas', CamposSelect='Tabla_Id,Descripcion,FechaRegistro', FromSelect='sueTabTitulo', WhereSelect='', OrderByDefault='', CamposClaves='Tabla_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S14030'
     WHERE Identidad_Id='sueTablas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueTablas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablas'),'Tabla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablas'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablas'),'FechaRegistro')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueTablaVacacion.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueTablaVacacion')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueTablaVacacion','Tablas de Vacaciones','TablaVac_Id,Descripcion,Inactivo,Posteado','sueTablaVacacion','','','TablaVac_Id','Descripcion','S14070')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tablas de Vacaciones', CamposSelect='TablaVac_Id,Descripcion,Inactivo,Posteado', FromSelect='sueTablaVacacion', WhereSelect='', OrderByDefault='', CamposClaves='TablaVac_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S14070'
     WHERE Identidad_Id='sueTablaVacacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueTablaVacacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablaVacacion'),'TablaVac_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablaVacacion'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablaVacacion'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTablaVacacion'),'Posteado')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueTareas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueTareas')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('sueTareas','Tareas','Tarea_Id,Descripcion,Posteado,Inactivo','sueTareas','','','Tarea_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tareas', CamposSelect='Tarea_Id,Descripcion,Posteado,Inactivo', FromSelect='sueTareas', WhereSelect='', OrderByDefault='', CamposClaves='Tarea_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='sueTareas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueTareas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTareas'),'Tarea_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTareas'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTareas'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTareas'),'Inactivo')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueTipoPago.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueTipoPago')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueTipoPago','TipoPago','TipoPago_Id,Descripcion,Inactivo,Posteado','sueTipoPago','','','TipoPago_Id','Descripcion','S11030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='TipoPago', CamposSelect='TipoPago_Id,Descripcion,Inactivo,Posteado', FromSelect='sueTipoPago', WhereSelect='', OrderByDefault='', CamposClaves='TipoPago_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S11030'
     WHERE Identidad_Id='sueTipoPago'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueTipoPago')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTipoPago'),'TipoPago_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTipoPago'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTipoPago'),'Inactivo')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueTipoPago'),'Posteado')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\sueVarGlobales.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'sueVarGlobales')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('sueVarGlobales','Variables Globales','VarGlobal_Id,Descripcion','sueVarGlobales','','','VarGlobal_Id','Descripcion','S1401010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Variables Globales', CamposSelect='VarGlobal_Id,Descripcion', FromSelect='sueVarGlobales', WhereSelect='', OrderByDefault='', CamposClaves='VarGlobal_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = 'S1401010'
     WHERE Identidad_Id='sueVarGlobales'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('sueVarGlobales')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueVarGlobales'),'VarGlobal_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('sueVarGlobales'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\swsUsuarios.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'swsUsuarios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('swsUsuarios','Usuarios','Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario','vswsUsuarios','','','Usuario_Id','Apellido_y_Nombres')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Usuarios', CamposSelect='Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario', FromSelect='vswsUsuarios', WhereSelect='', OrderByDefault='', CamposClaves='Usuario_Id', CampoDescripcion='Apellido_y_Nombres'
     WHERE Identidad_Id='swsUsuarios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('swsUsuarios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('swsUsuarios'),'Usuario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('swsUsuarios'),'Apellido_y_Nombres')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesBancos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesBancos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesBancos','Bancos','Banco_Id,Descripcion,Inactivo,Posteado,Empresa_Id','tesBancos','','','Banco_Id','Descripcion','612020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Bancos', CamposSelect='Banco_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='tesBancos', WhereSelect='', OrderByDefault='', CamposClaves='Banco_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario  ='612020'
     WHERE Identidad_Id='tesBancos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesBancos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesBancos'),'Banco_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesBancos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesCausasRechazo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesCausasRechazo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario) 
	 Values('tesCausasRechazo','Causas de Rechazo','Causa_Id,Descripcion','tesCausasRechazo','','Causa_Id','Causa_Id','Descripcion','612040')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Causas de Rechazo', 
	 CamposSelect='Causa_Id,Descripcion', FromSelect='tesCausasRechazo', 
	 WhereSelect='', OrderByDefault='Causa_Id', CamposClaves='Causa_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario  = '612040'
     WHERE Identidad_Id='tesCausasRechazo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesCausasRechazo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCausasRechazo'),'Causa_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCausasRechazo'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\TesCfdiCobranza.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'TesCfdiCobranza')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, 
		WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,
		CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('TesCfdiCobranza','CFDI Cobranza','Cliente_Id,RazonSocial,Empresa,Anulada,Fecha','vtesCfdiCobranza',
	   '','Fecha','','',
	   'TesCfdiCobranza','TesCFDICobranzaSegmentos', 'TesCfdiCobranza')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='CFDI Cobranza', 
	 CamposSelect='Cliente_Id,RazonSocial,Empresa,Anulada,Fecha', 
	 FromSelect='vtesCfdiCobranza', 
	 WhereSelect='', OrderByDefault='Fecha', 
	 CamposClaves='', CampoDescripcion='',
	 CampoFKTablaSeg='TesCfdiCobranza', 
	 VistaSeg='TesCFDICobranzaSegmentos', 
	 CampoPKVistaSeg='TesCfdiCobranza'
     WHERE Identidad_Id='TesCfdiCobranza'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('TesCfdiCobranza')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('TesCfdiCobranza'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('TesCfdiCobranza'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('TesCfdiCobranza'),'Fecha')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesChequeras.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesChequeras')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesChequeras','Chequeras','Chequera_Id,tesChequeras.Estado_Id,TipoChequera,Desde,Hasta,Proximo,tesIdentifica.Cartera_Id,tesChequeras.Inactivo,tesChequeras.Posteado,tesChequeras.Empresa_Id','tesChequeras inner join tesIdentifica ON
tesIdentifica.tesIdentifica = tesChequeras.Cartera_Id','','Chequera_Id','Chequera_Id','TipoChequera','613020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Chequeras', CamposSelect='Chequera_Id,tesChequeras.Estado_Id,TipoChequera,Desde,Hasta,Proximo,tesIdentifica.Cartera_Id,tesChequeras.Inactivo,tesChequeras.Posteado,tesChequeras.Empresa_Id', FromSelect='tesChequeras inner join tesIdentifica ON
	tesIdentifica.tesIdentifica = tesChequeras.Cartera_Id', WhereSelect='', OrderByDefault='Chequera_Id', CamposClaves='Chequera_Id', CampoDescripcion='TipoChequera',
		OrdenMenuFormulario = '613020'
     WHERE Identidad_Id='tesChequeras'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesChequeras')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Chequera_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'TipoChequera')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Desde')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Hasta')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Proximo')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequeras'),'Cartera_Id')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesChequerasEstado.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesChequerasEstado')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesChequerasEstado','Estado en Chequeras','Estado_Id,Descripcion','tesChequerasEstado','','Estado_Id','Estado_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Estado en Chequeras', CamposSelect='Estado_Id,Descripcion', FromSelect='tesChequerasEstado', WhereSelect='', OrderByDefault='Estado_Id', CamposClaves='Estado_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='tesChequerasEstado'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesChequerasEstado')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequerasEstado'),'Estado_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesChequerasEstado'),'Descripcion')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesClearing.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesClearing')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesClearing','Clearing','Clearing,Descripcion','tesClearing','','','Clearing','Descripcion','612030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Clearing', CamposSelect='Clearing,Descripcion', FromSelect='tesClearing', WhereSelect='', OrderByDefault='', CamposClaves='Clearing', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '612030'
     WHERE Identidad_Id='tesClearing'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesClearing')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesClearing'),'Clearing')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesClearing'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesCobranzas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesCobranzas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesCobranzas','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vTesCobranzas.tesMovimientos, Cliente_Id, RazonSocial','vTesCobranzas','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vTesCobranzas.tesMovimientos, Cliente_Id, RazonSocial', 
		FromSelect='vTesCobranzas', 
		WhereSelect='', OrderByDefault='Fecha Desc, tesMovimientos Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='tesCobranzas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesCobranzas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCobranzas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCobranzas'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzas'), 'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzas'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzas'), 'Anulado')






Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesCobranzasTodas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesCobranzasTodas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesCobranzasTodas','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vTesCobranzas.tesMovimientos, Cliente_Id, RazonSocial','vTesCobranzas','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vTesCobranzas.tesMovimientos, Cliente_Id, RazonSocial', 
		FromSelect='vTesCobranzas', 
		WhereSelect='', OrderByDefault='Fecha Desc, tesMovimientos Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='tesCobranzasTodas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesCobranzasTodas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCobranzasTodas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesCobranzasTodas'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzasTodas'), 'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzasTodas'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesCobranzasTodas'), 'Anulado')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesConciliacion.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesConciliacion')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesConciliacion','Conciliacion','NumeroConc,FechaConciliacion,tesIdentifica,Empresa_Id','vtesConciliacion','','NumeroConc','NumeroConc','NumeroConc')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Conciliacion', 
	 CamposSelect='NumeroConc,FechaConciliacion,tesIdentifica,Empresa_Id', 
	 FromSelect='vtesConciliacion', 
	 WhereSelect='', 
	 OrderByDefault='NumeroConc', 
	 CamposClaves='NumeroConc', CampoDescripcion='NumeroConc'
     WHERE Identidad_Id='tesConciliacion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesConciliacion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesConciliacion'),'NumeroConc')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesConciliacion'),'FechaConciliacion')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesFlujoFondo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesFlujoFondo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesFlujoFondo','Flujo de Fondos','FechaDesde,FechaHasta,Periodo','vtesFlujoFondo','','FechaDesde Desc','','', 'tesFlujoFondo','tesFFSegmentos', 'tesFlujoFondo')
ELSE
Begin
     UPDATE lupIdentidades 
		SET Descripcion ='Flujo de Fondos', 
		CamposSelect='FechaDesde,FechaHasta,Periodo', 
		FromSelect='vtesFlujoFondo', 
		WhereSelect='', OrderByDefault='FechaDesde Desc', 
		CamposClaves='', CampoDescripcion='',
		CampoFKTablaSeg = 'tesFlujoFondo',
		 VistaSeg = 'tesFFSegmentos', 
		 CampoPKVistaSeg = 'tesFlujoFondo'
		     WHERE Identidad_Id='tesFlujoFondo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesFlujoFondo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesFlujoFondo'),'FechaDesde')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesFlujoFondo'),'FechaHasta')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesFlujoFondo'),'Periodo')




Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesGanancias.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesGanancias')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesGanancias','Tabla_Ganancias','Tabla_Id,Descripcion,Inactivo,Posteado,Empresa_Id','tesGanancias','','','Tabla_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tabla_Ganancias', CamposSelect='Tabla_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='tesGanancias', WhereSelect='', OrderByDefault='', CamposClaves='Tabla_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='tesGanancias'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesGanancias')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesGanancias'),'Tabla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesGanancias'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesIdentifica.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesIdentifica')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesIdentifica','Identificadores','Cartera_Id,tesIdentifica.Descripcion,tesTiposId.TipoCartera,tesIdentifica.Posteado,tesIdentifica.Inactivo,tesIdentifica.Empresa_Id,conCuentas.Cuenta_Id,genMonedas.Moneda_Id','tesIdentifica inner join tesTiposId ON tesTiposId.tesTiposId = TesIdentifica.TipoCartera Inner join conCuentas ON conCuentas.conCuentas = tesIdentifica.Cuenta_Id inner join genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id','','Cartera_Id','Cartera_Id','Descripcion','6140')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Identificadores', 
	 CamposSelect='Cartera_Id,tesIdentifica.Descripcion,tesTiposId.TipoCartera,tesIdentifica.Posteado,tesIdentifica.Inactivo,tesIdentifica.Empresa_Id,conCuentas.Cuenta_Id,genMonedas.Moneda_Id', 
	 FromSelect='tesIdentifica inner join tesTiposId ON tesTiposId.tesTiposId = TesIdentifica.TipoCartera Inner join conCuentas ON conCuentas.conCuentas = tesIdentifica.Cuenta_Id inner join genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id', 
	 WhereSelect='', 
	 OrderByDefault='Cartera_Id', 
	 CamposClaves='Cartera_Id'
	 , CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario = '6140'
     WHERE Identidad_Id='tesIdentifica'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesIdentifica')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentifica'),'Cartera_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentifica'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentifica'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentifica'),'Moneda_Id')


--exec Lup_EjecutarConsulta @pidentidad_Id='tesIdentifica',@pWhereSP='( IsNull(Empresa_Id, ''1'') =  ''1'')',@pWhere=NULL,@pOrderBy=NULL,@pDesde=1,@pHasta=10,@pDominio='MX',@pP1=NULL,@pP2=NULL,@pP3=NULL,@pP4=NULL,@pP5=NULL,@pP6=NULL,@pP7=NULL,@pP8=NULL,@pP9=NULL,@pP10=NULL

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesIdentificaXUsuario.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesIdentificaXUsuario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesIdentificaXUsuario','Identificadores','Cartera_Id,tesIdentifica.Descripcion,tesTiposId.TipoCartera,tesIdentifica.Posteado,tesIdentifica.Inactivo,tesIdentifica.Empresa_Id,conCuentas.Cuenta_Id,genMonedas.Moneda_Id','tesIdentifica inner join tesTiposId ON tesTiposId.tesTiposId = TesIdentifica.TipoCartera Inner join conCuentas ON conCuentas.conCuentas = tesIdentifica.Cuenta_Id inner join genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = tesIdentifica.UsuarioAmo','','Cartera_Id','Cartera_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Identificadores', 
	 CamposSelect='Cartera_Id,tesIdentifica.Descripcion,tesTiposId.TipoCartera,tesIdentifica.Posteado,tesIdentifica.Inactivo,tesIdentifica.Empresa_Id,conCuentas.Cuenta_Id,genMonedas.Moneda_Id', 
	 FromSelect='tesIdentifica inner join tesTiposId ON tesTiposId.tesTiposId = TesIdentifica.TipoCartera Inner join conCuentas ON conCuentas.conCuentas = tesIdentifica.Cuenta_Id inner join genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = tesIdentifica.UsuarioAmo', 
	 WhereSelect='', 
	 OrderByDefault='Cartera_Id', 
	 CamposClaves='Cartera_Id'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='tesIdentificaXUsuario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesIdentificaXUsuario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaXUsuario'),'Cartera_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaXUsuario'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaXUsuario'),'Cuenta_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdentificaXUsuario'),'Moneda_Id')


--exec Lup_EjecutarConsulta @pidentidad_Id='tesIdentifica',@pWhereSP='( IsNull(Empresa_Id, ''1'') =  ''1'')',@pWhere=NULL,@pOrderBy=NULL,@pDesde=1,@pHasta=10,@pDominio='MX',@pP1=NULL,@pP2=NULL,@pP3=NULL,@pP4=NULL,@pP5=NULL,@pP6=NULL,@pP7=NULL,@pP8=NULL,@pP9=NULL,@pP10=NULL

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesIdTarjetasTipo.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesIdTarjetasTipo')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesIdTarjetasTipo','Tipos_de_Tarjetas','TipoTarjeta,Descripcion,Inactivo,Posteado,Empresa_Id','tesIdTarjetasTipo','','','TipoTarjeta','Descripcion', '615020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_de_Tarjetas', CamposSelect='TipoTarjeta,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='tesIdTarjetasTipo', 
	 WhereSelect='', OrderByDefault='', CamposClaves='TipoTarjeta', CampoDescripcion='Descripcion', OrdenMenuFormulario = '615020'
     WHERE Identidad_Id='tesIdTarjetasTipo'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesIdTarjetasTipo')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdTarjetasTipo'),'TipoTarjeta')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesIdTarjetasTipo'),'Descripcion')

GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesmovimientos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesMovimientos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesMovimientos','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesMovimientos.tesMovimientos','vtesMovimientos','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesMovimientos.tesMovimientos', 
		FromSelect='vtesMovimientos', 
		WhereSelect='',
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id', 
		OrderByDefault = ' Fecha Desc, tesMovimientos Desc '
     WHERE Identidad_Id='tesMovimientos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesMovimientos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMovimientos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMovimientos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesMovimientos'), 'SubTipo_Id')


/*

*/
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesMovimientosTodasSuc.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesMovimientosTodasSuc')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesMovimientosTodasSuc','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vtesMovimientosTodasSuc.tesMovimientos','vtesMovimientosTodasSuc','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesMovimientosTodasSuc.tesMovimientos', 
		FromSelect='vtesMovimientosTodasSuc', 
		WhereSelect='', OrderByDefault='Fecha Desc, tesMovimientos Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='tesMovimientosTodasSuc'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesMovimientosTodasSuc')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMovimientosTodasSuc'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesMovimientosTodasSuc'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesMovimientosTodasSuc'), 'SubTipo_Id')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesPagosProv.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesPagosProv')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesPagosProv','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vtesPagosProv.tesMovimientos, Proveed_Id, RazonSocial','vtesPagosProv','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesPagosProv.tesMovimientos, Proveed_Id, RazonSocial', 
		FromSelect='vtesPagosProv', 
		WhereSelect='', OrderByDefault='Fecha Desc, tesMovimientos Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='tesPagosProv'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesPagosProv')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesPagosProv'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesPagosProv'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProv'), 'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProv'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProv'), 'Anulado')






Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesPagosProvTodas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesPagosProvTodas')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('tesPagosProvTodas','Movimientos de Tesoreria','Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov, vtesPagosProv.tesMovimientos, Proveed_Id, RazonSocial','vtesPagosProv','','Fecha Desc, tesMovimientos Desc','','','tesMovimientos','genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Tesoreria', 
		CamposSelect='Fecha,SubTipo_Id,Formulario_Id,Posteado,Anulado,Empresa,SucursalMov,vtesPagosProv.tesMovimientos, Proveed_Id, RazonSocial', 
		FromSelect='vtesPagosProv', 
		WhereSelect='', OrderByDefault='Fecha Desc, tesMovimientos Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='tesMovimientos',
		VistaSeg = 'genAsiSegmentos', 
		CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='tesPagosProvTodas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesPagosProvTodas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesPagosProvTodas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesPagosProvTodas'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProvTodas'), 'Proveed_Id')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProvTodas'), 'RazonSocial')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('tesPagosProvTodas'), 'Anulado')






Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesRFCBanco.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesRFCBanco')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesRFCBanco','RFC Banco','RFC,Descripcion','tesBancos','RFC <> '' ''','RFC','RFC','','612020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='RFC Banco', CamposSelect='RFC,Descripcion', FromSelect='tesBancos', WhereSelect='RFC <> '' ''', OrderByDefault='RFC', CamposClaves='RFC', CampoDescripcion='',
	 OrdenMenuFormulario = '612020'
     WHERE Identidad_Id='tesRFCBanco'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesRFCBanco')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesRFCBanco'),'RFC')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesRFCBanco'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesSolicitantes.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesSolicitantes')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesSolicitantes','Solictantes','Solicitante_Id,Nombre,Empresa_Id,Inactivo,Posteado','tesSolicitantes','','','Solicitante_Id','Nombre')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Solictantes', CamposSelect='Solicitante_Id,Nombre,Empresa_Id,Inactivo,Posteado', FromSelect='tesSolicitantes', WhereSelect='', OrderByDefault='', CamposClaves='Solicitante_Id', CampoDescripcion='Nombre'
     WHERE Identidad_Id='tesSolicitantes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesSolicitantes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitantes'),'Solicitante_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitantes'),'Nombre')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesSolicitud.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesSolicitud')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('tesSolicitud','Solicitud de Anticipos','Fecha,Solicitante_Id,Nombre,Monto,Empresa,Estado','vtesSolicitud','','Fecha desc','','','tesSolicitud', 'tesSolicitud', 'tesSolSegmentos')
	   
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Solicitud de Anticipos', 
		CamposSelect='Fecha,Solicitante_Id,Nombre, Monto,Empresa,Estado', 
			FromSelect='vtesSolicitud', 
			WhereSelect='', 
			OrderByDefault='Fecha desc'		, CamposClaves='', CampoDescripcion='',
			CampoFKTablaSeg ='tesSolicitud', 
			CampoPKVistaSeg = 'tesSolicitud', 
			VistaSeg = 'tesSolSegmentos'
     WHERE Identidad_Id='tesSolicitud'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesSolicitud')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitud'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitud'),'Solicitante_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitud'),'Nombre')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSolicitud'),'Monto')


GO


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesSubTiposMov.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesSubTiposMov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesSubTiposMov','Sub Tipos Tesoreria','SubTipo_Id,Descripcion','tesSubTiposMov','','SubTipo_Id','SubTipo_Id','Descripcion','6197')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Sub Tipos Tesoreria', CamposSelect='SubTipo_Id,Descripcion', FromSelect='tesSubTiposMov', WhereSelect='', OrderByDefault='SubTipo_Id', CamposClaves='SubTipo_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '6197'
     WHERE Identidad_Id='tesSubTiposMov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesSubTiposMov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSubTiposMov'),'SubTipo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesSubTiposMov'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesT3Promociones.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesT3Promociones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('tesT3Promociones','Promociones_de_Tarjetas','Promocion_Id,Descripcion,Inactivo,Posteado,Empresa_Id','tesT3Promociones','','','Promocion_Id','Descripcion', '615020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Promociones_de_Tarjetas', CamposSelect='Promocion_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='tesT3Promociones', 
	 WhereSelect='', OrderByDefault='', CamposClaves='Promocion_Id', CampoDescripcion='Descripcion', OrdenMenuFormulario = '615020'
     WHERE Identidad_Id='tesT3Promociones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesT3Promociones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesT3Promociones'),'Promocion_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesT3Promociones'),'Descripcion')

GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\tesTiposMov.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'tesTiposmov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('tesTiposmov','Tipos de Movimientos de Tesoreria','Tipomov,Descripcion','tesTiposmov','','Tipomov','Tipomov','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos de Movimientos de Tesoreria', CamposSelect='Tipomov,Descripcion', FromSelect='tesTiposmov', WhereSelect='', OrderByDefault='Tipomov', CamposClaves='Tipomov', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='tesTiposmov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('tesTiposmov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesTiposmov'),'Tipomov')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('tesTiposmov'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\vconMetodos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'vconMetodos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('vconMetodos','Metodos de Ajuste Contable','Metodo_Id,Descripcion,Dominio_Id','vconMetodos','','','Metodo_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Metodos de Ajuste Contable', CamposSelect='Metodo_Id,Descripcion,Dominio_Id', FromSelect='vconMetodos', WhereSelect='', OrderByDefault='', CamposClaves='Metodo_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='vconMetodos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('vconMetodos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vconMetodos'),'Metodo_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vconMetodos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venBonifTemporal.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venBonifTemporal')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg)
       Values('venBonifTemporal','Bonificaciones Termporales','venBonifTemporal.venBonifTemporal, Descripcion, Inactivo, Posteado','venBonifTemporal',
	   '','venBonifTemporal Desc','','','venBonifTemporal','venBonifTemporalSegmento', 'venBonifTemporal')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Bonificaciones Temporales', 
		CamposSelect='venBonifTemporal.venBonifTemporal, Descripcion, Inactivo, Posteado', 
		FromSelect='venBonifTemporal', 
		WhereSelect='', OrderByDefault='venBonifTemporal Desc', 
		CamposClaves='', CampoDescripcion='', 
		CampoFKTablaSeg ='venBonifTemporal',
		VistaSeg = 'venBonifTemporalSegmento', 
		CampoPKVistaSeg = 'venBonifTemporal'
     WHERE Identidad_Id='venBonifTemporal'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venBonifTemporal')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venBonifTemporal'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venBonifTemporal'),'Posteado')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('venBonifTemporal'), 'Inactivo')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venCamiones.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCamiones')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venCamiones','Camiones','Patente_Id,Descripcion,FormaEntrega_Id,EsAcoplado,CargaMaxima,Tara,Marca,Inspeccion,Inactivo,Posteado,Empresa_Id','vvenCamiones','','','Patente_Id','Descripcion','51290')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Camiones', CamposSelect='Patente_Id,Descripcion,FormaEntrega_Id,EsAcoplado,CargaMaxima,Tara,Marca,Inspeccion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='vvenCamiones', WhereSelect='', OrderByDefault='', CamposClaves='Patente_Id', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '51290'
     WHERE Identidad_Id='venCamiones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCamiones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCamiones'),'Patente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCamiones'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCamiones'),'EsAcoplado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCamiones'),'FormaEntrega_id')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venCanjeNotas.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCanjeNotas')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('venCanjeNotas', 'venCanjeNotas', 
		'Fecha, Cliente_Id, RazonSocial, venTipomov, SubTipoMov_Id, MueveStock, Formulario_Id, Anulado,Vendedor_Id', 
		'vvenCanjeNotas', '', 'Fecha Desc', '', '', 'venMovimientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras', 
	 CamposSelect='Fecha,Cliente_Id,RazonSocial,venTipomov,SubTipoMov_Id,MueveStock,Formulario_Id,Anulado,Vendedor_Id', 
	 FromSelect='vvenCanjeNotas', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'venMovimientos',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='venCanjeNotas'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCanjeNotas')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCanjeNotas'),'Anulado')
GO
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venCategCredito.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCategCredito')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venCategCredito','Categorias de Credito','CategCred_Id,Descripcion,Posteado,Inactivo,Empresa_Id','venCategCredito','','','CategCred_Id','Descripcion','51250')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Categorias de Credito', CamposSelect='CategCred_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='venCategCredito', WhereSelect='', OrderByDefault='', CamposClaves='CategCred_Id', CampoDescripcion='Descripcion',
	 OrdenMenuFormulario = '51250'
     WHERE Identidad_Id='venCategCredito'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCategCredito')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCategCredito'),'CategCred_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCategCredito'),'Descripcion')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venclieHabitual.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venclieHabitual')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venclieHabitual','Sucursales Clientes','Sucursal,NombreFantasia,Cliente_Id,CondPagoCli_Id,ListaPrecio_Id,MonedaLista,FormaEntrega_Id,Zona_Id,Vendedor_Id,Inactivo,Posteado,Empresa_Id,MetodoDePago,N_MetodoPago,C_UsoCFDI,UsaComplementoINE,Vendedor,Direccion','vClientesHabitual','','','Sucursal','NombreFantasia')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Sucursales Clientes', CamposSelect='Sucursal,NombreFantasia,Cliente_Id,CondPagoCli_Id,ListaPrecio_Id,MonedaLista,FormaEntrega_Id,Zona_Id,Vendedor_Id,Inactivo,Posteado,Empresa_Id,MetodoDePago,N_MetodoPago,C_UsoCFDI,UsaComplementoINE,Vendedor,Direccion', 
		FromSelect='vClientesHabitual', 
		WhereSelect='', OrderByDefault='', 
		CamposClaves='Sucursal', 
		CampoDescripcion='NombreFantasia'
     WHERE Identidad_Id='venclieHabitual'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venclieHabitual')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Sucursal')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'NombreFantasia')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Direccion')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Cliente_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'CondPagoCli_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'ListaPrecio_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'FormaEntrega_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Zona_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Vendedor_Id')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'C_UsoCFDI')
--INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'UsaComplementoINE')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venclieHabitual'),'Vendedor')
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venClientes.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venClientes')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venClientes','Clientes',
	   'Cliente_Id,RazonSocial,SucursalPredeter,Empresa_Id,Posteado,CUIT,idFiscal,TipoDoc,CondFisc_Id,MonedaLimCred,Inactivo,NombreFantasia,case when @pPar1 IS NOT NULL AND Cliente_Id = ''COTBASE'' THEN @pPar1 ELSE Vendedor_Id END  Vendedor_Id,TipoCredito',
	   'vvenClientes','','Cliente_Id','Cliente_Id','RazonSocial')

ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Clientes', 
	 CamposSelect='Cliente_Id,RazonSocial,SucursalPredeter,Empresa_Id,Posteado,CUIT,idFiscal,TipoDoc,CondFisc_Id,MonedaLimCred,Inactivo,NombreFantasia,case when @pPar1 IS NOT NULL AND Cliente_Id = ''COTBASE'' THEN @pPar1 ELSE Vendedor_Id END  Vendedor_Id,TipoCredito', 
	 FromSelect='vvenClientes', 
	 WhereSelect='', 
	 OrderByDefault='Cliente_Id', 
	 CamposClaves='Cliente_Id', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='venClientes'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venClientes')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'NombreFantasia')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientes'),'Vendedor_Id')
go


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venClientesPlantilla.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venClientesPlantilla')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venClientesPlantilla','Plantilla_clientes','Plantilla_Id,Descripcion,Inactivo,Posteado,Empresa_Id','venClientesPlantilla','','','Plantilla_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Plantilla_clientes', 
	 CamposSelect='Plantilla_Id,Descripcion,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='venClientesPlantilla', 
	 WhereSelect='', 
	 OrderByDefault='', 
	 CamposClaves='Plantilla_Id', 
	 CampoDescripcion='Descripcion'
     WHERE Identidad_Id='venClientesPlantilla'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venClientesPlantilla')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venClientesPlantilla'),'Plantilla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venClientesPlantilla'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venClientesVend.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venClientesVend')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venClientesVend','ClientesVend','Cliente_Id,RazonSocial,SucursalPredeter,Empresa_Id,Posteado,CUIT,idFiscal,TipoDoc,MonedaLimCred,Inactivo,NombreFantasia,Vendedor_Id,TipoCredito','vvenClientesVend','','','Cliente_Id','RazonSocial')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='ClientesVend', CamposSelect='Cliente_Id,RazonSocial,SucursalPredeter,Empresa_Id,Posteado,CUIT,idFiscal,TipoDoc,MonedaLimCred,Inactivo,NombreFantasia,Vendedor_Id,TipoCredito', FromSelect='vvenClientesVend', WhereSelect='', OrderByDefault='', CamposClaves='Cliente_Id', CampoDescripcion='RazonSocial'
     WHERE Identidad_Id='venClientesVend'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venClientesVend')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientesVend'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientesVend'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientesVend'),'CUIT')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venClientesVend'),'NombreFantasia')


Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venCobradores.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCobradores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('venCobradores','Cobradores','Cobrador_Id,Nombre,Inactivo,Posteado,Empresa_Id','venCobradores','','','Cobrador_Id','Nombre','51220')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Cobradores', CamposSelect='Cobrador_Id,Nombre,Inactivo,Posteado,Empresa_Id', FromSelect='venCobradores', WhereSelect='', OrderByDefault='', CamposClaves='Cobrador_Id', CampoDescripcion='Nombre',
		OrdenMenuFormulario = '51220'
     WHERE Identidad_Id='venCobradores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCobradores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCobradores'),'Cobrador_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCobradores'),'Nombre')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venCondFiscal.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCondFiscal')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('venCondFiscal','Condicion Fiscal de Ventas','CondFisc_Id,Descripcion,Posteado,Inactivo,Empresa_Id','venCondFiscal','','','CondFisc_Id','Descripcion','412030')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Condicion Fiscal de Ventas', CamposSelect='CondFisc_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='venCondFiscal', WhereSelect='', OrderByDefault='', CamposClaves='CondFisc_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '412030'
     WHERE Identidad_Id='venCondFiscal'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCondFiscal')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondFiscal'),'CondFisc_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondFiscal'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venCondPago.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCondPago')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venCondPago','Condiciones de Pago','CondPagoCli_Id,Descripcion,Dias,Inactivo,Posteado,Empresa_Id','venCondPago','','','CondPagoCli_Id','Descripcion','51240')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Condiciones de Pago', CamposSelect='CondPagoCli_Id,Descripcion,Dias,Inactivo,Posteado,Empresa_Id', FromSelect='venCondPago', WhereSelect='', OrderByDefault='', CamposClaves='CondPagoCli_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '51240'
     WHERE Identidad_Id='venCondPago'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCondPago')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondPago'),'CondPagoCli_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondPago'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venCondPago'),'Dias')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venCotizaciones.sql*/

IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venCotizaciones')
     INSERT INTO lupIdentidades (Identidad_id, Descripcion, CamposSelect, CampoDescripcion, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoFKTablaSeg,VistaSeg,CampoPKVistaSeg)
       Values('venCotizaciones','Cotizaciones Ventas','RazonSocial,Fecha,Moneda_Id,Cliente_Id, ImporteTotal, Empresa, Estado, vvenCotizaciones.venCotizaciones,Vendedor_Id','','vvenCotizaciones','', 'Fecha','', 'venCotizaciones','venCotizSegmento','venCotizaciones')
ELSE

Begin
     UPDATE lupIdentidades SET Descripcion ='Cotizaciones Ventas', 
	 CamposSelect='RazonSocial,Fecha,Moneda_Id,Cliente_Id, ImporteTotal, Empresa, Estado, vvenCotizaciones.venCotizaciones, Vendedor_Id', 
	 FromSelect='vvenCotizaciones', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc, venCotizaciones Desc',	
	 CamposClaves='', 
	 CampoFKTablaSeg='venCotizaciones',
	 VistaSeg='venCotizSegmento',
	 CampoPKVistaSeg='venCotizaciones'
     WHERE Identidad_Id='venCotizaciones'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venCotizaciones')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'ImporteTotal')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Estado')
INSERT INTO lupIdentidadesColVisibles( Identidad_id, Campo) Values( dbo.FuncFklupIdentidades('venCotizaciones'),'Vendedor_Id')




Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venEsquemaAuto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venEsquemaAuto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venEsquemaAuto','','EsquemaAuto_Id,Descripcion,Empresa_Id','venEsquemaAuto','','','EsquemaAuto_Id','Descripcion','52105020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='', CamposSelect='EsquemaAuto_Id,Descripcion,Empresa_Id', FromSelect='venEsquemaAuto', WhereSelect='', OrderByDefault='', CamposClaves='EsquemaAuto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '52105020'
     WHERE Identidad_Id='venEsquemaAuto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venEsquemaAuto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venEsquemaAuto'),'EsquemaAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venEsquemaAuto'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venFormaEntrega.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venFormaEntrega')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venFormaEntrega','Forma_de_Entrega','FormaEntrega_Id,RazonSocial,Posteado,Inactivo,Empresa_Id,UsaCartaPorte','venFormaEntrega','','','FormaEntrega_Id','RazonSocial','51300')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Forma_de_Entrega', CamposSelect='FormaEntrega_Id,RazonSocial,Posteado,Inactivo,Empresa_Id,UsaCartaPorte', FromSelect='venFormaEntrega', WhereSelect='', OrderByDefault='', CamposClaves='FormaEntrega_Id', CampoDescripcion='RazonSocial',
		OrdenMenuFormulario = '51300'
     WHERE Identidad_Id='venFormaEntrega'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venFormaEntrega')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venFormaEntrega'),'FormaEntrega_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venFormaEntrega'),'RazonSocial')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venImpuestos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venImpuestos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venImpuestos','Impuestos','Impuesto_Id,Descripcion,Inactivo,Posteado,Empresa_Id','venImpuestos','','','Impuesto_Id','Descripcion','412010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Impuestos', CamposSelect='Impuesto_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='venImpuestos', WhereSelect='', OrderByDefault='', CamposClaves='Impuesto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '412010'
     WHERE Identidad_Id='venImpuestos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venImpuestos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venImpuestos'),'Impuesto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venImpuestos'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venIncoterm.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venIncoterm')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venIncoterm','Incoterm','Incoterm_Id,Descripcion','venIncoterm','','','Incoterm_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Incoterm', CamposSelect='Incoterm_Id,Descripcion', FromSelect='venIncoterm', WhereSelect='', OrderByDefault='', CamposClaves='Incoterm_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='venIncoterm'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venIncoterm')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venIncoterm'),'Incoterm_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venIncoterm'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venLibros.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venLibros')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venLibros','Libros de impuestos ventas','Libro_Id,Descripcion,Empresa_Id','venLibros','','','Libro_Id','Descripcion','412020')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Libros de impuestos ventas', CamposSelect='Libro_Id,Descripcion,Empresa_Id', FromSelect='venLibros', WhereSelect='', OrderByDefault='', CamposClaves='Libro_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '412020'
     WHERE Identidad_Id='venLibros'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venLibros')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venLibros'),'Libro_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venLibros'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venListasPrecios.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venListasPrecios')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venListasPrecios','Listas de Precios','ListaPrecio_Id,Descripcion,Moneda_Id,DescripcionMoneda,Inactivo,Posteado,Empresa_Id','vvenListasPrecios','','','ListaPrecio_Id','Descripcion','516010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Listas de Precios', CamposSelect='ListaPrecio_Id,Descripcion,Moneda_Id,DescripcionMoneda,Inactivo,Posteado,Empresa_Id', FromSelect='vvenListasPrecios', WhereSelect='', OrderByDefault='', CamposClaves='ListaPrecio_Id', CampoDescripcion='Descripcion',	
		OrdenMenuFormulario = '516010'
     WHERE Identidad_Id='venListasPrecios'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venListasPrecios')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasPrecios'),'ListaPrecio_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasPrecios'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasPrecios'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasPrecios'),'DescripcionMoneda')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venListasXUsuario.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venListasXUsuario')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venListasXUsuario','Listas de Precio Por Usuario',
		'ListaPrecio_Id,Descripcion,Moneda_Id,DescripcionMoneda,Inactivo,Posteado,Empresa_Id',
		'vvenListasPrecios Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = vvenListasPrecios.UsuAutorizado',
		'','ListaPrecio_Id','ListaPrecio_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Listas de Precio Por Usuario', 
	 CamposSelect='ListaPrecio_Id,Descripcion,Moneda_Id,DescripcionMoneda,Inactivo,Posteado,Empresa_Id', 
	 FromSelect='vvenListasPrecios Inner Join (Select Grupo_Id Usuario From genGrupos Where Usuario_Id = @pPar1 Union Select @pPar1 Usuario) Usuarios On Usuarios.Usuario = vvenListasPrecios.UsuAutorizado', 
	 WhereSelect='', 
	 OrderByDefault='ListaPrecio_Id', 
	 CamposClaves='ListaPrecio_Id'
	 , CampoDescripcion='Descripcion'
     WHERE Identidad_Id='venListasXUsuario'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venListasXUsuario')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasXUsuario'),'ListaPrecio_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasXUsuario'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasXUsuario'),'Moneda_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venListasXUsuario'),'DescripcionMoneda')
GO



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venLPTabla.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venLPTabla')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud)
       Values('venLPTabla','Tabla Descuentos','Tabla_Id,Descripcion','venLPTabla','','Tabla_Id','Tabla_Id','Descripcion', '', '',0)
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tabla Descuentos', CamposSelect='Tabla_Id,Descripcion', FromSelect='venLPTabla', WhereSelect='', OrderByDefault='Tabla_Id', CamposClaves='Tabla_Id', CampoDescripcion='Descripcion', CharCasing='', Mascara='', MaximaLongitud=0
     WHERE Identidad_Id='venLPTabla'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venLPTabla')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venLPTabla'),'Tabla_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venLPTabla'),'Descripcion')
GO

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venMonedaClie.sql*/
DELETE FROM lupIdentidadesParam WHERE Identidad_Id = dbo.FuncFKlupIdentidades('venMonedaClie')
DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id = dbo.FuncFKlupIdentidades('venMonedaClie')
DELETE FROM lupIdentidades WHERE Identidad_Id = 'venMonedaClie'
--lupIdentidades
INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) VALUES('venMonedaClie', 'Moneda Cliente', 'Moneda_Id,DescripcionMoneda,Cliente_Id', 'vvenClientesCtas', '', 'Moneda_Id', 'Moneda_Id', 'DescripcionMoneda', Null, Null, Null)
--lupIdentidadesColVisibles
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('venMonedaClie'), 'DescripcionMoneda')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('venMonedaClie'), 'Moneda_Id')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venMovimientos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venMovimientos')
	INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) 
	VALUES('venMovimientos', 'Movimientos de Compras', 
		'Fecha, Cliente_Id, RazonSocial, venTipomov, SubTipoMov_Id, MueveStock, Formulario_Id, Anulado,Vendedor_Id', 
		'vvenMovimientos', '', 'Fecha Desc', '', '', 'venMovimientos', 'genAsiSegmentos', 'Asiento_Id')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Movimientos de Compras', 
	 CamposSelect='Fecha,Cliente_Id,RazonSocial,venTipomov,SubTipoMov_Id,MueveStock,Formulario_Id,Anulado,Vendedor_Id', 
	 FromSelect='vvenMovimientos', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', CampoDescripcion='', 
	 CampoFKTablaSeg = 'venMovimientos',  VistaSeg = 'genAsiSegmentos', CampoPKVistaSeg = 'Asiento_Id'
     WHERE Identidad_Id='venMovimientos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venMovimientos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'Cliente_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'Anulado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venMovimientos'),'Vendedor_Id')
GO
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venNivelesAuto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venNivelesAuto')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('venNivelesAuto','Niveles_de_Autorizacion_NP','NivelAuto_Id,Descripcion,Empresa_Id,Inactivo','venNivelesAuto','','','NivelAuto_Id','Descripcion','52105010')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Niveles_de_Autorizacion_NP', CamposSelect='NivelAuto_Id,Descripcion,Empresa_Id,Inactivo', FromSelect='venNivelesAuto', WhereSelect='', OrderByDefault='', CamposClaves='NivelAuto_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '52105010'
     WHERE Identidad_Id='venNivelesAuto'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venNivelesAuto')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venNivelesAuto'),'NivelAuto_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venNivelesAuto'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venOperadores.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venOperadores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud, OrdenMenuFormulario)
       Values('venOperadores','Operadores camiones','Operador_Id,NombreOperador,Inactivo,Posteado,Empresa_Id','venOperadores','','','Operador_Id','NombreOperador', '', '',0,'512A0')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Operadores camiones', CamposSelect='Operador_Id,NombreOperador,Inactivo,Posteado,Empresa_Id', FromSelect='venOperadores', WhereSelect='', OrderByDefault='', CamposClaves='Operador_Id', CampoDescripcion='NombreOperador', CharCasing='', Mascara='', MaximaLongitud=0, 
		OrdenMenuFormulario = '512A0'
     WHERE Identidad_Id='venOperadores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venOperadores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venOperadores'),'Operador_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venOperadores'),'NombreOperador')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venPedidos.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venPedidos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('venPedidos','Pedidos','Cliente_Id,RazonSocial,Fecha,Posteado,vvenPedidos.Empresa,AnticipoPendiente,Estado,Vendedor_Id','vvenPedidos','','Fecha Desc','','','venPedidos','venPedidos','venPediSegmentos')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Pedidos', 
	 CamposSelect='Cliente_Id,RazonSocial,Fecha,Posteado,vvenPedidos.Empresa, AnticipoPendiente,Estado,Vendedor_Id', 
	 FromSelect='vvenPedidos', 
	 WhereSelect='', 
	 OrderByDefault='Fecha Desc', 
	 CamposClaves='', 
	 CampoDescripcion='', 
	 CampoFKTablaSeg='venPedidos', 
	 CampoPKVistaSeg='venPedidos', 
	 VistaSeg = 'venPediSegmentos'
     WHERE Identidad_Id='venPedidos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venPedidos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPedidos'),'RazonSocial')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPedidos'),'Fecha')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPedidos'),'Posteado')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPedidos'),'Vendedor_Id')

Go
 
Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venPropietarioArrenda.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venPropietarioArrenda')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CharCasing, Mascara, MaximaLongitud, OrdenMenuFormulario)
       Values('venPropietarioArrenda','Propietarios Arrendatarios','PropArre_Id,Nombre','venPropietarioArrenda','','','PropArre_Id','Nombre', '', '',0,'512B0')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Propietarios Arrendatarios', CamposSelect='PropArre_Id,Nombre', FromSelect='venPropietarioArrenda', WhereSelect='', OrderByDefault='', CamposClaves='PropArre_Id', CampoDescripcion='Nombre', CharCasing='', Mascara='', MaximaLongitud=0,
	 OrdenMenuFormulario = '512B0'
     WHERE Identidad_Id='venPropietarioArrenda'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venPropietarioArrenda')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPropietarioArrenda'),'PropArre_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venPropietarioArrenda'),'Nombre')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venRegion.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venRegion')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venRegion','Region','Region_Id,Descripcion,Inactivo,Posteado,Empresa_Id','venRegion','','','Region_Id','Descripcion','51280')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Region', CamposSelect='Region_Id,Descripcion,Inactivo,Posteado,Empresa_Id', FromSelect='venRegion', WhereSelect='', OrderByDefault='', CamposClaves='Region_Id', CampoDescripcion='Descripcion', 
		OrdenMenuFormulario = '51280'
     WHERE Identidad_Id='venRegion'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venRegion')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRegion'),'Region_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRegion'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venReparto.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venRepartos')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, 
		CamposClaves, CampoDescripcion, CampoFKTablaSeg, CampoPKVistaSeg, VistaSeg)
       Values('venRepartos','Repartos de pedidos','FechaReparto,FechaEntrega,Automatico,Cerrado,Empresa','vvenReparto',
	   '','FechaReparto Desc','','','venReparto','venReparto','venRepaSegmentos')
ELSE
Begin
     UPDATE lupIdentidades SET 
	 Descripcion ='Repartos de pedidos', 
	 CamposSelect='FechaReparto,FechaEntrega,Automatico,Cerrado,Empresa', 
	 FromSelect='vvenReparto', 
	 WhereSelect='', 
	 OrderByDefault='FechaReparto Desc', 
	 CamposClaves='', 
	 CampoDescripcion='', 
	 VistaSeg = 'venRepaSegmentos',
	 CampoFKTablaSeg = 'venReparto',
	 CampoPKVistaSeg = 'venReparto'
     WHERE Identidad_Id='venRepartos'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venRepartos')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRepartos'),'FechaReparto')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRepartos'),'FechaEntrega')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRepartos'),'Automatico')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venRepartos'),'Cerrado')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venSubTipoMov.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venSubTipoMov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venSubTipoMov','SubTipos de Movimiento','SubTipoMov_Id,Descripcion,MueveStock,venTipomov,Inactivo,Posteado,Empresa_Id,CodigoFiscal','venSubTipoMov','','','SubTipoMov_Id','Descripcion','5130')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='SubTipos de Movimiento', CamposSelect='SubTipoMov_Id,Descripcion,MueveStock,venTipomov,Inactivo,Posteado,Empresa_Id,CodigoFiscal', FromSelect='venSubTipoMov', WhereSelect='', OrderByDefault='', CamposClaves='SubTipoMov_Id', CampoDescripcion='Descripcion',
		OrdenMenuFormulario = '5130'
     WHERE Identidad_Id='venSubTipoMov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venSubTipoMov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venSubTipoMov'),'SubTipoMov_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venSubTipoMov'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venSubTipoMov'),'venTipomov')



Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venTipomov.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venTipomov')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('venTipomov','Tipo de Movimiento','venTipoMov,Descripcion','venTipomov','','','venTipoMov','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipo de Movimiento', CamposSelect='venTipoMov,Descripcion', FromSelect='venTipomov', WhereSelect='', OrderByDefault='', CamposClaves='venTipoMov', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='venTipomov'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venTipomov')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venTipomov'),'venTipoMov')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venTipomov'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venTiposClie.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venTiposClie')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venTiposClie','Tipos_de_Clientes','TipoClie_Id,Descripcion,Posteado,Empresa_Id','venTiposClie','','','TipoClie_Id','Descripcion','51270')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Tipos_de_Clientes', CamposSelect='TipoClie_Id,Descripcion,Posteado,Empresa_Id', FromSelect='venTiposClie', WhereSelect='', OrderByDefault='', CamposClaves='TipoClie_Id', CampoDescripcion='Descripcion', 
	 OrdenMenuFormulario= '51270'
     WHERE Identidad_Id='venTiposClie'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venTiposClie')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venTiposClie'),'TipoClie_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venTiposClie'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venVendedores.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venVendedores')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion,OrdenMenuFormulario)
       Values('venVendedores','Vendedores','Vendedor_Id,Nombre,Posteado,Inactivo,Empresa_Id','venVendedores','','','Vendedor_Id','Nombre','51210')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Vendedores', CamposSelect='Vendedor_Id,Nombre,Posteado,Inactivo,Empresa_Id', FromSelect='venVendedores', WhereSelect='', OrderByDefault='', CamposClaves='Vendedor_Id', CampoDescripcion='Nombre',	
		OrdenMenuFormulario = '51210'
     WHERE Identidad_Id='venVendedores'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venVendedores')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venVendedores'),'Vendedor_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venVendedores'),'Nombre')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\venZona.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'venZona')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, OrdenMenuFormulario)
       Values('venZona','Zona','Zona_Id,Descripcion,Posteado,Inactivo,Empresa_Id','venZona','','','Zona_Id','Descripcion','51500')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Zona', CamposSelect='Zona_Id,Descripcion,Posteado,Inactivo,Empresa_Id', FromSelect='venZona', WhereSelect='', OrderByDefault='', CamposClaves='Zona_Id', CampoDescripcion='Descripcion',	
	 OrdenMenuFormulario = '51500'
     WHERE Identidad_Id='venZona'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('venZona')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venZona'),'Zona_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('venZona'),'Descripcion')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\vProductoMedida.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'vProductoMedida')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('vProductoMedida','Producto Unidad de Medida','Medida_Id,Descripcion,Factor,Producto_Id,Inactivo,Posteado,Empresa_Id','vProductoMedida','','','Medida_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Producto Unidad de Medida', CamposSelect='Medida_Id,Descripcion,Factor,Producto_Id,Inactivo,Posteado,Empresa_Id', FromSelect='vProductoMedida', WhereSelect='', OrderByDefault='', CamposClaves='Medida_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='vProductoMedida'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('vProductoMedida')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vProductoMedida'),'Medida_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vProductoMedida'),'Descripcion')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vProductoMedida'),'Factor')

Go 

/* C:\V3\SummaAdvanced\Scripts\Lupas\vtesFormularioCheque.sql*/
IF NOT EXISTS(SELECT 1 FROM lupIdentidades where Identidad_Id = 'vtesFormularioCheque')
     INSERT INTO lupIdentidades (Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion)
       Values('vtesFormularioCheque','Fomulario de Cheques','Formulario_Id,Descripcion','vtesFormularioCheque','','Formulario_Id','Formulario_Id','Descripcion')
ELSE
Begin
     UPDATE lupIdentidades SET Descripcion ='Fomulario de Cheques', CamposSelect='Formulario_Id,Descripcion', FromSelect='vtesFormularioCheque', WhereSelect='', OrderByDefault='Formulario_Id', CamposClaves='Formulario_Id', CampoDescripcion='Descripcion'
     WHERE Identidad_Id='vtesFormularioCheque'
     DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id=dbo.FuncFklupIdentidades('vtesFormularioCheque')
End
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vtesFormularioCheque'),'Formulario_Id')
INSERT INTO lupIdentidadesColVisibles( Identidad_Id, Campo) Values( dbo.FuncFklupIdentidades('vtesFormularioCheque'),'Descripcion')

Go 

