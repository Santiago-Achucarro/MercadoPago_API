using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comImpuestosActionEnum
        {            public enum EnumcomImpuestosAction
            {
                Guardar,Datos,Eliminar,PorTipo
            }
        public static string GetAccioncomImpuestosAction(comImpuestosActionEnum.EnumcomImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comImpuestosActionEnum.EnumcomImpuestosAction.Guardar: lRetorno = "comImpuestosGuardar"; break;
                case comImpuestosActionEnum.EnumcomImpuestosAction.Datos: lRetorno = "comImpuestosDevolverDatos"; break;
                case comImpuestosActionEnum.EnumcomImpuestosAction.Eliminar: lRetorno = "comImpuestosEliminar"; break;
                case comImpuestosActionEnum.EnumcomImpuestosAction.PorTipo: lRetorno = "comImpuestosPorTipo"; break;
            }
            return lRetorno;
        }
    }
}
