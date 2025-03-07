using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 20 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClientesActionEnum
        {            public enum EnumvenClientesAction
            {
                Guardar,Datos,Eliminar,DatosId
            }
        public static string GetAccionvenClientesAction(venClientesActionEnum.EnumvenClientesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClientesActionEnum.EnumvenClientesAction.Guardar: lRetorno = "venClientesGuardar"; break;
                case venClientesActionEnum.EnumvenClientesAction.Datos: lRetorno = "venClientesDevolverDatos"; break;
                case venClientesActionEnum.EnumvenClientesAction.Eliminar: lRetorno = "venClientesEliminar"; break;
                case venClientesActionEnum.EnumvenClientesAction.DatosId: lRetorno = "venClientesDatosId"; break;
            }
            return lRetorno;
        }
    }
}
