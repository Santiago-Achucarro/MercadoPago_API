using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvEmbDatosFullActionEnum
        {            public enum EnumcomMovProvEmbDatosFullAction
            {
                Datos
            }
        public static string GetAccioncomMovProvEmbDatosFullAction(comMovProvEmbDatosFullActionEnum.EnumcomMovProvEmbDatosFullAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvEmbDatosFullActionEnum.EnumcomMovProvEmbDatosFullAction.Datos: lRetorno = "comMovProvEmbDatosFullDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
