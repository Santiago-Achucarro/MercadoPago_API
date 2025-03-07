using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAtributosValoresActionEnum
        {            public enum EnumgenAtributosValoresAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenAtributosValoresAction(genAtributosValoresActionEnum.EnumgenAtributosValoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAtributosValoresActionEnum.EnumgenAtributosValoresAction.Guardar: lRetorno = "genAtributosValoresGuardar"; break;
                case genAtributosValoresActionEnum.EnumgenAtributosValoresAction.Datos: lRetorno = "genAtributosValoresDevolverDatos"; break;
                case genAtributosValoresActionEnum.EnumgenAtributosValoresAction.Eliminar: lRetorno = "genAtributosValoresEliminar"; break;
            }
            return lRetorno;
        }
    }
}
