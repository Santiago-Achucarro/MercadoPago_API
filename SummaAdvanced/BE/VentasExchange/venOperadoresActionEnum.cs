using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 24 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venOperadoresActionEnum
        {            public enum EnumvenOperadoresAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenOperadoresAction(venOperadoresActionEnum.EnumvenOperadoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venOperadoresActionEnum.EnumvenOperadoresAction.Guardar: lRetorno = "venOperadoresGuardar"; break;
                case venOperadoresActionEnum.EnumvenOperadoresAction.Datos: lRetorno = "venOperadoresDevolverDatos"; break;
                case venOperadoresActionEnum.EnumvenOperadoresAction.Eliminar: lRetorno = "venOperadoresEliminar"; break;
            }
            return lRetorno;
        }
    }
}
