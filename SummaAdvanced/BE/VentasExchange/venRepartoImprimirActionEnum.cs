using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venRepartoImprimirActionEnum
        {            public enum EnumvenRepartoImprimirAction
            {
                Guardar,Datos,AsignarNombre
            }
        public static string GetAccionvenRepartoImprimirAction(venRepartoImprimirActionEnum.EnumvenRepartoImprimirAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRepartoImprimirActionEnum.EnumvenRepartoImprimirAction.Guardar: lRetorno = "venRepartoImprimirGuardar"; break;
                case venRepartoImprimirActionEnum.EnumvenRepartoImprimirAction.Datos: lRetorno = "venRepartoImprimirDevolverDatos"; break;
                case venRepartoImprimirActionEnum.EnumvenRepartoImprimirAction.AsignarNombre: lRetorno = "venRepartoImprimirAsignarNombre"; break;
            }
            return lRetorno;
        }
    }
}
