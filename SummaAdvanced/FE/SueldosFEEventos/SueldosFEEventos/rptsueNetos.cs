using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    class rptsueNetos
    {
        [Generalidades.QFuncion_AccionFE]
        public SueldosReportesCommon.sueNetosDS VezActiva(SueldosReportesCommon.sueNetosDS pCommonDS, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Anio == 0)
            {
                SueldosReportesCommon.sueNetosDS res = new SueldosReportesCommon.sueNetosDS();
                res.Merge(SueldosValidacion.sueVezActiva.Asignar(new Framework.Core.Exchange("", pCommonDS), cmd).RawDataSet, false, System.Data.MissingSchemaAction.Ignore);
                return res;
            }
            else
                return pCommonDS;
        }
    }
}
