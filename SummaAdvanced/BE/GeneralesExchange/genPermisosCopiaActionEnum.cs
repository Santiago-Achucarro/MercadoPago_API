using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 22 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genPermisosCopiaActionEnum
        {            public enum EnumgenPermisosCopiaAction
            {
                Guardar
            }
        public static string GetAcciongenPermisosCopiaAction(genPermisosCopiaActionEnum.EnumgenPermisosCopiaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genPermisosCopiaActionEnum.EnumgenPermisosCopiaAction.Guardar: lRetorno = "genPermisosCopiaGuardar"; break;
            }
            return lRetorno;
        }
    }
}
