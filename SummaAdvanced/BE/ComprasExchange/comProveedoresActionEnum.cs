using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 6 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comProveedoresActionEnum
    {
        public enum EnumcomProveedoresAction
        {
            Guardar, Datos, Eliminar, DatosId, AnexoDatos, DatosAdjuntos
        }
        public static string GetAccioncomProveedoresAction(comProveedoresActionEnum.EnumcomProveedoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProveedoresActionEnum.EnumcomProveedoresAction.Guardar: lRetorno = "comProveedoresGuardar"; break;
                case comProveedoresActionEnum.EnumcomProveedoresAction.Datos: lRetorno = "comProveedoresDevolverDatos"; break;
                case comProveedoresActionEnum.EnumcomProveedoresAction.Eliminar: lRetorno = "comProveedoresEliminar"; break;
                case comProveedoresActionEnum.EnumcomProveedoresAction.DatosId: lRetorno = "comProveedoresDatosId"; break;
                case comProveedoresActionEnum.EnumcomProveedoresAction.AnexoDatos: lRetorno = "comProveedoresAnexoDatos"; break;
                case comProveedoresActionEnum.EnumcomProveedoresAction.DatosAdjuntos: lRetorno = "comProveedoresDatosAdjuntos"; break;
            }
            return lRetorno;
        }
    }
}
