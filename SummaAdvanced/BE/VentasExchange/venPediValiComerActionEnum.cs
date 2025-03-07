using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 29 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPediValiComerActionEnum
        {            public enum EnumvenPediValiComerAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenPediValiComerAction(venPediValiComerActionEnum.EnumvenPediValiComerAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPediValiComerActionEnum.EnumvenPediValiComerAction.Guardar: lRetorno = "venPediValiComerGuardar"; break;
                case venPediValiComerActionEnum.EnumvenPediValiComerAction.Datos: lRetorno = "venPediValiComerDevolverDatos"; break;
                case venPediValiComerActionEnum.EnumvenPediValiComerAction.Eliminar: lRetorno = "venPediValiComerEliminar"; break;
            }
            return lRetorno;
        }
    }
}
