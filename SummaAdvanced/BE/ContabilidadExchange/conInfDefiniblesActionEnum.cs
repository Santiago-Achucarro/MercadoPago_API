using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 9 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conInfDefiniblesActionEnum
        {            public enum EnumconInfDefiniblesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconInfDefiniblesAction(conInfDefiniblesActionEnum.EnumconInfDefiniblesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conInfDefiniblesActionEnum.EnumconInfDefiniblesAction.Guardar: lRetorno = "conInfDefiniblesGuardar"; break;
                case conInfDefiniblesActionEnum.EnumconInfDefiniblesAction.Datos: lRetorno = "conInfDefiniblesDevolverDatos"; break;
                case conInfDefiniblesActionEnum.EnumconInfDefiniblesAction.Eliminar: lRetorno = "conInfDefiniblesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
