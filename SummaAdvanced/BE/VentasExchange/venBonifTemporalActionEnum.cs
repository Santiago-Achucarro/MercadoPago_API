using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 9 de junio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venBonifTemporalActionEnum
        {            public enum EnumvenBonifTemporalAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenBonifTemporalAction(venBonifTemporalActionEnum.EnumvenBonifTemporalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venBonifTemporalActionEnum.EnumvenBonifTemporalAction.Guardar: lRetorno = "venBonifTemporalGuardar"; break;
                case venBonifTemporalActionEnum.EnumvenBonifTemporalAction.Datos: lRetorno = "venBonifTemporalDevolverDatos"; break;
                case venBonifTemporalActionEnum.EnumvenBonifTemporalAction.Eliminar: lRetorno = "venBonifTemporalEliminar"; break;
            }
            return lRetorno;
        }
    }
}
