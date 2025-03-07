using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ContabilidadFEEventos
{
    public class conAsientos
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string DebeHaber(ContabilidadCommon.conAsientosContDS ExcPost,
                ContabilidadCommon.conAsientosContDS ExcNoPos, int Indice,  Command cmd)
        {

            if (ExcNoPos.grdCuerpo[0].Debe != 0)
                return "D";

            if (ExcNoPos.grdCuerpo[0].Haber != 0)
                return "H";


            return "N";


        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(ContabilidadCommon.conAsientosContDS ExcPost,
                ContabilidadCommon.conAsientosContDS ExcNoPos, int Indice, Command cmd)
        {
            if (ExcNoPos.grdCuerpo[0].Debe == 0 && ExcNoPos.grdCuerpo[0].Haber == 0)
                return "Debe_Ingresar_un_Importe";

            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputable(ExcNoPos.grdCuerpo[0].Cuenta_Id, cmd);

            return "";

        }
        /*
        [Generalidades.QFuncion_AccionGrilla]
        public ContabilidadCommon.conAsientosContDS AsignarDebe(ContabilidadCommon.conAsientosContDS ExcPost,
                ContabilidadCommon.conAsientosContDS ExcNoPos, int Indice, Command cmd)
        {
            if (ExcNoPos.grdCuerpo[0].Debe!=0)
                ExcNoPos.grdCuerpo[0].Haber = 0;

            return ExcNoPos;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public ContabilidadCommon.conAsientosContDS AsignarHaber(ContabilidadCommon.conAsientosContDS ExcPost,
        ContabilidadCommon.conAsientosContDS ExcNoPos, int Indice, Command cmd)
        {
            if (ExcNoPos.grdCuerpo[0].Haber != 0)
                ExcNoPos.grdCuerpo[0].Debe = 0;

            return ExcNoPos;

        }
        */

    }
}
