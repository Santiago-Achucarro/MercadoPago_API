using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 6 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comProveedoresSaldoIniActionEnum
    {
        public enum EnumcomProveedoresSaldoIniAction
        {
            Guardar, Datos, ImportarXls
        }
        public static string GetAccioncomProveedoresSaldoIniAction(comProveedoresSaldoIniActionEnum.EnumcomProveedoresSaldoIniAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProveedoresSaldoIniActionEnum.EnumcomProveedoresSaldoIniAction.Guardar: lRetorno = "comProveedoresSaldoIniGuardar"; break;
                case comProveedoresSaldoIniActionEnum.EnumcomProveedoresSaldoIniAction.Datos: lRetorno = "comProveedoresSaldoIniDevolverDatos"; break;
                case comProveedoresSaldoIniActionEnum.EnumcomProveedoresSaldoIniAction.ImportarXls: lRetorno = "comProveedoresSaldoIniImportarXls"; break;

            }
            return lRetorno;
        }
    }
}
