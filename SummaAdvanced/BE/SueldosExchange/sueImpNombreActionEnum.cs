using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, August 9, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueImpNombreActionEnum
        {            public enum EnumsueImpNombreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueImpNombreAction(sueImpNombreActionEnum.EnumsueImpNombreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueImpNombreActionEnum.EnumsueImpNombreAction.Guardar: lRetorno = "sueImpNombreGuardar"; break;
                case sueImpNombreActionEnum.EnumsueImpNombreAction.Datos: lRetorno = "sueImpNombreDevolverDatos"; break;
                case sueImpNombreActionEnum.EnumsueImpNombreAction.Eliminar: lRetorno = "sueImpNombreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
