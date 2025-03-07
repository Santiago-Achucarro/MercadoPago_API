using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 21 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impTipoImpuestoActionEnum
        {            public enum EnumimpTipoImpuestoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionimpTipoImpuestoAction(impTipoImpuestoActionEnum.EnumimpTipoImpuestoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impTipoImpuestoActionEnum.EnumimpTipoImpuestoAction.Guardar: lRetorno = "impTipoImpuestoGuardar"; break;
                case impTipoImpuestoActionEnum.EnumimpTipoImpuestoAction.Datos: lRetorno = "impTipoImpuestoDevolverDatos"; break;
                case impTipoImpuestoActionEnum.EnumimpTipoImpuestoAction.Eliminar: lRetorno = "impTipoImpuestoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
