using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 21 de abril de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venListasPreciosActionEnum
        {            public enum EnumvenListasPreciosAction
            {
                Guardar,Datos,Eliminar, CargarExcel, TraerProductos, DatosCabe
        }
        public static string GetAccionvenListasPreciosAction(venListasPreciosActionEnum.EnumvenListasPreciosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venListasPreciosActionEnum.EnumvenListasPreciosAction.Guardar: lRetorno = "venListasPreciosGuardar"; break;
                case venListasPreciosActionEnum.EnumvenListasPreciosAction.Datos: lRetorno = "venListasPreciosDevolverDatos"; break;
                case venListasPreciosActionEnum.EnumvenListasPreciosAction.Eliminar: lRetorno = "venListasPreciosEliminar"; break;
                case venListasPreciosActionEnum.EnumvenListasPreciosAction.CargarExcel: lRetorno = "venListasPreciosCargarExcel"; break;
                case venListasPreciosActionEnum.EnumvenListasPreciosAction.TraerProductos: lRetorno = "venListasPreciosTraerProductos"; break;
                case venListasPreciosActionEnum.EnumvenListasPreciosAction.DatosCabe: lRetorno = "venListasPreciosDatosCabe"; break;
            }
            return lRetorno;
        }
    }
}
