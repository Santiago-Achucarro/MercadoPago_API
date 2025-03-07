using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 4 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePlantillaActionEnum
        {            public enum EnumsuePlantillaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsuePlantillaAction(suePlantillaActionEnum.EnumsuePlantillaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePlantillaActionEnum.EnumsuePlantillaAction.Guardar: lRetorno = "suePlantillaGuardar"; break;
                case suePlantillaActionEnum.EnumsuePlantillaAction.Datos: lRetorno = "suePlantillaDevolverDatos"; break;
                case suePlantillaActionEnum.EnumsuePlantillaAction.Eliminar: lRetorno = "suePlantillaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
