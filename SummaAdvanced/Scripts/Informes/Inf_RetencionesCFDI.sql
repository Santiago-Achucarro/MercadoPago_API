drop procedure Inf_ImpRetenciones
go
create procedure Inf_ImpRetenciones (@pFolio int, 
@pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)
SELECT impRetencionesCFDI.impRetencionesCFDI,
	impRetencionesCFDI.Folio, impRetencionesCFDI.Sello, impRetencionesCFDI.NumCert, impRetencionesCFDI.FechaExp,
	impRetencionesCFDI.CveRetenc, impRetencionesCFDI.DescRetenc, impRetencionesCFDI.Nacionalidad, impRetencionesCFDI.RFC,
	impRetencionesCFDI.RazonSocial, impRetencionesCFDI.CURP, impRetencionesCFDI.NroRegIdTrib, impRetencionesCFDI.Ejercicio,
	impRetencionesCFDI.MesIni, impRetencionesCFDI.MesFin, impRetencionesCFDI.montoTotOperacion, impRetencionesCFDI.montoTotGrav,
	impRetencionesCFDI.montoTotExent, impRetencionesCFDI.montoTotRet, impRetencionesCFDI.Cancelado, impRetencionesCFDI.FechaCancelacion,
	impRetencionesCFDI.FechaTimbre, impRetencionesCFDI.SelloSAT, impRetencionesCFDI.NoCertificadoSAT, impRetencionesCFDI.UUID,
	impRetencionesCFDI.RfcProvCertif, impRetencionesCFDI.Leyenda, impRetencionesCFDI.Xml
FROM impRetencionesCFDI 
WHERE (Folio = @pFolio)

go

drop procedure Inf_impRetCFDIDetalleDatos
go
create procedure Inf_impRetCFDIDetalleDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIDetalleDatos   @pidentity

go

drop procedure Inf_impRetCFDIArrendaDatos

go

create procedure Inf_impRetCFDIArrendaDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIArrendaDatos  @pidentity

go

drop procedure Inf_impRetCFDIDividendosDatos

go

create procedure Inf_impRetCFDIDividendosDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIDividendosDatos   @pidentity

go

drop procedure Inf_impRetCFDIEnajAccionDatos

go

create procedure Inf_impRetCFDIEnajAccionDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIEnajAccionDatos   @pidentity

go

drop procedure Inf_impRetCFDIFiedeEmprDatos

go

create procedure Inf_impRetCFDIFiedeEmprDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIFiedeEmprDatos   @pidentity

go

drop procedure Inf_impRetCFDIOperConDerivDatos

go

create procedure Inf_impRetCFDIOperConDerivDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIOperConDerivDatos   @pidentity

go

drop procedure Inf_impRetCFDIPagosExtrDatos

go

create procedure Inf_impRetCFDIPagosExtrDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIPagosExtrDatos   @pidentity

go

drop procedure Inf_impRetCFDIPlanesRetDatos

go

create procedure Inf_impRetCFDIPlanesRetDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIPlanesRetDatos   @pidentity

go

drop procedure Inf_impRetCFDIPremiosDatos

go

create procedure Inf_impRetCFDIPremiosDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDIPremiosDatos   @pidentity

go

drop procedure Inf_impRetCFDISecFinanDatos

go

create procedure Inf_impRetCFDISecFinanDatos (@pFolio int, @pEmpresa_Id Int)
as
SET NOCOUNT ON 
DECLARE @pidentity INT = isnull((select impRetencionesCFDI 
 from impRetencionesCFDI 
 Where
	Empresa_id = @pEmpresa_id and 
	Folio = @pFolio),0)

Exec impRetCFDISecFinanDatos   @pidentity

go