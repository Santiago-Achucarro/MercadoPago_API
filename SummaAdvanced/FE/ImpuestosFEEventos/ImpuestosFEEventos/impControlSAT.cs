using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ImpuestosFEEventos
{
    public class impControlSAT
    {

        [Generalidades.QFuncion_ObtenerDatosReporte]
        public DataSet LlenarReporte(string pParametros, Framework.Core.Command cmd)
        {
            DataSet lRetorno = new DataSet();

            // AVERIGUO LOS PARAMETROS
            string[] lPar = pParametros.Split('@');

            DateTime lFechaDesde = Convert.ToDateTime(lPar[2].Split('|')[1]);
            DateTime lFechaHasta = Convert.ToDateTime(lPar[3].Split('|')[1]);
            string lProveedDesde = lPar[0].Split('|')[1];
            string lProveedHasta = lPar[1].Split('|')[1];
            bool lSoloErrores = Convert.ToBoolean(lPar[4].Split('|')[1]);

            ImpuestosExchange.impValidacionFComprasActionExchange req = new ImpuestosExchange.impValidacionFComprasActionExchange(ImpuestosExchange.impValidacionFComprasActionEnum.EnumimpValidacionFComprasAction.Datos)
            {
                FechaDesde = lFechaDesde,
                FechaHasta = lFechaHasta,
                ProveedDesde = lProveedDesde,
                ProveedHasta = lProveedHasta,
                SoloConErrores = lSoloErrores
            };
            req = new ImpuestosExchange.impValidacionFComprasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(req, cmd));
            lRetorno.Tables.Add("Principal");
            lRetorno.Tables[0].Merge(req.Param.Cuerpo, true);
            return lRetorno;
        }
    }
}
