using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 14 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comTraePendientesActionEnum
        {            public enum EnumcomTraePendientesAction
            {
                Datos
            }
        public static string GetAccioncomTraePendientesAction(comTraePendientesActionEnum.EnumcomTraePendientesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comTraePendientesActionEnum.EnumcomTraePendientesAction.Datos: lRetorno = "comTraePendientesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
