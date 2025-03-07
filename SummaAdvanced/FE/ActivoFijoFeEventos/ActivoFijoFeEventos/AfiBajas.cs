using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ActivoFijoFeEventos
{
    public class AfiBajas
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(ActivoFijoCommon.AfiBajasDS exch, ActivoFijoCommon.AfiBajasDS exchNoPost,
           int pIndice, Command cmd)
        {
            if (exchNoPost.Cuerpo[0].Importe == 0)
                return "El_Importe_Debe_Ser_Distinto_de_Cero";

            return "";
        }
    }
}

