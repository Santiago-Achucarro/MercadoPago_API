using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ContabilidadFEEventos
{
    public class conCuentasActualizacion
    {
        [Generalidades.QFuncion_Condicion]
        public string QueNivel(ContabilidadCommon.conCuentasActualizacionDS lDs, Command cmd)
        {
            if (lDs.Principal[0].Nivel < 3)
                return "A";

            if (lDs.Principal[0].Nivel == 3)
                return "B";

            return "C";
        }


        [Generalidades.QFuncion_Condicion]
        public string conSubCuentas(ContabilidadCommon.conCuentasActualizacionDS lDs, Command cmd)
        {
            if (lDs.Principal[0].Nivel >= 2 && !lDs.Principal[0].Imputable)
            {
                ContabilidadExchange.conRubrosActionExchange Exc =
                        new ContabilidadExchange.conRubrosActionExchange(ContabilidadExchange.conRubrosActionEnum.EnumconRubrosAction.Datos);
                Exc.Rubro_Id = lDs.Principal[0].Rubro_Id;

                Exc = new ContabilidadExchange.conRubrosActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(Exc, cmd));
                if (Exc.Existe)
                {
                    if (Exc.Tipo == "GAS" || Exc.Tipo == "COS")
                        return "S";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string Ajustable(ContabilidadCommon.conCuentasActualizacionDS lDs, Command cmd)
        {
            return lDs.Principal[0].Ajustable ? "S" : "N";
        }
    }
}
