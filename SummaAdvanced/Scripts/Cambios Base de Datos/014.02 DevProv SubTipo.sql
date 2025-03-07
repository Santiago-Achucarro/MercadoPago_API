IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 14.02)
begin

	INSERT INTO genVersion(Version) Values(14.02);


insert into stkSubTipoMov
values
('DP','S','Devoluciones_a_Proveedores',0,1,null)

update stkSubTipoMov set Reporte_Id= dbo.FuncFKgenReportes('STKMOVICABECD') where SubTipoMov_Id='CDE' OR SubTipoMov_Id='CDS'
update stkSubTipoMov set Reporte_Id= dbo.FuncFKgenReportes('STKMOVICAUSA') where SubTipoMov_Id='EOMV'
update stkSubTipoMov set Reporte_Id= dbo.FuncFKgenReportes('STKDEVPROV') where SubTipoMov_Id='NP' OR SubTipoMov_Id='DP'
update stkSubTipoMov set Reporte_Id= dbo.FuncFKgenReportes('STKENTREMB') where SubTipoMov_Id='OE'
update stkSubTipoMov set Reporte_Id= dbo.FuncFKgenReportes('STKREMICLIE') where SubTipoMov_Id='REM'
update stkSubTipoMov set Reporte_Id= dbo.FuncFKgenReportes('STKREMIPROV') where SubTipoMov_Id='RPR'
update stkSubTipoMov set Reporte_Id= dbo.FuncFKgenReportes('STKMOVICAUSA') where SubTipoMov_Id='SOMV'


end