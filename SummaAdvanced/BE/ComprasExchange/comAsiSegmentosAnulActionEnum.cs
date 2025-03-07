using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 2 de julio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comAsiSegmentosAnulActionEnum
        {            public enum EnumcomAsiSegmentosAnulAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomAsiSegmentosAnulAction(comAsiSegmentosAnulActionEnum.EnumcomAsiSegmentosAnulAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comAsiSegmentosAnulActionEnum.EnumcomAsiSegmentosAnulAction.Guardar: lRetorno = "comAsiSegmentosAnulGuardar"; break;
                case comAsiSegmentosAnulActionEnum.EnumcomAsiSegmentosAnulAction.Datos: lRetorno = "comAsiSegmentosAnulDevolverDatos"; break;
                case comAsiSegmentosAnulActionEnum.EnumcomAsiSegmentosAnulAction.Eliminar: lRetorno = "comAsiSegmentosAnulEliminar"; break;
            }
            return lRetorno;
        }
    }
}
