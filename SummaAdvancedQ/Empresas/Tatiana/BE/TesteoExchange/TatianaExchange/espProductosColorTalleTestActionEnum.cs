using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TatianaExchange{
        public static class espProductosColorTalleTestActionEnum
        {            public enum EnumespProductosColorTalleTestAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespProductosColorTalleTestAction(espProductosColorTalleTestActionEnum.EnumespProductosColorTalleTestAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espProductosColorTalleTestActionEnum.EnumespProductosColorTalleTestAction.Guardar: lRetorno = "espProductosColorTalleTestGuardar"; break;
                case espProductosColorTalleTestActionEnum.EnumespProductosColorTalleTestAction.Datos: lRetorno = "espProductosColorTalleTestDevolverDatos"; break;
                case espProductosColorTalleTestActionEnum.EnumespProductosColorTalleTestAction.Eliminar: lRetorno = "espProductosColorTalleTestEliminar"; break;
            }
            return lRetorno;
        }
    }
}
