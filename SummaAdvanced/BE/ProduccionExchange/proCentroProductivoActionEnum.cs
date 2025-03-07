using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proCentroProductivoActionEnum
        {            public enum EnumproCentroProductivoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproCentroProductivoAction(proCentroProductivoActionEnum.EnumproCentroProductivoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proCentroProductivoActionEnum.EnumproCentroProductivoAction.Guardar: lRetorno = "proCentroProductivoGuardar"; break;
                case proCentroProductivoActionEnum.EnumproCentroProductivoAction.Datos: lRetorno = "proCentroProductivoDevolverDatos"; break;
                case proCentroProductivoActionEnum.EnumproCentroProductivoAction.Eliminar: lRetorno = "proCentroProductivoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
