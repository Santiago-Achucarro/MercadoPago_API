using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ComprasFEEventos
{
    public class comOCPendAuto
    {
        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comOrdenCompPendAutoDS DatosOc(ComprasCommon.comOrdenCompPendAutoDS exch,
         ComprasCommon.comOrdenCompPendAutoDS exchNoPost, int pIndice, Command cmd)
        {
            
            ComprasExchange.comOrdenCompActionExchange eOrdenComp = new ComprasExchange.comOrdenCompActionExchange(ComprasExchange.comOrdenCompActionEnum.EnumcomOrdenCompAction.Datos)
            {
                Empresa_Id=cmd.Empresa_Id,
                Segmento_Id= exch.Cuerpo[pIndice].Segmento_Id,
                Segmento1N= exch.Cuerpo[pIndice].Segmento1N,
                Segmento2N = exch.Cuerpo[pIndice].Segmento2N,
                Segmento3N = exch.Cuerpo[pIndice].Segmento3N,
                Segmento4N = exch.Cuerpo[pIndice].Segmento4N,
                Segmento1C = exch.Cuerpo[pIndice].Segmento1C,
                Segmento2C = exch.Cuerpo[pIndice].Segmento2C,
                Segmento3C = exch.Cuerpo[pIndice].Segmento3C,
                Segmento4C = exch.Cuerpo[pIndice].Segmento4C
            };
            eOrdenComp = new ComprasExchange.comOrdenCompActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eOrdenComp, cmd));
            exch.CabeceraOc.Clear();
            exch.comOCArticulo.Clear();
            exch.comOcMemo.Clear();
            exch.CabeceraOc.Merge(eOrdenComp.Param.Principal, false, System.Data.MissingSchemaAction.Ignore);
            exch.comOCArticulo.Merge(eOrdenComp.Param.CuerpoArti, false, System.Data.MissingSchemaAction.Ignore);
            exch.comOcMemo.Merge(eOrdenComp.Param.CuerpoMemo, false, System.Data.MissingSchemaAction.Ignore);

            return exch;
        }
    }
}
