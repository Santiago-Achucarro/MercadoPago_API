-- AJ JUN 2016 AdicionalesParametros
-- AJ SET 2018 Especializacion


DROP PROCEDURE disFormulariosGuardar
GO
CREATE PROCEDURE disFormulariosGuardar
(
@pFormulario_Id varchar(30),
@pFormulario_Id_Nuevo varchar(30),
@pDescripcion varchar(80),
@pAlto int,
@pAncho int,
@pArriba smallint,
@pIzquierda smallint,
@pTitulo varchar(80),
@pPosicionInicial char(1),
@pBotonNuevo Sino,
@pBotonGuardar Sino,
@pBotonPostear Sino,
@pBotonEliminar Sino,
@pBotonImprimir Sino,
@pGuardaeImprime Sino,
@pTabla_Id varchar(60),
@pDllCommon varchar(80),
@pClaseCommon varchar(80), 
@pDllExchange varchar(80), 
@pClaseExchange varchar(80), 
@pClaseEnum varchar(80), 
@pDllEventos varchar(80),
@pClaseEventos varchar(80), 
@pFormularioPadre_Id varchar(30) = NULL,
@pPosteado Sino,
@pInactivo Sino,
@pUsuario_Id int,
@pTipoFormulario varchar(3),
@pBotonRptVer Sino,
@pBotonRptImprimir Sino,
@pBotonRptPdf Sino,
@pBotonRptXls Sino, 
@pEspecializacion VarChar(80) = NULL,
@pDllCommonEsp varchar(80) = NULL,
@pClaseCommonEsp varchar(80) = NULL, 
@pDllExchangeEsp varchar(80) = NULL, 
@pClaseExchangeEsp varchar(80) = NULL, 
@pClaseEnumEsp varchar(80) = NULL, 
@pDllEventosEsp varchar(80) = NULL,
@pClaseEventosEsp varchar(80) = NULL,
@pVersion varchar(10) = NULL,
@pTipoEspecial char(1) = NULL,
@pBotonCopiar SiNo,
@pCodigoLnk varchar(25) = NULL,
@pAnulaAccionesEliminarDefault Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM disFormularios WHERE (Formulario_Id = @pFormulario_Id)))
BEGIN 
	UPDATE disFormularios
	SET		@lIdentidad = disFormularios,
		Formulario_Id = @pFormulario_Id_Nuevo,
		Descripcion = @pDescripcion,
		Alto = @pAlto,
		Ancho = @pAncho,
		Arriba = @pArriba,
		Izquierda = @pIzquierda,
		Titulo = @pTitulo,
		PosicionInicial = @pPosicionInicial,
		BotonNuevo = @pBotonNuevo,
		BotonGuardar = @pBotonGuardar,
		BotonPostear = @pBotonPostear,
		BotonEliminar = @pBotonEliminar,
		BotonImprimir = @pBotonImprimir,
		GuardaeImprime = @pGuardaeImprime,
		Tabla_Id = @pTabla_Id,
		DllCommon = @pDllCommon,
		ClaseCommon = @pClaseCommon,
		DllExchange = @pDllExchange,
		ClaseExchange = @pClaseExchange,
		ClaseEnum = @pClaseEnum,
		DllEventos = @pDllEventos,
		ClaseEventos = @pClaseEventos,
		DllCommonEsp = @pDllCommonEsp,
		ClaseCommonEsp = @pClaseCommonEsp,
		DllExchangeEsp = @pDllExchangeEsp,
		ClaseExchangeEsp = @pClaseExchangeEsp,
		ClaseEnumEsp = @pClaseEnumEsp,
		DllEventosEsp = @pDllEventosEsp,
		ClaseEventosEsp = @pClaseEventosEsp,
		FormularioPadre_Id = dbo.FuncFKdisFormularios(@pFormularioPadre_Id),
		Posteado = @pPosteado,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		UltimaModif = dbo.FechaActual(),
		BotonRptVer = @pBotonRptVer,
		BotonRptImprimir = @pBotonRptImprimir,
		BotonRptPdf = @pBotonRptPdf,
		BotonRptXls = @pBotonRptXls, 
		Especializacion = @pEspecializacion,
		Version = @pVersion,
		TipoEspecial = @pTipoEspecial,
		BotonCopiar = @pBotonCopiar,
		CodigoLnk = @pCodigoLnk,
		AnulaAccionesEliminarDefault = @pAnulaAccionesEliminarDefault
	WHERE (Formulario_Id = @pFormulario_Id)

	UPDATE disControles
	SET Control_Id = @pFormulario_Id_nuevo, 
		TipoControl = @pTipoFormulario,
		Alto = @pAlto, 
		Ancho = @pAncho, 
		Arriba = @pArriba, 
		Izquierda = @pIzquierda, 
		Texto = @pTitulo, 
		Heredado = case when (@pFormularioPadre_Id IS NULL) then 0 else 1 end 
	WHERE Formulario_Id = @lIdentidad
	AND Control_Id = @pFormulario_Id 
END 
ELSE 
BEGIN 
	INSERT INTO disFormularios
	(
		Formulario_Id,
		Descripcion,
		Alto,
		Ancho,
		Arriba,
		Izquierda,
		Titulo,
		PosicionInicial,
		BotonNuevo,
		BotonGuardar,
		BotonPostear,
		BotonEliminar,
		BotonImprimir,
		GuardaeImprime,
		Tabla_Id,
		DllCommon,
		ClaseCommon,
		DllExchange,
		ClaseExchange,
		ClaseEnum,
		DllEventos,
		ClaseEventos,
		DllCommonEsp,
		ClaseCommonEsp,
		DllExchangeEsp,
		ClaseExchangeEsp,
		ClaseEnumEsp,
		DllEventosEsp,
		ClaseEventosEsp,
		FormularioPadre_Id,
		Posteado,
		Inactivo,
		Usuario_Id,
		UltimaModif,
		BotonRptVer,
		BotonRptImprimir,
		BotonRptPdf,
		BotonRptXls,
		Especializacion,
		Version,
		TipoEspecial,
		BotonCopiar,
		CodigoLnk,
		AnulaAccionesEliminarDefault
	)
	VALUES 
	(
		@pFormulario_Id,
		@pDescripcion,
		@pAlto,
		@pAncho,
		@pArriba,
		@pIzquierda,
		@pTitulo,
		@pPosicionInicial,
		@pBotonNuevo,
		@pBotonGuardar,
		@pBotonPostear,
		@pBotonEliminar,
		@pBotonImprimir,
		@pGuardaeImprime,
		@pTabla_Id,
		@pDllCommon,
		@pClaseCommon, 
		@pDllExchange, 
		@pClaseExchange, 
		@pClaseEnum, 
		@pDllEventos,
		@pClaseEventos, 
		@pDllCommonEsp,
		@pClaseCommonEsp, 
		@pDllExchangeEsp, 
		@pClaseExchangeEsp, 
		@pClaseEnumEsp, 
		@pDllEventosEsp,
		@pClaseEventosEsp, 
		dbo.FuncFKdisFormularios(@pFormularioPadre_Id),
		@pPosteado,
		@pInactivo,
		@pUsuario_Id,
		dbo.FechaActual(),
		@pBotonRptVer,
		@pBotonRptImprimir,
		@pBotonRptPdf,
		@pBotonRptXls, 
		@pEspecializacion,
		@pVersion,
		@pTipoEspecial,
		@pBotonCopiar,
		@pCodigoLnk,
		@pAnulaAccionesEliminarDefault
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
	-- Inserto un control para el formulario, para poder manejar los eventos del formulario
	INSERT INTO disControles(Formulario_Id, Control_Id, NroControl, ControlParent_Id, TipoControl,
						Alto, Ancho, Arriba, Izquierda, Fila, Columna, FilasExtension, ColumnasExtension,
						Texto, Visible, Habilitado, Alineacion, TabStop, TabOrden, Requerido, Embebido,
						Ancla, EsCodigoNuevo, Paises, MaximaLongitud, ClickNuevoBlanquea, ControlaCambios,
						SoloLectura, TextoFijo, TextoControlVacio, Estilo, TituloLabel, AlineacionLabel, IgualaAnchoColumna, 
						Heredado)
     VALUES (@lIdentidad,  @pFormulario_Id_nuevo, 0, NULL, @pTipoFormulario, 
			 @pAlto, @pAncho, @pArriba, @pIzquierda, 0, 0, 0, 0,
			 @pTitulo, 1, 1, ' ', 1, 0, 0, 0,
			 'T,L', 0, NULL, 0, 1, 1, 
			 0, 0, NULL, NULL, NULL, NULL, 0, case when (@pFormularioPadre_Id IS NULL) then 0 else 1 end   )
END 
Select @lIdentidad as RetVal 

GO


DROP PROCEDURE disFormulariosDatos
GO
CREATE PROCEDURE [dbo].[disFormulariosDatos]
(
@pFormulario_Id varchar(30),
@pParaWeb bit
)
AS

DECLARE @liFormulario int
DECLARE @lSegmento_Id int
DECLARE @lLongTotalSegmento int
DECLARE @ListaDeFormularios Table (Id int, SolapaInvocante varchar(200))
DECLARE @ListaDeFormInscrustados Table (Id int, ControlReferencia varchar(200), Parametros varchar(512), Formulario_Id varchar(30))
DECLARE @CantSolapasOrig int
DECLARE @lTabla_Id varchar(60)
DECLARE @lEspecializacion varchar(80)

SET NOCOUNT ON   


SET @liFormulario = dbo.FuncFKdisFormularios(@pFormulario_Id)
-- Primero obtengo la lista de formularios popup que sean referenciados desde alguna de las solapas
INSERT INTO @ListaDeFormularios (Id, SolapaInvocante)
SELECT FormularioPopup_Id, Control_Id
FROM disControlesSolapa 
WHERE disControlesSolapa.Formulario_Id = @liFormulario
AND FormularioPopup_Id IS NOT NULL
AND (@pParaWeb = 1) --Solo se necesita retornar los componentes del invocado, cuando es para web

-- obtengo la lista de formularios incrusatdos que sean referenciados desde algun control referencia
INSERT INTO @ListaDeFormInscrustados (Id, ControlReferencia, Parametros, Formulario_Id)
SELECT FormularioPopup_Id, Control_Id, Parametros, disFormularios.Formulario_Id
FROM disControlesReferencia 
inner join disFormularios on disFormularios.disFormularios = FormularioPopup_Id
WHERE disControlesReferencia.Formulario_Id = @liFormulario
AND FormularioPopup_Id IS NOT NULL
AND (@pParaWeb = 1) --Solo se necesita retornar los componentes del invocado, cuando es para web

--SELECT @lTabla_Id = Tabla_Id FROM disFormularios WHERE (disFormularios.disFormularios = @liFormulario))
SELECT @lTabla_Id = Tabla_Id, @lEspecializacion= Especializacion FROM disFormularios WHERE (disFormularios.disFormularios = @liFormulario)

SELECT disFormularios.disFormularios, disFormularios.Formulario_Id, disFormularios.Descripcion, disFormularios.Alto,
	disFormularios.Ancho, disFormularios.Arriba, disFormularios.Izquierda, disFormularios.Titulo, disFormularios.PosicionInicial,
	disFormularios.BotonNuevo, disFormularios.BotonGuardar, disFormularios.BotonPostear,
	disFormularios.BotonEliminar, disFormularios.BotonImprimir, disFormularios.GuardaeImprime,
	disFormularios.Tabla_Id, disFormularios.DllCommon, disFormularios.ClaseCommon,
	disFormularios.DllExchange, disFormularios.ClaseExchange, disFormularios.ClaseEnum,
	disFormularios.DllEventos, disFormularios.ClaseEventos, CAST(ISNULL(@pParaWeb,0) AS BIT) as ParaWeb,
	disFormularios.Posteado, disFormularios.Inactivo, disFormularios.Usuario_Id,
	FormPadre.Formulario_Id as FormularioPadre_Id, ISNULL(disControles.TipoControl, 'frm') as TipoFormulario,
	disFormularios.BotonRptVer, disFormularios.BotonRptImprimir, disFormularios.BotonRptPdf, disFormularios.BotonRptXls, 
	disFormularios.Especializacion, disFormularios.DllCommonEsp, disFormularios.ClaseCommonEsp,
	disFormularios.DllExchangeEsp, disFormularios.ClaseExchangeEsp, disFormularios.ClaseEnumEsp,
	disFormularios.DllEventosEsp, disFormularios.ClaseEventosEsp, disFormularios.Version, Cast(0 as Bit) as Temporal,
	disFormularios.TipoEspecial, disFormularios.BotonCopiar, disFormularios.CodigoLnk, disFormularios.AnulaAccionesEliminarDefault
FROM disFormularios 
LEFT JOIN disFormularios FormPadre ON FormPadre.disFormularios = disFormularios.FormularioPadre_Id
LEFT JOIN disControles ON disControles.Formulario_Id = disFormularios.disFormularios AND disControles.Control_Id = disFormularios.Formulario_Id
WHERE (disFormularios.disFormularios = @liFormulario)

-- Grupos Solapas
SELECT disControlesGrupoSolapa.Control_Id, disControlesGrupoSolapa.CantSolapas
FROM disControlesGrupoSolapa 
WHERE (Formulario_Id = @liFormulario)

SET @CantSolapasOrig = (SELECT count(*) FROM disControlesSolapa WHERE (disControlesSolapa.Formulario_Id = @liFormulario))

-- Solapas
SELECT disControlesSolapa.Control_Id, disControlesSolapa.Posicion,	disControlesSolapa.CantFilas, disControlesSolapa.CantColumnas,
disControlesSolapa.TipoPopup, disFormularios.Formulario_Id as FormularioPopup_Id, disControlesSolapa.TieneBtnCerrar, disControlesSolapa.TieneBtnGuardar,
disControlesSolapa.TablaPrimaria, 
disControlesSolapa.Parametros, disControlesSolapa.TamanioPopup, cast(null as varchar(200)) as ControlReferencia
FROM disControlesSolapa 
LEFT JOIN disFormularios ON disFormularios.disFormularios = disControlesSolapa.FormularioPopup_Id
WHERE (disControlesSolapa.Formulario_Id = @liFormulario)
UNION
SELECT disControlesSolapa.Control_Id + '_' + lstfrm.ControlReferencia, 
cast (ROW_NUMBER() OVER(ORDER BY disControlesSolapa.Formulario_Id, disControlesSolapa.Posicion) + @CantSolapasOrig - 1 as int) as Posicion,	
disControlesSolapa.CantFilas, disControlesSolapa.CantColumnas,
disControlesSolapa.TipoPopup, disFormularios.Formulario_Id as FormularioPopup_Id, disControlesSolapa.TieneBtnCerrar, disControlesSolapa.TieneBtnGuardar,
disControlesSolapa.TablaPrimaria, 
CASE WHEN disControlesSolapa.Posicion = 0 THEN disControlesSolapa.Parametros ELSE isnull(disControlesSolapa.Parametros, '') + isnull(lstfrm.Parametros, '') END,
disControlesSolapa.TamanioPopup, CASE WHEN disControlesSolapa.Posicion = 0 THEN lstfrm.ControlReferencia ELSE null END
FROM disControlesSolapa 
INNER JOIN @ListaDeFormInscrustados as lstfrm ON lstfrm.Id = disControlesSolapa.Formulario_Id
LEFT JOIN disFormularios ON disFormularios.disFormularios = disControlesSolapa.Formulario_Id
ORDER BY disControlesSolapa.Posicion



-- Columnas Solapas
SELECT disControlesColumnaSolapa.Control_Id, disControlesColumnaSolapa.Columna,	disControlesColumnaSolapa.Ancho, 
	disControlesColumnaSolapa.TipoValor
FROM disControlesColumnaSolapa 
INNER JOIN disControlesSolapa ON disControlesSolapa.Formulario_Id = disControlesColumnaSolapa.Formulario_Id 
							AND disControlesSolapa.Control_Id = disControlesColumnaSolapa.Control_Id
WHERE (disControlesColumnaSolapa.Formulario_Id = @liFormulario)
AND ((disControlesSolapa.FormularioPopup_Id IS NULL) OR (@pParaWeb = 0))
UNION --Busco las columnas de las solapas del popup referenciado
SELECT lstfrm.SolapaInvocante, disControlesColumnaSolapa.Columna,	disControlesColumnaSolapa.Ancho, 
	disControlesColumnaSolapa.TipoValor
FROM disControlesColumnaSolapa 
INNER JOIN @ListaDeFormularios as lstfrm ON lstfrm.Id = disControlesColumnaSolapa.Formulario_Id
UNION --Busco las columnas de las solapas del form referenciado en un control
SELECT disControlesColumnaSolapa.Control_Id + '_' + lstfrm.ControlReferencia, disControlesColumnaSolapa.Columna,	disControlesColumnaSolapa.Ancho, 
	disControlesColumnaSolapa.TipoValor
FROM disControlesColumnaSolapa 
INNER JOIN @ListaDeFormInscrustados as lstfrm ON lstfrm.Id = disControlesColumnaSolapa.Formulario_Id
ORDER BY 1,2



-- Filas Solapas
SELECT disControlesFilaSolapa.Control_Id, disControlesFilaSolapa.Fila, disControlesFilaSolapa.Alto, 
disControlesFilaSolapa.TipoValor
FROM disControlesFilaSolapa 
INNER JOIN disControlesSolapa ON disControlesSolapa.Formulario_Id = disControlesFilaSolapa.Formulario_Id 
							AND disControlesSolapa.Control_Id = disControlesFilaSolapa.Control_Id
WHERE (disControlesFilaSolapa.Formulario_Id = @liFormulario)
AND ((disControlesSolapa.FormularioPopup_Id IS NULL) OR (@pParaWeb = 0))
UNION
SELECT lstfrm.SolapaInvocante, disControlesFilaSolapa.Fila, disControlesFilaSolapa.Alto, 
disControlesFilaSolapa.TipoValor
FROM disControlesFilaSolapa 
INNER JOIN @ListaDeFormularios as lstfrm ON lstfrm.Id = disControlesFilaSolapa.Formulario_Id
UNION --Busco las columnas de las solapas del form referenciado en un control
SELECT disControlesFilaSolapa.Control_Id + '_' + lstfrm.ControlReferencia, disControlesFilaSolapa.Fila,	disControlesFilaSolapa.Alto, 
	disControlesFilaSolapa.TipoValor
FROM disControlesFilaSolapa 
INNER JOIN @ListaDeFormInscrustados as lstfrm ON lstfrm.Id = disControlesFilaSolapa.Formulario_Id
ORDER BY 1,2

-- Celdas
/**
SELECT disControlesCelda.Control_Id, disControlesCelda.NombrePanel,	disControlesCelda.Fila, 
	disControlesCelda.Columna, disControlesCelda.FilasExtension, disControlesCelda.ColumnasExtension, disControles.ControlParent_Id
FROM disControlesCelda 
INNER JOIN disControles ON disControles.Control_Id = disControlesCelda.Control_Id AND disControlesCelda.Formulario_Id = disControles.Formulario_Id
WHERE (disControlesCelda.Formulario_Id = @liFormulario)
ORDER BY disControles.ControlParent_Id, disControlesCelda.Fila, disControlesCelda.Columna
**/

--Controles
SELECT disControles.Control_Id, disControles.NroControl, disControles.ControlParent_Id, 
		disControles.TipoControl, disControles.Alto, disControles.Ancho, 
		disControles.Arriba, disControles.Izquierda, disControles.Texto, 
		disControles.Visible, disControles.Habilitado, disControles.Alineacion,
		disControles.TabStop, disControles.TabOrden, disControles.Requerido, 
		TablasColumnas1.Tabla_Id NombreTabla, TablasColumnas1.Columna_Id NombreColumna, 
		disControles.Embebido, 
		disControles.Ancla, disControles.EsCodigoNuevo, disControles.Paises, disControles.Fila, 
		disControles.Columna, disControles.FilasExtension, disControles.ColumnasExtension,
		disControles.MaximaLongitud, disControles.ClickNuevoBlanquea, disControles.ControlaCambios, 
		disControles.SoloLectura, disControles.TextoFijo, disControles.TextoControlVacio,
		disControles.Estilo, disControles.TituloLabel, disControles.AlineacionLabel, disControles.IgualaAnchoColumna,
		disControles.SegmentoOrigen, disControles.ControlSegmento, disControles.Heredado
FROM disControles 
LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
WHERE (disControles.Formulario_Id = @liFormulario)
UNION--Los controles de los popups asociados
SELECT disControles.Control_Id, disControles.NroControl, 
		case when disControles.ControlParent_Id = 'Solapa_Datos' then lstFrm.SolapaInvocante else disControles.ControlParent_Id end as ControlParent_Id, 
		disControles.TipoControl, disControles.Alto, disControles.Ancho, 
		disControles.Arriba, disControles.Izquierda, disControles.Texto, 
		disControles.Visible, disControles.Habilitado, disControles.Alineacion,
		disControles.TabStop, disControles.TabOrden, disControles.Requerido, 
		TablasColumnas1.Tabla_Id NombreTabla, TablasColumnas1.Columna_Id NombreColumna, 
		disControles.Embebido, 
		disControles.Ancla, disControles.EsCodigoNuevo, disControles.Paises, disControles.Fila, 
		disControles.Columna, disControles.FilasExtension, disControles.ColumnasExtension,
		disControles.MaximaLongitud, disControles.ClickNuevoBlanquea, disControles.ControlaCambios, 
		disControles.SoloLectura, disControles.TextoFijo, disControles.TextoControlVacio,
		disControles.Estilo, disControles.TituloLabel, disControles.AlineacionLabel, disControles.IgualaAnchoColumna,
		disControles.SegmentoOrigen, disControles.ControlSegmento, disControles.Heredado
