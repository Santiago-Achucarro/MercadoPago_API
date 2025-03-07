using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 25 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRIConsolidacionActionEnum
        {            public enum EnumcomRIConsolidacionAction
            {
                Guardar,Datos, CalcularTotal
        }
        public static string GetAccioncomRIConsolidacionAction(comRIConsolidacionActionEnum.EnumcomRIConsolidacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRIConsolidacionActionEnum.EnumcomRIConsolidacionAction.Guardar: lRetorno = "comRIConsolidacionGuardar"; break;
                case comRIConsolidacionActionEnum.EnumcomRIConsolidacionAction.Datos: lRetorno = "comRIConsolidacionDevolverDatos"; break;
                case comRIConsolidacionActionEnum.EnumcomRIConsolidacionAction.CalcularTotal:lRetorno = "comRIConsolidacionCalcularTotal"; break;
                    
            }
            return lRetorno;
        }
    }
}
