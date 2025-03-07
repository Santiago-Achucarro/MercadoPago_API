using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 16 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venNotaDeCreditoAnticipoActionEnum
        {            public enum EnumvenNotaDeCreditoAnticipoAction
            {
                Guardar
            }
        public static string GetAccionvenNotaDeCreditoAnticipoAction(venNotaDeCreditoAnticipoActionEnum.EnumvenNotaDeCreditoAnticipoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venNotaDeCreditoAnticipoActionEnum.EnumvenNotaDeCreditoAnticipoAction.Guardar: lRetorno = "venNotaDeCreditoAnticipoGuardar"; break;
            }
            return lRetorno;
        }
    }
}
