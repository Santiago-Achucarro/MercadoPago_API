using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proOrdenProd
    {
        public static proOrdenProdDS Datos(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proOrdenProdDatos", parametros);

            string[] camposTabla0 = { "Deposito_Id", "DescripcionDepositos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proOrdenProdDS dsTipado = new proOrdenProdDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proOrdenProdEliminar", parametros);
        }

        public static void Guardar(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/pProducto_Id, string /*3*/pEntradaSalida, string /*4*/pMedida_Id, decimal /*5*/pCantidad, decimal /*6*/pPorcentajeCosto, string /*7*/pDeposito_Id, bool /*8*/pTomaDepoT3, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pRenglon, /*2*/pProducto_Id, /*3*/pEntradaSalida, /*4*/pMedida_Id, /*5*/pCantidad, /*6*/pPorcentajeCosto, new Generalidades.NullableString(/*7*/pDeposito_Id), /*8*/pTomaDepoT3 };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proOrdenProdGuardar", parametros);
        }

    }
}
