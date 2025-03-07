using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCotizPedido
    {
        public static venCotizPedidosDS Datos(int /*0*/pCotizacion_Id, int /*1*/pPedido_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id, /*1*/pPedido_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCotizPedidosDatos", parametros);

            venCotizPedidosDS dsTipado = new venCotizPedidosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pCotizacion_Id, int /*1*/pPedido_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id, /*1*/pPedido_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCotizPedidosEliminar", parametros);
        }

        public static void Guardar(int /*0*/pCotizacion_Id, int /*1*/pPedido_Id, decimal /*2*/pImporte, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id, /*1*/pPedido_Id, /*2*/pImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizPedidosGuardar", parametros);
        }


    }
}
