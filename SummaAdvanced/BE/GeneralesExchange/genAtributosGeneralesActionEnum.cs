using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAtributosGeneralesActionEnum
        {            public enum EnumgenAtributosGeneralesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenAtributosGeneralesAction(genAtributosGeneralesActionEnum.EnumgenAtributosGeneralesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAtributosGeneralesActionEnum.EnumgenAtributosGeneralesAction.Guardar: lRetorno = "genAtributosGeneralesGuardar"; break;
                case genAtributosGeneralesActionEnum.EnumgenAtributosGeneralesAction.Datos: lRetorno = "genAtributosGeneralesDevolverDatos"; break;
                case genAtributosGeneralesActionEnum.EnumgenAtributosGeneralesAction.Eliminar: lRetorno = "genAtributosGeneralesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
