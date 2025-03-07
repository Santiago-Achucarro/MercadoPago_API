using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 24 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genJurisCoeficientesActionEnum
    {
        public enum EnumgenJurisCoeficientesAction
        {
            Guardar, Eliminar
        }
        public static string GetAcciongenJurisCoeficientesAction(genJurisCoeficientesActionEnum.EnumgenJurisCoeficientesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genJurisCoeficientesActionEnum.EnumgenJurisCoeficientesAction.Guardar: lRetorno = "genJurisCoeficientesGuardar"; break;
                case genJurisCoeficientesActionEnum.EnumgenJurisCoeficientesAction.Eliminar: lRetorno = "genJurisCoeficientesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
