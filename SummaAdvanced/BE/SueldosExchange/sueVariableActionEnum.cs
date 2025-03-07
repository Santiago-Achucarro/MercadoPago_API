using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, August 8, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVariableActionEnum
        {            public enum EnumsueVariableAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueVariableAction(sueVariableActionEnum.EnumsueVariableAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVariableActionEnum.EnumsueVariableAction.Guardar: lRetorno = "sueVariableGuardar"; break;
                case sueVariableActionEnum.EnumsueVariableAction.Datos: lRetorno = "sueVariableDevolverDatos"; break;
                case sueVariableActionEnum.EnumsueVariableAction.Eliminar: lRetorno = "sueVariableEliminar"; break;
            }
            return lRetorno;
        }
    }
}
