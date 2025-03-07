using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class suePagosHabi
    {

        
        [Generalidades.QFuncion_AccionGrilla]
        public SueldosCommon.suePagosHabiPendDS TraerEmpleados(SueldosCommon.suePagosHabiPendDS exch, SueldosCommon.suePagosHabiPendDS exchNoPost,
          int pIndice, Framework.Core.Command cmd)
        {

            if (exchNoPost.Empleados.Count == 0)
            {
                // traigo los empledos de la base
                SueldosExchange.suePagosHabiPorEmpleadoPendActionExchange ePorEmp = new SueldosExchange.suePagosHabiPorEmpleadoPendActionExchange(SueldosExchange.suePagosHabiPorEmpleadoPendActionEnum.EnumsuePagosHabiPorEmpleadoPendAction.Datos)
                {
                    sueLiquidacion = exchNoPost.Liquidaciones[0].sueLiquidacion

                };
                ePorEmp = new SueldosExchange.suePagosHabiPorEmpleadoPendActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePorEmp, cmd));
                foreach (var ren in ePorEmp.Param.Empleados)
                {
                    exchNoPost.Empleados.AddEmpleadosRow(false, 1, ren.Legajo, ren.DescripcionPersonal, ren.sueLiquidacion, 0,
                            ren.FechaHabilitacion, ren.Importe, ren.Usuario_Id, ren.DescripcionUsuario, ren.Anio, ren.Mes, ren.Quincena, 
                            ren.Decena, ren.Semana, ren.Vez);
                }

            }

            return exchNoPost;

        }
        
    }
}
