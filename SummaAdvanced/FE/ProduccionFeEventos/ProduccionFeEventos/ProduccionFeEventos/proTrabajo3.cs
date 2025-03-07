using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionFeEventos
{
    public class proTrabajo3
    {
        [Generalidades.QFuncion_CondicionGrilla]
         public string ValidarFila(ProduccionCommon.proTrabajo3DS exch,
            ProduccionCommon.proTrabajo3DS exchNoPost, int pIndice, Command cmd)
        {
            ComprasValidacion.comProveedores.AnexoExistePosteadoyActiva(exchNoPost.Trabajo3Prov[0].Proveed_Id, cmd);
            GeneralesValidacion.genMonedas.ExistePosteadoyActiva(exchNoPost.Trabajo3Prov[0].Moneda_Id, cmd);
            return "";
        }
    }
}
