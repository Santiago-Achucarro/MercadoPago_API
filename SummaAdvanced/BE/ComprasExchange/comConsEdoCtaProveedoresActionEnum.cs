using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comConsEdoCtaProveedoresActionEnum
        {            public enum EnumcomConsEdoCtaProveedoresAction
            {
                Datos,Aplicar,DesAplicar,AplicarEmbarques, EliminarXML
        }
        public static string GetAccioncomConsEdoCtaProveedoresAction(comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction.Datos: lRetorno = "comConsEdoCtaProveedoresDevolverDatos"; break;
                case comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction.Aplicar: lRetorno = "comConsEdoCtaProveedoresAplicar"; break;
                case comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction.DesAplicar: lRetorno = "comConsEdoCtaProveedoresDesAplicar"; break;
                case comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction.AplicarEmbarques: lRetorno = "comConsEdoCtaProveedoresAplicarEmbarques"; break;
                case comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction.EliminarXML: lRetorno = "comConsEdoCtaProveedoresEliminarXML"; break;

            }
            return lRetorno;
        }
    }
}
