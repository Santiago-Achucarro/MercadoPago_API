using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 24 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesT3PromocionesVigentesActionEnum
        {            public enum EnumtesT3PromocionesVigentesAction
            {
                Datos
            }
        public static string GetAcciontesT3PromocionesVigentesAction(tesT3PromocionesVigentesActionEnum.EnumtesT3PromocionesVigentesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesT3PromocionesVigentesActionEnum.EnumtesT3PromocionesVigentesAction.Datos: lRetorno = "tesT3PromocionesVigentesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
