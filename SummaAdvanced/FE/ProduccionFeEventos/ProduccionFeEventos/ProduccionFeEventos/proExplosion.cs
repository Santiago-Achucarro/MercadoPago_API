using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProduccionExchange;
using ProduccionCommon;
using System.Data;
using Framework.Core;

namespace ProduccionFeEventos
{
    public class proExplosion
    {
        public enum proExplosionVar
        {
            Receta_Id
        }
        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesReceta(proExplosionDS exch,
          proExplosionDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            ProduccionExchange.proProductosRecetaActionExchange eRelacion = new ProduccionExchange.proProductosRecetaActionExchange(
            Generalidades.QBIInternal.WrapperExecuteActionInternal(
            new ProduccionExchange.proProductosRecetaActionExchange(ProduccionExchange.proProductosRecetaActionEnum.EnumproProductosRecetaAction.Datos)
            {
                Producto_Id = exch.Principal[0].Producto_Id
            }, cmd));
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (eRelacion.Existe)
                lRetorno.Add(proExplosionVar.Receta_Id.ToString(), eRelacion.Receta_Id);
            else
                lRetorno.Add(proExplosionVar.Receta_Id.ToString(), "");
            return lRetorno;

        }

        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string AsignarParametros(ProduccionCommon.proExplosionDS Exch, Command cmd)
        {
            string lRetorno = "";
            lRetorno = "Producto_Id|" + Exch.Principal[0].Producto_Id + "@"+
                "Receta_Id|"+ Exch.Principal[0].Receta_Id+"@"+
                "Cantidad|"+ Exch.Principal[0].Cantidad.ToString()+"@"+
                "Medida_Id|"+Exch.Principal[0].Medida_Id + "@" +
                "SoloFaltantes|" + Exch.Principal[0].SoloFaltantes.ToString();
            return lRetorno;
        }

        [Generalidades.QFuncion_ObtenerDatosReporte]
        public DataSet LlenarDataSet(string pParametros, Framework.Core.Command cmd)
        {
            string[] lPar = pParametros.Split('@');

            ProduccionExchange.proExplosionActionExchange eExplo = new proExplosionActionExchange(proExplosionActionEnum.EnumproExplosionAction.Explotar)
            {
                Producto_Id = lPar[0].Split('|')[1],
                Receta_Id = lPar[1].Split('|')[1],
                Cantidad = Convert.ToDecimal(lPar[2].Split('|')[1]),
                Medida_Id = lPar[3].Split('|')[1],
                SoloFaltantes = Convert.ToBoolean(lPar[4].Split('|')[1])

            };
            eExplo = new proExplosionActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExplo, cmd));

            return eExplo.Param;
        }

    }
}
