using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Wednesday, September 18, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comSubCategoriasActionEnum
        {            public enum EnumcomSubCategoriasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomSubCategoriasAction(comSubCategoriasActionEnum.EnumcomSubCategoriasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comSubCategoriasActionEnum.EnumcomSubCategoriasAction.Guardar: lRetorno = "comSubCategoriasGuardar"; break;
                case comSubCategoriasActionEnum.EnumcomSubCategoriasAction.Datos: lRetorno = "comSubCategoriasDevolverDatos"; break;
                case comSubCategoriasActionEnum.EnumcomSubCategoriasAction.Eliminar: lRetorno = "comSubCategoriasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
