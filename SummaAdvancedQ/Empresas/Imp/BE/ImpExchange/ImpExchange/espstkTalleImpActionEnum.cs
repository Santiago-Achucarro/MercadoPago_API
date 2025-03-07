using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 24 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpExchange{
        public static class espstkTalleImpActionEnum
        {            public enum EnumespstkTalleImpAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkTalleImpAction(espstkTalleImpActionEnum.EnumespstkTalleImpAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkTalleImpActionEnum.EnumespstkTalleImpAction.Guardar: lRetorno = "espstkTalleImpGuardar"; break;
                case espstkTalleImpActionEnum.EnumespstkTalleImpAction.Datos: lRetorno = "espstkTalleImpDevolverDatos"; break;
                case espstkTalleImpActionEnum.EnumespstkTalleImpAction.Eliminar: lRetorno = "espstkTalleImpEliminar"; break;
            }
            return lRetorno;
        }
    }
}
