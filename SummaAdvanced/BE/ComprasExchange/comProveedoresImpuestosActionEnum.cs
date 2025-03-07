using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProveedoresImpuestosActionEnum
        {            public enum EnumcomProveedoresImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomProveedoresImpuestosAction(comProveedoresImpuestosActionEnum.EnumcomProveedoresImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProveedoresImpuestosActionEnum.EnumcomProveedoresImpuestosAction.Guardar: lRetorno = "comProveedoresImpuestosGuardar"; break;
                case comProveedoresImpuestosActionEnum.EnumcomProveedoresImpuestosAction.Datos: lRetorno = "comProveedoresImpuestosDevolverDatos"; break;
                case comProveedoresImpuestosActionEnum.EnumcomProveedoresImpuestosAction.Eliminar: lRetorno = "comProveedoresImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
