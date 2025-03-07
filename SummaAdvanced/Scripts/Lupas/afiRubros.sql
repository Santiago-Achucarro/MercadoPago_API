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