DROP PROCEDURE [dbo].[Borra_cuerpoForm] 
GO

CREATE PROCEDURE [dbo].[Borra_cuerpoForm] (@Fomulario_id VarChar(30))
as
IF EXISTS(SELECT 1 FROM sysobjects where name = 'disControlesIndicador' and type = 'U')
BEGIN
Delete from disControlesIndicador where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
END


IF EXISTS(SELECT 1 FROM sysobjects where name = 'disControlesGrillaPivot' and type = 'U')
BEGIN
Delete from disControlesGrillaPivot where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
END


IF EXISTS(SELECT 1 FROM sysobjects where name = 'disControlesListaAdjuntos' and type = 'U')
BEGIN
Delete from disControlesListaAdjuntos where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
END

IF EXISTS(SELECT 1 FROM sysobjects where name = 'disControlesGrafico' and type = 'U')
BEGIN
Delete from disControlesGraficoTorta where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
Delete from disControlesGrafico where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
END


IF EXISTS(SELECT 1 FROM sysobjects where name = 'discontroleslink' and type = 'U')
BEGIN
Delete from discontroleslink where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
Delete from disControlesBoton where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
END

Delete From disFormulariosComentarios where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
Delete From disAccionesTablasaEnviar where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
Delete From disAccionesTablasaActualizar where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disControlesReferencia where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disRelacionesTablas where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disControlesParametros where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesUpLoad where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from discontrolesSegmento where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from discontrolesCheckBox where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesTexto where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesNumerico where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE from disControlesLupaCodigos where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesLupa where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesUpLoad where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesSegmento where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesFecha  where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesComboItems where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesCombo where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE FROM disControlesGrillaColComboItems where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE FROM disControlesGrillaColCombo where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE FROM disControlesGrillaColBoton where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE FROM disControlesGrillaColFecha where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE FROM disControlesGrillaColTexto where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE FROM disControlesGrillaColNumerico where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disControlesGrillaColumnas  where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disControlesGrilla where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disAcciones where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disEventos where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE FROM disEventosColumnas where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
--DELETE FROM disAccionesColumnas where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesFilaSolapa where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesColumnaSolapa where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesSolapa where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from disControlesGrupoSolapa where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disControlesRefSolapa where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disControlesBotonLupa where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disControlesBotonSegmento where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE from discontroles where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id) and (disControles.Control_Id <> @Fomulario_id)
DELETE FROM disTablasColumnas where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
DELETE FROM disTablas where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
delete from disFormulariosComentarios where formulario_id = dbo.FuncFKdisFormularios(@Fomulario_id)
GO

