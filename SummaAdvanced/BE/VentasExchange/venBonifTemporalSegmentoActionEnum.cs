using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 10 de junio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venBonifTemporalSegmentoActionEnum
        {            public enum EnumvenBonifTemporalSegmentoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenBonifTemporalSegmentoAction(venBonifTemporalSegmentoActionEnum.EnumvenBonifTemporalSegmentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venBonifTemporalSegmentoActionEnum.EnumvenBonifTemporalSegmentoAction.Guardar: lRetorno = "venBonifTemporalSegmentoGuardar"; break;
                case venBonifTemporalSegmentoActionEnum.EnumvenBonifTemporalSegmentoAction.Datos: lRetorno = "venBonifTemporalSegmentoDevolverDatos"; break;
                case venBonifTemporalSegmentoActionEnum.EnumvenBonifTemporalSegmentoAction.Eliminar: lRetorno = "venBonifTemporalSegmentoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
