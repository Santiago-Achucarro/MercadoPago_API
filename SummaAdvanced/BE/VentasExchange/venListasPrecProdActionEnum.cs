using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venListasPrecProdActionEnum
        {            public enum EnumvenListasPrecProdAction
            {
                Guardar,Datos,Eliminar, DatosFecha
        }
        public static string GetAccionvenListasPrecProdAction(venListasPrecProdActionEnum.EnumvenListasPrecProdAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venListasPrecProdActionEnum.EnumvenListasPrecProdAction.Guardar: lRetorno = "venListasPrecProdGuardar"; break;
                case venListasPrecProdActionEnum.EnumvenListasPrecProdAction.Datos: lRetorno = "venListasPrecProdDevolverDatos"; break;
                case venListasPrecProdActionEnum.EnumvenListasPrecProdAction.Eliminar: lRetorno = "venListasPrecProdEliminar"; break;
                case venListasPrecProdActionEnum.EnumvenListasPrecProdAction.DatosFecha: lRetorno = "venListasPrecProdDatosFecha"; break;
            }
            return lRetorno;
        }
    }
}
