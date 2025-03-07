using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 19 de mayo de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comConsEdoCtaProveedoresTesoreriaActionEnum
        {            public enum EnumcomConsEdoCtaProveedoresTesoreriaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomConsEdoCtaProveedoresTesoreriaAction(comConsEdoCtaProveedoresTesoreriaActionEnum.EnumcomConsEdoCtaProveedoresTesoreriaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comConsEdoCtaProveedoresTesoreriaActionEnum.EnumcomConsEdoCtaProveedoresTesoreriaAction.Guardar: lRetorno = "comConsEdoCtaProveedoresTesoreriaGuardar"; break;
                case comConsEdoCtaProveedoresTesoreriaActionEnum.EnumcomConsEdoCtaProveedoresTesoreriaAction.Datos: lRetorno = "comConsEdoCtaProveedoresTesoreriaDevolverDatos"; break;
                case comConsEdoCtaProveedoresTesoreriaActionEnum.EnumcomConsEdoCtaProveedoresTesoreriaAction.Eliminar: lRetorno = "comConsEdoCtaProveedoresTesoreriaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
