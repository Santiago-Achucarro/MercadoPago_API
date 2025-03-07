using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 13 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMaxMinActionEnum
        {            public enum EnumstkMaxMinAction
            {
                Guardar,Datos,Eliminar,SubirExcel
            }
        public static string GetAccionstkMaxMinAction(stkMaxMinActionEnum.EnumstkMaxMinAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMaxMinActionEnum.EnumstkMaxMinAction.Guardar: lRetorno = "stkMaxMinGuardar"; break;
                case stkMaxMinActionEnum.EnumstkMaxMinAction.Datos: lRetorno = "stkMaxMinDevolverDatos"; break;
                case stkMaxMinActionEnum.EnumstkMaxMinAction.Eliminar: lRetorno = "stkMaxMinEliminar"; break;
                case stkMaxMinActionEnum.EnumstkMaxMinAction.SubirExcel: lRetorno = "stkMaxMinSubirExcel"; break;
            }
            return lRetorno;
        }
    }
}
