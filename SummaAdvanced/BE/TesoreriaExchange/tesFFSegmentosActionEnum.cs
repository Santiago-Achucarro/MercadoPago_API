using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesFFSegmentosActionEnum
        {            public enum EnumtesFFSegmentosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesFFSegmentosAction(tesFFSegmentosActionEnum.EnumtesFFSegmentosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesFFSegmentosActionEnum.EnumtesFFSegmentosAction.Guardar: lRetorno = "tesFFSegmentosGuardar"; break;
                case tesFFSegmentosActionEnum.EnumtesFFSegmentosAction.Datos: lRetorno = "tesFFSegmentosDevolverDatos"; break;
                case tesFFSegmentosActionEnum.EnumtesFFSegmentosAction.Eliminar: lRetorno = "tesFFSegmentosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
