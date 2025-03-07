using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContabilidadFEEventos
{
    public class conAsientosTipo
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string DebeHaber(ContabilidadCommon.conAsientosTipoDS ExcPost,
        ContabilidadCommon.conAsientosTipoDS ExcNoPos, int Indice, Command cmd)
        {

            if (ExcNoPos.Cuerpo[0].Debe != 0)
                return "D";

            if (ExcNoPos.Cuerpo[0].Haber != 0)
                return "H";


            return "D";


        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(ContabilidadCommon.conAsientosTipoDS ExcPost,
                ContabilidadCommon.conAsientosTipoDS ExcNoPos, int Indice, Command cmd)
        {
            //if (ExcNoPos.Cuerpo[0].Debe == 0 && ExcNoPos.Cuerpo[0].Haber == 0)
            //    return "Debe_Ingresar_un_Importe";

            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputable(ExcNoPos.Cuerpo[0].Cuenta_Id, cmd);

            return "";

        }

    }
}
