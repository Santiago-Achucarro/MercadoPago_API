using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMoviPredialActionEnum
        {            public enum EnumvenMoviPredialAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMoviPredialAction(venMoviPredialActionEnum.EnumvenMoviPredialAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMoviPredialActionEnum.EnumvenMoviPredialAction.Guardar: lRetorno = "venMoviPredialGuardar"; break;
                case venMoviPredialActionEnum.EnumvenMoviPredialAction.Datos: lRetorno = "venMoviPredialDevolverDatos"; break;
                case venMoviPredialActionEnum.EnumvenMoviPredialAction.Eliminar: lRetorno = "venMoviPredialEliminar"; break;
            }
            return lRetorno;
        }
    }
}
