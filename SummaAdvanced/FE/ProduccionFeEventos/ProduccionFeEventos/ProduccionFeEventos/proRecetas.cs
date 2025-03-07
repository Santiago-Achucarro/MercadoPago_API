using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionFeEventos
{
    public class proRecetas
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarProductos(ProduccionCommon.proRecetasDS exch, ProduccionCommon.proRecetasDS excNoPos,
                int Indice, Framework.Core.Command cmd)
        {

            StockExchange.stkProductosActionExchange eProducto =
            StockValidacion.stkProductos.ExistePosteadoyActivo(excNoPos.Productos[0].Producto_Id, cmd);
            StockValidacion.stkProductos.Factor(eProducto, excNoPos.Productos[0].Medida_Id);
            if (excNoPos.Productos[0].EntradaSalida != "C" && excNoPos.Productos[0].EntradaSalida != "P")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Tipo_de_Uso_C_o_P");
            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarTrabajos3(ProduccionCommon.proRecetasDS exch, ProduccionCommon.proRecetasDS excNoPos,
                int Indice, Framework.Core.Command cmd)
        {

            ProduccionValidacion.proTrabajo3.ExistePosteadoyActiva(excNoPos.Trabajo3[0].Trabajo3_Id, cmd);

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRecursos(ProduccionCommon.proRecetasDS exch, ProduccionCommon.proRecetasDS excNoPos,
                int Indice, Framework.Core.Command cmd)
        {

            ProduccionValidacion.proRecursos.ExistePosteadoyActiva(excNoPos.Recursos[0].Recurso_Id, cmd);

            return "";
        }

    }
}
