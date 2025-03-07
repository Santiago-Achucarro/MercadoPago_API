using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 15 de julio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venRepaSegmentosActionEnum
        {            public enum EnumvenRepaSegmentosAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionvenRepaSegmentosAction(venRepaSegmentosActionEnum.EnumvenRepaSegmentosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRepaSegmentosActionEnum.EnumvenRepaSegmentosAction.Guardar: lRetorno = "venRepaSegmentosGuardar"; break;
                case venRepaSegmentosActionEnum.EnumvenRepaSegmentosAction.Eliminar: lRetorno = "venRepaSegmentosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
