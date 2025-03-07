using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 16 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueConcDescuentoActionEnum
        {            public enum EnumsueConcDescuentoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueConcDescuentoAction(sueConcDescuentoActionEnum.EnumsueConcDescuentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueConcDescuentoActionEnum.EnumsueConcDescuentoAction.Guardar: lRetorno = "sueConcDescuentoGuardar"; break;
                case sueConcDescuentoActionEnum.EnumsueConcDescuentoAction.Datos: lRetorno = "sueConcDescuentoDevolverDatos"; break;
                case sueConcDescuentoActionEnum.EnumsueConcDescuentoAction.Eliminar: lRetorno = "sueConcDescuentoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
