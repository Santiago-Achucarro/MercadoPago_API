using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, June 28, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePersonalActionEnum
        {            public enum EnumsuePersonalAction
        {
            Guardar, Datos, Eliminar, Actividades, ActividadesGuardar, Afore, AforeGuardar, Categorias, CategoriasGuardar, CondServicio, CondServicioGuardar, Contable, ContableGuardar, Convenios, ConveniosGuardar, Domicilios, DomiciliosGuardar, EstadoCivil, EstadoCivilGuardar, Localidades, LocalidadesGuardar, ModContrata, ModContrataGuardar, Puestos, PuestosGuardar, Sinestrado, SinestradorGuardar, SituacionRevi, SituacionReviGuardar, Sucursales, SucursalesGuardar, TipoContrato, TipoContratoGuardar, TipoEmpleador, TipoEmpleadorGuardar, TipoJornada, TipoJornadaGuardar, TipoPago, TipoPagoGuardar, TipoRegimen, TipoRegimenGuardar, TipoSDI, TipoSDIGuardar, Ordenar, ContableDatos, RebPromo, RebPromoGuardar, RedZonalGuardar, RedZonal, AporteAdicGuardar, AporteAdic, AporteVoluntarioGuardar, AporteVoluntario, ObraSocialGuardar, ObraSocial
        }
        public static string GetAccionsuePersonalAction(suePersonalActionEnum.EnumsuePersonalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePersonalActionEnum.EnumsuePersonalAction.Guardar: lRetorno = "suePersonalGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Datos: lRetorno = "suePersonalDevolverDatos"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Eliminar: lRetorno = "suePersonalEliminar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Actividades: lRetorno = "suePersonalActividades"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.ActividadesGuardar: lRetorno = "suePersonalActividadesGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Afore: lRetorno = "suePersonalAfore"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.AforeGuardar: lRetorno = "suePersonalAforeGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Categorias: lRetorno = "suePersonalCategorias"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.CategoriasGuardar: lRetorno = "suePersonalCategoriasGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.CondServicio: lRetorno = "suePersonalCondServicio"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.CondServicioGuardar: lRetorno = "suePersonalCondServicioGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Contable: lRetorno = "suePersonalContable"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.ContableGuardar: lRetorno = "suePersonalContableGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Convenios: lRetorno = "suePersonalConvenios"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.ConveniosGuardar: lRetorno = "suePersonalConveniosGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Domicilios: lRetorno = "suePersonalDomicilios"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.DomiciliosGuardar: lRetorno = "suePersonalDomiciliosGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.EstadoCivil: lRetorno = "suePersonalEstadoCivil"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.EstadoCivilGuardar: lRetorno = "suePersonalEstadoCivilGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Localidades: lRetorno = "suePersonalLocalidades"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.LocalidadesGuardar: lRetorno = "suePersonalLocalidadesGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.ModContrata: lRetorno = "suePersonalModContrata"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.ModContrataGuardar: lRetorno = "suePersonalModContrataGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Puestos: lRetorno = "suePersonalPuestos"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.PuestosGuardar: lRetorno = "suePersonalPuestosGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Sinestrado: lRetorno = "suePersonalSinestrado"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.SinestradorGuardar: lRetorno = "suePersonalSinestradoGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.SituacionRevi: lRetorno = "suePersonalSituacionRevi"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.SituacionReviGuardar: lRetorno = "suePersonalSituacionRevi"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Sucursales: lRetorno = "suePersonalSucursales"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.SucursalesGuardar: lRetorno = "suePersonalSucursalesGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoContrato: lRetorno = "suePersonalTipoContrato"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoContratoGuardar: lRetorno = "suePersonalTipoContratoGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoEmpleador: lRetorno = "suePersonalTipoEmpleador"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoEmpleadorGuardar: lRetorno = "suePersonalTipoEmpleadorGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoJornada: lRetorno = "suePersonalTipoJornada"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoJornadaGuardar: lRetorno = "suePersonalTipoJornadaGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoPago: lRetorno = "suePersonalTipoPago"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoPagoGuardar: lRetorno = "suePersonalTipoPagoGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoRegimen: lRetorno = "suePersonalTipoRegimen"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoRegimenGuardar: lRetorno = "suePersonalTipoRegimenGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoSDI: lRetorno = "suePersonalTipoSDI"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.TipoSDIGuardar: lRetorno = "suePersonalTipoSDIGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.Ordenar: lRetorno = "suePersonalOrdenar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.ContableDatos: lRetorno = "suePersonalContableDatosDatos"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.RebPromo: lRetorno = "suePersonalRebPromo"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.RebPromoGuardar: lRetorno = "suePersonalRebPromoGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.RedZonal: lRetorno = "suePersonalRedZonal"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.RedZonalGuardar: lRetorno = "suePersonalRedZonalGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.AporteAdic: lRetorno = "suePersonalAporteAdic"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.AporteAdicGuardar: lRetorno = "suePersonalAporteAdicGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.AporteVoluntario: lRetorno = "suePersonalAporteVolunt"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.AporteVoluntarioGuardar: lRetorno = "suePersonalAporteVoluntGuardar"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.ObraSocial: lRetorno = "suePersonalObraSocial"; break;
                case suePersonalActionEnum.EnumsuePersonalAction.ObraSocialGuardar: lRetorno = "suePersonalObraSocialGuardar"; break;
            }
            return lRetorno;
        }
    }
}