FROM disControles 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControles.Formulario_Id
LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
WHERE (disControles.NroControl > 2) -- el 0 es el formulario, el 1 es el control solapas, y el 2 la solapa_datos
UNION--Los controles de los forms refenciados por controles
SELECT case when disControles.TipoControl = 'System.Windows.Forms.TabPage' then disControles.Control_Id + '_' + lstfrm.ControlReferencia else disControles.Control_Id end as Control_Id, 
		disControles.NroControl, 
		case when disControles.ControlParent_Id like 'Solapa__%' then disControles.ControlParent_Id + '_' + lstfrm.ControlReferencia else disControles.ControlParent_Id end as ControlParent_Id, 
		disControles.TipoControl, disControles.Alto, disControles.Ancho, 
		disControles.Arriba, disControles.Izquierda, disControles.Texto, 
		disControles.Visible, disControles.Habilitado, disControles.Alineacion,
		disControles.TabStop, disControles.TabOrden, disControles.Requerido, 
		TablasColumnas1.Tabla_Id NombreTabla, TablasColumnas1.Columna_Id NombreColumna, 
		disControles.Embebido, 
		disControles.Ancla, disControles.EsCodigoNuevo, disControles.Paises, disControles.Fila, 
		disControles.Columna, disControles.FilasExtension, disControles.ColumnasExtension,
		disControles.MaximaLongitud, disControles.ClickNuevoBlanquea, disControles.ControlaCambios, 
		disControles.SoloLectura, disControles.TextoFijo, disControles.TextoControlVacio,
		disControles.Estilo, disControles.TituloLabel, disControles.AlineacionLabel, disControles.IgualaAnchoColumna,
		disControles.SegmentoOrigen, disControles.ControlSegmento, disControles.Heredado
FROM disControles 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControles.Formulario_Id
LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
WHERE (disControles.NroControl > 1) -- el 0 es el formulario, el 1 es el control solapas, y el 2 la solapa_datos
ORDER BY disControles.Fila, disControles.Columna, disControles.NroControl

--Check Box
SELECT disControlesCheckBox.Control_Id, disControlesCheckBox.Checked
FROM disControlesCheckBox 
WHERE (Formulario_Id = @liFormulario)
UNION
SELECT disControlesCheckBox.Control_Id, disControlesCheckBox.Checked
FROM disControlesCheckBox 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesCheckBox.Formulario_Id
UNION
SELECT disControlesCheckBox.Control_Id, disControlesCheckBox.Checked
FROM disControlesCheckBox 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesCheckBox.Formulario_Id

-- Grillas
SELECT disControlesGrilla.Control_Id, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, EditaEnGrilla, RegistrosxPagina, 
	AutoFormateable, EsGrillaAdjuntos, EsArbol, AccionNuevoValorNodo, TotalizaColumnas, FilasAMostrar, AnchoMinimo, AnchoColumnasFijas,
	NombreColCalculoTotal,ColFormatoNumericoFila, ColumnasFijas, ColumnasSoloLectura, ColumnasOcultas, ColumnasTotalizarCantidad, 
	ColumnasTotalizarMinimo, ColumnasTotalizarMaximo,ColumnasTotalizarPromedio, ColumnasTotalizarSuma, AnchoColPorContenido,
	ColumnaColorFondoFila, ColumnaColorTextoFila, PermiteCambiarOrden, PermiteOrdenMultiCols, ExpandirHastaNivel
FROM disControlesGrilla 
WHERE (Formulario_Id = @liFormulario)
UNION
SELECT disControlesGrilla.Control_Id, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, EditaEnGrilla, RegistrosxPagina, 
	AutoFormateable, EsGrillaAdjuntos, EsArbol, AccionNuevoValorNodo, TotalizaColumnas,FilasAMostrar, AnchoMinimo, AnchoColumnasFijas,
	NombreColCalculoTotal, ColFormatoNumericoFila, ColumnasFijas, ColumnasSoloLectura, ColumnasOcultas, ColumnasTotalizarCantidad, 
	ColumnasTotalizarMinimo, ColumnasTotalizarMaximo,ColumnasTotalizarPromedio, ColumnasTotalizarSuma, AnchoColPorContenido,
	ColumnaColorFondoFila, ColumnaColorTextoFila, PermiteCambiarOrden, PermiteOrdenMultiCols, ExpandirHastaNivel
FROM disControlesGrilla 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrilla.Formulario_Id 
UNION
SELECT disControlesGrilla.Control_Id, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, EditaEnGrilla, RegistrosxPagina, 
	AutoFormateable, EsGrillaAdjuntos, EsArbol, AccionNuevoValorNodo, TotalizaColumnas,FilasAMostrar, AnchoMinimo, AnchoColumnasFijas,
	NombreColCalculoTotal, ColFormatoNumericoFila, ColumnasFijas, ColumnasSoloLectura, ColumnasOcultas, ColumnasTotalizarCantidad, 
	ColumnasTotalizarMinimo, ColumnasTotalizarMaximo, ColumnasTotalizarPromedio, ColumnasTotalizarSuma, AnchoColPorContenido,
	ColumnaColorFondoFila, ColumnaColorTextoFila, PermiteCambiarOrden, PermiteOrdenMultiCols, ExpandirHastaNivel
FROM disControlesGrilla 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesGrilla.Formulario_Id 

-- Columnas Grillas
SELECT disControlesGrillaColumnas.Control_Id, disControlesGrillaColumnas.Posicion,	disControlesGrillaColumnas.NombreCampo, 
	disControlesGrillaColumnas.Titulo, disControlesGrillaColumnas.TipoDato, disControlesGrillaColumnas.Formato,
	disControlesGrillaColumnas.Visible, disControlesGrillaColumnas.ControlColumna_Id, disControlesGrillaColumnas.Ancho, 
	disControlesGrillaColumnas.AnchoVariable, disControlesGrillaColumnas.Alineacion, disControlesGrillaColumnas.SoloLectura,
	disControlesGrillaColumnas.ModoTamanioVariable, disControlesGrillaColumnas.CongelarTamanio, disControlesGrillaColumnas.AnchoMinimo, 
	disControlesGrillaColumnas.ModoOrdenamiento, disControlesGrillaColumnas.TextoColumnaVacia, 
	disControlesGrillaColumnas.Texto, disControlesGrillaColumnas.EsParamAccionBoton, disControlesGrillaColumnas.Heredado,
	disControlesGrillaColumnas.Requerido, disControlesGrillaColumnas.AutoNumerico, disControlesGrillaColumnas.EsPrimaryKey,
	disControlesGrillaColumnas.ItemsCombo, lupIdentidades.Identidad_Id, disControlesGrillaColumnas.TotalizarCantidad, 
	disControlesGrillaColumnas.TotalizarMinimo, disControlesGrillaColumnas.TotalizarMaximo,
	disControlesGrillaColumnas.TotalizarSuma, disControlesGrillaColumnas.TotalizarPromedio,
	disControlesGrillaColumnas.ColumnaColorFondoCelda, disControlesGrillaColumnas.ColumnaColorTextoCelda
FROM disControlesGrillaColumnas 
LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesGrillaColumnas.Identidad_Id
WHERE (Formulario_Id = @liFormulario)
UNION
SELECT disControlesGrillaColumnas.Control_Id, disControlesGrillaColumnas.Posicion,	disControlesGrillaColumnas.NombreCampo, 
	disControlesGrillaColumnas.Titulo, disControlesGrillaColumnas.TipoDato, disControlesGrillaColumnas.Formato,
	disControlesGrillaColumnas.Visible, disControlesGrillaColumnas.ControlColumna_Id, disControlesGrillaColumnas.Ancho, 
	disControlesGrillaColumnas.AnchoVariable, disControlesGrillaColumnas.Alineacion, disControlesGrillaColumnas.SoloLectura,
	disControlesGrillaColumnas.ModoTamanioVariable, disControlesGrillaColumnas.CongelarTamanio, disControlesGrillaColumnas.AnchoMinimo, 
	disControlesGrillaColumnas.ModoOrdenamiento, disControlesGrillaColumnas.TextoColumnaVacia, 
	disControlesGrillaColumnas.Texto, disControlesGrillaColumnas.EsParamAccionBoton, disControlesGrillaColumnas.Heredado,
	disControlesGrillaColumnas.Requerido, disControlesGrillaColumnas.AutoNumerico, disControlesGrillaColumnas.EsPrimaryKey,
	disControlesGrillaColumnas.ItemsCombo, lupIdentidades.Identidad_Id, disControlesGrillaColumnas.TotalizarCantidad, 
	disControlesGrillaColumnas.TotalizarMinimo, disControlesGrillaColumnas.TotalizarMaximo,
	disControlesGrillaColumnas.TotalizarSuma, disControlesGrillaColumnas.TotalizarPromedio,
	disControlesGrillaColumnas.ColumnaColorFondoCelda, disControlesGrillaColumnas.ColumnaColorTextoCelda
FROM disControlesGrillaColumnas 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColumnas.Formulario_Id 
LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesGrillaColumnas.Identidad_Id
UNION
SELECT disControlesGrillaColumnas.Control_Id, disControlesGrillaColumnas.Posicion,	disControlesGrillaColumnas.NombreCampo, 
	disControlesGrillaColumnas.Titulo, disControlesGrillaColumnas.TipoDato, disControlesGrillaColumnas.Formato,
	disControlesGrillaColumnas.Visible, disControlesGrillaColumnas.ControlColumna_Id, disControlesGrillaColumnas.Ancho, 
	disControlesGrillaColumnas.AnchoVariable, disControlesGrillaColumnas.Alineacion, disControlesGrillaColumnas.SoloLectura,
	disControlesGrillaColumnas.ModoTamanioVariable, disControlesGrillaColumnas.CongelarTamanio, disControlesGrillaColumnas.AnchoMinimo, 
	disControlesGrillaColumnas.ModoOrdenamiento, disControlesGrillaColumnas.TextoColumnaVacia, 
	disControlesGrillaColumnas.Texto, disControlesGrillaColumnas.EsParamAccionBoton, disControlesGrillaColumnas.Heredado,
	disControlesGrillaColumnas.Requerido, disControlesGrillaColumnas.AutoNumerico, disControlesGrillaColumnas.EsPrimaryKey,
	disControlesGrillaColumnas.ItemsCombo, lupIdentidades.Identidad_Id, disControlesGrillaColumnas.TotalizarCantidad, 
	disControlesGrillaColumnas.TotalizarMinimo, disControlesGrillaColumnas.TotalizarMaximo,
	disControlesGrillaColumnas.TotalizarSuma, disControlesGrillaColumnas.TotalizarPromedio,
	disControlesGrillaColumnas.ColumnaColorFondoCelda, disControlesGrillaColumnas.ColumnaColorTextoCelda
FROM disControlesGrillaColumnas 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesGrillaColumnas.Formulario_Id 
LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesGrillaColumnas.Identidad_Id

ORDER BY disControlesGrillaColumnas.Control_Id, disControlesGrillaColumnas.Posicion

---- Columnas Texto Grillas 
--SELECT Control_Id, NombreCampo, MaximaLongitud
--FROM disControlesGrillaColTexto
--WHERE (Formulario_Id = @liFormulario)
--UNION
--SELECT Control_Id, NombreCampo, MaximaLongitud
--FROM disControlesGrillaColTexto
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColTexto.Formulario_Id 

---- Columnas Numericas Grillas 
--SELECT Control_Id, NombreCampo, ParteEntera, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje, Autonumerico
--FROM disControlesGrillaColNumerico 
--WHERE (Formulario_Id = @liFormulario)
--UNION
--SELECT Control_Id, NombreCampo, ParteEntera, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje, Autonumerico
--FROM disControlesGrillaColNumerico 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColNumerico.Formulario_Id 


---- Columnas Fecha Grillas 
--SELECT Control_Id, NombreCampo, UsaDatePicker, ValorMinimo, ValorMaximo, DiasDiferenciaFecha,
--		DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima	
--FROM disControlesGrillaColFecha 
--WHERE (Formulario_Id = @liFormulario)
--UNION
--SELECT Control_Id, NombreCampo, UsaDatePicker, ValorMinimo, ValorMaximo, DiasDiferenciaFecha,
--		DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima	
--FROM disControlesGrillaColFecha 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColFecha.Formulario_Id 

---- Columnas Boton Grillas 
--SELECT Control_Id, NombreCampo, EsLink 
--FROM disControlesGrillaColBoton  
--WHERE (Formulario_Id = @liFormulario)
--UNION
--SELECT Control_Id, NombreCampo, EsLink 
--FROM disControlesGrillaColBoton  
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColBoton.Formulario_Id 

---- Columnas Combo Grillas 
--SELECT disControlesGrillaColCombo.Control_Id, disControlesGrillaColCombo.NombreCampo, 
--	disControlesGrillaColCombo.MultiSeleccion, disControlesGrillaColCombo.CheckBoxes, lupIdentidades.Identidad_Id
--FROM disControlesGrillaColCombo
--LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesGrillaColCombo.Identidad_Id 
--WHERE (Formulario_Id = @liFormulario) 
--UNION
--SELECT disControlesGrillaColCombo.Control_Id, disControlesGrillaColCombo.NombreCampo, 
--	disControlesGrillaColCombo.MultiSeleccion, disControlesGrillaColCombo.CheckBoxes, lupIdentidades.Identidad_Id
--FROM disControlesGrillaColCombo
--LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesGrillaColCombo.Identidad_Id 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColCombo.Formulario_Id 


----  Items de Columnas Combo Grillas
--SELECT disControlesGrillaColComboItems.Control_Id, disControlesGrillaColComboItems.NombreCampo, 
--	disControlesGrillaColComboItems.Valor, disControlesGrillaColComboItems.Descripcion, disControlesGrillaColComboItems.Tipo
--FROM disControlesGrillaColComboItems
--WHERE (Formulario_Id = @liFormulario) 
--UNION
--SELECT disControlesGrillaColComboItems.Control_Id, disControlesGrillaColComboItems.NombreCampo, 
--	disControlesGrillaColComboItems.Valor, disControlesGrillaColComboItems.Descripcion, disControlesGrillaColComboItems.Tipo
--FROM disControlesGrillaColComboItems
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColComboItems.Formulario_Id 

-- Lupas
SELECT disControlesLupa.Control_Id, disControlesLupa.CamposClave, disControlesLupa.CantMaxRegAMostrar, 
	disControlesLupa.EsLaEntidadDelForm, lupIdentidades.Identidad_Id,
	disControlesLupa.OrderBy, disControlesLupa.TraePrimerRegistro, disControlesLupa.UsaAccion, 
	disControlesLupa.DescripcionCharCasing,	disControlesLupa.DescripcionMaxLength, disControlesLupa.DescripcionTexto, 
	disControlesLupa.DescripcionOculta, disControlesLupa.ColumnaGrillaDescripcion,
	TablasColumnasD.Columna_Id NombreColumnaDescripcion, 
	disControlesLupa.Filtros, disControlesLupa.CodigoTipo, 
	disControlesLupa.CodigoCharCasing, disControlesLupa.CodigoMask, disControlesLupa.CodigoRegExpression,
	disControlesLupa.CodigoMaxLength, disControlesLupa.CodigoTexto, disControlesLupa.CodigoWidth, 
	disControlesLupa.CodigoNombreColumna, disControlesLupa.AdicionalesCampos, disControlesLupa.AdicionalesControles, 
	disControlesLupa.AdicionalesParametros, disControlesLupa.PermiteNoExistentes, lupIdentidades.OrdenMenuFormulario,
	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup, 
	lupIdentidades.CharCasing, ISNULL(disControlesLupa.Mascara, lupIdentidades.Mascara) as Mascara, lupIdentidades.MaximaLongitud 
FROM disControlesLupa 
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesLupa.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
LEFT JOIN disTablasColumnas as TablasColumnasD ON (TablasColumnasD.Control_Id = disControlesLupa.Control_Id) 
		  AND (TablasColumnasD.Formulario_Id = disControlesLupa.Formulario_Id)
		  AND (TablasColumnasD.AdicionalControl = 'D') 
WHERE (disControlesLupa.Formulario_Id = @liFormulario)
UNION
SELECT disControlesLupa.Control_Id, disControlesLupa.CamposClave, disControlesLupa.CantMaxRegAMostrar, 
	disControlesLupa.EsLaEntidadDelForm, lupIdentidades.Identidad_Id,
	disControlesLupa.OrderBy, disControlesLupa.TraePrimerRegistro, disControlesLupa.UsaAccion, 
	disControlesLupa.DescripcionCharCasing,	disControlesLupa.DescripcionMaxLength, disControlesLupa.DescripcionTexto, 
	disControlesLupa.DescripcionOculta, disControlesLupa.ColumnaGrillaDescripcion,
	TablasColumnasD.Columna_Id NombreColumnaDescripcion, 
	disControlesLupa.Filtros, disControlesLupa.CodigoTipo, 
	disControlesLupa.CodigoCharCasing, disControlesLupa.CodigoMask, disControlesLupa.CodigoRegExpression,
	disControlesLupa.CodigoMaxLength, disControlesLupa.CodigoTexto, disControlesLupa.CodigoWidth, 
	disControlesLupa.CodigoNombreColumna, disControlesLupa.AdicionalesCampos, disControlesLupa.AdicionalesControles, 
	disControlesLupa.AdicionalesParametros, disControlesLupa.PermiteNoExistentes, lupIdentidades.OrdenMenuFormulario,
	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup,
	lupIdentidades.CharCasing, ISNULL(disControlesLupa.Mascara, lupIdentidades.Mascara) as Mascara, lupIdentidades.MaximaLongitud
FROM disControlesLupa 
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesLupa.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
LEFT JOIN disTablasColumnas as TablasColumnasD ON (TablasColumnasD.Control_Id = disControlesLupa.Control_Id) 
		  AND (TablasColumnasD.Formulario_Id = disControlesLupa.Formulario_Id)
		  AND (TablasColumnasD.AdicionalControl = 'D') 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesLupa.Formulario_Id 
UNION
SELECT disControlesLupa.Control_Id, disControlesLupa.CamposClave, disControlesLupa.CantMaxRegAMostrar, 
	disControlesLupa.EsLaEntidadDelForm, lupIdentidades.Identidad_Id,
	disControlesLupa.OrderBy, disControlesLupa.TraePrimerRegistro, disControlesLupa.UsaAccion, 
	disControlesLupa.DescripcionCharCasing,	disControlesLupa.DescripcionMaxLength, disControlesLupa.DescripcionTexto, 
	disControlesLupa.DescripcionOculta, disControlesLupa.ColumnaGrillaDescripcion,
	TablasColumnasD.Columna_Id NombreColumnaDescripcion, 
	disControlesLupa.Filtros, disControlesLupa.CodigoTipo, 
	disControlesLupa.CodigoCharCasing, disControlesLupa.CodigoMask, disControlesLupa.CodigoRegExpression,
	disControlesLupa.CodigoMaxLength, disControlesLupa.CodigoTexto, disControlesLupa.CodigoWidth, 
	disControlesLupa.CodigoNombreColumna, disControlesLupa.AdicionalesCampos, disControlesLupa.AdicionalesControles, 
	disControlesLupa.AdicionalesParametros, disControlesLupa.PermiteNoExistentes, lupIdentidades.OrdenMenuFormulario,
	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup,
	lupIdentidades.CharCasing, ISNULL(disControlesLupa.Mascara, lupIdentidades.Mascara) as Mascara, lupIdentidades.MaximaLongitud
FROM disControlesLupa 
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesLupa.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
LEFT JOIN disTablasColumnas as TablasColumnasD ON (TablasColumnasD.Control_Id = disControlesLupa.Control_Id) 
		  AND (TablasColumnasD.Formulario_Id = disControlesLupa.Formulario_Id)
		  AND (TablasColumnasD.AdicionalControl = 'D') 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesLupa.Formulario_Id 

-- Combos
SELECT disControlesCombo.Control_Id, disControlesCombo.MultiSeleccion, disControlesCombo.CheckBoxes, lupIdentidades.Identidad_Id,
	disControlesCombo.EsOptionGroup, disControlesCombo.OptionGroupHorizontal	
FROM disControlesCombo
LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesCombo.Identidad_Id 
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT disControlesCombo.Control_Id, disControlesCombo.MultiSeleccion, disControlesCombo.CheckBoxes, lupIdentidades.Identidad_Id,
	disControlesCombo.EsOptionGroup, disControlesCombo.OptionGroupHorizontal
FROM disControlesCombo
LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesCombo.Identidad_Id 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesCombo.Formulario_Id 
UNION
SELECT disControlesCombo.Control_Id, disControlesCombo.MultiSeleccion, disControlesCombo.CheckBoxes, lupIdentidades.Identidad_Id,
	disControlesCombo.EsOptionGroup, disControlesCombo.OptionGroupHorizontal
