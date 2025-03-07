using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proSubRecursosActionEnum
        {            public enum EnumproSubRecursosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproSubRecursosAction(proSubRecursosActionEnum.EnumproSubRecursosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proSubRecursosActionEnum.EnumproSubRecursosAction.Guardar: lRetorno = "proSubRecursosGuardar"; break;
                case proSubRecursosActionEnum.EnumproSubRecursosAction.Datos: lRetorno = "proSubRecursosDevolverDatos"; break;
                case proSubRecursosActionEnum.EnumproSubRecursosAction.Eliminar: lRetorno = "proSubRecursosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
