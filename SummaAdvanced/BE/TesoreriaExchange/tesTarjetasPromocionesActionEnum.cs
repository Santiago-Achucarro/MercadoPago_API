using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 20 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesTarjetasPromocionesActionEnum
        {            public enum EnumtesTarjetasPromocionesAction
            {
                Guardar,Eliminar
            }
        public static string GetAcciontesTarjetasPromocionesAction(tesTarjetasPromocionesActionEnum.EnumtesTarjetasPromocionesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesTarjetasPromocionesActionEnum.EnumtesTarjetasPromocionesAction.Guardar: lRetorno = "tesTarjetasPromocionesGuardar"; break;
                case tesTarjetasPromocionesActionEnum.EnumtesTarjetasPromocionesAction.Eliminar: lRetorno = "tesTarjetasPromocionesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
