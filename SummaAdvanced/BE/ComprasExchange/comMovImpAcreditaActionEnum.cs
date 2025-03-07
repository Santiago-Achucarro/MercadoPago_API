using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovImpAcreditaActionEnum
        {            public enum EnumcomMovImpAcreditaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovImpAcreditaAction(comMovImpAcreditaActionEnum.EnumcomMovImpAcreditaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovImpAcreditaActionEnum.EnumcomMovImpAcreditaAction.Guardar: lRetorno = "comMovImpAcreditaGuardar"; break;
                case comMovImpAcreditaActionEnum.EnumcomMovImpAcreditaAction.Datos: lRetorno = "comMovImpAcreditaDevolverDatos"; break;
                case comMovImpAcreditaActionEnum.EnumcomMovImpAcreditaAction.Eliminar: lRetorno = "comMovImpAcreditaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
