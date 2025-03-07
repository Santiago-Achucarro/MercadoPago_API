ALTER TABLE proRecetas ADD [Tiempo] [numeric](15, 4) NOT NULL DEFAULT(0)
GO
ALTER TABLE proRecetas ADD [UnidadTiempo] [char](2) NOT NULL DEFAULT('')
GO

ALTER TABLE proRecetas ADD [Setup] [numeric](15, 4) NOT NULL DEFAULT(0)
GO
ALTER TABLE proRecetas ADD [SetupUT] [char](2) NOT NULL DEFAULT('')
GO

INSERT INTO genGlobales(Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,nValor,cValor,fValor,mValor,SubSistema,
SoloLectura,lupIdentidad,WhereF10)
select genEmpresas.genEmpresas, 'PathAdjuntosRecetas','Ruta de adjuntos Recetas','C',120,0,null,'',NULL,NULL, 'PRO',0,NULL, NULL
FROM genEmpresas
GO

Insert Into genVersion (Version) Values (1114.14)
Go


