Delete from GENMENUS where orden like '42%' and pais='AR'
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id,Pais, Orientacion,Especial) Values('4400',2 ,'Generacion_de_Archivos', 'S',NULL,'AR','D', 0)
go

INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4420',3 ,'Arba', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpArbaTxt'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4430',3 ,'CABA', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpCABATxt'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('443010',3 ,'Padrones', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpPadronTxt'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4440',3 ,'Exportacion_Sifere', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpSifere'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4450',3 ,'Exportacion_Citi_compras_ventas', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpCiti'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445010',3 ,'Exportacion_Sicore', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpSicore'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445020',3 ,'Exportacion_Arciba', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpArciba'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445030',3 ,'Modificacion_Alicuota_Arba', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpArbaTxtModif'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445040',3 ,'Ret_Perc_Iva', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpRetPercIva'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('445050',3 ,'eSicol', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpeSicol'),'D', 0)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4450202',3 ,'Exportacion_Retenciones_Bs_As', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpRetPba'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Pais, Formulario_id, Orientacion,Especial) Values('4450201',3 ,'Exportacion_Percepciones_Bs_As', 'C', 'AR', dbo.FuncFKdisFormularios('frmimpPercPba'),'D', 1)

go

insert into genVersion(Version) values(1090.25)