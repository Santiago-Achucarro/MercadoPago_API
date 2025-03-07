using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 12 de mayo de 2023
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class espvenClieHabitualKSKActionEnum
        {            public enum EnumespvenClieHabitualKSKAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespvenClieHabitualKSKAction(espvenClieHabitualKSKActionEnum.EnumespvenClieHabitualKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espvenClieHabitualKSKActionEnum.EnumespvenClieHabitualKSKAction.Guardar: lRetorno = "espvenClieHabitualKSKGuardar"; break;
                case espvenClieHabitualKSKActionEnum.EnumespvenClieHabitualKSKAction.Datos: lRetorno = "espvenClieHabitualKSKDevolverDatos"; break;
                case espvenClieHabitualKSKActionEnum.EnumespvenClieHabitualKSKAction.Eliminar: lRetorno = "espvenClieHabitualKSKEliminar"; break;
            }
            return lRetorno;
        }
    }
}
