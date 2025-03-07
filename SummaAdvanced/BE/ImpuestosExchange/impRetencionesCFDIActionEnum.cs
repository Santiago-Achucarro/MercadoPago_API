using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 7 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impRetencionesCFDIActionEnum
        {            public enum EnumimpRetencionesCFDIAction
            {
                Guardar,Datos,Eliminar,Calcular, DatosInt
        }
        public static string GetAccionimpRetencionesCFDIAction(impRetencionesCFDIActionEnum.EnumimpRetencionesCFDIAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impRetencionesCFDIActionEnum.EnumimpRetencionesCFDIAction.Guardar: lRetorno = "impRetencionesCFDIGuardar"; break;
                case impRetencionesCFDIActionEnum.EnumimpRetencionesCFDIAction.Datos: lRetorno = "impRetencionesCFDIDevolverDatos"; break;
                case impRetencionesCFDIActionEnum.EnumimpRetencionesCFDIAction.DatosInt: lRetorno = "impRetencionesCFDIDevolverDatosInt"; break;
                case impRetencionesCFDIActionEnum.EnumimpRetencionesCFDIAction.Eliminar: lRetorno = "impRetencionesCFDIEliminar"; break;
                case impRetencionesCFDIActionEnum.EnumimpRetencionesCFDIAction.Calcular: lRetorno = "impRetencionesCFDICalcular"; break;
            }
            return lRetorno;
        }
    }
}
