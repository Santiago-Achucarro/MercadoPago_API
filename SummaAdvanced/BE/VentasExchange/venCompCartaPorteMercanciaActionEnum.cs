using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 31 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCompCartaPorteMercanciaActionEnum
        {            public enum EnumvenCompCartaPorteMercanciaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCompCartaPorteMercanciaAction(venCompCartaPorteMercanciaActionEnum.EnumvenCompCartaPorteMercanciaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCompCartaPorteMercanciaActionEnum.EnumvenCompCartaPorteMercanciaAction.Guardar: lRetorno = "venCompCartaPorteMercanciaGuardar"; break;
                case venCompCartaPorteMercanciaActionEnum.EnumvenCompCartaPorteMercanciaAction.Datos: lRetorno = "venCompCartaPorteMercanciaDevolverDatos"; break;
                case venCompCartaPorteMercanciaActionEnum.EnumvenCompCartaPorteMercanciaAction.Eliminar: lRetorno = "venCompCartaPorteMercanciaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
