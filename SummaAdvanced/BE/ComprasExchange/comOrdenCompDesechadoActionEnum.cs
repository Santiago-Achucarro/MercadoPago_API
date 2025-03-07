using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 1 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOrdenCompDesechadoActionEnum
        {            public enum EnumcomOrdenCompDesechadoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomOrdenCompDesechadoAction(comOrdenCompDesechadoActionEnum.EnumcomOrdenCompDesechadoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrdenCompDesechadoActionEnum.EnumcomOrdenCompDesechadoAction.Guardar: lRetorno = "comOrdenCompDesechadoGuardar"; break;
                case comOrdenCompDesechadoActionEnum.EnumcomOrdenCompDesechadoAction.Datos: lRetorno = "comOrdenCompDesechadoDevolverDatos"; break;
                case comOrdenCompDesechadoActionEnum.EnumcomOrdenCompDesechadoAction.Eliminar: lRetorno = "comOrdenCompDesechadoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
