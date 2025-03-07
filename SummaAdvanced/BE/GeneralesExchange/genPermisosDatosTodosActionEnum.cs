using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genPermisosDatosTodosActionEnum
        {            public enum EnumgenPermisosDatosTodosAction
            {
                Datos
            }
        public static string GetAcciongenPermisosDatosTodosAction(genPermisosDatosTodosActionEnum.EnumgenPermisosDatosTodosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genPermisosDatosTodosActionEnum.EnumgenPermisosDatosTodosAction.Datos: lRetorno = "genPermisosDatosTodosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
