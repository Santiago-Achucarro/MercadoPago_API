using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proRecursosActionEnum
        {            public enum EnumproRecursosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproRecursosAction(proRecursosActionEnum.EnumproRecursosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proRecursosActionEnum.EnumproRecursosAction.Guardar: lRetorno = "proRecursosGuardar"; break;
                case proRecursosActionEnum.EnumproRecursosAction.Datos: lRetorno = "proRecursosDevolverDatos"; break;
                case proRecursosActionEnum.EnumproRecursosAction.Eliminar: lRetorno = "proRecursosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
