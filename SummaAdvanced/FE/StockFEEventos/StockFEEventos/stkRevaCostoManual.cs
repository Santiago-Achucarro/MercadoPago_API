using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkRevaCostoManual
    {
        [Generalidades.QFuncion_Condicion]
        public string CostoSucursal(StockCommon.stkRevaCostoManualDS exch, Framework.Core.Command cmd)
        {

            if (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).TipoCosto == "S")
                return "S";

            return "N";

        }


    }
}