FROM disControlesCombo
LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesCombo.Identidad_Id 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesCombo.Formulario_Id 



-- Items del Combo
SELECT disControlesComboItems.Control_Id, disControlesComboItems.Valor, disControlesComboItems.Descripcion, disControlesComboItems.Tipo, disControlesComboItems.Orden
FROM disControlesComboItems
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT disControlesComboItems.Control_Id, disControlesComboItems.Valor, disControlesComboItems.Descripcion, disControlesComboItems.Tipo, disControlesComboItems.Orden
FROM disControlesComboItems
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesComboItems.Formulario_Id 
UNION
SELECT disControlesComboItems.Control_Id, disControlesComboItems.Valor, disControlesComboItems.Descripcion, disControlesComboItems.Tipo, disControlesComboItems.Orden
FROM disControlesComboItems
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesComboItems.Formulario_Id 
ORDER BY 1, 5, 2

-- Numericos
SELECT Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje, LLevaSeparadorGrupo
FROM disControlesNumerico
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje, LLevaSeparadorGrupo
FROM disControlesNumerico
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesNumerico.Formulario_Id 
UNION
SELECT Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje, LLevaSeparadorGrupo
FROM disControlesNumerico
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesNumerico.Formulario_Id 

-- Fechas
SELECT Control_Id, ValorMinimo, ValorMaximo, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima, EsFechaHora, ValorHora
FROM disControlesFecha
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, ValorMinimo, ValorMaximo, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima, EsFechaHora, ValorHora 
FROM disControlesFecha
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesFecha.Formulario_Id 
UNION
SELECT Control_Id, ValorMinimo, ValorMaximo, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima, EsFechaHora, ValorHora 
FROM disControlesFecha
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesFecha.Formulario_Id 

-- Textos
SELECT Control_Id, MultiplesLineas, CharCasing, Mascara
FROM disControlesTexto
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, MultiplesLineas, CharCasing, Mascara
FROM disControlesTexto
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesTexto.Formulario_Id 
UNION
SELECT Control_Id, MultiplesLineas, CharCasing, Mascara
FROM disControlesTexto
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesTexto.Formulario_Id 

