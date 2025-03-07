using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, August 9, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueCateNombreActionEnum
        {            public enum EnumsueCateNombreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueCateNombreAction(sueCateNombreActionEnum.EnumsueCateNombreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueCateNombreActionEnum.EnumsueCateNombreAction.Guardar: lRetorno = "sueCateNombreGuardar"; break;
                case sueCateNombreActionEnum.EnumsueCateNombreAction.Datos: lRetorno = "sueCateNombreDevolverDatos"; break;
                case sueCateNombreActionEnum.EnumsueCateNombreAction.Eliminar: lRetorno = "sueCateNombreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
