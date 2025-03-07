using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovImpuestosActionEnum
        {            public enum EnumcomMovImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovImpuestosAction(comMovImpuestosActionEnum.EnumcomMovImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovImpuestosActionEnum.EnumcomMovImpuestosAction.Guardar: lRetorno = "comMovImpuestosGuardar"; break;
                case comMovImpuestosActionEnum.EnumcomMovImpuestosAction.Datos: lRetorno = "comMovImpuestosDevolverDatos"; break;
                case comMovImpuestosActionEnum.EnumcomMovImpuestosAction.Eliminar: lRetorno = "comMovImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
