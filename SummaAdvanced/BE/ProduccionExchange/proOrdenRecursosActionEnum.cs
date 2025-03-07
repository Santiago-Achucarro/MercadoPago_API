using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 20 de marzo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenRecursosActionEnum
        {            public enum EnumproOrdenRecursosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproOrdenRecursosAction(proOrdenRecursosActionEnum.EnumproOrdenRecursosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenRecursosActionEnum.EnumproOrdenRecursosAction.Guardar: lRetorno = "proOrdenRecursosGuardar"; break;
                case proOrdenRecursosActionEnum.EnumproOrdenRecursosAction.Datos: lRetorno = "proOrdenRecursosDevolverDatos"; break;
                case proOrdenRecursosActionEnum.EnumproOrdenRecursosAction.Eliminar: lRetorno = "proOrdenRecursosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
