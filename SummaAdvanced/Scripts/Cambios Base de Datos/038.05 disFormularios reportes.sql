IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 38.05)
begin

ALTER TABLE disFormularios ADD BotonRptVer Sino null
ALTER TABLE disFormularios ADD BotonRptImprimir Sino null
ALTER TABLE disFormularios ADD BotonRptPdf Sino null
ALTER TABLE disFormularios ADD BotonRptXls Sino null

end
go

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 38.05)
begin
update disFormularios
set BotonRptVer = case when (disControles.TipoControl = 'frm') then 0 else 1 end,
	BotonRptImprimir = case when (disControles.TipoControl = 'frm') then 0 else 1 end,
	BotonRptPdf = case when (disControles.TipoControl = 'frm') then 0 else 1 end,
	BotonRptXls = case when (disControles.TipoControl = 'frm') then 0 else 1 end,
	BotonNuevo = case when (disControles.TipoControl = 'frm') then BotonNuevo else 0 end,
	BotonGuardar = case when (disControles.TipoControl = 'frm') then BotonGuardar else 0 end,
	BotonPostear = case when (disControles.TipoControl = 'frm') then BotonPostear else 0 end,
	BotonEliminar = case when (disControles.TipoControl = 'frm') then BotonEliminar else 0 end,
	BotonImprimir = case when (disControles.TipoControl = 'frm') then BotonImprimir else 0 end
From discontroles
where discontroles.Formulario_Id = disFormularios.disFormularios
and ((disControles.TipoControl = 'frm') or (disControles.TipoControl = 'rpt'))

end

IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 38.05)
begin

ALTER TABLE disFormularios alter COLUMN BotonRptVer Sino not null
ALTER TABLE disFormularios alter COLUMN BotonRptImprimir Sino not null
ALTER TABLE disFormularios alter COLUMN BotonRptPdf Sino not null
ALTER TABLE disFormularios alter COLUMN BotonRptXls Sino not null

INSERT INTO genVersion(Version) Values(38.05);

end
go
