using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 8 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conCuadro1FilasActionEnum
        {            public enum EnumconCuadro1FilasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconCuadro1FilasAction(conCuadro1FilasActionEnum.EnumconCuadro1FilasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conCuadro1FilasActionEnum.EnumconCuadro1FilasAction.Guardar: lRetorno = "conCuadro1FilasGuardar"; break;
                case conCuadro1FilasActionEnum.EnumconCuadro1FilasAction.Datos: lRetorno = "conCuadro1FilasDevolverDatos"; break;
                case conCuadro1FilasActionEnum.EnumconCuadro1FilasAction.Eliminar: lRetorno = "conCuadro1FilasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
