using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 22 de julio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impImpuestosActionEnum
        {            public enum EnumimpImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionimpImpuestosAction(impImpuestosActionEnum.EnumimpImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impImpuestosActionEnum.EnumimpImpuestosAction.Guardar: lRetorno = "impImpuestosGuardar"; break;
                case impImpuestosActionEnum.EnumimpImpuestosAction.Datos: lRetorno = "impImpuestosDevolverDatos"; break;
                case impImpuestosActionEnum.EnumimpImpuestosAction.Eliminar: lRetorno = "impImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
