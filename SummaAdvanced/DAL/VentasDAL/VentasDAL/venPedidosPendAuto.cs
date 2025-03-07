using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;


namespace VentasDAL
{
    public class venPedidosPendAuto
    {
        public static venPedidosPendAutoDS Datos(int /*0*/Empresa_Id, int /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosPendAuto", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "ObservEstado", "ResultadoFormula", "MVendedor", "MListaP", "MFormaE",
                "MBonifDato", "MPrecioReng", "MBonifReng" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);



            venPedidosPendAutoDS dsTipado = new venPedidosPendAutoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Pedidos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
