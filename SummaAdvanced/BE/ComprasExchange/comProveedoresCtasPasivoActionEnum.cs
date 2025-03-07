using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProveedoresCtasPasivoActionEnum
        {            public enum EnumcomProveedoresCtasPasivoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomProveedoresCtasPasivoAction(comProveedoresCtasPasivoActionEnum.EnumcomProveedoresCtasPasivoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProveedoresCtasPasivoActionEnum.EnumcomProveedoresCtasPasivoAction.Guardar: lRetorno = "comProveedoresCtasPasivoGuardar"; break;
                case comProveedoresCtasPasivoActionEnum.EnumcomProveedoresCtasPasivoAction.Datos: lRetorno = "comProveedoresCtasPasivoDevolverDatos"; break;
                case comProveedoresCtasPasivoActionEnum.EnumcomProveedoresCtasPasivoAction.Eliminar: lRetorno = "comProveedoresCtasPasivoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
