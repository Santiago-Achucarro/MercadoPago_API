using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 1 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenesGenerarActionEnum
        {            public enum EnumproOrdenesGenerarAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionproOrdenesGenerarAction(proOrdenesGenerarActionEnum.EnumproOrdenesGenerarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenesGenerarActionEnum.EnumproOrdenesGenerarAction.Guardar: lRetorno = "proOrdenesGenerarGuardar"; break;
                case proOrdenesGenerarActionEnum.EnumproOrdenesGenerarAction.Eliminar: lRetorno = "proOrdenesGenerarEliminar"; break;
            }
            return lRetorno;
        }
    }
}
