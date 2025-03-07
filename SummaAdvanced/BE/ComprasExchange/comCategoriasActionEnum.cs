using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, September 9, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comCategoriasActionEnum
        {            public enum EnumcomCategoriasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomCategoriasAction(comCategoriasActionEnum.EnumcomCategoriasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comCategoriasActionEnum.EnumcomCategoriasAction.Guardar: lRetorno = "comCategoriasGuardar"; break;
                case comCategoriasActionEnum.EnumcomCategoriasAction.Datos: lRetorno = "comCategoriasDevolverDatos"; break;
                case comCategoriasActionEnum.EnumcomCategoriasAction.Eliminar: lRetorno = "comCategoriasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
