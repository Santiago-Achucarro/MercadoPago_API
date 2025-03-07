using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 11 de mayo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genInstalacionActionEnum
        {            public enum EnumgenInstalacionAction
            {
                Guardar,Datos,SeguridadGuardar, ActualizaLicencia
        }
        public static string GetAcciongenInstalacionAction(genInstalacionActionEnum.EnumgenInstalacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genInstalacionActionEnum.EnumgenInstalacionAction.Guardar: lRetorno = "genInstalacionGuardar"; break;
                case genInstalacionActionEnum.EnumgenInstalacionAction.Datos: lRetorno = "genInstalacionDevolverDatos"; break;
                case genInstalacionActionEnum.EnumgenInstalacionAction.SeguridadGuardar: lRetorno = "genInstalacionSeguridadGuardar"; break;
                case genInstalacionActionEnum.EnumgenInstalacionAction.ActualizaLicencia: lRetorno = "genInstalacionActualizaLicencia"; break;
            }
            return lRetorno;
        }
    }
}
