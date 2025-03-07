using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venMLPubliPedido
    {
        public static venMLPubliPedidoDS Datos(long /*0*/pPublicacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPublicacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMLPubliPedidoDatos", parametros);

            venMLPubliPedidoDS dsTipado = new venMLPubliPedidoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Guardar(long /*0*/pPublicacion, int /*1*/pvenPedidos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPublicacion, /*1*/pvenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMLPubliPedidoGuardar", parametros);
        }
    }
}
