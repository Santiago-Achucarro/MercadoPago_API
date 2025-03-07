using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 9 de febrero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePersRebPromoActionEnum
        {            public enum EnumsuePersRebPromoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsuePersRebPromoAction(suePersRebPromoActionEnum.EnumsuePersRebPromoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePersRebPromoActionEnum.EnumsuePersRebPromoAction.Guardar: lRetorno = "suePersRebPromoGuardar"; break;
                case suePersRebPromoActionEnum.EnumsuePersRebPromoAction.Datos: lRetorno = "suePersRebPromoDevolverDatos"; break;
                case suePersRebPromoActionEnum.EnumsuePersRebPromoAction.Eliminar: lRetorno = "suePersRebPromoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
