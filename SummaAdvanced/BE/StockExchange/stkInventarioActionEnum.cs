using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 5 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkInventarioActionEnum
        {            public enum EnumstkInventarioAction
            {
                Guardar,Datos,Eliminar,AgregarProductos,AgregarProductosxls
        }
        public static string GetAccionstkInventarioAction(stkInventarioActionEnum.EnumstkInventarioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkInventarioActionEnum.EnumstkInventarioAction.Guardar: lRetorno = "stkInventarioGuardar"; break;
                case stkInventarioActionEnum.EnumstkInventarioAction.Datos: lRetorno = "stkInventarioDevolverDatos"; break;
                case stkInventarioActionEnum.EnumstkInventarioAction.Eliminar: lRetorno = "stkInventarioEliminar"; break;
                case stkInventarioActionEnum.EnumstkInventarioAction.AgregarProductos: lRetorno = "stkInventarioAgregarProductos"; break;
                case stkInventarioActionEnum.EnumstkInventarioAction.AgregarProductosxls: lRetorno = "stkInventarioAgregarProductosxls"; break;
            }
            return lRetorno;
        }
    }
}
