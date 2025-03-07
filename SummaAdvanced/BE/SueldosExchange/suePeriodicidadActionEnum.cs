using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, June 28, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePeriodicidadActionEnum
        {            public enum EnumsuePeriodicidadAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsuePeriodicidadAction(suePeriodicidadActionEnum.EnumsuePeriodicidadAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePeriodicidadActionEnum.EnumsuePeriodicidadAction.Guardar: lRetorno = "suePeriodicidadGuardar"; break;
                case suePeriodicidadActionEnum.EnumsuePeriodicidadAction.Datos: lRetorno = "suePeriodicidadDevolverDatos"; break;
                case suePeriodicidadActionEnum.EnumsuePeriodicidadAction.Eliminar: lRetorno = "suePeriodicidadEliminar"; break;
            }
            return lRetorno;
        }
    }
}
