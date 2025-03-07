using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 16 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueConcAcumSegmentoActionEnum
        {            public enum EnumsueConcAcumSegmentoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueConcAcumSegmentoAction(sueConcAcumSegmentoActionEnum.EnumsueConcAcumSegmentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueConcAcumSegmentoActionEnum.EnumsueConcAcumSegmentoAction.Guardar: lRetorno = "sueConcAcumSegmentoGuardar"; break;
                case sueConcAcumSegmentoActionEnum.EnumsueConcAcumSegmentoAction.Datos: lRetorno = "sueConcAcumSegmentoDevolverDatos"; break;
                case sueConcAcumSegmentoActionEnum.EnumsueConcAcumSegmentoAction.Eliminar: lRetorno = "sueConcAcumSegmentoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
