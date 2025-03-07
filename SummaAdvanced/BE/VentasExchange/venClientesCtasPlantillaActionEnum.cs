using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 2 de junio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClientesCtasPlantillaActionEnum
        {            public enum EnumvenClientesCtasPlantillaAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionvenClientesCtasPlantillaAction(venClientesCtasPlantillaActionEnum.EnumvenClientesCtasPlantillaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClientesCtasPlantillaActionEnum.EnumvenClientesCtasPlantillaAction.Guardar: lRetorno = "venClientesCtasPlantillaGuardar"; break;
                case venClientesCtasPlantillaActionEnum.EnumvenClientesCtasPlantillaAction.Eliminar: lRetorno = "venClientesCtasPlantillaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