-- Segmentos
SELECT Control_Id, genSegmentos.Segmento_Id, lupIdentidades.Identidad_Id, EsLaEntidadDelForm, Filtros, 
lupIdentidades.OrdenMenuFormulario,	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesSegmento
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = disControlesSegmento.Segmento_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesSegmento.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
WHERE (disControlesSegmento.Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, genSegmentos.Segmento_Id, lupIdentidades.Identidad_Id, EsLaEntidadDelForm, Filtros, 
lupIdentidades.OrdenMenuFormulario,	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesSegmento
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = disControlesSegmento.Segmento_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesSegmento.Identidad_Id 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesSegmento.Formulario_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
UNION
SELECT Control_Id, genSegmentos.Segmento_Id, lupIdentidades.Identidad_Id, EsLaEntidadDelForm, Filtros, 
lupIdentidades.OrdenMenuFormulario,	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesSegmento
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = disControlesSegmento.Segmento_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesSegmento.Identidad_Id 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesSegmento.Formulario_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id

-- UpLoad
SELECT Control_Id, GuardaCaminoCompleto, ColumnaNombreInterno, ExtensionesPermitidas
FROM disControlesUpLoad
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, GuardaCaminoCompleto, ColumnaNombreInterno, ExtensionesPermitidas
FROM disControlesUpLoad
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesUpLoad.Formulario_Id 
UNION
SELECT Control_Id, GuardaCaminoCompleto, ColumnaNombreInterno, ExtensionesPermitidas
FROM disControlesUpLoad
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesUpLoad.Formulario_Id 

-- grafico
SELECT Control_Id, SubTitulo, Leyenda, Tipo, SubTipo, PermiteCambiarSubTipo, TituloEjevalores, Colores
FROM disControlesGrafico
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, SubTitulo, Leyenda, Tipo, SubTipo, PermiteCambiarSubTipo, TituloEjevalores, Colores
FROM disControlesGrafico
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrafico.Formulario_Id 
UNION
SELECT Control_Id, SubTitulo, Leyenda, Tipo, SubTipo, PermiteCambiarSubTipo, TituloEjevalores, Colores
FROM disControlesGrafico
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesGrafico.Formulario_Id 

-- grafico torta
SELECT Control_Id, ValoresASeparar, UbicacionTituloPorcion, FormatoTituloPorcion
FROM disControlesGraficoTorta
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, ValoresASeparar, UbicacionTituloPorcion, FormatoTituloPorcion
FROM disControlesGraficoTorta
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGraficoTorta.Formulario_Id 
UNION
SELECT Control_Id, ValoresASeparar, UbicacionTituloPorcion, FormatoTituloPorcion
FROM disControlesGraficoTorta
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesGraficoTorta.Formulario_Id 

-- Lista Adjuntos
SELECT Control_Id, PermiteAgregarArchivo, PermiteBorrarArchivo, MuestraDescripciones, PermiteDescargar, CantidadMaxima, ExtensionesPermitidas,
TamanioMaximo
FROM disControlesListaAdjuntos
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, PermiteAgregarArchivo, PermiteBorrarArchivo, MuestraDescripciones, PermiteDescargar, CantidadMaxima, ExtensionesPermitidas,
TamanioMaximo
FROM disControlesListaAdjuntos
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesListaAdjuntos.Formulario_Id 
UNION
SELECT Control_Id, PermiteAgregarArchivo, PermiteBorrarArchivo, MuestraDescripciones, PermiteDescargar, CantidadMaxima, ExtensionesPermitidas,
TamanioMaximo
FROM disControlesListaAdjuntos
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesListaAdjuntos.Formulario_Id 



---- DownLoad
--SELECT Control_Id, CarpetaServidor, ArchivoADescargar, ArchivoDescargado, ExtensionArchivo, EsUrl
--FROM disControlesDownLoad
--WHERE (Formulario_Id = @liFormulario) 
--UNION
--SELECT Control_Id, CarpetaServidor, ArchivoADescargar, ArchivoDescargado, ExtensionArchivo, EsUrl
--FROM disControlesDownLoad
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesDownLoad.Formulario_Id 
--UNION
--SELECT Control_Id, CarpetaServidor, ArchivoADescargar, ArchivoDescargado, ExtensionArchivo, EsUrl
--FROM disControlesDownLoad
--INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesDownLoad.Formulario_Id 

-- Controles Boton
SELECT disControlesBoton.Control_Id, ControlAsociado_Id, AsociadoAFilaGrilla, Icono, disControles.Fila, disControles.Columna
FROM disControlesBoton 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBoton.Formulario_Id 
						AND disControles.Control_Id = disControlesBoton.Control_Id
WHERE (disControlesBoton.Formulario_Id = @liFormulario) 
UNION
SELECT disControlesBoton.Control_Id, ControlAsociado_Id, AsociadoAFilaGrilla, Icono, disControles.Fila, disControles.Columna
FROM disControlesBoton
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesBoton.Formulario_Id 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBoton.Formulario_Id 
						AND disControles.Control_Id = disControlesBoton.Control_Id
UNION
SELECT disControlesBoton.Control_Id, ControlAsociado_Id, AsociadoAFilaGrilla, Icono, disControles.Fila, disControles.Columna
FROM disControlesBoton
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesBoton.Formulario_Id 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBoton.Formulario_Id 
						AND disControles.Control_Id = disControlesBoton.Control_Id
order by disControles.Fila, disControles.Columna

-- Controles Link
SELECT disControlesLink.Control_Id, disControlesLink.Link
FROM disControlesLink 
WHERE (disControlesLink.Formulario_Id = @liFormulario) 
UNION
SELECT disControlesLink.Control_Id, disControlesLink.Link
FROM disControlesLink 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesLink.Formulario_Id 
UNION
SELECT disControlesLink.Control_Id, disControlesLink.Link
FROM disControlesLink 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesLink.Formulario_Id 

-- Controles Grilla Pivot
SELECT disControlesGrillaPivot.Control_Id, UrlServidor, Catalogo, Cubo, Measures, Filas, Columnas, disControles.Fila, disControles.Columna
FROM disControlesGrillaPivot 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesGrillaPivot.Formulario_Id 
						AND disControles.Control_Id = disControlesGrillaPivot.Control_Id
WHERE (disControlesGrillaPivot.Formulario_Id = @liFormulario) 
UNION
SELECT disControlesGrillaPivot.Control_Id, UrlServidor, Catalogo, Cubo, Measures, Filas, Columnas, disControles.Fila, disControles.Columna
FROM disControlesGrillaPivot
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaPivot.Formulario_Id 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesGrillaPivot.Formulario_Id 
						AND disControles.Control_Id = disControlesGrillaPivot.Control_Id
UNION
SELECT disControlesGrillaPivot.Control_Id, UrlServidor, Catalogo, Cubo, Measures, Filas, Columnas, disControles.Fila, disControles.Columna
FROM disControlesGrillaPivot
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesGrillaPivot.Formulario_Id 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesGrillaPivot.Formulario_Id 
						AND disControles.Control_Id = disControlesGrillaPivot.Control_Id
order by disControles.Fila, disControles.Columna


-- Controles Indicador
SELECT disControlesIndicador.Control_Id, disControlesIndicador.Tipo, disControlesIndicador.Decimales
FROM disControlesIndicador 
WHERE (disControlesIndicador.Formulario_Id = @liFormulario) 
UNION
SELECT disControlesIndicador.Control_Id, disControlesIndicador.Tipo, disControlesIndicador.Decimales
FROM disControlesIndicador 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesIndicador.Formulario_Id 
UNION
SELECT disControlesIndicador.Control_Id, disControlesIndicador.Tipo, disControlesIndicador.Decimales
FROM disControlesIndicador 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesIndicador.Formulario_Id 


-- Controles Boton Lupa
SELECT disControlesBotonLupa.Control_Id, disControlesBotonLupa.ControlAsociado_Id, disControlesBotonLupa.Icono, 
	disControles.Fila, disControles.Columna,
	disControlesBotonLupa.CamposClave, disControlesBotonLupa.CantMaxRegAMostrar, 
	lupIdentidades.Identidad_Id, disControlesBotonLupa.OrderBy, disControlesBotonLupa.UsaAccion, 
	disControlesBotonLupa.Filtros, disControlesBotonLupa.AdicionalesCampos, disControlesBotonLupa.AdicionalesControles, 
	disControlesBotonLupa.AdicionalesParametros, lupIdentidades.OrdenMenuFormulario,
	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup, disControlesBotonLupa.ReemplazaEnDestino
FROM disControlesBotonLupa 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBotonLupa.Formulario_Id 
						AND disControles.Control_Id = disControlesBotonLupa.Control_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesBotonLupa.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
WHERE (disControlesBotonLupa.Formulario_Id = @liFormulario)
UNION
SELECT disControlesBotonLupa.Control_Id, disControlesBotonLupa.ControlAsociado_Id, disControlesBotonLupa.Icono, 
	disControles.Fila, disControles.Columna,
	disControlesBotonLupa.CamposClave, disControlesBotonLupa.CantMaxRegAMostrar, 
	lupIdentidades.Identidad_Id, disControlesBotonLupa.OrderBy, disControlesBotonLupa.UsaAccion, 
	disControlesBotonLupa.Filtros, disControlesBotonLupa.AdicionalesCampos, disControlesBotonLupa.AdicionalesControles, 
	disControlesBotonLupa.AdicionalesParametros, lupIdentidades.OrdenMenuFormulario,
	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup, disControlesBotonLupa.ReemplazaEnDestino
FROM disControlesBotonLupa 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBotonLupa.Formulario_Id 
						AND disControles.Control_Id = disControlesBotonLupa.Control_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesBotonLupa.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesBotonLupa.Formulario_Id 
UNION
SELECT disControlesBotonLupa.Control_Id, disControlesBotonLupa.ControlAsociado_Id, disControlesBotonLupa.Icono, 
	disControles.Fila, disControles.Columna,
	disControlesBotonLupa.CamposClave, disControlesBotonLupa.CantMaxRegAMostrar, 
	lupIdentidades.Identidad_Id, disControlesBotonLupa.OrderBy, disControlesBotonLupa.UsaAccion, 
	disControlesBotonLupa.Filtros, disControlesBotonLupa.AdicionalesCampos, disControlesBotonLupa.AdicionalesControles, 
	disControlesBotonLupa.AdicionalesParametros, lupIdentidades.OrdenMenuFormulario,
	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup, disControlesBotonLupa.ReemplazaEnDestino
FROM disControlesBotonLupa 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBotonLupa.Formulario_Id 
						AND disControles.Control_Id = disControlesBotonLupa.Control_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesBotonLupa.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesBotonLupa.Formulario_Id 


-- Controles Boton Segmento
SELECT disControlesBotonSegmento.Control_Id, disControlesBotonSegmento.ControlAsociado_Id, disControlesBotonSegmento.Icono, 
	disControles.Fila, disControles.Columna,
	lupIdentidades.Identidad_Id, disControlesBotonSegmento.Filtros,
	lupIdentidades.OrdenMenuFormulario,	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesBotonSegmento 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBotonSegmento.Formulario_Id 
						AND disControles.Control_Id = disControlesBotonSegmento.Control_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesBotonSegmento.Identidad_Id
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
WHERE (disControlesBotonSegmento.Formulario_Id = @liFormulario)
UNION
SELECT disControlesBotonSegmento.Control_Id, disControlesBotonSegmento.ControlAsociado_Id, disControlesBotonSegmento.Icono, 
	disControles.Fila, disControles.Columna,
	lupIdentidades.Identidad_Id, disControlesBotonSegmento.Filtros, 
	lupIdentidades.OrdenMenuFormulario,	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesBotonSegmento 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBotonSegmento.Formulario_Id 
						AND disControles.Control_Id = disControlesBotonSegmento.Control_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesBotonSegmento.Identidad_Id
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesBotonSegmento.Formulario_Id 
UNION
SELECT disControlesBotonSegmento.Control_Id, disControlesBotonSegmento.ControlAsociado_Id, disControlesBotonSegmento.Icono, 
	disControles.Fila, disControles.Columna,
	lupIdentidades.Identidad_Id, 
	disControlesBotonSegmento.Filtros, 
	lupIdentidades.OrdenMenuFormulario,
	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesBotonSegmento 
INNER JOIN disControles ON disControles.Formulario_Id = disControlesBotonSegmento.Formulario_Id 
						AND disControles.Control_Id = disControlesBotonSegmento.Control_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesBotonSegmento.Identidad_Id
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesBotonSegmento.Formulario_Id 



-- Parametros
SELECT Control_Id, TipoDato
FROM disControlesParametros
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT Control_Id, TipoDato
FROM disControlesParametros
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesParametros.Formulario_Id 
UNION
SELECT Control_Id, TipoDato
FROM disControlesParametros
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesParametros.Formulario_Id 

-- Controles referencia
SELECT disControlesReferencia.Control_Id, disFormularios.Formulario_Id as FormularioPopup_Id, disControlesReferencia.TieneBtnCerrar, 
disControlesReferencia.TieneBtnGuardar,disControlesReferencia.TablaPrimaria, 
disControlesReferencia.Parametros, disControlesReferencia.TamanioPopup
FROM disControlesReferencia 
LEFT JOIN disFormularios ON disFormularios.disFormularios = disControlesReferencia.FormularioPopup_Id
WHERE (disControlesReferencia.Formulario_Id = @liFormulario) 

-- Controles referencia solapa
SELECT disControlesRefSolapa.Control_Id, disControlesRefSolapa.ControlSolapaRef_Id
FROM disControlesRefSolapa 
WHERE (disControlesRefSolapa.Formulario_Id = @liFormulario) 
UNION
SELECT disControlesRefSolapa.Control_Id, disControlesRefSolapa.ControlSolapaRef_Id
FROM disControlesRefSolapa 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesRefSolapa.Formulario_Id 
UNION
SELECT disControlesRefSolapa.Control_Id, disControlesRefSolapa.ControlSolapaRef_Id + '_' + lstfrm.ControlReferencia as ControlSolapaRef_Id
FROM disControlesRefSolapa 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesRefSolapa.Formulario_Id 

-- Eventos
-- Si es para dise?o, debo mostrar todo tal cual est? en la BD
IF (@pParaWeb = 0)
BEGIN
	SELECT disEventos.Control_Id, disEventos.TipoEvento, disEventos.EsMetodo, disEventos.Habilitado, disEventos.Heredado
	FROM disEventos 
	WHERE (Formulario_Id = @liFormulario) 
END
ELSE  -- No debo pasar lo metodos, ya que las acciones de los mismos van incluidos en quienes los invocan
BEGIN
	SELECT disEventos.Control_Id, disEventos.TipoEvento, disEventos.EsMetodo, disEventos.Habilitado, disEventos.Heredado
	FROM disEventos 
	WHERE (Formulario_Id = @liFormulario) and (EsMetodo = 0) AND (Habilitado = 1)
	UNION
	SELECT disEventos.Control_Id, disEventos.TipoEvento, disEventos.EsMetodo, disEventos.Habilitado, disEventos.Heredado
	FROM disEventos
	INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disEventos.Formulario_Id 
	WHERE (EsMetodo = 0) AND (Habilitado = 1)
	UNION
	--SELECT disEventos.Control_Id, disEventos.TipoEvento, disEventos.EsMetodo, disEventos.Habilitado, disEventos.Heredado
	SELECT case when disEventos.TipoEvento in ('Mostrando', 'Ocultando') then lstFrm.ControlReferencia else disEventos.Control_Id end, disEventos.TipoEvento, disEventos.EsMetodo, disEventos.Habilitado, disEventos.Heredado
	FROM disEventos
	INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disEventos.Formulario_Id 
	WHERE (EsMetodo = 0) AND (Habilitado = 1)

END

--Acciones
-- Si es para dise?o, debo mostrar todo tal cual est? en la BD
IF (@pParaWeb = 0)
BEGIN
	SELECT disAcciones.Control_Id, disAcciones.TipoEvento, cast(disAcciones.OrdenAccion as int) as OrdenAccion, 
		disAcciones.Accion, disAcciones.ControlDestino_Id, disAcciones.Texto,
		disAcciones.ControlTexto_Id, disAcciones.ValorCondicion, disAcciones.AccionPadre_Id, disAcciones.Heredado,
		disAcciones.Accion_Id, disAcciones.Habilitado, disAcciones.EsEspecializacion, disAcciones.AdicionalInfo
	FROM disAcciones 
	WHERE (Formulario_Id = @liFormulario)
	ORDER BY 1, 2, 3
END
ELSE --si es para generar la aplciacion web, debo reemplazar la invocacion al metodo por las acciones del metodo
BEGIN
SELECT disAcciones.Control_Id, disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion, 
	disAcciones.Accion, disAcciones.ControlDestino_Id, disAcciones.Texto,
	disAcciones.ControlTexto_Id, disAcciones.ValorCondicion, disAcciones.AccionPadre_Id, disAcciones.Heredado,
	disAcciones.Accion_Id, disAcciones.Habilitado, disAcciones.EsEspecializacion, disAcciones.AdicionalInfo
FROM disAcciones 
WHERE (Formulario_Id = @liFormulario) and (disAcciones.Accion <> 'InvocarMetodo') and (disAcciones.Accion <> 'DoDefault')
AND (disAcciones.Habilitado = 1)
UNION
SELECT disAcciones1.Control_Id, disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
	disAcciones2.Accion, disAcciones2.ControlDestino_Id, disAcciones2.Texto,
	disAcciones2.ControlTexto_Id, isnull(disAcciones2.ValorCondicion, disAcciones1.ValorCondicion), isnull(disAcciones2.AccionPadre_Id, disAcciones1.AccionPadre_Id), disAcciones1.Heredado,
	disAcciones2.Accion_Id, disAcciones2.Habilitado, disAcciones2.EsEspecializacion, disAcciones2.AdicionalInfo
FROM disAcciones disAcciones1
INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
                                        and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
WHERE (disAcciones1.Formulario_Id = @liFormulario) and (disAcciones1.Accion = 'InvocarMetodo') 
		and (disAcciones1.Accion <> 'DoDefault') and (disAcciones2.Accion <> 'DoDefault')
		AND (disAcciones1.Habilitado = 1)
		AND (disAcciones2.Habilitado = 1)
UNION
SELECT disAcciones.Control_Id, disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion, 
	disAcciones.Accion, disAcciones.ControlDestino_Id, disAcciones.Texto,
	disAcciones.ControlTexto_Id, disAcciones.ValorCondicion, disAcciones.AccionPadre_Id, disAcciones.Heredado,
	disAcciones.Accion_Id, disAcciones.Habilitado, disAcciones.EsEspecializacion, disAcciones.AdicionalInfo
FROM disAcciones
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAcciones.Formulario_Id
WHERE (disAcciones.Accion <> 'InvocarMetodo') and (disAcciones.Accion <> 'DoDefault')
AND (disAcciones.Habilitado = 1)
UNION
SELECT disAcciones1.Control_Id, disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
	disAcciones2.Accion, disAcciones2.ControlDestino_Id, disAcciones2.Texto,
	disAcciones2.ControlTexto_Id, isnull(disAcciones2.ValorCondicion, disAcciones1.ValorCondicion), isnull(disAcciones2.AccionPadre_Id, disAcciones1.AccionPadre_Id), disAcciones1.Heredado,
	disAcciones2.Accion_Id, disAcciones2.Habilitado, disAcciones2.EsEspecializacion, disAcciones2.AdicionalInfo
FROM disAcciones disAcciones1
INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
                                        and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAcciones1.Formulario_Id 
WHERE (disAcciones1.Accion = 'InvocarMetodo') 
		and (disAcciones1.Accion <> 'DoDefault') and (disAcciones2.Accion <> 'DoDefault')
		AND (disAcciones1.Habilitado = 1)
		AND (disAcciones2.Habilitado = 1)
UNION
--SELECT disAcciones.Control_Id, 
SELECT case when disAcciones.TipoEvento in ('Mostrando', 'Ocultando') then lstFrm.ControlReferencia else disAcciones.Control_Id end, 
		disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion,  disAcciones.Accion, 
-- si la accion es mostrar popup, debo agregar al nombre del control destino el nombre de del control referencia
-- Se debe hacer este cambio, porque mostrar popup, tiene como destino una solapa, y las solapas del elemento referenciado
--cambian su nombre original
	case when (disAcciones.Accion <> 'MostrarPopup') and (disAcciones.Accion <> 'CerrarPopup') then disAcciones.ControlDestino_Id else disAcciones.ControlDestino_Id + '_' + lstfrm.ControlReferencia end,
	disAcciones.Texto,
	disAcciones.ControlTexto_Id, disAcciones.ValorCondicion, disAcciones.AccionPadre_Id, disAcciones.Heredado,
	disAcciones.Accion_Id, disAcciones.Habilitado, disAcciones.EsEspecializacion, disAcciones.AdicionalInfo
FROM disAcciones
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disAcciones.Formulario_Id
WHERE (disAcciones.Accion <> 'InvocarMetodo') and (disAcciones.Accion <> 'DoDefault')
AND (disAcciones.Habilitado = 1)
UNION
--SELECT disAcciones1.Control_Id, 
	SELECT case when disAcciones1.TipoEvento in ('Mostrando', 'Ocultando') then lstFrm.ControlReferencia else disAcciones1.Control_Id end, 
	disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, disAcciones2.Accion, 
-- si la accion es mostrar popup, debo agregar al nombre del control destino el nombre de del control referencia
-- Se debe hacer este cambio, porque mostrar popup, tiene como destino una solapa, y las solapas del elemento referenciado
--cambian su nombre original
	case when (disAcciones2.Accion <> 'MostrarPopup') and (disAcciones2.Accion <> 'CerrarPopup')  then disAcciones2.ControlDestino_Id else disAcciones2.ControlDestino_Id + '_' + lstfrm.ControlReferencia end,
	disAcciones2.Texto,
	disAcciones2.ControlTexto_Id, isnull(disAcciones2.ValorCondicion, disAcciones1.ValorCondicion), isnull(disAcciones2.AccionPadre_Id, disAcciones1.AccionPadre_Id), disAcciones1.Heredado,
	disAcciones2.Accion_Id, disAcciones2.Habilitado, disAcciones2.EsEspecializacion, disAcciones2.AdicionalInfo
FROM disAcciones disAcciones1
INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
                                        and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disAcciones1.Formulario_Id 
WHERE (disAcciones1.Accion = 'InvocarMetodo') 
		and (disAcciones1.Accion <> 'DoDefault') and (disAcciones2.Accion <> 'DoDefault')
		AND (disAcciones1.Habilitado = 1)
		AND (disAcciones2.Habilitado = 1)
ORDER BY 1, 2, 3
END


---- Eventos Columnas
--SELECT Control_Id, Columna, TipoEvento, Heredado
--FROM disEventosColumnas 
--WHERE (Formulario_Id = @liFormulario) 
--UNION
--SELECT Control_Id, Columna, TipoEvento, Heredado
--FROM disEventosColumnas 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disEventosColumnas.Formulario_Id
--UNION
--SELECT Control_Id, Columna, TipoEvento, Heredado
--FROM disEventosColumnas 
--INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disEventosColumnas.Formulario_Id

----Acciones Columnas
--SELECT Control_Id, Columna, TipoEvento, OrdenAccion, 
--	Accion, ControlDestino_Id, ColumnaDestino, Texto,
--	ControlTexto_Id, ValorCondicion, AccionPadre_Id, Heredado, Accion_Id
--FROM disAccionesColumnas 
--WHERE (Formulario_Id = @liFormulario) and (Accion <> 'DoDefault')
--UNION
--SELECT Control_Id, Columna, TipoEvento, OrdenAccion, 
--	Accion, ControlDestino_Id, ColumnaDestino, Texto,
--	ControlTexto_Id, ValorCondicion, AccionPadre_Id, Heredado, Accion_Id
--FROM disAccionesColumnas 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAccionesColumnas.Formulario_Id
--WHERE (Accion <> 'DoDefault')
--UNION
--SELECT Control_Id, Columna, TipoEvento, OrdenAccion, 
--	Accion, ControlDestino_Id, ColumnaDestino, Texto,
--	ControlTexto_Id, ValorCondicion, AccionPadre_Id, Heredado, Accion_Id
--FROM disAccionesColumnas 
--INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disAccionesColumnas.Formulario_Id
--WHERE (Accion <> 'DoDefault')



-- Tablas del Common
SELECT Tabla_Id, TipoControl, Control_Id, EsEspecializacion
FROM disTablas
WHERE (Formulario_Id = @liFormulario)
AND ( (Tabla_Id = 'Principal') 
    OR ( (Tabla_Id NOT IN (Select Tabla_Id 
						FROM disTablas
						INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disTablas.Formulario_Id))
         AND (Tabla_Id NOT IN (Select Tabla_Id 
						FROM disTablas
						INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disTablas.Formulario_Id))
	   )
	)
UNION
SELECT Tabla_Id, TipoControl, Control_Id, EsEspecializacion
FROM disTablas
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disTablas.Formulario_Id
AND (Tabla_Id <> 'Principal') 
UNION
SELECT Tabla_Id, TipoControl, Control_Id, EsEspecializacion
FROM disTablas
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disTablas.Formulario_Id
AND (Tabla_Id <> 'Principal') 



-- Columnas de Common
SELECT Tabla_Id, Columna_Id, TipoControl, Control_Id, AdicionalControl, EsEspecializacion
FROM disTablasColumnas
WHERE (Formulario_Id = @liFormulario)
AND ((Tabla_Id = 'Principal') 
    OR ( (Tabla_Id NOT IN (Select Tabla_Id 
						FROM disTablas
						INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disTablas.Formulario_Id))
         AND (Tabla_Id NOT IN (Select Tabla_Id 
						FROM disTablas
						INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disTablas.Formulario_Id))
	   )
	)
UNION
SELECT Tabla_Id, Columna_Id, TipoControl, Control_Id, AdicionalControl, EsEspecializacion
FROM disTablasColumnas
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disTablasColumnas.Formulario_Id
AND (Tabla_Id <> 'Principal') 
UNION
SELECT Tabla_Id, Columna_Id, TipoControl, Control_Id, AdicionalControl, EsEspecializacion
FROM disTablasColumnas
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disTablasColumnas.Formulario_Id
AND (Tabla_Id <> 'Principal') 

--Relaciones entre Tablas
SELECT TablaMaster_Id, TablaDetalle_Id, ColumnaMaster_Id, ColumnaMaster2_Id, ColumnaMaster3_Id,
		ColumnaDetalle_Id, ColumnaDetalle2_Id, ColumnaDetalle3_Id
FROM disRelacionesTablas
WHERE (Formulario_Id = @liFormulario)
UNION
SELECT TablaMaster_Id, TablaDetalle_Id, ColumnaMaster_Id, ColumnaMaster2_Id, ColumnaMaster3_Id,
		ColumnaDetalle_Id, ColumnaDetalle2_Id, ColumnaDetalle3_Id
FROM disRelacionesTablas
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disRelacionesTablas.Formulario_Id
UNION
SELECT TablaMaster_Id, TablaDetalle_Id, ColumnaMaster_Id, ColumnaMaster2_Id, ColumnaMaster3_Id,
		ColumnaDetalle_Id, ColumnaDetalle2_Id, ColumnaDetalle3_Id
FROM disRelacionesTablas
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disRelacionesTablas.Formulario_Id

--Condiciones Acciones
IF (@pParaWeb = 0)
BEGIN
SELECT distinct disAcciones.Control_Id, disAcciones.TipoEvento, disAcciones.AccionPadre_Id as Accion, disAcciones.ValorCondicion 
FROM disAcciones 
WHERE (Formulario_Id = @liFormulario)
AND disAcciones.AccionPadre_Id is not null 
END
ELSE --si es para generar la aplciacion web, debo reemplazar la invocacion al metodo por las acciones del metodo y buscar aho los valores
BEGIN
SELECT distinct ldisAcciones.Control_Id, ldisAcciones.TipoEvento, ldisAcciones.AccionPadre as Accion, ldisAcciones.ValorCondicion 
FROM 
	(SELECT disAcciones.Control_Id, disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion, 
		disAcciones.Accion, disAcciones.ControlDestino_Id, disAcciones.Texto,
		disAcciones.ControlTexto_Id, disAcciones.ValorCondicion, disAcciones.AccionPadre_Id as AccionPadre
	FROM disAcciones 
	WHERE (Formulario_Id = @liFormulario) and disAcciones.Accion <> 'InvocarMetodo' 
	AND disAcciones.AccionPadre_Id is not null 
	UNION
	SELECT disAcciones1.Control_Id, disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
		disAcciones2.Accion, disAcciones2.ControlDestino_Id, disAcciones2.Texto,
		disAcciones2.ControlTexto_Id, disAcciones2.ValorCondicion, disAcciones2.AccionPadre_Id as AccionPadre
	FROM disAcciones disAcciones1
	INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
											and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
	WHERE (disAcciones1.Formulario_Id = @liFormulario) 
	and disAcciones1.Accion = 'InvocarMetodo'
	AND disAcciones2.AccionPadre_Id is not null
	UNION
	SELECT disAcciones.Control_Id, disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion, 
		disAcciones.Accion, disAcciones.ControlDestino_Id, disAcciones.Texto,
		disAcciones.ControlTexto_Id, disAcciones.ValorCondicion, disAcciones.AccionPadre_Id as AccionPadre
	FROM disAcciones 
	WHERE (Formulario_Id = @liFormulario) 
	AND disAcciones.Accion = 'InvocarMetodo' 
	AND disAcciones.AccionPadre_Id is not null 
	AND disAcciones.ValorCondicion is not null	
	) as ldisAcciones
	UNION
    SELECT distinct ldisAcciones.Control_Id, ldisAcciones.TipoEvento, ldisAcciones.AccionPadre as Accion, ldisAcciones.ValorCondicion 
	FROM 
	(SELECT disAcciones.Control_Id, disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion, 
		disAcciones.Accion, disAcciones.ControlDestino_Id, disAcciones.Texto,
		disAcciones.ControlTexto_Id, disAcciones.ValorCondicion, disAcciones.AccionPadre_Id as AccionPadre
	FROM disAcciones 
	INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAcciones.Formulario_Id
	WHERE disAcciones.Accion <> 'InvocarMetodo' 
	AND disAcciones.AccionPadre_Id is not null 
	UNION
	SELECT disAcciones1.Control_Id, disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
		disAcciones2.Accion, disAcciones2.ControlDestino_Id, disAcciones2.Texto,
		disAcciones2.ControlTexto_Id, disAcciones2.ValorCondicion, disAcciones2.AccionPadre_Id as AccionPadre
	FROM disAcciones disAcciones1
	INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
											and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
	INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAcciones1.Formulario_Id
	WHERE disAcciones1.Accion = 'InvocarMetodo'
	AND disAcciones2.AccionPadre_Id is not null) as ldisAcciones
    UNION
    SELECT distinct ldisAcciones.Control_Id, ldisAcciones.TipoEvento, ldisAcciones.AccionPadre as Accion, ldisAcciones.ValorCondicion 
	FROM 
	(--SELECT disAcciones.Control_Id, 
		SELECT case when disAcciones.TipoEvento in ('Mostrando', 'Ocultando') then lstFrm.ControlReferencia else disAcciones.Control_Id end as Control_Id, 
		disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion, 
		disAcciones.Accion, disAcciones.ControlDestino_Id, disAcciones.Texto,
		disAcciones.ControlTexto_Id, disAcciones.ValorCondicion, disAcciones.AccionPadre_Id as AccionPadre
	FROM disAcciones 
	INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disAcciones.Formulario_Id
	WHERE disAcciones.Accion <> 'InvocarMetodo' 
	AND disAcciones.AccionPadre_Id is not null 
	UNION
	--SELECT disAcciones1.Control_Id, 
		SELECT case when disAcciones1.TipoEvento in ('Mostrando', 'Ocultando') then lstFrm.ControlReferencia else disAcciones1.Control_Id end, 
		disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
		disAcciones2.Accion, disAcciones2.ControlDestino_Id, disAcciones2.Texto,
		disAcciones2.ControlTexto_Id, disAcciones2.ValorCondicion, disAcciones2.AccionPadre_Id as AccionPadre
	FROM disAcciones disAcciones1
	INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
											and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
	INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disAcciones1.Formulario_Id
	WHERE disAcciones1.Accion = 'InvocarMetodo'
	AND disAcciones2.AccionPadre_Id is not null) as ldisAcciones

END

--tablas a refrescar luego de invocaer a una Accion
IF (@pParaWeb = 0)
BEGIN
	SELECT act.Control_Id, act.TipoEvento, cast(act.OrdenAccion as int) as OrdenAccion, act.Tabla_Id, a.Accion_Id
	FROM disAccionesTablasaActualizar act
	INNER JOIN disAcciones a ON a.Formulario_Id = act.Formulario_Id 
						AND a.Control_Id = act.Control_Id 
						AND a.TipoEvento = act.TipoEvento
						AND a.OrdenAccion = act.OrdenAccion 

	WHERE (act.Formulario_Id = @liFormulario)
	ORDER BY 1, 2, 3, 4
END
ELSE --si es para generar la aplciacion web, debo reemplazar la invocacion al metodo por las acciones del metodo
BEGIN
SELECT act.Control_Id, act.TipoEvento, cast(act.OrdenAccion * 10000 as int) as OrdenAccion, act.Tabla_id, a.Accion_Id
FROM disAccionesTablasaActualizar act
INNER JOIN disAcciones a ON a.Formulario_Id = act.Formulario_Id 
						AND a.Control_Id = act.Control_Id 
						AND a.TipoEvento = act.TipoEvento
						AND a.OrdenAccion = act.OrdenAccion 
WHERE (act.Formulario_Id = @liFormulario) and (a.Accion <> 'InvocarMetodo') and (a.Accion <> 'DoDefault')
AND (a.Habilitado = 1)
UNION
SELECT disAcciones1.Control_Id, disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
	act.Tabla_id, disAcciones2.Accion_Id
FROM disAcciones disAcciones1
INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
                                        and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
INNER JOIN disAccionesTablasaActualizar act ON disAcciones2.Formulario_Id = act.Formulario_Id 
											AND disAcciones2.Control_Id = act.Control_Id 
											AND disAcciones2.TipoEvento = act.TipoEvento
											AND disAcciones2.OrdenAccion = act.OrdenAccion 
WHERE (disAcciones1.Formulario_Id = @liFormulario) and (disAcciones1.Accion = 'InvocarMetodo') 
		and (disAcciones1.Accion <> 'DoDefault') and (disAcciones2.Accion <> 'DoDefault')
		AND (disAcciones1.Habilitado = 1)
		AND (disAcciones2.Habilitado = 1)
UNION
SELECT disAcciones.Control_Id, disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion, 
	act.Tabla_Id, disAcciones.Accion_Id
FROM disAcciones
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAcciones.Formulario_Id
INNER JOIN disAccionesTablasaActualizar act ON disAcciones.Formulario_Id = act.Formulario_Id 
											AND disAcciones.Control_Id = act.Control_Id 
											AND disAcciones.TipoEvento = act.TipoEvento
											AND disAcciones.OrdenAccion = act.OrdenAccion 
WHERE (disAcciones.Accion <> 'InvocarMetodo') and (disAcciones.Accion <> 'DoDefault')
AND (disAcciones.Habilitado = 1)
UNION
SELECT disAcciones1.Control_Id, disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
	act.Tabla_id, disAcciones2.Accion_Id
FROM disAcciones disAcciones1
INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
                                        and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAcciones1.Formulario_Id 
INNER JOIN disAccionesTablasaActualizar act ON disAcciones2.Formulario_Id = act.Formulario_Id 
											AND disAcciones2.Control_Id = act.Control_Id 
											AND disAcciones2.TipoEvento = act.TipoEvento
											AND disAcciones2.OrdenAccion = act.OrdenAccion 
WHERE (disAcciones1.Accion = 'InvocarMetodo') 
		and (disAcciones1.Accion <> 'DoDefault') and (disAcciones2.Accion <> 'DoDefault')
		AND (disAcciones1.Habilitado = 1)
		AND (disAcciones2.Habilitado = 1)
ORDER BY 1, 2, 3
END


--tablas a enviar al invocar a una accion
IF (@pParaWeb = 0)
BEGIN
	SELECT act.Control_Id, act.TipoEvento, cast(act.OrdenAccion as int) as OrdenAccion, act.Tabla_Id, a.Accion_Id
	FROM disAccionesTablasaEnviar act
	INNER JOIN disAcciones a ON a.Formulario_Id = act.Formulario_Id 
						AND a.Control_Id = act.Control_Id 
						AND a.TipoEvento = act.TipoEvento
						AND a.OrdenAccion = act.OrdenAccion 

	WHERE (act.Formulario_Id = @liFormulario)
	ORDER BY 1, 2, 3, 4
END
ELSE --si es para generar la aplciacion web, debo reemplazar la invocacion al metodo por las acciones del metodo
BEGIN
SELECT act.Control_Id, act.TipoEvento, cast(act.OrdenAccion * 10000 as int) as OrdenAccion, act.Tabla_id, a.Accion_Id
FROM disAccionesTablasaEnviar act
INNER JOIN disAcciones a ON a.Formulario_Id = act.Formulario_Id 
						AND a.Control_Id = act.Control_Id 
						AND a.TipoEvento = act.TipoEvento
						AND a.OrdenAccion = act.OrdenAccion 
WHERE (act.Formulario_Id = @liFormulario) and (a.Accion <> 'InvocarMetodo') and (a.Accion <> 'DoDefault')
AND (a.Habilitado = 1)
UNION
SELECT disAcciones1.Control_Id, disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
	act.Tabla_id, disAcciones2.Accion_Id
FROM disAcciones disAcciones1
INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
                                        and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
INNER JOIN disAccionesTablasaEnviar act ON disAcciones2.Formulario_Id = act.Formulario_Id 
											AND disAcciones2.Control_Id = act.Control_Id 
											AND disAcciones2.TipoEvento = act.TipoEvento
											AND disAcciones2.OrdenAccion = act.OrdenAccion 
WHERE (disAcciones1.Formulario_Id = @liFormulario) and (disAcciones1.Accion = 'InvocarMetodo') 
		and (disAcciones1.Accion <> 'DoDefault') and (disAcciones2.Accion <> 'DoDefault')
		AND (disAcciones1.Habilitado = 1)
		AND (disAcciones2.Habilitado = 1)
UNION
SELECT disAcciones.Control_Id, disAcciones.TipoEvento, cast(disAcciones.OrdenAccion * 10000 as int) as OrdenAccion, 
	act.Tabla_Id, disAcciones.Accion_Id
FROM disAcciones
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAcciones.Formulario_Id
INNER JOIN disAccionesTablasaEnviar act ON disAcciones.Formulario_Id = act.Formulario_Id 
											AND disAcciones.Control_Id = act.Control_Id 
											AND disAcciones.TipoEvento = act.TipoEvento
											AND disAcciones.OrdenAccion = act.OrdenAccion 
WHERE (disAcciones.Accion <> 'InvocarMetodo') and (disAcciones.Accion <> 'DoDefault')
AND (disAcciones.Habilitado = 1)
UNION
SELECT disAcciones1.Control_Id, disAcciones1.TipoEvento, cast(disAcciones1.OrdenAccion * 10000 + disAcciones2.OrdenAccion as int) as OrdenAccion, 
	act.Tabla_id, disAcciones2.Accion_Id
FROM disAcciones disAcciones1
INNER JOIN disAcciones disAcciones2 ON (disAcciones2.TipoEvento = disAcciones1.Texto
                                        and disAcciones2.Formulario_Id = disAcciones1.Formulario_Id)
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAcciones1.Formulario_Id 
INNER JOIN disAccionesTablasaEnviar act ON disAcciones2.Formulario_Id = act.Formulario_Id 
											AND disAcciones2.Control_Id = act.Control_Id 
											AND disAcciones2.TipoEvento = act.TipoEvento
											AND disAcciones2.OrdenAccion = act.OrdenAccion 
WHERE (disAcciones1.Accion = 'InvocarMetodo') 
		and (disAcciones1.Accion <> 'DoDefault') and (disAcciones2.Accion <> 'DoDefault')
		AND (disAcciones1.Habilitado = 1)
		AND (disAcciones2.Habilitado = 1)
ORDER BY 1, 2, 3
END

-- Extras, para evitar llamar a mas acciones
SELECT genSegmentoOrigenes.OriSeg_Id, genSegmentoOrigenes.Descripcion
FROM genSegmentoOrigenes  

--obtener todos los posibles segmentos
SELECT Segmento_Id
FROM genSegmentos


-- Obtener configuracion de segmento
SELECT distinct vseg.Segmento_id, vseg.Orden, vseg.Campo, vseg.Tipo, vseg.Digitos, 
	   cast(case when seg.TamanioVariable = cast(vseg.Campo as char(1)) + vseg.Tipo then 1 else 0 end as bit) as EsTamaniovariable,
	   vseg.TieneColumnaAutomatica , vseg.Origen,vseg.Nombre, vseg.HabilitaEdicion 
FROM disControlesSegmento
INNER JOIN vGenSegmentosConfiguracion vseg ON vseg.genSegmentos = disControlesSegmento.Segmento_Id
INNER JOIN genSegmentos seg ON seg.genSegmentos = disControlesSegmento.Segmento_Id
WHERE (disControlesSegmento.Formulario_Id = @liFormulario) 
OR (disControlesSegmento.Formulario_Id in (select Id from @ListaDeFormInscrustados))
ORDER BY 1, 2

--Obtener Atributos generales
SELECT AtributoNro, Descripcion, Tipo
FROM genAtributosGenerales
WHERE Tabla_Id = @lTabla_Id
AND EnGrilla = 1

--Obtener Atributos generales especializacion 
-- solo debo agregar los especializados si el formulario es una especializacion
SELECT AtributoNro, Descripcion, Tipo
FROM genAtributosGenerales
WHERE Tabla_Id = @lTabla_Id
AND @lEspecializacion IS NOT NULL
AND EnGrilla = 0

--Obtener Comentarios, ordenados por fecha de registro
if (@pParaWeb = 0)
begin
SELECT FechaRegistro, FechaRegistroOrig, FechaUltModif, Comentario, /*disformularios.formulario_id as*/ FormularioRegOrig_Id, Comentario_Id, TipoComentario
FROM disFormulariosComentarios
--LEFT JOIN disformularios on disformularios.disformularios = disFormulariosComentarios.FormularioRegOrig_Id
WHERE (disFormulariosComentarios.Formulario_Id = @liFormulario) 
end
else
begin
SELECT FechaRegistro, FechaRegistroOrig, FechaUltModif, Comentario, /*disformularios.formulario_id as*/ FormularioRegOrig_Id, Comentario_Id, TipoComentario
FROM disFormulariosComentarios
--LEFT JOIN disformularios on disformularios.disformularios = disFormulariosComentarios.FormularioRegOrig_Id
WHERE (disFormulariosComentarios.Formulario_Id = -1) 
end


IF (@pParaWeb = 0)
BEGIN
	SELECT disAccionesDescargaEsp.Control_Id, disAccionesDescargaEsp.TipoEvento, disAccionesDescargaEsp.Accion, disAccionesDescargaEsp.ControlDestino_Id, disAccionesDescargaEsp.Texto
	FROM disAccionesDescargaEsp 
	WHERE (Formulario_Id = @liFormulario)
	AND (1 = 0)

	SELECT 	genControlesSeteos.Control_Id, genControlesSeteos.Orden, genControlesSeteos.Valor,  genControlesSeteos.ModificoValor, genControlesSeteos.Deshabilitar, 
		genControlesSeteos.Ocultar, genControlesSeteos.SeteadoPorSistema, genControlesSeteos.Usuario_Id,  disControles.TipoControl, TablasColumnas1.Tabla_Id, TablasColumnas1.Columna_Id
	FROM genControlesSeteos 
	INNER JOIN disControles ON disControles.Formulario_Id = genControlesSeteos.Formulario_Id AND disControles.Control_Id = genControlesSeteos.Control_Id
	LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
	WHERE (genControlesSeteos.Formulario_Id = @liFormulario)
	AND (1 = 0)

END
ELSE 
BEGIN
	SELECT disAccionesDescargaEsp.Control_Id, disAccionesDescargaEsp.TipoEvento, disAccionesDescargaEsp.Accion, disAccionesDescargaEsp.ControlDestino_Id, disAccionesDescargaEsp.Texto
	FROM disAccionesDescargaEsp 
	WHERE (Formulario_Id = @liFormulario)
	ORDER BY 1, 2, 3

	SELECT 	genControlesSeteos.Control_Id, genControlesSeteos.Orden, genControlesSeteos.Valor,  genControlesSeteos.ModificoValor, genControlesSeteos.Deshabilitar, 
		genControlesSeteos.Ocultar, genControlesSeteos.SeteadoPorSistema, genControlesSeteos.Usuario_Id,  disControles.TipoControl, TablasColumnas1.Tabla_Id, TablasColumnas1.Columna_Id
	FROM genControlesSeteos 
	INNER JOIN disControles ON disControles.Formulario_Id = genControlesSeteos.Formulario_Id AND disControles.Control_Id = genControlesSeteos.Control_Id
	LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
	WHERE (genControlesSeteos.Formulario_Id = @liFormulario)
	UNION
	SELECT genControlesSeteos.Control_Id, genControlesSeteos.Orden, genControlesSeteos.Valor,  genControlesSeteos.ModificoValor, genControlesSeteos.Deshabilitar, 
		genControlesSeteos.Ocultar, genControlesSeteos.SeteadoPorSistema, genControlesSeteos.Usuario_Id, 'Columna', '', ''
	FROM genControlesSeteos 
	INNER JOIN disControlesGrillaColumnas c1 ON genControlesSeteos.Formulario_Id = c1.Formulario_Id AND
										(c1.Control_Id + '.' + c1.NombreCampo = genControlesSeteos.Control_Id)
	WHERE (genControlesSeteos.Formulario_Id = @liFormulario)
	order by genControlesSeteos.Orden

END



RETURN @@Error 

GO




DROP PROCEDURE disFormulariosEliminar
GO
CREATE PROCEDURE disFormulariosEliminar
(
@pFormulario_Id varchar(30) = NULL
)
AS
SET NOCOUNT ON 

--Borro antes el control que está asociado al formulario

DELETE FROM disControles 
WHERE Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id)

