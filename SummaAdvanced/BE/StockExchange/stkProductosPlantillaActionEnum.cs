using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Wednesday, November 13, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProductosPlantillaActionEnum
        {            public enum EnumstkProductosPlantillaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkProductosPlantillaAction(stkProductosPlantillaActionEnum.EnumstkProductosPlantillaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosPlantillaActionEnum.EnumstkProductosPlantillaAction.Guardar: lRetorno = "stkProductosPlantillaGuardar"; break;
                case stkProductosPlantillaActionEnum.EnumstkProductosPlantillaAction.Datos: lRetorno = "stkProductosPlantillaDevolverDatos"; break;
                case stkProductosPlantillaActionEnum.EnumstkProductosPlantillaAction.Eliminar: lRetorno = "stkProductosPlantillaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
