using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 21 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conGrupoCentroActionEnum
        {            public enum EnumconGrupoCentroAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconGrupoCentroAction(conGrupoCentroActionEnum.EnumconGrupoCentroAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conGrupoCentroActionEnum.EnumconGrupoCentroAction.Guardar: lRetorno = "conGrupoCentroGuardar"; break;
                case conGrupoCentroActionEnum.EnumconGrupoCentroAction.Datos: lRetorno = "conGrupoCentroDevolverDatos"; break;
                case conGrupoCentroActionEnum.EnumconGrupoCentroAction.Eliminar: lRetorno = "conGrupoCentroEliminar"; break;
            }
            return lRetorno;
        }
    }
}
