Insert Into  genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, nValor, cValor, fValor, mValor, SubSistema, SoloLectura, lupIdentidad, WhereF10)
Select genEmpresas, 'PathAdjuntosMovProv', 'Ruta de adjuntos Facturas de compras', 'C', 120, 0, null, null, null, null, 'COM', 0, null, null
From genEmpresas
GO

Insert Into genVersion (Version) Values(1066.10)
GO
