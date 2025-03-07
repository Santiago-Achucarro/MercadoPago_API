using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, September 10, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comReqInternoActionEnum
        {            public enum EnumcomReqInternoAction
            {
                Guardar,Datos,Eliminar, DatosInt, CambiarEstado
        }
        public static string GetAccioncomReqInternoAction(comReqInternoActionEnum.EnumcomReqInternoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comReqInternoActionEnum.EnumcomReqInternoAction.Guardar: lRetorno = "comReqInternoGuardar"; break;
                case comReqInternoActionEnum.EnumcomReqInternoAction.Datos: lRetorno = "comReqInternoDevolverDatos"; break;
                case comReqInternoActionEnum.EnumcomReqInternoAction.Eliminar: lRetorno = "comReqInternoEliminar"; break;
                case comReqInternoActionEnum.EnumcomReqInternoAction.DatosInt: lRetorno = "comReqInternoDatosInt"; break;
                case comReqInternoActionEnum.EnumcomReqInternoAction.CambiarEstado: lRetorno = "comReqInternoCambiarEstado"; break;
            }
            return lRetorno;
        }
    }
}
