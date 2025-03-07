using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 31 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClientesPlantillaActionEnum
        {            public enum EnumvenClientesPlantillaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenClientesPlantillaAction(venClientesPlantillaActionEnum.EnumvenClientesPlantillaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClientesPlantillaActionEnum.EnumvenClientesPlantillaAction.Guardar: lRetorno = "venClientesPlantillaGuardar"; break;
                case venClientesPlantillaActionEnum.EnumvenClientesPlantillaAction.Datos: lRetorno = "venClientesPlantillaDevolverDatos"; break;
                case venClientesPlantillaActionEnum.EnumvenClientesPlantillaAction.Eliminar: lRetorno = "venClientesPlantillaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
