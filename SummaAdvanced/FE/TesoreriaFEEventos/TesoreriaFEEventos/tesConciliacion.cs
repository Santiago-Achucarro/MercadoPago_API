using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesoreriaFEEventos
{
    public class tesConciliacion
    {
        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesConciliacionDS MarcarCheques(TesoreriaCommon.tesConciliacionDS ExcPost,
               TesoreriaCommon.tesConciliacionDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            // FM 28/03/2019 Que busque también los saldos iniciales //
            if (ExcNoPos.Cuerpo[Indice].SubTipo_Id == "DE3" || ExcNoPos.Cuerpo[Indice].SubTipo_Id == "AIB")
            {
                if (!ExcNoPos.Cuerpo[Indice].PorCheque)
                {
                    // Marco los de Adentro
                    foreach (var ren in ExcNoPos.Cheques)
                        ren.Marca = true;
                    ExcNoPos.Cuerpo[Indice].Marca = true;

                }
                ExcNoPos.Cuerpo[Indice].PorCheque = true;
            }
            else
            {
                Generalidades.qFunctionalException.GenerarExcepcion("Esto_es_solo_para_deposito_de_cheques");
            }
            return ExcNoPos;
        }
    }
}
