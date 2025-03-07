using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 8 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genSegmentosValoresActionEnum
        {   public enum EnumgenSegmentosValoresAction
            {
                Datos
            }
        public static string GetAcciongenSegmentosValoresAction(genSegmentosValoresActionEnum.EnumgenSegmentosValoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genSegmentosValoresActionEnum.EnumgenSegmentosValoresAction.Datos: lRetorno = "genSegmentosValoresDevolverDatos"; break;
            }
            return lRetorno;
        }
        public enum OrigenesN:short
        {
            Pantalla=1,Año=2,Mes=3,Ninguno=0, Ejercicio=7,
            AnioSueldos = 13, MesSueldos = 14, QunSueldos = 15, SemanaSueldos = 16, DecenaSueldos = 17, VezSueldos = 18
        }

        public enum OrigenesS : short
        {
            Pantalla = 1, LetraVen = 5, Ninguno = 0, LetraCom=6, TipoMov=8, Proveedor=9, Despacho=10, Sucursal = 11, Rellena0 = 12
        }

    }
}
