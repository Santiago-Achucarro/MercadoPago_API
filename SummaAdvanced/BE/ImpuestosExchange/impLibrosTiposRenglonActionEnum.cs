using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 10 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impLibrosTiposRenglonActionEnum
        {            public enum EnumimpLibrosTiposRenglonAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionimpLibrosTiposRenglonAction(impLibrosTiposRenglonActionEnum.EnumimpLibrosTiposRenglonAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impLibrosTiposRenglonActionEnum.EnumimpLibrosTiposRenglonAction.Guardar: lRetorno = "impLibrosTiposRenglonGuardar"; break;
                case impLibrosTiposRenglonActionEnum.EnumimpLibrosTiposRenglonAction.Datos: lRetorno = "impLibrosTiposRenglonDevolverDatos"; break;
                case impLibrosTiposRenglonActionEnum.EnumimpLibrosTiposRenglonAction.Eliminar: lRetorno = "impLibrosTiposRenglonEliminar"; break;
            }
            return lRetorno;
        }
    }
}
