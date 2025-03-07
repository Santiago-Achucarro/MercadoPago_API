using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genCancMovApliImporActionEnum
        {            public enum EnumgenCancMovApliImporAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenCancMovApliImporAction(genCancMovApliImporActionEnum.EnumgenCancMovApliImporAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genCancMovApliImporActionEnum.EnumgenCancMovApliImporAction.Guardar: lRetorno = "genCancMovApliImporGuardar"; break;
                case genCancMovApliImporActionEnum.EnumgenCancMovApliImporAction.Datos: lRetorno = "genCancMovApliImporDevolverDatos"; break;
                case genCancMovApliImporActionEnum.EnumgenCancMovApliImporAction.Eliminar: lRetorno = "genCancMovApliImporEliminar"; break;
            }
            return lRetorno;
        }
    }
}
