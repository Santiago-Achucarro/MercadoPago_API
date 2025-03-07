using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 11 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class AfiRubrosActionEnum
        {            public enum EnumAfiRubrosAction
            {
                Guardar,Datos,Eliminar, DatosCuenta
        }
        public static string GetAccionAfiRubrosAction(AfiRubrosActionEnum.EnumAfiRubrosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case AfiRubrosActionEnum.EnumAfiRubrosAction.Guardar: lRetorno = "AfiRubrosGuardar"; break;
                case AfiRubrosActionEnum.EnumAfiRubrosAction.Datos: lRetorno = "AfiRubrosDevolverDatos"; break;
                case AfiRubrosActionEnum.EnumAfiRubrosAction.Eliminar: lRetorno = "AfiRubrosEliminar"; break;
                case AfiRubrosActionEnum.EnumAfiRubrosAction.DatosCuenta: lRetorno = "AfiRubrosCuentaDatos"; break;
            }
            return lRetorno;
        }
    }
}
