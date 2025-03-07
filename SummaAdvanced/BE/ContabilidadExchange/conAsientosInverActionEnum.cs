using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 5 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsientosInverActionEnum
        {            public enum EnumconAsientosInverAction
            {
                Guardar,Datos
            }
        public static string GetAccionconAsientosInverAction(conAsientosInverActionEnum.EnumconAsientosInverAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsientosInverActionEnum.EnumconAsientosInverAction.Guardar: lRetorno = "conAsientosInverGuardar"; break;
                case conAsientosInverActionEnum.EnumconAsientosInverAction.Datos: lRetorno = "conAsientosInverDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
