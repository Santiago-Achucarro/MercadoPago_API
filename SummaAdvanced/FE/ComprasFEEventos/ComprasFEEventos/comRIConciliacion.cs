using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ComprasFEEventos
{
    public class comRIConciliacion
    {
        [Generalidades.QFuncion_Condicion]
        public string TipoCuerpo(ComprasCommon.comRIConsolidacionDS exch, Command cmd)
        {
            ComprasExchange.comTipoPermiActionExchange ExcTP = new ComprasExchange.comTipoPermiActionExchange(ComprasExchange.comTipoPermiActionEnum.EnumcomTipoPermiAction.Datos);

            ExcTP.TipoPermi_Id = exch.Principal[0].TipoPermi_Id;

            ExcTP = new ComprasExchange.comTipoPermiActionExchange(
                                Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcTP, cmd));

            if (ExcTP.Existe)
                return ExcTP.TipoCuerpo;

            return "P";
        }
    }
}
