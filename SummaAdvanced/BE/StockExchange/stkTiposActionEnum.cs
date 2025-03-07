using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 13 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkTiposActionEnum
        {            public enum EnumstkTiposAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkTiposAction(stkTiposActionEnum.EnumstkTiposAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkTiposActionEnum.EnumstkTiposAction.Guardar: lRetorno = "stkTiposGuardar"; break;
                case stkTiposActionEnum.EnumstkTiposAction.Datos: lRetorno = "stkTiposDevolverDatos"; break;
                case stkTiposActionEnum.EnumstkTiposAction.Eliminar: lRetorno = "stkTiposEliminar"; break;
            }
            return lRetorno;
        }
    }
}
