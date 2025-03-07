using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ComprasFEEventos
{
    public class comHabilitarPagoMasivos
    {
        

        [Generalidades.QFuncion_Condicion]
        public string CargaImportesExtra(ComprasCommon.comHabilitarPagosMasivosDS exch, Command cmd)
        {
            if (cmd.Dominio_Id == "AR")
                return "S";

            return "N";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comHabilitarPagosMasivosDS Completar(ComprasCommon.comHabilitarPagosMasivosDS Exch, ComprasCommon.comHabilitarPagosMasivosDS exchNoPost, int pIndice, Command cmd)
        {
            if (Exch.PagosHabilitados[pIndice].ImporteHabilitado == 0)

                Exch.PagosHabilitados[pIndice].ImporteHabilitado = Exch.PagosHabilitados[pIndice].Saldo;

            else
                // Sin esto una vez marcado no se podía desmarcar con la cruz EMP 28/08/2021
                Exch.PagosHabilitados[pIndice].ImporteHabilitado = 0;

            return Exch;
        }
    }
}
