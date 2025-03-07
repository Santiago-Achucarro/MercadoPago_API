using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 18 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TatianaExchange{
        public static class espstkTalleTestActionEnum
        {            public enum EnumespstkTalleTestAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkTalleTestAction(espstkTalleTestActionEnum.EnumespstkTalleTestAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkTalleTestActionEnum.EnumespstkTalleTestAction.Guardar: lRetorno = "espstkTalleTestGuardar"; break;
                case espstkTalleTestActionEnum.EnumespstkTalleTestAction.Datos: lRetorno = "espstkTalleTestDevolverDatos"; break;
                case espstkTalleTestActionEnum.EnumespstkTalleTestAction.Eliminar: lRetorno = "espstkTalleTestEliminar"; break;
            }
            return lRetorno;
        }
    }
}
