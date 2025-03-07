using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 8 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkRemiProvActionEnum
        {            public enum EnumstkRemiProvAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkRemiProvAction(stkRemiProvActionEnum.EnumstkRemiProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkRemiProvActionEnum.EnumstkRemiProvAction.Guardar: lRetorno = "stkRemiProvGuardar"; break;
                case stkRemiProvActionEnum.EnumstkRemiProvAction.Datos: lRetorno = "stkRemiProvDevolverDatos"; break;
                case stkRemiProvActionEnum.EnumstkRemiProvAction.Eliminar: lRetorno = "stkRemiProvEliminar"; break;
            }
            return lRetorno;
        }
    }
}
