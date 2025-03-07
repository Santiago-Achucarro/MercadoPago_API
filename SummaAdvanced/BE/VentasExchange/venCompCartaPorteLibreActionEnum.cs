using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de diciembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCompCartaPorteLibreActionEnum
        {            public enum EnumvenCompCartaPorteLibreAction
            {
                Guardar,Datos,Eliminar,Descargar
            }
        public static string GetAccionvenCompCartaPorteLibreAction(venCompCartaPorteLibreActionEnum.EnumvenCompCartaPorteLibreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCompCartaPorteLibreActionEnum.EnumvenCompCartaPorteLibreAction.Guardar: lRetorno = "venCompCartaPorteLibreGuardar"; break;
                case venCompCartaPorteLibreActionEnum.EnumvenCompCartaPorteLibreAction.Datos: lRetorno = "venCompCartaPorteLibreDevolverDatos"; break;
                case venCompCartaPorteLibreActionEnum.EnumvenCompCartaPorteLibreAction.Eliminar: lRetorno = "venCompCartaPorteLibreEliminar"; break;
                case venCompCartaPorteLibreActionEnum.EnumvenCompCartaPorteLibreAction.Descargar: lRetorno = "venCompCartaPorteLibreDescargar"; break;
                
                    
            }
            return lRetorno;
        }
    }
}
