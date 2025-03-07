using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de marzo de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovConformaActionEnum
        {            public enum EnumvenMovConformaAction
            {
                Guardar,Datos,Eliminar,AdjuntosDatos
            }
        public static string GetAccionvenMovConformaAction(venMovConformaActionEnum.EnumvenMovConformaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovConformaActionEnum.EnumvenMovConformaAction.Guardar: lRetorno = "venMovConformaGuardar"; break;
                case venMovConformaActionEnum.EnumvenMovConformaAction.Datos: lRetorno = "venMovConformaDevolverDatos"; break;
                case venMovConformaActionEnum.EnumvenMovConformaAction.Eliminar: lRetorno = "venMovConformaEliminar"; break;
                case venMovConformaActionEnum.EnumvenMovConformaAction.AdjuntosDatos: lRetorno = "venMovConformaAdjuntosDatos"; break;
            }
            return lRetorno;
        }
    }
}
