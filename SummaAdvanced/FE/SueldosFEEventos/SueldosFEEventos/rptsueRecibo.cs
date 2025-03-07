using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    class rptsueRecibo
    {
        [Generalidades.QFuncion_AccionFE]
        public SueldosReportesCommon.sueRecibosDS VezActiva(SueldosReportesCommon.sueRecibosDS pCommonDS, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Anio == 0)
            {
                SueldosReportesCommon.sueRecibosDS res = new SueldosReportesCommon.sueRecibosDS();
                res.Merge(SueldosValidacion.sueVezActiva.Asignar(new Framework.Core.Exchange("", pCommonDS), cmd).RawDataSet, false, System.Data.MissingSchemaAction.Ignore);
                return res;
            }
            else
                return pCommonDS;
        }
    }
}
