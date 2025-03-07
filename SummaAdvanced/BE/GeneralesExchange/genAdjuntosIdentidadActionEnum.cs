using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 20 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAdjuntosIdentidadActionEnum
        {            public enum EnumgenAdjuntosIdentidadAction
            {
                Guardar,Datos
            }
        public static string GetAcciongenAdjuntosIdentidadAction(genAdjuntosIdentidadActionEnum.EnumgenAdjuntosIdentidadAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAdjuntosIdentidadActionEnum.EnumgenAdjuntosIdentidadAction.Guardar: lRetorno = "genAdjuntosIdentidadGuardar"; break;
                case genAdjuntosIdentidadActionEnum.EnumgenAdjuntosIdentidadAction.Datos: lRetorno = "genAdjuntosIdentidadDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
