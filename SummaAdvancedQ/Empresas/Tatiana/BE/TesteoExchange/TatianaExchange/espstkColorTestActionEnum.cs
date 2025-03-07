using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 18 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TatianaExchange{
        public static class espstkColorTestActionEnum
        {            public enum EnumespstkColorTestAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkColorTestAction(espstkColorTestActionEnum.EnumespstkColorTestAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkColorTestActionEnum.EnumespstkColorTestAction.Guardar: lRetorno = "espstkColorTestGuardar"; break;
                case espstkColorTestActionEnum.EnumespstkColorTestAction.Datos: lRetorno = "espstkColorTestDevolverDatos"; break;
                case espstkColorTestActionEnum.EnumespstkColorTestAction.Eliminar: lRetorno = "espstkColorTestEliminar"; break;
            }
            return lRetorno;
        }
    }
}
