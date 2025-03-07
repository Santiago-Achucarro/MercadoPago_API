using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasFEEventos
{
    public class comHabilitarPagos
    {
        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comHabilitarPagosDS CopiarImporte(ComprasCommon.comHabilitarPagosDS exch,
    ComprasCommon.comHabilitarPagosDS exchNoPost, int pIndice, Command cmd)
        {
            exchNoPost.PagosHabilitados[0].ImporteHabilitado = exchNoPost.PagosHabilitados[0].Saldo;

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public string CargaImportesExtra(ComprasCommon.comHabilitarPagosDS exch, Command cmd)
        {
            if (cmd.Dominio_Id == "AR")
                return "S";

            return "N";
        }
    }
}