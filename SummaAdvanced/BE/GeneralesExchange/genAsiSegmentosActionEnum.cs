using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genAsiSegmentosActionEnum
    {
        public enum EnumgenAsiSegmentosAction
        {
            Guardar, Datos, Eliminar, DatosInt, Modificar1N
        }
        public static string GetAcciongenAsiSegmentosAction(genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.Guardar: lRetorno = "genAsiSegmentosGuardar"; break;
                case genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.Datos: lRetorno = "genAsiSegmentosDevolverDatos"; break;
                case genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.Eliminar: lRetorno = "genAsiSegmentosEliminar"; break;
                case genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.DatosInt: lRetorno = "genAsiSegmentosDatosInt"; break;
                case genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.Modificar1N: lRetorno = "genAsiSegmentosModificar1N"; break;
            }
            return lRetorno;
        }
    }
}
