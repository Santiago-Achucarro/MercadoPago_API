using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockDAL
{
    public class stkUbiAlmacenDefecto
    {
        public static stkUbiAlmacenDS DatosAlmacen(int /*0*/pEmpresa_Id, string /*1*/pDeposito_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pDeposito_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkUbiAlmacenDatos", parametros);

            stkUbiAlmacenDS dsTipado = new stkUbiAlmacenDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkUbiAlmacenDefectoDS Datos(int /*0*/pEmpresa_Id, string /*1*/pDeposito_Id, string /*2*/pProducto_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pDeposito_Id, new Generalidades.NullableString(/*2*/pProducto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkUbiAlmacenDefectoDatos", parametros);

            stkUbiAlmacenDefectoDS dsTipado = new stkUbiAlmacenDefectoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/pDeposito_Id, string /*2*/pProducto_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pDeposito_Id, new Generalidades.NullableString(/*2*/pProducto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkUbiAlmacenDefectoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pEmpresa_Id, string /*1*/pDeposito_Id, string /*2*/pProducto_Id, string /*3*/pUbicacion_Id, int /*4*/pUsuario_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pDeposito_Id, /*2*/pProducto_Id, /*3*/pUbicacion_Id, /*4*/pUsuario_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkUbiAlmacenDefectoGuardar", parametros);
        }

    }
}
