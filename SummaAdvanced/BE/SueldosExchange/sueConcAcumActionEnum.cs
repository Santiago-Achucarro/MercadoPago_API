using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 16 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueConcAcumActionEnum
        {            public enum EnumsueConcAcumAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueConcAcumAction(sueConcAcumActionEnum.EnumsueConcAcumAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueConcAcumActionEnum.EnumsueConcAcumAction.Guardar: lRetorno = "sueConcAcumGuardar"; break;
                case sueConcAcumActionEnum.EnumsueConcAcumAction.Datos: lRetorno = "sueConcAcumDevolverDatos"; break;
                case sueConcAcumActionEnum.EnumsueConcAcumAction.Eliminar: lRetorno = "sueConcAcumEliminar"; break;
            }
            return lRetorno;
        }
    }
}
