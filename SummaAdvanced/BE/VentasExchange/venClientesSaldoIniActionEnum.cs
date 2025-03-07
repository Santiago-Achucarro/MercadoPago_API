using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 15 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClientesSaldoIniActionEnum
        {            public enum EnumvenClientesSaldoIniAction
            {
                Guardar,Datos,TraerXls
            }
        public static string GetAccionvenClientesSaldoIniAction(venClientesSaldoIniActionEnum.EnumvenClientesSaldoIniAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClientesSaldoIniActionEnum.EnumvenClientesSaldoIniAction.Guardar: lRetorno = "venClientesSaldoIniGuardar"; break;
                case venClientesSaldoIniActionEnum.EnumvenClientesSaldoIniAction.Datos: lRetorno = "venClientesSaldoIniDevolverDatos"; break;
                case venClientesSaldoIniActionEnum.EnumvenClientesSaldoIniAction.TraerXls: lRetorno = "venClientesSaldoIniTraerXls"; break;
            }
            return lRetorno;
        }
    }
}
