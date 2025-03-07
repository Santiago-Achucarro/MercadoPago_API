using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 5 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesDepositoActionEnum
        {            public enum EnumtesDepositoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesDepositoAction(tesDepositoActionEnum.EnumtesDepositoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesDepositoActionEnum.EnumtesDepositoAction.Guardar: lRetorno = "tesDepositoGuardar"; break;
                case tesDepositoActionEnum.EnumtesDepositoAction.Datos: lRetorno = "tesDepositoDevolverDatos"; break;
                case tesDepositoActionEnum.EnumtesDepositoAction.Eliminar: lRetorno = "tesDepositoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
