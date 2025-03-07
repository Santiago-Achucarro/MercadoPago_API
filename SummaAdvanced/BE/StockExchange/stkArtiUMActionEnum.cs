using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 16 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkArtiUMActionEnum
        {            public enum EnumstkArtiUMAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkArtiUMAction(stkArtiUMActionEnum.EnumstkArtiUMAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkArtiUMActionEnum.EnumstkArtiUMAction.Guardar: lRetorno = "stkArtiUMGuardar"; break;
                case stkArtiUMActionEnum.EnumstkArtiUMAction.Datos: lRetorno = "stkArtiUMDevolverDatos"; break;
                case stkArtiUMActionEnum.EnumstkArtiUMAction.Eliminar: lRetorno = "stkArtiUMEliminar"; break;
            }
            return lRetorno;
        }
    }
}
