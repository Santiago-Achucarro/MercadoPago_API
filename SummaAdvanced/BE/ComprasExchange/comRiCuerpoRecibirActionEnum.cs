using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRiCuerpoRecibirActionEnum
        {            public enum EnumcomRiCuerpoRecibirAction
            {
                Guardar
            }
        public static string GetAccioncomRiCuerpoRecibirAction(comRiCuerpoRecibirActionEnum.EnumcomRiCuerpoRecibirAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRiCuerpoRecibirActionEnum.EnumcomRiCuerpoRecibirAction.Guardar: lRetorno = "comRiCuerpoRecibirGuardar"; break;
            }
            return lRetorno;
        }
    }
}
