using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 2 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genSegmentosActionEnum
        {            public enum EnumgenSegmentosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenSegmentosAction(genSegmentosActionEnum.EnumgenSegmentosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genSegmentosActionEnum.EnumgenSegmentosAction.Guardar: lRetorno = "genSegmentosGuardar"; break;
                case genSegmentosActionEnum.EnumgenSegmentosAction.Datos: lRetorno = "genSegmentosDevolverDatos"; break;
                case genSegmentosActionEnum.EnumgenSegmentosAction.Eliminar: lRetorno = "genSegmentosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
