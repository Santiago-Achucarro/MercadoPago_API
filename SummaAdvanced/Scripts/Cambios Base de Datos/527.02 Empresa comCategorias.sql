Alter Table comCategorias add Empresa_Id int null
go

Alter Table comCategorias  add constraint VR_4422 
	foreign key (Empresa_Id) references genEmpresas(genEmpresas)

GO

exec genSegmentosGuardar  'REQIN', 'REQIN', 'Requerimiento Interno' , 8,0,0,0, 1, 4,0,0,0,1,0,0,0,11,0,0,0,
	2,0,0,0,1,0,0,0,1, '1N',0,1,1
GO

insert into genVersion(Version) values (527.02)
go