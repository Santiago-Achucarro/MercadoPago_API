using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genProvinciasActionEnum
        {            public enum EnumgenProvinciasAction
            {
            Guardar, Datos, Eliminar
        }
        public static string GetAcciongenProvinciasAction(genProvinciasActionEnum.EnumgenProvinciasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genProvinciasActionEnum.EnumgenProvinciasAction.Guardar: lRetorno = "genProvinciasGuardar"; break;
                case genProvinciasActionEnum.EnumgenProvinciasAction.Datos: lRetorno = "genProvinciasDevolverDatos"; break;
                case genProvinciasActionEnum.EnumgenProvinciasAction.Eliminar: lRetorno = "genProvinciasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
