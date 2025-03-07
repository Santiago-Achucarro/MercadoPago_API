using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, December 16, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueInfDefiniblesActionEnum
        {            public enum EnumsueInfDefiniblesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueInfDefiniblesAction(sueInfDefiniblesActionEnum.EnumsueInfDefiniblesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueInfDefiniblesActionEnum.EnumsueInfDefiniblesAction.Guardar: lRetorno = "sueInfDefiniblesGuardar"; break;
                case sueInfDefiniblesActionEnum.EnumsueInfDefiniblesAction.Datos: lRetorno = "sueInfDefiniblesDevolverDatos"; break;
                case sueInfDefiniblesActionEnum.EnumsueInfDefiniblesAction.Eliminar: lRetorno = "sueInfDefiniblesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
