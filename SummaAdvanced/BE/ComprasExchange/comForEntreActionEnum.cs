using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 2 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comForEntreActionEnum
        {            public enum EnumcomForEntreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomForEntreAction(comForEntreActionEnum.EnumcomForEntreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comForEntreActionEnum.EnumcomForEntreAction.Guardar: lRetorno = "comForEntreGuardar"; break;
                case comForEntreActionEnum.EnumcomForEntreAction.Datos: lRetorno = "comForEntreDevolverDatos"; break;
                case comForEntreActionEnum.EnumcomForEntreAction.Eliminar: lRetorno = "comForEntreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
