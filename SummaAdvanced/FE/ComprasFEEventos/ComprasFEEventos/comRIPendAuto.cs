using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ComprasFEEventos
{
    public class comRIPendAuto
    {
        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comReqInternoPendAutoDS DatosOc(ComprasCommon.comReqInternoPendAutoDS exch,
        ComprasCommon.comReqInternoPendAutoDS exchNoPost, int pIndice, Command cmd)
        {

            ComprasExchange.comReqInternoActionExchange eReqInterno = new ComprasExchange.comReqInternoActionExchange(ComprasExchange.comReqInternoActionEnum.EnumcomReqInternoAction.Datos)
            {
                Empresa_Id = cmd.Empresa_Id,
                Segmento_Id = exch.Cuerpo[pIndice].Segmento_Id,
                Segmento1N = exch.Cuerpo[pIndice].Segmento1N,
                Segmento2N = exch.Cuerpo[pIndice].Segmento2N,
                Segmento3N = exch.Cuerpo[pIndice].Segmento3N,
                Segmento4N = exch.Cuerpo[pIndice].Segmento4N,
                Segmento1C = exch.Cuerpo[pIndice].Segmento1C,
                Segmento2C = exch.Cuerpo[pIndice].Segmento2C,
                Segmento3C = exch.Cuerpo[pIndice].Segmento3C,
                Segmento4C = exch.Cuerpo[pIndice].Segmento4C
            };
            eReqInterno = new ComprasExchange.comReqInternoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eReqInterno, cmd));
            exch.RIPrincipal.Clear();
            exch.RICuerpoArti.Clear();
            exch.RICuerpoMemo.Clear();
            exch.RIPrincipal.Merge(eReqInterno.Param.Principal, false, System.Data.MissingSchemaAction.Ignore);
            exch.RICuerpoArti.Merge(eReqInterno.Param.CuerpoArti, false, System.Data.MissingSchemaAction.Ignore);
            exch.RICuerpoMemo.Merge(eReqInterno.Param.CuerpoMemo, false, System.Data.MissingSchemaAction.Ignore);
            return exch;
        }
    }
}
