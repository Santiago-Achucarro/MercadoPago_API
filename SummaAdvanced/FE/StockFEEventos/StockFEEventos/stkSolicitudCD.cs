using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockFEEventos
{
    public class stkSolicitudCD
    {

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkSolicitudCDDS exch,
          stkSolicitudCDDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            string lDepo =
            GeneralesValidacion.genSucursalesEmpr.Existe(
            GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal, cmd).DepositoVentas;
                lRetorno.Add(stkSolicitudCDVar.DepositoOrigen.ToString(),lDepo);

            return lRetorno;
        }

        public enum stkSolicitudCDVar
        {
            DepositoOrigen
        }
    }
}
