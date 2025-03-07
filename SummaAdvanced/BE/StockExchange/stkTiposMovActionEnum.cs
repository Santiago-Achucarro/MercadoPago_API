using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 13 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkTiposMovActionEnum
        {            public enum EnumstkTiposMovAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkTiposMovAction(stkTiposMovActionEnum.EnumstkTiposMovAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkTiposMovActionEnum.EnumstkTiposMovAction.Guardar: lRetorno = "stkTiposMovGuardar"; break;
                case stkTiposMovActionEnum.EnumstkTiposMovAction.Datos: lRetorno = "stkTiposMovDevolverDatos"; break;
                case stkTiposMovActionEnum.EnumstkTiposMovAction.Eliminar: lRetorno = "stkTiposMovEliminar"; break;
            }
            return lRetorno;
        }
    }
}
