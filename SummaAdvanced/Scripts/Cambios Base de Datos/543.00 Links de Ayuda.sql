
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATCLIE','MX', 'CATALOGO DE CLIENTES', 'http://adv.quasarglobal.com/adv/CatClientes/GuiaMigraExcelClientes.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATCLIE',' ', 'CATALOGO DE CLIENTES', 'http://adv.quasarglobal.com/adv/CatClientesAr/GuiaMigraExcelClientesAR.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATPROD',' ', 'CATALOGO DE PRODUCTOS', 'http://adv.quasarglobal.com/adv/CatProductos/GuiaCatExcelProductos.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATPROVE','MX', 'CATALOGO DE PROVEEDORES', 'http://adv.quasarglobal.com/adv/CatProvee/GuiaMigraExcelProvee.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATPROVE',' ', 'CATALOGO DE PROVEEDORES', 'http://adv.quasarglobal.com/adv/CatProveeAR/GuiaMigraExcelProveeAR.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('INVENTARIO',' ', 'INVENTARIO FISICO', 'http://adv.quasarglobal.com/adv/Inventario/GuiaCargaExcelInventario.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('LISTASPRE',' ', 'LISTAS DE PRECIOS', 'http://adv.quasarglobal.com/adv/ListasPrec/GuiaCargaExcelListasPrec.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('SINICLIE','MX', 'SALDO INICIAL CLIENTES', 'http://adv.quasarglobal.com/adv/SaldoIniClie/GuiaMigraSaldoIniClie.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('SINICLIE',' ', 'SALDO INICIAL CLIENTES', 'http://adv.quasarglobal.com/adv/SaldoIniClieAR/GuiaMigraSaldoIniClieAR.html')
GO

Insert into tesSubTiposMov (SubTipo_Id, Descripcion,TipoMov, CantCopias) VALUES('PAI','Pago de Impuestos','E',1)
GO

INSERT INTO genVersion (Version) Values(543.00)
GO

insert into tesIdentifica(Cartera_Id, Empresa_Id, TipoCartera, Descripcion, Centro1_Id, Centro2_Id, ModiCent1, ModiCent2,
	 Reservado, VaAlCashFlow, Inactivo, Usuario_Id, Posteado)
	VALUES('IMP',NULL, 9, 'Impuestos', 1,1,0,0,0,0,0,1,1)

GO
