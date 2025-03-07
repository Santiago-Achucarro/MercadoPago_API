using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 28 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovStkHistActionEnum
        {            public enum EnumvenMovStkHistAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovStkHistAction(venMovStkHistActionEnum.EnumvenMovStkHistAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovStkHistActionEnum.EnumvenMovStkHistAction.Guardar: lRetorno = "venMovStkHistGuardar"; break;
                case venMovStkHistActionEnum.EnumvenMovStkHistAction.Datos: lRetorno = "venMovStkHistDevolverDatos"; break;
                case venMovStkHistActionEnum.EnumvenMovStkHistAction.Eliminar: lRetorno = "venMovStkHistEliminar"; break;
            }
            return lRetorno;
        }
    }
}