DELETE FROM disFormularios 
WHERE (Formulario_Id = @pFormulario_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE disFormulariosHijosDatos
GO
CREATE PROCEDURE disFormulariosHijosDatos
(
@pFormulario_Id varchar(30) = NULL
)
AS
SET NOCOUNT ON 

SELECT Formulario_Id
FROM disFormularios 
WHERE (FormularioPadre_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
-- Solo considero los hijos que ya hn pasado algunas vez por el diseñador
AND exists (select 1 from disTablas where Formulario_Id = disFormularios.disFormularios)
 
RETURN @@Error 

GO

DROP PROCEDURE disFormulariosFamiliaDatos
GO
CREATE PROCEDURE disFormulariosFamiliaDatos
(
@pFormulario_Id varchar(30) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lPadreNivel0 int;

	WITH FormulariosPadre (FormularioPadre_Id, disformulario, formulario_Id, nivel)
    AS
    (
        SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, 0 AS nivel
        FROM disFormularios AS e
        WHERE Formulario_Id = @pFormulario_Id
        UNION ALL
        SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, nivel + 1
        FROM disFormularios AS e
        INNER JOIN FormulariosPadre AS d
            ON e.disFormularios = d.FormularioPadre_Id
    )


    -- Statement that executes the CTE
    SELECT  @lPadreNivel0 = disFormulario
    FROM FormulariosPadre
    --WHERE title = N'Sales and Marketing' OR Level = 0;
	WHERE FormularioPadre_Id IS NULL;


	WITH FormulariosFamiliares (FormularioPadre_Id, disFormularios, Formulario_Id, Nivel)
    AS
    (
    -- Anchor member definition
        SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, 0 AS Nivel
        FROM disFormularios AS e
        WHERE disFormularios = @lPadreNivel0
        UNION ALL
    -- Recursive member definition
        SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, Nivel + 1
        FROM disFormularios AS e
        INNER JOIN FormulariosFamiliares AS d
            ON e.FormularioPadre_Id = d.disFormularios
    )
    -- Statement that executes the CTE
    SELECT distinct FormularioPadre_Id, disFormularios, Formulario_Id, Nivel
    FROM FormulariosFamiliares
	order by nivel
 
RETURN @@Error 

GO


DROP PROCEDURE disFormulariosFamiliaTodaActualizar
GO
CREATE PROCEDURE disFormulariosFamiliaTodaActualizar
(
@pFormulario_Id varchar(30) = NULL
)
AS
SET NOCOUNT ON 
--DECLARE @lPadreNivel0 int;
DECLARE @lFormIdentity int;
DECLARE @lVersion varchar(10);
DECLARE @lFormsDescendientes Table (Id int)

	select @lFormIdentity = disFormularios.disFormularios, @lVersion = isnull(disFormularios.Version,'') from disFormularios where Formulario_Id = @pFormulario_Id;
	
	---- Busco el padre del formulario, nivel 0
	--WITH FormulariosPadre (FormularioPadre_Id, disformulario, formulario_Id, nivel)
 --   AS
 --   (
 --       SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, 0 AS nivel
 --       FROM disFormularios AS e
 --       WHERE Formulario_Id = @pFormulario_Id
 --       UNION ALL
 --       SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, nivel + 1
 --       FROM disFormularios AS e
 --       INNER JOIN FormulariosPadre AS d
 --           ON e.disFormularios = d.FormularioPadre_Id
 --   )

	-- -- Statement that executes the CTE
 --   SELECT  @lPadreNivel0 = disFormulario
 --   FROM FormulariosPadre
 --   --WHERE title = N'Sales and Marketing' OR Level = 0;
	--WHERE FormularioPadre_Id IS NULL;

	---- Marco como modificado todos los descendientes del padre nivel 0, o sea, todos los familiares del formulario modificado
	--WITH FormulariosFamiliares (FormularioPadre_Id, disFormularios, Formulario_Id, Nivel)
 --   AS
 --   (
 --   -- Anchor member definition
 --       SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, 0 AS Nivel
 --       FROM disFormularios AS e
 --       WHERE disFormularios = @lPadreNivel0
 --       UNION ALL
 --   -- Recursive member definition
 --       SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, Nivel + 1
 --       FROM disFormularios AS e
 --       INNER JOIN FormulariosFamiliares AS d
 --           ON e.FormularioPadre_Id = d.disFormularios
 --   )
 --   -- Statement that executes the CTE
	--update disFormularios
	--set UltimaModif = getDate()
	--where exists (select 1 from FormulariosFamiliares where  FormulariosFamiliares.disFormularios = disFormularios.disFormularios);

	--Busco todos los descendientes del formulario modificado y cambio version
	WITH FormulariosDescendientes1 (disformulario)
    AS
    (
        SELECT e.disFormularios
        FROM disFormularios AS e
        WHERE FormularioPadre_Id = @lFormIdentity
        UNION ALL
        SELECT e.disFormularios
        FROM disFormularios AS e
        INNER JOIN FormulariosDescendientes1 AS d
            ON e.FormularioPadre_Id = d.disformulario
    )

	 -- Statement that executes the CTE
	update disFormularios
	set Version = @lVersion, UltimaModif = getDate()
	where exists (select 1 from FormulariosDescendientes1 where  FormulariosDescendientes1.disFormulario = disFormularios.disFormularios)
	and isnull(version, '') < @lVersion;

	----Busco todos los descendientes del formulario modificado
	--WITH FormulariosDescendientes (disformulario)
 --   AS
 --   (
 --       SELECT e.disFormularios
 --       FROM disFormularios AS e
 --       WHERE FormularioPadre_Id = @lFormIdentity
 --       UNION ALL
 --       SELECT e.disFormularios
 --       FROM disFormularios AS e
 --       INNER JOIN FormulariosDescendientes AS d
 --           ON e.FormularioPadre_Id = d.disformulario
 --   )

	-- -- Statement that executes the CTE
	--insert @lFormsDescendientes (Id)
 --   SELECT  disFormulario
 --   FROM FormulariosDescendientes;


	----Agrego comentario a todos los familiares, excepto al formulario modificado y a sus descendientes
	--WITH FormulariosFamiliares2 (FormularioPadre_Id, disFormularios, Formulario_Id, Nivel)
 --   AS
 --   (
 --   -- Anchor member definition
 --       SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, 0 AS Nivel
 --       FROM disFormularios AS e
 --       WHERE disFormularios = @lPadreNivel0
 --       UNION ALL
 --   -- Recursive member definition
 --       SELECT e.FormularioPadre_Id, e.disFormularios, e.Formulario_Id, Nivel + 1
 --       FROM disFormularios AS e
 --       INNER JOIN FormulariosFamiliares2 AS d
 --           ON e.FormularioPadre_Id = d.disFormularios
 --   )
 --   -- Statement that executes the CTE
	--insert into disFormulariosComentarios (Formulario_Id, FechaRegistro, FechaRegistroOrig, FechaUltModif, Comentario, FormularioRegOrig_Id)
	--select FormulariosFamiliares2.disFormularios, GETDATE(), GETDATE(), GETDATE(), 'Actualizado por Cambio en Familiar', /*@lFormIdentity*/ @pFormulario_Id
	--from FormulariosFamiliares2
	--where (FormulariosFamiliares2.disFormularios <> @lFormIdentity)
	--and not exists (select 1 from @lFormsDescendientes fd where fd.Id = FormulariosFamiliares2.disFormularios)
	--and not exists (select 1 from disFormulariosComentarios 
	--						where Formulario_Id = FormulariosFamiliares2.disFormularios AND 
	--						cast(FechaUltModif as date) = cast(GETDATE() as date) AND  
	--						Comentario = 'Actualizado por Cambio en Familiar')

RETURN @@Error 
GO




DROP FUNCTION FuncFKdisFormularios
GO

CREATE FUNCTION FuncFKdisFormularios
(
@pFormulario_Id varchar (30)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = disFormularios 
  FROM disFormularios 
  WHERE Formulario_Id = @pFormulario_Id
  RETURN @pIdentity
END


GO

DROP TRIGGER truUltimaModif_disFormularios
GO
CREATE TRIGGER truUltimaModif_disFormularios
ON disFormularios
AFTER UPDATE 
AS
BEGIN
    IF NOT UPDATE(UltimaModif)
    BEGIN
        UPDATE t
            SET t.UltimaModif = dbo.FechaActual()
            FROM disFormularios AS t 
            INNER JOIN inserted AS i 
            ON t.disFormularios = i.disFormularios;
    END
END
GO


DROP PROCEDURE disFormulariosExiste
GO
CREATE PROCEDURE [dbo].[disFormulariosExiste]
(
@pFormulario_Id varchar(30)
)
AS

SELECT disFormularios.disFormularios, disFormularios.Formulario_Id, disFormularios.Descripcion, disFormularios.Alto,
	disFormularios.Ancho, disFormularios.Arriba, disFormularios.Izquierda, disFormularios.Titulo, disFormularios.PosicionInicial,
	disFormularios.BotonNuevo, disFormularios.BotonGuardar, disFormularios.BotonPostear,
	disFormularios.BotonEliminar, disFormularios.BotonImprimir, disFormularios.GuardaeImprime,
	disFormularios.Tabla_Id, disFormularios.DllCommon, disFormularios.ClaseCommon,
	disFormularios.DllExchange, disFormularios.ClaseExchange, disFormularios.ClaseEnum,
	disFormularios.DllEventos, disFormularios.ClaseEventos, CAST(0 AS BIT) as ParaWeb,
	disFormularios.Posteado, disFormularios.Inactivo, disFormularios.Usuario_Id,
	FormPadre.Formulario_Id as FormularioPadre_Id, ISNULL(disControles.TipoControl, 'frm') as TipoFormulario, 
	disFormularios.BotonRptVer, disFormularios.BotonRptImprimir, disFormularios.BotonRptPdf, disFormularios.BotonRptXls
FROM disFormularios 
LEFT JOIN disFormularios FormPadre ON FormPadre.disFormularios = disFormularios.FormularioPadre_Id
LEFT JOIN disControles ON disControles.Formulario_Id = disFormularios.disFormularios AND disControles.Control_Id = disFormularios.Formulario_Id
WHERE disFormularios.disFormularios = dbo.FuncFKdisFormularios(@pFormulario_Id)
Go

DROP PROCEDURE disFormulariosPadresTodos 
GO
CREATE PROCEDURE disFormulariosPadresTodos 
AS

select Formulario_id, Descripcion 
from disFormularios
Where (inactivo = 0) and (FormularioPadre_Id is null)
ORDER BY 1

GO


DROP PROCEDURE tempdisDisenioBorrar
GO
CREATE PROCEDURE tempdisDisenioBorrar
AS

SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesBotonLupa'))
BEGIN
DROP TABLE TempdisControlesBotonLupa
END

SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesBotonSegmento'))
BEGIN
DROP TABLE TempdisControlesBotonSegmento
END


SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesBoton'))
BEGIN
DROP TABLE TempdisControlesBoton
END

SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesGrillaPivot'))
BEGIN
DROP TABLE TempdisControlesGrillaPivot
END

SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesIndicador'))
BEGIN
DROP TABLE TempdisControlesIndicador
END



SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesLink'))
BEGIN
DROP TABLE TempdisControlesLink
END

SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesIndicador'))
BEGIN
DROP TABLE TempdisControlesIndicador
END


SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesListaAdjuntos'))
BEGIN
DROP TABLE TempdisControlesListaAdjuntos
END

SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesGraficoTorta'))
BEGIN
DROP TABLE TempdisControlesGraficoTorta
END

SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesGrafico'))
BEGIN
DROP TABLE TempdisControlesGrafico
END


SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisAcciones'))
BEGIN
DROP TABLE TempdisAcciones 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisAccionesTablasaActualizar'))
BEGIN
DROP TABLE TempdisAccionesTablasaActualizar
END
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisAccionesTablasaEnviar'))
BEGIN
DROP TABLE TempdisAccionesTablasaEnviar
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControles'))
BEGIN
DROP TABLE TempdisControles 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesCheckBox'))
BEGIN
DROP TABLE TempdisControlesCheckBox
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesColumnaSolapa'))
BEGIN
DROP TABLE TempdisControlesColumnaSolapa
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesCombo'))
BEGIN
DROP TABLE TempdisControlesCombo 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesComboItems'))
BEGIN
DROP TABLE TempdisControlesComboItems
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesFecha'))
BEGIN
DROP TABLE TempdisControlesFecha 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesFilaSolapa'))
BEGIN
DROP TABLE TempdisControlesFilaSolapa
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesGrilla'))
BEGIN
DROP TABLE TempdisControlesGrilla 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesGrillaColumnas'))
BEGIN
DROP TABLE TempdisControlesGrillaColumnas
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesGrupoSolapa'))
BEGIN
DROP TABLE TempdisControlesGrupoSolapa
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesLupa'))
BEGIN
DROP TABLE TempdisControlesLupa
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesNumerico'))
BEGIN
DROP TABLE TempdisControlesNumerico
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesParametros'))
BEGIN
DROP TABLE TempdisControlesParametros
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesReferencia'))
BEGIN
DROP TABLE TempdisControlesReferencia
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesRefSolapa'))
BEGIN
DROP TABLE TempdisControlesRefSolapa 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesSegmento'))
BEGIN
DROP TABLE TempdisControlesSegmento 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesSolapa'))
BEGIN
DROP TABLE TempdisControlesSolapa 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesTexto'))
BEGIN
DROP TABLE TempdisControlesTexto 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisControlesUpLoad'))
BEGIN
DROP TABLE TempdisControlesUpLoad 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisEventos'))
BEGIN
DROP TABLE TempdisEventos 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisFormularios'))
BEGIN
DROP TABLE TempdisFormularios 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisFormulariosParametros'))
BEGIN
DROP TABLE TempdisFormulariosParametros 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisRelacionesTablas'))
BEGIN
DROP TABLE TempdisRelacionesTablas 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisTablas'))
BEGIN
DROP TABLE TempdisTablas 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisTablasColumnas'))
BEGIN
DROP TABLE TempdisTablasColumnas 
END

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisFormulariosComentarios'))
BEGIN
DROP TABLE TempdisFormulariosComentarios 
END

SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TempdisAccionesDescargaEsp'))
BEGIN
DROP TABLE TempdisAccionesDescargaEsp
END


GO


DROP PROCEDURE TempdisDisenioCopiarActual
GO
CREATE PROCEDURE TempdisDisenioCopiarActual
AS
SET NOCOUNT ON 

--Primero elimino todo lo que pudiera existir en temporal
exec tempdisDisenioBorrar

--INSERT INTO TempdisAcciones (Formulario_Id, Control_Id, TipoEvento, OrdenAccion, Accion, ControlDestino_Id,
--			Texto, ControlTexto_Id, ValorCondicion, Accion_Id, AccionPadre_Id, Heredado,
--			Habilitado, EsEspecializacion, AdicionalInfo)
--SELECT Formulario_Id, Control_Id, TipoEvento, OrdenAccion, Accion, ControlDestino_Id,
--		Texto, ControlTexto_Id, ValorCondicion, Accion_Id, AccionPadre_Id, Heredado,
--		Habilitado, EsEspecializacion, AdicionalInfo
SELECT *
INTO dbo.TempdisAcciones
FROM disAcciones


--INSERT INTO TempdisAccionesTablasaActualizar (Formulario_Id, Control_Id, TipoEvento , OrdenAccion, Tabla_Id )
--SELECT Formulario_Id, Control_Id, TipoEvento , OrdenAccion, Tabla_Id  
SELECT *
INTO dbo.TempdisAccionesTablasaActualizar
FROM disAccionesTablasaActualizar


--INSERT INTO TempdisAccionesTablasaEnviar (Formulario_Id, Control_Id, TipoEvento, OrdenAccion, Tabla_Id)
--SELECT Formulario_Id, Control_Id, TipoEvento, OrdenAccion, Tabla_Id  
SELECT *
INTO dbo.TempdisAccionesTablasaEnviar
FROM disAccionesTablasaEnviar


--INSERT INTO TempdisControles (Formulario_Id, Control_Id, NroControl, ControlParent_Id, TipoControl, Alto, Ancho, Arriba, Izquierda, Texto, Visible,
--	  Habilitado, Alineacion, TabStop, TabOrden, Requerido, Embebido, Ancla, EsCodigoNuevo, Paises, Fila, Columna, FilasExtension,
--	  ColumnasExtension, MaximaLongitud, ClickNuevoBlanquea, ControlaCambios, SoloLectura, TextoFijo, TextoControlVacio,
--	  Estilo, TituloLabel, AlineacionLabel, IgualaAnchoColumna, ControlSegmento, Heredado, SegmentoOrigen)
--SELECT Formulario_Id, Control_Id, NroControl, ControlParent_Id, TipoControl, Alto, Ancho, Arriba, Izquierda, Texto, Visible,
--	  Habilitado, Alineacion, TabStop, TabOrden, Requerido, Embebido, Ancla, EsCodigoNuevo, Paises, Fila, Columna, FilasExtension,
--	  ColumnasExtension, MaximaLongitud, ClickNuevoBlanquea, ControlaCambios, SoloLectura, TextoFijo, TextoControlVacio,
--	  Estilo, TituloLabel, AlineacionLabel, IgualaAnchoColumna, ControlSegmento, Heredado, SegmentoOrigen
SELECT *
INTO dbo.TempdisControles
FROM disControles


--INSERT INTO TempdisControlesCheckBox (Formulario_Id, Control_Id, Checked)
--SELECT Formulario_Id, Control_Id, Checked  
SELECT *
INTO dbo.TempdisControlesCheckBox
FROM disControlesCheckBox


--INSERT INTO TempdisControlesColumnaSolapa (Formulario_Id, Control_Id, Columna, Ancho, TipoValor)
--SELECT Formulario_Id, Control_Id, Columna, Ancho, TipoValor
SELECT *
INTO dbo.TempdisControlesColumnaSolapa
FROM disControlesColumnaSolapa


--INSERT INTO TempdisControlesCombo (Formulario_Id, Control_Id, MultiSeleccion, CheckBoxes, Identidad, Identidad_Id, EsOptionGroup, OptionGroupHorizontal)
--SELECT Formulario_Id, Control_Id, MultiSeleccion, CheckBoxes, Identidad, Identidad_Id, EsOptionGroup, OptionGroupHorizontal
SELECT *
INTO dbo.TempdisControlesCombo
FROM disControlesCombo


--INSERT INTO TempdisControlesComboItems (Formulario_Id, Control_Id, Valor, Descripcion, Tipo)
--SELECT Formulario_Id, Control_Id, Valor, Descripcion, Tipo
SELECT *
INTO dbo.TempdisControlesComboItems 
FROM disControlesComboItems


--INSERT INTO TempdisControlesFecha (Formulario_Id, Control_Id, ValorMinimo, ValorMaximo, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima)
--SELECT Formulario_Id, Control_Id, ValorMinimo, ValorMaximo, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima
SELECT *
INTO dbo.TempdisControlesFecha
FROM disControlesFecha


--INSERT INTO TempdisControlesFilaSolapa (Formulario_Id, Control_Id, Fila, Alto, TipoValor)
--SELECT Formulario_Id, Control_Id, Fila, Alto, TipoValor  
SELECT *
INTO dbo.TempdisControlesFilaSolapa
FROM disControlesFilaSolapa


--INSERT INTO TempdisControlesGrilla (Formulario_Id, Control_Id, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, EditaEnGrilla, RegistrosxPagina, 
--		AutoFormateable, EsGrillaAdjuntos, EsArbol, AccionNuevoValorNodo)
--SELECT Formulario_Id, Control_Id, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, EditaEnGrilla, RegistrosxPagina, 
--		AutoFormateable, EsGrillaAdjuntos, EsArbol, AccionNuevoValorNodo
SELECT *
INTO dbo.TempdisControlesGrilla
FROM disControlesGrilla


--INSERT INTO TempdisControlesGrillaColumnas (Formulario_Id, Control_Id, NombreCampo, Posicion, Titulo, TipoDato, Formato, Visible, ControlColumna_Id, Ancho, AnchoVariable,
--		Alineacion, SoloLectura, ModoTamanioVariable, CongelarTamanio, AnchoMinimo, ModoOrdenamiento, TextoColumnaVacia, Texto, 
--		EsParamAccionBoton, Heredado, Requerido, AutoNumerico, EsPrimaryKey, ItemsCombo, Identidad_Id)
--SELECT Formulario_Id, Control_Id, NombreCampo, Posicion, Titulo, TipoDato, Formato, Visible, ControlColumna_Id, Ancho, AnchoVariable,
--		Alineacion, SoloLectura, ModoTamanioVariable, CongelarTamanio, AnchoMinimo, ModoOrdenamiento, TextoColumnaVacia, Texto, 
--		EsParamAccionBoton, Heredado, Requerido, AutoNumerico, EsPrimaryKey, ItemsCombo, Identidad_Id
SELECT *
INTO dbo.TempdisControlesGrillaColumnas
FROM disControlesGrillaColumnas


--INSERT INTO TempdisControlesGrupoSolapa (Formulario_Id, Control_Id, CantSolapas )
--SELECT Formulario_Id, Control_Id, CantSolapas 
SELECT *
INTO dbo.TempdisControlesGrupoSolapa 
FROM disControlesGrupoSolapa


--INSERT INTO TempdisControlesLupa (Formulario_Id, Control_Id, CamposClave, CantMaxRegAMostrar, EsLaEntidadDelForm, OrderBy, TraePrimerRegistro, UsaAccion, DescripcionCharCasing,
--	DescripcionMaxLength, DescripcionTexto, DescripcionOculta, ColumnaGrillaDescripcion, Identidad_Id, Filtros, CodigoTipo, CodigoCharCasing, CodigoMask,
--	CodigoRegExpression, CodigoMaxLength, CodigoTexto, CodigoWidth, CodigoNombreColumna, AdicionalesCampos, AdicionalesControles,
--	AdicionalesParametros, PermiteNoExistentes)
--SELECT Formulario_Id, Control_Id, CamposClave, CantMaxRegAMostrar, EsLaEntidadDelForm, OrderBy, TraePrimerRegistro, UsaAccion, DescripcionCharCasing,
--	DescripcionMaxLength, DescripcionTexto, DescripcionOculta, ColumnaGrillaDescripcion, Identidad_Id, Filtros, CodigoTipo, CodigoCharCasing, CodigoMask,
--	CodigoRegExpression, CodigoMaxLength, CodigoTexto, CodigoWidth, CodigoNombreColumna, AdicionalesCampos, AdicionalesControles,
--	AdicionalesParametros, PermiteNoExistentes
SELECT *
INTO dbo.TempdisControlesLupa
  FROM disControlesLupa


--INSERT INTO TempdisControlesNumerico (Formulario_Id, Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje)
--SELECT Formulario_Id, Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje
SELECT *
INTO dbo.TempdisControlesNumerico
  FROM disControlesNumerico


--INSERT INTO TempdisControlesParametros (Formulario_Id, Control_Id, TipoDato)
--SELECT Formulario_Id, Control_Id, TipoDato
SELECT *
INTO dbo.TempdisControlesParametros
  FROM disControlesParametros


--INSERT INTO TempdisControlesReferencia (Formulario_Id, Control_Id, FormularioPopup_Id, TieneBtnCerrar, TieneBtnGuardar, TablaPrimaria, Parametros, TamanioPopup)
--SELECT Formulario_Id, Control_Id, FormularioPopup_Id, TieneBtnCerrar, TieneBtnGuardar, TablaPrimaria, Parametros, TamanioPopup
SELECT *
INTO dbo.TempdisControlesReferencia
  FROM disControlesReferencia


--INSERT INTO TempdisControlesRefSolapa (Formulario_Id, Control_Id, ControlSolapaRef_Id)
--SELECT Formulario_Id, Control_Id, ControlSolapaRef_Id
SELECT *
INTO dbo.TempdisControlesRefSolapa
  FROM disControlesRefSolapa


--INSERT INTO TempdisControlesSegmento (Formulario_Id, Control_Id, Segmento_Id, Identidad_Id, EsLaEntidadDelForm, Filtros)
--SELECT Formulario_Id, Control_Id, Segmento_Id, Identidad_Id, EsLaEntidadDelForm, Filtros
SELECT *
INTO dbo.TempdisControlesSegmento
  FROM disControlesSegmento


--INSERT INTO TempdisControlesSolapa (Formulario_Id, Control_Id, Posicion, CantFilas, CantColumnas, FormularioPopup_Id, TieneBtnCerrar, TieneBtnGuardar, TablaPrimaria,
--		Parametros, TipoPopup, TamanioPopup)
--SELECT Formulario_Id, Control_Id, Posicion, CantFilas, CantColumnas, FormularioPopup_Id, TieneBtnCerrar, TieneBtnGuardar, TablaPrimaria,
--		Parametros, TipoPopup, TamanioPopup  
SELECT *
INTO dbo.TempdisControlesSolapa
FROM disControlesSolapa


--INSERT INTO TempdisControlesTexto (Formulario_Id, Control_Id, MultiplesLineas, CharCasing)
--SELECT Formulario_Id, Control_Id, MultiplesLineas, CharCasing  
SELECT * 
INTO dbo.TempdisControlesTexto
FROM disControlesTexto


--INSERT INTO TempdisControlesUpLoad (Formulario_Id, Control_Id, GuardaCaminoCompleto, ColumnaNombreInterno, ExtensionesPermitidas)
--SELECT Formulario_Id, Control_Id, GuardaCaminoCompleto, ColumnaNombreInterno, ExtensionesPermitidas  
SELECT *
INTO dbo.TempdisControlesUpLoad
FROM disControlesUpLoad

--INSERT INTO TempdisEventos (Formulario_Id, Control_Id, TipoEvento, EsMetodo, Heredado, Habilitado)
--SELECT Formulario_Id, Control_Id, TipoEvento, EsMetodo, Heredado, Habilitado
SELECT *
INTO dbo.TempdisEventos
  FROM disEventos


--INSERT INTO TempdisFormularios (disFormularios, Formulario_Id, Descripcion, Alto, Ancho, Arriba, Izquierda, Titulo, PosicionInicial, BotonNuevo,
--		BotonGuardar, BotonPostear, BotonEliminar, BotonImprimir, GuardaeImprime, Tabla_Id, DllCommon, ClaseCommon, DllExchange,
--		ClaseExchange, ClaseEnum, DllEventos, ClaseEventos, UltimaModif, FormularioPadre_Id, Inactivo, Usuario_Id, Posteado, 
--		BotonRptVer, BotonRptImprimir, BotonRptPdf, BotonRptXls, Especializacion, DllCommonEsp, ClaseCommonEsp, DllExchangeEsp,
--		ClaseExchangeEsp, ClaseEnumEsp, DllEventosEsp, ClaseEventosEsp, Version  )
--SELECT disFormularios, Formulario_Id, Descripcion, Alto, Ancho, Arriba, Izquierda, Titulo, PosicionInicial, BotonNuevo,
--		BotonGuardar, BotonPostear, BotonEliminar, BotonImprimir, GuardaeImprime, Tabla_Id, DllCommon, ClaseCommon, DllExchange,
--		ClaseExchange, ClaseEnum, DllEventos, ClaseEventos, UltimaModif, FormularioPadre_Id, Inactivo, Usuario_Id, Posteado, 
--		BotonRptVer, BotonRptImprimir, BotonRptPdf, BotonRptXls, Especializacion, DllCommonEsp, ClaseCommonEsp, DllExchangeEsp,
--		ClaseExchangeEsp, ClaseEnumEsp, DllEventosEsp, ClaseEventosEsp, Version  
SELECT *
INTO dbo.TempdisFormularios
FROM disFormularios


--INSERT INTO TempdisFormulariosParametros (Formulario_Id, Control_Id, TipoDato)
--SELECT Formulario_Id, Control_Id, TipoDato
SELECT *
INTO dbo.TempdisFormulariosParametros
  FROM disFormulariosParametros


--INSERT INTO TempdisRelacionesTablas (Formulario_Id, TablaMaster_Id, TablaDetalle_Id, ColumnaMaster_Id, ColumnaMaster2_Id, ColumnaMaster3_Id, ColumnaDetalle_Id, 
--	ColumnaDetalle2_Id, ColumnaDetalle3_Id)
--SELECT Formulario_Id, TablaMaster_Id, TablaDetalle_Id, ColumnaMaster_Id, ColumnaMaster2_Id, ColumnaMaster3_Id, ColumnaDetalle_Id, 
--	ColumnaDetalle2_Id, ColumnaDetalle3_Id  
SELECT *
INTO dbo.TempdisRelacionesTablas
FROM disRelacionesTablas


--INSERT INTO TempdisTablas (Formulario_Id, Tabla_Id, TipoControl, Control_Id, EsEspecializacion)
--SELECT Formulario_Id, Tabla_Id, TipoControl, Control_Id, EsEspecializacion
SELECT *
INTO dbo.TempdisTablas
  FROM disTablas


--INSERT INTO TempdisTablasColumnas (Formulario_Id, Tabla_Id, Columna_Id, TipoControl, Control_Id, AdicionalControl, EsEspecializacion)
--SELECT Formulario_Id, Tabla_Id, Columna_Id, TipoControl, Control_Id, AdicionalControl, EsEspecializacion  
SELECT *
INTO dbo.TempdisTablasColumnas
FROM disTablasColumnas


SELECT *
INTO dbo.TempdisFormulariosComentarios
FROM disFormulariosComentarios

SELECT *
INTO dbo.TempdisControlesGrafico
FROM disControlesGrafico

SELECT *
INTO dbo.TempdisControlesGraficoTorta
FROM disControlesGraficoTorta

SELECT *
INTO dbo.TempdisControlesListaAdjuntos
FROM disControlesListaAdjuntos

SELECT *
INTO dbo.TempdisControlesBoton
FROM disControlesBoton

SELECT *
INTO dbo.TempdisControlesBotonLupa
FROM disControlesBotonLupa

SELECT *
INTO dbo.TempdisControlesBotonSegmento
FROM disControlesBotonSegmento


SELECT *
INTO dbo.TempdisControlesLink
FROM disControlesLink

SELECT *
INTO dbo.TempdisControlesGrillaPivot
FROM disControlesGrillaPivot

SELECT *
INTO dbo.TempdisControlesIndicador
FROM disControlesIndicador

SELECT *
INTO dbo.TempdisAccionesDescargaEsp
FROM disAccionesDescargaEsp


GO


DROP PROCEDURE TempdisFormulariosDatos
GO
CREATE PROCEDURE tempdisFormulariosDatos
(
@pFormulario_Id varchar(30)
)
AS

DECLARE @liFormulario int
DECLARE @lSegmento_Id int
DECLARE @lLongTotalSegmento int
--DECLARE @ListaDeFormularios Table (Id int, SolapaInvocante varchar(200))
--DECLARE @ListaDeFormInscrustados Table (Id int, ControlReferencia varchar(200), Parametros varchar(512))
DECLARE @CantSolapasOrig int
DECLARE @lTabla_Id varchar(60)
DECLARE @lEspecializacion varchar(80)

SET NOCOUNT ON   


SET @liFormulario = dbo.FuncFKdisFormularios(@pFormulario_Id)

--SET @lTabla_Id = (SELECT Tabla_Id FROM tempdisFormularios WHERE (tempdisFormularios.disFormularios = @liFormulario))
SELECT @lTabla_Id = Tabla_Id, @lEspecializacion= Especializacion FROM tempdisFormularios WHERE (tempdisFormularios.disFormularios = @liFormulario)

SELECT tempdisFormularios.disFormularios, tempdisFormularios.Formulario_Id, tempdisFormularios.Descripcion, tempdisFormularios.Alto,
	tempdisFormularios.Ancho, tempdisFormularios.Arriba, tempdisFormularios.Izquierda, tempdisFormularios.Titulo, tempdisFormularios.PosicionInicial,
	tempdisFormularios.BotonNuevo, tempdisFormularios.BotonGuardar, tempdisFormularios.BotonPostear,
	tempdisFormularios.BotonEliminar, tempdisFormularios.BotonImprimir, tempdisFormularios.GuardaeImprime,
	tempdisFormularios.Tabla_Id, tempdisFormularios.DllCommon, tempdisFormularios.ClaseCommon,
	tempdisFormularios.DllExchange, tempdisFormularios.ClaseExchange, tempdisFormularios.ClaseEnum,
	tempdisFormularios.DllEventos, tempdisFormularios.ClaseEventos, CAST(0 AS BIT) as ParaWeb,
	tempdisFormularios.Posteado, tempdisFormularios.Inactivo, tempdisFormularios.Usuario_Id,
	FormPadre.Formulario_Id as FormularioPadre_Id, ISNULL(tempdisControles.TipoControl, 'frm') as TipoFormulario,
	tempdisFormularios.BotonRptVer, tempdisFormularios.BotonRptImprimir, tempdisFormularios.BotonRptPdf, tempdisFormularios.BotonRptXls, 
	tempdisFormularios.Especializacion, tempdisFormularios.DllCommonEsp, tempdisFormularios.ClaseCommonEsp,
	tempdisFormularios.DllExchangeEsp, tempdisFormularios.ClaseExchangeEsp, tempdisFormularios.ClaseEnumEsp,
	tempdisFormularios.DllEventosEsp, tempdisFormularios.ClaseEventosEsp, tempdisFormularios.Version, Cast(1 as Bit) as Temporal,
	tempdisFormularios.TipoEspecial, TempdisFormularios.BotonCopiar,TempdisFormularios.CodigoLnk, TempdisFormularios.AnulaAccionesEliminarDefault
FROM tempdisFormularios 
LEFT JOIN tempdisFormularios FormPadre ON FormPadre.disFormularios = tempdisFormularios.FormularioPadre_Id
LEFT JOIN tempdisControles ON tempdisControles.Formulario_Id = tempdisFormularios.disFormularios AND tempdisControles.Control_Id = tempdisFormularios.Formulario_Id
WHERE (tempdisFormularios.disFormularios = @liFormulario)

-- Grupos Solapas
SELECT tempdisControlesGrupoSolapa.Control_Id, tempdisControlesGrupoSolapa.CantSolapas
FROM tempdisControlesGrupoSolapa 
WHERE (Formulario_Id = @liFormulario)

SET @CantSolapasOrig = (SELECT count(*) FROM tempdisControlesSolapa WHERE (tempdisControlesSolapa.Formulario_Id = @liFormulario))

-- Solapas
SELECT tempdisControlesSolapa.Control_Id, tempdisControlesSolapa.Posicion,	tempdisControlesSolapa.CantFilas, tempdisControlesSolapa.CantColumnas,
tempdisControlesSolapa.TipoPopup, tempdisFormularios.Formulario_Id as FormularioPopup_Id, tempdisControlesSolapa.TieneBtnCerrar, tempdisControlesSolapa.TieneBtnGuardar,
tempdisControlesSolapa.TablaPrimaria, 
tempdisControlesSolapa.Parametros, tempdisControlesSolapa.TamanioPopup, cast(null as varchar(200)) as ControlReferencia
FROM tempdisControlesSolapa 
LEFT JOIN tempdisFormularios ON tempdisFormularios.disFormularios = tempdisControlesSolapa.FormularioPopup_Id
WHERE (tempdisControlesSolapa.Formulario_Id = @liFormulario)
ORDER BY tempdisControlesSolapa.Posicion



-- Columnas Solapas
SELECT tempdisControlesColumnaSolapa.Control_Id, tempdisControlesColumnaSolapa.Columna,	tempdisControlesColumnaSolapa.Ancho, 
	tempdisControlesColumnaSolapa.TipoValor
FROM tempdisControlesColumnaSolapa 
INNER JOIN tempdisControlesSolapa ON tempdisControlesSolapa.Formulario_Id = tempdisControlesColumnaSolapa.Formulario_Id 
							AND tempdisControlesSolapa.Control_Id = tempdisControlesColumnaSolapa.Control_Id
WHERE (tempdisControlesColumnaSolapa.Formulario_Id = @liFormulario)
--AND ((tempdisControlesSolapa.FormularioPopup_Id IS NULL) OR (@pParaWeb = 0))
ORDER BY 1,2


-- Filas Solapas
SELECT tempdisControlesFilaSolapa.Control_Id, tempdisControlesFilaSolapa.Fila, tempdisControlesFilaSolapa.Alto, 
tempdisControlesFilaSolapa.TipoValor
FROM tempdisControlesFilaSolapa 
INNER JOIN tempdisControlesSolapa ON tempdisControlesSolapa.Formulario_Id = tempdisControlesFilaSolapa.Formulario_Id 
							AND tempdisControlesSolapa.Control_Id = tempdisControlesFilaSolapa.Control_Id
WHERE (tempdisControlesFilaSolapa.Formulario_Id = @liFormulario)
--AND ((disControlesSolapa.FormularioPopup_Id IS NULL) OR (@pParaWeb = 0))
ORDER BY 1,2

-- Celdas
/**
SELECT disControlesCelda.Control_Id, disControlesCelda.NombrePanel,	disControlesCelda.Fila, 
	disControlesCelda.Columna, disControlesCelda.FilasExtension, disControlesCelda.ColumnasExtension, disControles.ControlParent_Id
FROM disControlesCelda 
INNER JOIN disControles ON disControles.Control_Id = disControlesCelda.Control_Id AND disControlesCelda.Formulario_Id = disControles.Formulario_Id
WHERE (disControlesCelda.Formulario_Id = @liFormulario)
ORDER BY disControles.ControlParent_Id, disControlesCelda.Fila, disControlesCelda.Columna
**/

--Controles
SELECT tempdisControles.Control_Id, tempdisControles.NroControl, tempdisControles.ControlParent_Id, 
		tempdisControles.TipoControl, tempdisControles.Alto, tempdisControles.Ancho, 
		tempdisControles.Arriba, tempdisControles.Izquierda, tempdisControles.Texto, 
		tempdisControles.Visible, tempdisControles.Habilitado, tempdisControles.Alineacion,
		tempdisControles.TabStop, tempdisControles.TabOrden, tempdisControles.Requerido, 
		TablasColumnas1.Tabla_Id NombreTabla, TablasColumnas1.Columna_Id NombreColumna, 
		tempdisControles.Embebido, 
		tempdisControles.Ancla, tempdisControles.EsCodigoNuevo, tempdisControles.Paises, tempdisControles.Fila, 
		tempdisControles.Columna, tempdisControles.FilasExtension, tempdisControles.ColumnasExtension,
		tempdisControles.MaximaLongitud, tempdisControles.ClickNuevoBlanquea, tempdisControles.ControlaCambios, 
		tempdisControles.SoloLectura, tempdisControles.TextoFijo, tempdisControles.TextoControlVacio,
		tempdisControles.Estilo, tempdisControles.TituloLabel, tempdisControles.AlineacionLabel, tempdisControles.IgualaAnchoColumna,
		tempdisControles.SegmentoOrigen, tempdisControles.ControlSegmento, tempdisControles.Heredado
FROM tempdisControles 
LEFT JOIN tempdisTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = tempdisControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = tempdisControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
WHERE (tempdisControles.Formulario_Id = @liFormulario)
ORDER BY tempdisControles.Fila, tempdisControles.Columna, tempdisControles.NroControl

--Check Box
SELECT tempdisControlesCheckBox.Control_Id, tempdisControlesCheckBox.Checked
FROM tempdisControlesCheckBox 
WHERE (Formulario_Id = @liFormulario)

-- Grillas
SELECT tempdisControlesGrilla.Control_Id, PermiteAgregarFilas, PermiteBorrarFilas, PermiteEditarCeldas, EditaEnGrilla, RegistrosxPagina, 
	AutoFormateable, EsGrillaAdjuntos, EsArbol, AccionNuevoValorNodo, TotalizaColumnas, FilasAMostrar, AnchoMinimo, AnchoColumnasFijas,
	NombreColCalculoTotal,ColFormatoNumericoFila, ColumnasFijas, ColumnasSoloLectura, ColumnasOcultas, ColumnasTotalizarCantidad, 
	ColumnasTotalizarMinimo, ColumnasTotalizarMaximo,ColumnasTotalizarPromedio, ColumnasTotalizarSuma, AnchoColPorContenido, 
	ColumnaColorFondoFila, ColumnaColorTextoFila, PermiteCambiarOrden, PermiteOrdenMultiCols, ExpandirHastaNivel
FROM tempdisControlesGrilla 
WHERE (Formulario_Id = @liFormulario)

-- Columnas Grillas
SELECT tempdisControlesGrillaColumnas.Control_Id, tempdisControlesGrillaColumnas.Posicion,	tempdisControlesGrillaColumnas.NombreCampo, 
	tempdisControlesGrillaColumnas.Titulo, tempdisControlesGrillaColumnas.TipoDato, tempdisControlesGrillaColumnas.Formato,
	tempdisControlesGrillaColumnas.Visible, tempdisControlesGrillaColumnas.ControlColumna_Id, tempdisControlesGrillaColumnas.Ancho, 
	tempdisControlesGrillaColumnas.AnchoVariable, tempdisControlesGrillaColumnas.Alineacion, tempdisControlesGrillaColumnas.SoloLectura,
	tempdisControlesGrillaColumnas.ModoTamanioVariable, tempdisControlesGrillaColumnas.CongelarTamanio, tempdisControlesGrillaColumnas.AnchoMinimo, 
	tempdisControlesGrillaColumnas.ModoOrdenamiento, tempdisControlesGrillaColumnas.TextoColumnaVacia, 
	tempdisControlesGrillaColumnas.Texto, tempdisControlesGrillaColumnas.EsParamAccionBoton, tempdisControlesGrillaColumnas.Heredado,
	tempdisControlesGrillaColumnas.Requerido, tempdisControlesGrillaColumnas.AutoNumerico, tempdisControlesGrillaColumnas.EsPrimaryKey,
	tempdisControlesGrillaColumnas.ItemsCombo, lupIdentidades.Identidad_Id, tempdisControlesGrillaColumnas.TotalizarCantidad, 
	tempdisControlesGrillaColumnas.TotalizarMinimo, tempdisControlesGrillaColumnas.TotalizarMaximo,
	tempdisControlesGrillaColumnas.TotalizarSuma, tempdisControlesGrillaColumnas.TotalizarPromedio,
	tempdisControlesGrillaColumnas.ColumnaColorFondoCelda, tempdisControlesGrillaColumnas.ColumnaColorTextoCelda
FROM tempdisControlesGrillaColumnas 
LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = tempdisControlesGrillaColumnas.Identidad_Id
WHERE (Formulario_Id = @liFormulario)
ORDER BY tempdisControlesGrillaColumnas.Control_Id, tempdisControlesGrillaColumnas.Posicion

---- Columnas Texto Grillas 
--SELECT Control_Id, NombreCampo, MaximaLongitud
--FROM disControlesGrillaColTexto
--WHERE (Formulario_Id = @liFormulario)
--UNION
--SELECT Control_Id, NombreCampo, MaximaLongitud
--FROM disControlesGrillaColTexto
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColTexto.Formulario_Id 

---- Columnas Numericas Grillas 
--SELECT Control_Id, NombreCampo, ParteEntera, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje, Autonumerico
--FROM disControlesGrillaColNumerico 
--WHERE (Formulario_Id = @liFormulario)
--UNION
--SELECT Control_Id, NombreCampo, ParteEntera, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje, Autonumerico
--FROM disControlesGrillaColNumerico 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColNumerico.Formulario_Id 


---- Columnas Fecha Grillas 
--SELECT Control_Id, NombreCampo, UsaDatePicker, ValorMinimo, ValorMaximo, DiasDiferenciaFecha,
--		DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima	
--FROM disControlesGrillaColFecha 
--WHERE (Formulario_Id = @liFormulario)
--UNION
--SELECT Control_Id, NombreCampo, UsaDatePicker, ValorMinimo, ValorMaximo, DiasDiferenciaFecha,
--		DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima	
--FROM disControlesGrillaColFecha 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColFecha.Formulario_Id 

---- Columnas Boton Grillas 
--SELECT Control_Id, NombreCampo, EsLink 
--FROM disControlesGrillaColBoton  
--WHERE (Formulario_Id = @liFormulario)
--UNION
--SELECT Control_Id, NombreCampo, EsLink 
--FROM disControlesGrillaColBoton  
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColBoton.Formulario_Id 

---- Columnas Combo Grillas 
--SELECT disControlesGrillaColCombo.Control_Id, disControlesGrillaColCombo.NombreCampo, 
--	disControlesGrillaColCombo.MultiSeleccion, disControlesGrillaColCombo.CheckBoxes, lupIdentidades.Identidad_Id
--FROM disControlesGrillaColCombo
--LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesGrillaColCombo.Identidad_Id 
--WHERE (Formulario_Id = @liFormulario) 
--UNION
--SELECT disControlesGrillaColCombo.Control_Id, disControlesGrillaColCombo.NombreCampo, 
--	disControlesGrillaColCombo.MultiSeleccion, disControlesGrillaColCombo.CheckBoxes, lupIdentidades.Identidad_Id
--FROM disControlesGrillaColCombo
--LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesGrillaColCombo.Identidad_Id 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColCombo.Formulario_Id 


----  Items de Columnas Combo Grillas
--SELECT disControlesGrillaColComboItems.Control_Id, disControlesGrillaColComboItems.NombreCampo, 
--	disControlesGrillaColComboItems.Valor, disControlesGrillaColComboItems.Descripcion, disControlesGrillaColComboItems.Tipo
--FROM disControlesGrillaColComboItems
--WHERE (Formulario_Id = @liFormulario) 
--UNION
--SELECT disControlesGrillaColComboItems.Control_Id, disControlesGrillaColComboItems.NombreCampo, 
--	disControlesGrillaColComboItems.Valor, disControlesGrillaColComboItems.Descripcion, disControlesGrillaColComboItems.Tipo
--FROM disControlesGrillaColComboItems
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesGrillaColComboItems.Formulario_Id 

-- Lupas
SELECT tempdisControlesLupa.Control_Id, tempdisControlesLupa.CamposClave, tempdisControlesLupa.CantMaxRegAMostrar, 
	tempdisControlesLupa.EsLaEntidadDelForm, lupIdentidades.Identidad_Id,
	tempdisControlesLupa.OrderBy, tempdisControlesLupa.TraePrimerRegistro, tempdisControlesLupa.UsaAccion, 
	tempdisControlesLupa.DescripcionCharCasing,	tempdisControlesLupa.DescripcionMaxLength, tempdisControlesLupa.DescripcionTexto, 
	tempdisControlesLupa.DescripcionOculta, tempdisControlesLupa.ColumnaGrillaDescripcion,
	TablasColumnasD.Columna_Id NombreColumnaDescripcion, 
	tempdisControlesLupa.Filtros, tempdisControlesLupa.CodigoTipo, 
	tempdisControlesLupa.CodigoCharCasing, tempdisControlesLupa.CodigoMask, tempdisControlesLupa.CodigoRegExpression,
	tempdisControlesLupa.CodigoMaxLength, tempdisControlesLupa.CodigoTexto, tempdisControlesLupa.CodigoWidth, 
	tempdisControlesLupa.CodigoNombreColumna, tempdisControlesLupa.AdicionalesCampos, tempdisControlesLupa.AdicionalesControles, 
	tempdisControlesLupa.AdicionalesParametros, tempdisControlesLupa.PermiteNoExistentes, lupIdentidades.OrdenMenuFormulario,
	tempdisFormularios.Formulario_Id, tempdisFormularios.Titulo as TituloFormPopup,
	lupIdentidades.CharCasing, ISNULL(tempdisControlesLupa.Mascara, lupIdentidades.Mascara) as Mascara, lupIdentidades.MaximaLongitud
FROM tempdisControlesLupa 
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = tempdisControlesLupa.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN tempdisFormularios ON tempdisFormularios.disFormularios = genMenus.Formulario_Id
LEFT JOIN tempdisTablasColumnas as TablasColumnasD ON (TablasColumnasD.Control_Id = tempdisControlesLupa.Control_Id) 
		  AND (TablasColumnasD.Formulario_Id = tempdisControlesLupa.Formulario_Id)
		  AND (TablasColumnasD.AdicionalControl = 'D') 
WHERE (tempdisControlesLupa.Formulario_Id = @liFormulario)

-- Combos
SELECT tempdisControlesCombo.Control_Id, tempdisControlesCombo.MultiSeleccion, tempdisControlesCombo.CheckBoxes, lupIdentidades.Identidad_Id,
	tempdisControlesCombo.EsOptionGroup, tempdisControlesCombo.OptionGroupHorizontal	
FROM tempdisControlesCombo
LEFT JOIN lupIdentidades ON lupIdentidades.lupIdentidades = tempdisControlesCombo.Identidad_Id 
WHERE (Formulario_Id = @liFormulario) 


-- Items del Combo
SELECT tempdisControlesComboItems.Control_Id, tempdisControlesComboItems.Valor, tempdisControlesComboItems.Descripcion, tempdisControlesComboItems.Tipo, tempdisControlesComboItems.Orden
FROM tempdisControlesComboItems
WHERE (Formulario_Id = @liFormulario) 
ORDER BY 1,5, 2

-- Numericos
SELECT Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje,LLevaSeparadorGrupo
FROM tempdisControlesNumerico
WHERE (Formulario_Id = @liFormulario) 

-- Fechas
SELECT Control_Id, ValorMinimo, ValorMaximo, DiasDiferenciaFecha, DiasDiferenciaFechaMaxima, DiasDiferenciaFechaMinima, EsFechaHora, ValorHora 
FROM tempdisControlesFecha
WHERE (Formulario_Id = @liFormulario) 

-- Textos
SELECT Control_Id, MultiplesLineas, CharCasing, Mascara
FROM tempdisControlesTexto
WHERE (Formulario_Id = @liFormulario) 

-- Segmentos
SELECT Control_Id, genSegmentos.Segmento_Id, lupIdentidades.Identidad_Id, EsLaEntidadDelForm, Filtros, 
lupIdentidades.OrdenMenuFormulario,	tempdisFormularios.Formulario_Id, tempdisFormularios.Titulo as TituloFormPopup
FROM tempdisControlesSegmento
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = tempdisControlesSegmento.Segmento_Id
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = tempdisControlesSegmento.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN tempdisFormularios ON tempdisFormularios.disFormularios = genMenus.Formulario_Id
WHERE (tempdisControlesSegmento.Formulario_Id = @liFormulario) 

-- UpLoad
SELECT Control_Id, GuardaCaminoCompleto, ColumnaNombreInterno, ExtensionesPermitidas
FROM tempdisControlesUpLoad
WHERE (Formulario_Id = @liFormulario) 

---- DownLoad
--SELECT Control_Id, CarpetaServidor, ArchivoADescargar, ArchivoDescargado, ExtensionArchivo, EsUrl
--FROM disControlesDownLoad
--WHERE (Formulario_Id = @liFormulario) 
--UNION
--SELECT Control_Id, CarpetaServidor, ArchivoADescargar, ArchivoDescargado, ExtensionArchivo, EsUrl
--FROM disControlesDownLoad
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesDownLoad.Formulario_Id 
--UNION
--SELECT Control_Id, CarpetaServidor, ArchivoADescargar, ArchivoDescargado, ExtensionArchivo, EsUrl
--FROM disControlesDownLoad
--INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesDownLoad.Formulario_Id 


-- grafico
SELECT Control_Id, SubTitulo, Leyenda, Tipo, SubTipo, PermiteCambiarSubTipo, TituloEjevalores, Colores
FROM tempdisControlesGrafico
WHERE (Formulario_Id = @liFormulario) 

-- grafico torta
SELECT Control_Id, ValoresASeparar, UbicacionTituloPorcion, FormatoTituloPorcion
FROM tempdisControlesGraficoTorta
WHERE (Formulario_Id = @liFormulario) 

-- Lista Adjuntos
SELECT Control_Id, PermiteAgregarArchivo, PermiteBorrarArchivo, MuestraDescripciones, PermiteDescargar, CantidadMaxima, ExtensionesPermitidas,
TamanioMaximo
FROM tempdisControlesListaAdjuntos
WHERE (Formulario_Id = @liFormulario) 


-- Controles Boton
SELECT tempdisControlesBoton.Control_Id, ControlAsociado_Id, AsociadoAFilaGrilla, Icono, TempdisControles.Fila, TempdisControles.Columna
FROM tempdisControlesBoton
INNER JOIN TempdisControles ON TempdisControles.Formulario_Id = tempdisControlesBoton.Formulario_Id 
						AND TempdisControles.Control_Id = tempdisControlesBoton.Control_Id

WHERE (tempdisControlesBoton.Formulario_Id = @liFormulario) 

-- Controles Link
SELECT Control_Id, Link
FROM tempdisControlesLink
WHERE (Formulario_Id = @liFormulario) 

-- Controles Grilla Pivot
SELECT tempdisControlesGrillaPivot.Control_Id, URLServidor, Catalogo, Cubo, Measures, Filas, Columnas, TempdisControles.Fila, TempdisControles.Columna
FROM tempdisControlesGrillaPivot
INNER JOIN TempdisControles ON TempdisControles.Formulario_Id = tempdisControlesGrillaPivot.Formulario_Id 
						AND TempdisControles.Control_Id = tempdisControlesGrillaPivot.Control_Id

WHERE (tempdisControlesGrillaPivot.Formulario_Id = @liFormulario) 

-- Controles Indicador
SELECT Control_Id, Tipo, Decimales
FROM tempdisControlesIndicador
WHERE (Formulario_Id = @liFormulario) 


SELECT tempdisControlesBotonLupa.Control_Id, tempdisControlesBotonLupa.ControlAsociado_Id, tempdisControlesBotonLupa.Icono, tempdisControlesBotonLupa.CamposClave,
	TempdisControles.Fila, TempdisControles.Columna,
	tempdisControlesBotonLupa.CamposClave, tempdisControlesBotonLupa.CantMaxRegAMostrar, lupIdentidades.Identidad_Id,
	tempdisControlesBotonLupa.OrderBy, tempdisControlesBotonLupa.UsaAccion, tempdisControlesBotonLupa.Filtros, 
	tempdisControlesBotonLupa.AdicionalesCampos, tempdisControlesBotonLupa.AdicionalesControles, 
	tempdisControlesBotonLupa.AdicionalesParametros, lupIdentidades.OrdenMenuFormulario,
	tempdisFormularios.Formulario_Id, tempdisFormularios.Titulo as TituloFormPopup, TempdisControlesBotonLupa.ReemplazaEnDestino
FROM tempdisControlesBotonLupa 
INNER JOIN TempdisControles ON TempdisControles.Formulario_Id = tempdisControlesBotonLupa.Formulario_Id 
						AND TempdisControles.Control_Id = tempdisControlesBotonLupa.Control_Id

INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = tempdisControlesBotonLupa.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN tempdisFormularios ON tempdisFormularios.disFormularios = genMenus.Formulario_Id
WHERE (tempdisControlesBotonLupa.Formulario_Id = @liFormulario)


SELECT tempdisControlesBotonSegmento.Control_Id, tempdisControlesBotonSegmento.ControlAsociado_Id, 
	tempdisControlesBotonSegmento.Icono, TempdisControles.Fila, TempdisControles.Columna,
	lupIdentidades.Identidad_Id, tempdisControlesBotonSegmento.Filtros, 
	lupIdentidades.OrdenMenuFormulario,
	tempdisFormularios.Formulario_Id, tempdisFormularios.Titulo as TituloFormPopup
FROM tempdisControlesBotonSegmento 
INNER JOIN TempdisControles ON TempdisControles.Formulario_Id = tempdisControlesBotonSegmento.Formulario_Id 
						AND TempdisControles.Control_Id = tempdisControlesBotonSegmento.Control_Id

INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = tempdisControlesBotonSegmento.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN tempdisFormularios ON tempdisFormularios.disFormularios = genMenus.Formulario_Id
WHERE (tempdisControlesBotonSegmento.Formulario_Id = @liFormulario)

-- Parametros
SELECT Control_Id, TipoDato
FROM tempdisControlesParametros
WHERE (Formulario_Id = @liFormulario) 

-- Controles referencia
SELECT tempdisControlesReferencia.Control_Id, tempdisFormularios.Formulario_Id as FormularioPopup_Id, tempdisControlesReferencia.TieneBtnCerrar, 
tempdisControlesReferencia.TieneBtnGuardar,tempdisControlesReferencia.TablaPrimaria, 
tempdisControlesReferencia.Parametros, tempdisControlesReferencia.TamanioPopup
FROM tempdisControlesReferencia 
LEFT JOIN tempdisFormularios ON tempdisFormularios.disFormularios = tempdisControlesReferencia.FormularioPopup_Id
WHERE (tempdisControlesReferencia.Formulario_Id = @liFormulario) 

-- Controles referencia solapa
SELECT tempdisControlesRefSolapa.Control_Id, tempdisControlesRefSolapa.ControlSolapaRef_Id
FROM tempdisControlesRefSolapa 
WHERE (tempdisControlesRefSolapa.Formulario_Id = @liFormulario) 

-- Eventos
-- Si es para dise?o, debo mostrar todo tal cual est? en la BD
	SELECT tempdisEventos.Control_Id, tempdisEventos.TipoEvento, tempdisEventos.EsMetodo, tempdisEventos.Habilitado, tempdisEventos.Heredado
	FROM tempdisEventos 
	WHERE (Formulario_Id = @liFormulario) 

--Acciones
-- Si es para dise?o, debo mostrar todo tal cual est? en la BD
	SELECT tempdisAcciones.Control_Id, tempdisAcciones.TipoEvento, cast(tempdisAcciones.OrdenAccion as int) as OrdenAccion, 
		tempdisAcciones.Accion, tempdisAcciones.ControlDestino_Id, tempdisAcciones.Texto,
		tempdisAcciones.ControlTexto_Id, tempdisAcciones.ValorCondicion, tempdisAcciones.AccionPadre_Id, tempdisAcciones.Heredado,
		tempdisAcciones.Accion_Id, tempdisAcciones.Habilitado, tempdisAcciones.EsEspecializacion, tempdisAcciones.AdicionalInfo
	FROM tempdisAcciones 
	WHERE (Formulario_Id = @liFormulario)
	ORDER BY 1, 2, 3



---- Eventos Columnas
--SELECT Control_Id, Columna, TipoEvento, Heredado
--FROM disEventosColumnas 
--WHERE (Formulario_Id = @liFormulario) 
--UNION
--SELECT Control_Id, Columna, TipoEvento, Heredado
--FROM disEventosColumnas 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disEventosColumnas.Formulario_Id
--UNION
--SELECT Control_Id, Columna, TipoEvento, Heredado
--FROM disEventosColumnas 
--INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disEventosColumnas.Formulario_Id

----Acciones Columnas
--SELECT Control_Id, Columna, TipoEvento, OrdenAccion, 
--	Accion, ControlDestino_Id, ColumnaDestino, Texto,
--	ControlTexto_Id, ValorCondicion, AccionPadre_Id, Heredado, Accion_Id
--FROM disAccionesColumnas 
--WHERE (Formulario_Id = @liFormulario) and (Accion <> 'DoDefault')
--UNION
--SELECT Control_Id, Columna, TipoEvento, OrdenAccion, 
--	Accion, ControlDestino_Id, ColumnaDestino, Texto,
--	ControlTexto_Id, ValorCondicion, AccionPadre_Id, Heredado, Accion_Id
--FROM disAccionesColumnas 
--INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disAccionesColumnas.Formulario_Id
--WHERE (Accion <> 'DoDefault')
--UNION
--SELECT Control_Id, Columna, TipoEvento, OrdenAccion, 
--	Accion, ControlDestino_Id, ColumnaDestino, Texto,
--	ControlTexto_Id, ValorCondicion, AccionPadre_Id, Heredado, Accion_Id
--FROM disAccionesColumnas 
--INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disAccionesColumnas.Formulario_Id
--WHERE (Accion <> 'DoDefault')



-- Tablas del Common
SELECT Tabla_Id, TipoControl, Control_Id, EsEspecializacion
FROM tempdisTablas
WHERE (Formulario_Id = @liFormulario)


-- Columnas de Common
SELECT Tabla_Id, Columna_Id, TipoControl, Control_Id, AdicionalControl, EsEspecializacion
FROM tempdisTablasColumnas
WHERE (Formulario_Id = @liFormulario)


--Relaciones entre Tablas
SELECT TablaMaster_Id, TablaDetalle_Id, ColumnaMaster_Id, ColumnaMaster2_Id, ColumnaMaster3_Id,
		ColumnaDetalle_Id, ColumnaDetalle2_Id, ColumnaDetalle3_Id
FROM tempdisRelacionesTablas
WHERE (Formulario_Id = @liFormulario)

--Condiciones Acciones
SELECT distinct tempdisAcciones.Control_Id, tempdisAcciones.TipoEvento, tempdisAcciones.AccionPadre_Id as Accion, tempdisAcciones.ValorCondicion 
FROM tempdisAcciones 
WHERE (Formulario_Id = @liFormulario)
AND tempdisAcciones.AccionPadre_Id is not null 

--tablas a refrescar luego de invocaer a una Accion
	SELECT act.Control_Id, act.TipoEvento, cast(act.OrdenAccion as int) as OrdenAccion, act.Tabla_Id, a.Accion_Id
	FROM tempdisAccionesTablasaActualizar act
	INNER JOIN tempdisAcciones a ON a.Formulario_Id = act.Formulario_Id 
						AND a.Control_Id = act.Control_Id 
						AND a.TipoEvento = act.TipoEvento
						AND a.OrdenAccion = act.OrdenAccion 
	WHERE (act.Formulario_Id = @liFormulario)
	ORDER BY 1, 2, 3, 4


--tablas a enviar al invocar a una accion
	SELECT act.Control_Id, act.TipoEvento, cast(act.OrdenAccion as int) as OrdenAccion, act.Tabla_Id, a.Accion_Id
	FROM tempdisAccionesTablasaEnviar act
	INNER JOIN tempdisAcciones a ON a.Formulario_Id = act.Formulario_Id 
						AND a.Control_Id = act.Control_Id 
						AND a.TipoEvento = act.TipoEvento
						AND a.OrdenAccion = act.OrdenAccion 
	WHERE (act.Formulario_Id = @liFormulario)
	ORDER BY 1, 2, 3, 4

-- Extras, para evitar llamar a mas acciones
SELECT genSegmentoOrigenes.OriSeg_Id, genSegmentoOrigenes.Descripcion
FROM genSegmentoOrigenes  

--obtener todos los posibles segmentos
SELECT Segmento_Id
FROM genSegmentos


-- Obtener configuracion de segmento
SELECT distinct vseg.Segmento_id, vseg.Orden, vseg.Campo, vseg.Tipo, vseg.Digitos, 
	   cast(case when seg.TamanioVariable = cast(vseg.Campo as char(1)) + vseg.Tipo then 1 else 0 end as bit) as EsTamaniovariable,
	   vseg.TieneColumnaAutomatica , vseg.Origen,vseg.Nombre, vseg.HabilitaEdicion 
FROM tempdisControlesSegmento
INNER JOIN vGenSegmentosConfiguracion vseg ON vseg.genSegmentos = tempdisControlesSegmento.Segmento_Id
INNER JOIN genSegmentos seg ON seg.genSegmentos = tempdisControlesSegmento.Segmento_Id
WHERE (tempdisControlesSegmento.Formulario_Id = @liFormulario) 
ORDER BY 1, 2

--Obtener Atributos generales
SELECT AtributoNro, Descripcion, Tipo
FROM genAtributosGenerales
WHERE Tabla_Id = @lTabla_Id
AND EnGrilla = 1

--Obtener Atributos generales especializacion
SELECT AtributoNro, Descripcion, Tipo
FROM genAtributosGenerales
WHERE Tabla_Id = @lTabla_Id
AND @lEspecializacion IS NOT NULL
AND EnGrilla = 0


--Obtener Comentarios, ordenados por fecha de registro
SELECT FechaRegistro, FechaRegistroOrig, FechaUltModif, Comentario, /*tempdisformularios.formulario_id as*/ FormularioRegOrig_Id, Comentario_Id, TipoComentario
FROM tempdisFormulariosComentarios
--LEFT JOIN tempdisformularios on tempdisformularios.disformularios = tempdisFormulariosComentarios.FormularioRegOrig_Id
WHERE (tempdisFormulariosComentarios.Formulario_Id = @liFormulario) 

SELECT tempdisAccionesDescargaEsp.Control_Id, tempdisAccionesDescargaEsp.TipoEvento, 
		tempdisAccionesDescargaEsp.Accion, tempdisAccionesDescargaEsp.ControlDestino_Id, tempdisAccionesDescargaEsp.Texto
FROM tempdisAccionesDescargaEsp
WHERE (Formulario_Id = @liFormulario)
ORDER BY 1, 2, 3

SELECT 	genControlesSeteos.Control_Id, genControlesSeteos.Orden, genControlesSeteos.Valor,  genControlesSeteos.ModificoValor, genControlesSeteos.Deshabilitar, 
		genControlesSeteos.Ocultar, genControlesSeteos.SeteadoPorSistema, genControlesSeteos.Usuario_Id,  disControles.TipoControl, Tabla_Id, Columna_Id
FROM genControlesSeteos 
INNER JOIN disControles ON disControles.Formulario_Id = genControlesSeteos.Formulario_Id AND disControles.Control_Id = genControlesSeteos.Control_Id
	LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 

WHERE (genControlesSeteos.Formulario_Id = @liFormulario)
AND (1 = 0)


RETURN @@Error 

GO



DROP PROCEDURE disFormulariosCambioSegDatos
GO
CREATE PROCEDURE disFormulariosCambioSegDatos
(
@pFormulario_Id varchar(30),
@pControl_Id varchar(30),
@pSegmento_Id varchar(10)
)
AS

DECLARE @liFormulario int
DECLARE @lSegmento_Id int
DECLARE @lLongTotalSegmento int
DECLARE @ListaDeFormularios Table (Id int, SolapaInvocante varchar(200))
DECLARE @ListaDeFormInscrustados Table (Id int, ControlReferencia varchar(200), Parametros varchar(512))
DECLARE @ListaControlesAfectados Table (Control_Id varchar(200))

SET NOCOUNT ON   


SET @liFormulario = dbo.FuncFKdisFormularios(@pFormulario_Id)
-- Primero obtengo la lista de formularios popup que sean referenciados desde alguna de las solapas
INSERT INTO @ListaDeFormularios (Id, SolapaInvocante)
SELECT FormularioPopup_Id, Control_Id
FROM disControlesSolapa 
WHERE disControlesSolapa.Formulario_Id = @liFormulario
AND FormularioPopup_Id IS NOT NULL

-- obtengo la lista de formularios incrusatdos que sean referenciados desde algun control referencia
INSERT INTO @ListaDeFormInscrustados (Id, ControlReferencia, Parametros)
SELECT FormularioPopup_Id, Control_Id, Parametros
FROM disControlesReferencia 
WHERE disControlesReferencia.Formulario_Id = @liFormulario
AND FormularioPopup_Id IS NOT NULL

--Obtengo la lista de controles que se ven afectados por el cambio del id de segmento. Ellos son el mismo segmento, y los controles asociados
INSERT INTO @ListaControlesAfectados (Control_Id)
SELECT disControles.Control_Id 
FROM disControles 
WHERE (disControles.Formulario_Id = @liFormulario)
AND ((disControles.Control_Id = @pControl_Id)
	OR (disControles.ControlSegmento = @pControl_Id)
	AND (disControles.TipoControl <> 'OrigenSegmento')
	)
UNION--Los controles de los popups asociados
SELECT disControles.Control_Id
FROM disControles 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControles.Formulario_Id
WHERE (disControles.NroControl > 2) -- el 0 es el formulario, el 1 es el control solapas, y el 2 la solapa_datos
AND ((disControles.Control_Id = @pControl_Id)
	OR (disControles.ControlSegmento = @pControl_Id)
	AND (disControles.TipoControl <> 'OrigenSegmento')
	)
UNION--Los controles de los forms refenciados por controles
SELECT case when disControles.TipoControl = 'System.Windows.Forms.TabPage' then disControles.Control_Id + '_' + lstfrm.ControlReferencia else disControles.Control_Id end as Control_Id 
FROM disControles 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControles.Formulario_Id
WHERE (disControles.NroControl > 1) -- el 0 es el formulario, el 1 es el control solapas, y el 2 la solapa_datos
AND ((disControles.Control_Id = @pControl_Id)
	OR (disControles.ControlSegmento = @pControl_Id)
	AND (disControles.TipoControl <> 'OrigenSegmento')
	)

--Controles
SELECT disControles.Control_Id, disControles.NroControl, disControles.ControlParent_Id, 
		disControles.TipoControl, disControles.Alto, disControles.Ancho, 
		disControles.Arriba, disControles.Izquierda, disControles.Texto, 
		disControles.Visible, disControles.Habilitado, disControles.Alineacion,
		disControles.TabStop, disControles.TabOrden, disControles.Requerido, 
		TablasColumnas1.Tabla_Id NombreTabla, TablasColumnas1.Columna_Id NombreColumna, 
		disControles.Embebido, 
		disControles.Ancla, disControles.EsCodigoNuevo, disControles.Paises, disControles.Fila, 
		disControles.Columna, disControles.FilasExtension, disControles.ColumnasExtension,
		disControles.MaximaLongitud, disControles.ClickNuevoBlanquea, disControles.ControlaCambios, 
		disControles.SoloLectura, disControles.TextoFijo, disControles.TextoControlVacio,
		disControles.Estilo, disControles.TituloLabel, disControles.AlineacionLabel, disControles.IgualaAnchoColumna,
		disControles.SegmentoOrigen, disControles.ControlSegmento, disControles.Heredado
FROM disControles 
INNER JOIN @ListaControlesAfectados as ctrl ON ctrl.Control_Id = disControles.Control_Id
LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
WHERE (disControles.Formulario_Id = @liFormulario)
UNION--Los controles de los popups asociados
SELECT disControles.Control_Id, disControles.NroControl, 
		case when disControles.ControlParent_Id = 'Solapa_Datos' then lstFrm.SolapaInvocante else disControles.ControlParent_Id end as ControlParent_Id, 
		disControles.TipoControl, disControles.Alto, disControles.Ancho, 
		disControles.Arriba, disControles.Izquierda, disControles.Texto, 
		disControles.Visible, disControles.Habilitado, disControles.Alineacion,
		disControles.TabStop, disControles.TabOrden, disControles.Requerido, 
		TablasColumnas1.Tabla_Id NombreTabla, TablasColumnas1.Columna_Id NombreColumna, 
		disControles.Embebido, 
		disControles.Ancla, disControles.EsCodigoNuevo, disControles.Paises, disControles.Fila, 
		disControles.Columna, disControles.FilasExtension, disControles.ColumnasExtension,
		disControles.MaximaLongitud, disControles.ClickNuevoBlanquea, disControles.ControlaCambios, 
		disControles.SoloLectura, disControles.TextoFijo, disControles.TextoControlVacio,
		disControles.Estilo, disControles.TituloLabel, disControles.AlineacionLabel, disControles.IgualaAnchoColumna,
		disControles.SegmentoOrigen, disControles.ControlSegmento, disControles.Heredado
FROM disControles 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControles.Formulario_Id
INNER JOIN @ListaControlesAfectados as ctrl ON ctrl.Control_Id = disControles.Control_Id
LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
WHERE (disControles.NroControl > 2) -- el 0 es el formulario, el 1 es el control solapas, y el 2 la solapa_datos
UNION--Los controles de los forms refenciados por controles
SELECT case when disControles.TipoControl = 'System.Windows.Forms.TabPage' then disControles.Control_Id + '_' + lstfrm.ControlReferencia else disControles.Control_Id end as Control_Id, 
		disControles.NroControl, 
		case when disControles.ControlParent_Id like 'Solapa__%' then disControles.ControlParent_Id + '_' + lstfrm.ControlReferencia else disControles.ControlParent_Id end as ControlParent_Id, 
		disControles.TipoControl, disControles.Alto, disControles.Ancho, 
		disControles.Arriba, disControles.Izquierda, disControles.Texto, 
		disControles.Visible, disControles.Habilitado, disControles.Alineacion,
		disControles.TabStop, disControles.TabOrden, disControles.Requerido, 
		TablasColumnas1.Tabla_Id NombreTabla, TablasColumnas1.Columna_Id NombreColumna, 
		disControles.Embebido, 
		disControles.Ancla, disControles.EsCodigoNuevo, disControles.Paises, disControles.Fila, 
		disControles.Columna, disControles.FilasExtension, disControles.ColumnasExtension,
		disControles.MaximaLongitud, disControles.ClickNuevoBlanquea, disControles.ControlaCambios, 
		disControles.SoloLectura, disControles.TextoFijo, disControles.TextoControlVacio,
		disControles.Estilo, disControles.TituloLabel, disControles.AlineacionLabel, disControles.IgualaAnchoColumna,
		disControles.SegmentoOrigen, disControles.ControlSegmento, disControles.Heredado
FROM disControles 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControles.Formulario_Id
INNER JOIN @ListaControlesAfectados as ctrl ON ctrl.Control_Id = disControles.Control_Id
LEFT JOIN disTablasColumnas as TablasColumnas1 ON (TablasColumnas1.Control_Id = disControles.Control_Id) 
		  AND (TablasColumnas1.Formulario_Id = disControles.Formulario_Id)
		  AND ((TablasColumnas1.AdicionalControl is null) 
		  -- Es el codigo de la Lupa
		  OR (TablasColumnas1.AdicionalControl = '1') 
		  -- Es el campo cliente del upoload
		  OR (TablasColumnas1.AdicionalControl = 'C')) 
WHERE (disControles.NroControl > 1) -- el 0 es el formulario, el 1 es el control solapas, y el 2 la solapa_datos
ORDER BY disControles.Fila, disControles.Columna, disControles.NroControl

-- Numericos
SELECT disControlesNumerico.Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje
FROM disControlesNumerico
INNER JOIN @ListaControlesAfectados as ctrl ON ctrl.Control_Id = disControlesNumerico.Control_Id
WHERE (Formulario_Id = @liFormulario) 
UNION
SELECT disControlesNumerico.Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje
FROM disControlesNumerico
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesNumerico.Formulario_Id
INNER JOIN @ListaControlesAfectados as ctrl ON ctrl.Control_Id = disControlesNumerico.Control_Id 
UNION
SELECT disControlesNumerico.Control_Id, Decimales, BotonSpin, SpinIncremento, ValorMinimo, ValorMaximo, EsPorcentaje
FROM disControlesNumerico
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesNumerico.Formulario_Id 
INNER JOIN @ListaControlesAfectados as ctrl ON ctrl.Control_Id = disControlesNumerico.Control_Id


-- Segmentos
SELECT Control_Id, genSegmentos.Segmento_Id, lupIdentidades.Identidad_Id, EsLaEntidadDelForm, Filtros, 
lupIdentidades.OrdenMenuFormulario,	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesSegmento
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = dbo.FuncFKgenSegmentos(@pSegmento_Id)
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesSegmento.Identidad_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
WHERE (disControlesSegmento.Formulario_Id = @liFormulario) 
AND (disControlesSegmento.Control_Id = @pControl_Id)
UNION
SELECT Control_Id, genSegmentos.Segmento_Id, lupIdentidades.Identidad_Id, EsLaEntidadDelForm, Filtros, 
lupIdentidades.OrdenMenuFormulario,	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesSegmento
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = dbo.FuncFKgenSegmentos(@pSegmento_Id)
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesSegmento.Identidad_Id 
INNER JOIN @ListaDeFormularios as lstFrm ON lstFrm.id = disControlesSegmento.Formulario_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
WHERE (disControlesSegmento.Control_Id = @pControl_Id)
UNION
SELECT Control_Id, genSegmentos.Segmento_Id, lupIdentidades.Identidad_Id, EsLaEntidadDelForm, Filtros, 
lupIdentidades.OrdenMenuFormulario,	disFormularios.Formulario_Id, disFormularios.Titulo as TituloFormPopup
FROM disControlesSegmento
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = dbo.FuncFKgenSegmentos(@pSegmento_Id)
INNER JOIN lupIdentidades ON lupIdentidades.lupIdentidades = disControlesSegmento.Identidad_Id 
INNER JOIN @ListaDeFormInscrustados as lstFrm ON lstFrm.id = disControlesSegmento.Formulario_Id 
LEFT JOIN genMenus ON genMenus.Orden = lupIdentidades.OrdenMenuFormulario
LEFT JOIN disFormularios ON disFormularios.disFormularios = genMenus.Formulario_Id
WHERE (disControlesSegmento.Control_Id = @pControl_Id)

-- Extras, para evitar llamar a mas acciones
SELECT genSegmentoOrigenes.OriSeg_Id, genSegmentoOrigenes.Descripcion
FROM genSegmentoOrigenes  

--obtener todos los posibles segmentos
SELECT Segmento_Id
FROM genSegmentos


-- Obtener configuracion de segmento
SELECT distinct vseg.Segmento_id, vseg.Orden, vseg.Campo, vseg.Tipo, vseg.Digitos, 
	   cast(case when seg.TamanioVariable = cast(vseg.Campo as char(1)) + vseg.Tipo then 1 else 0 end as bit) as EsTamaniovariable,
	   vseg.TieneColumnaAutomatica , vseg.Origen,vseg.Nombre, vseg.HabilitaEdicion 
FROM disControlesSegmento
INNER JOIN vGenSegmentosConfiguracion vseg ON vseg.genSegmentos = dbo.FuncFKgenSegmentos(@pSegmento_Id)
INNER JOIN genSegmentos seg ON seg.genSegmentos = dbo.FuncFKgenSegmentos(@pSegmento_Id)
WHERE ((disControlesSegmento.Formulario_Id = @liFormulario) 
OR (disControlesSegmento.Formulario_Id in (select Id from @ListaDeFormInscrustados)))
AND disControlesSegmento.Control_Id = @pControl_Id
ORDER BY 1, 2


RETURN @@Error 

GO