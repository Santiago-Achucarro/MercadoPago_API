using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 23 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvDPreFactDirActionEnum
        {            public enum EnumcomMovProvDPreFactDirAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovProvDPreFactDirAction(comMovProvDPreFactDirActionEnum.EnumcomMovProvDPreFactDirAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDPreFactDirActionEnum.EnumcomMovProvDPreFactDirAction.Guardar: lRetorno = "comMovProvDPreFactDirGuardar"; break;
                case comMovProvDPreFactDirActionEnum.EnumcomMovProvDPreFactDirAction.Datos: lRetorno = "comMovProvDPreFactDirDevolverDatos"; break;
                case comMovProvDPreFactDirActionEnum.EnumcomMovProvDPreFactDirAction.Eliminar: lRetorno = "comMovProvDPreFactDirEliminar"; break;
            }
            return lRetorno;
        }
    }
}
