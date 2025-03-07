using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    class rptsueNomina
    {
        [Generalidades.QFuncion_AccionFE]
        public SueldosReportesCommon.sueNominaDS VezActiva(SueldosReportesCommon.sueNominaDS pCommonDS, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Anio == 0)
            {
                SueldosReportesCommon.sueNominaDS res = new SueldosReportesCommon.sueNominaDS();
                res.Merge(SueldosValidacion.sueVezActiva.Asignar(new Framework.Core.Exchange("", pCommonDS), cmd).RawDataSet, false, System.Data.MissingSchemaAction.Ignore);
                return res;
            }
            else
                return pCommonDS;
        }
    }
}
