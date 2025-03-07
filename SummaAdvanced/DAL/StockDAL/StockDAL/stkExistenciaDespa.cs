using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkExistenciaDespa
    {
        public static stkExistenciaDespaDS Datos(string /*0*/pProducto_Id, string /*1*/pDeposito_Id, string /*2*/pDespacho_Id, 
            int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pDeposito_Id, /*2*/pDespacho_Id, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkExistenciaDespaDatos", parametros);

            stkExistenciaDespaDS dsTipado = new stkExistenciaDespaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkExistenciaDespaDS DatosXFifo(string /*0*/pProducto_Id, string /*1*/pDeposito_Id,
            int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pDeposito_Id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkExistenciaDespaXFifo", parametros);

            stkExistenciaDespaDS dsTipado = new stkExistenciaDespaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pProducto_Id, string /*1*/pDeposito_Id, string /*2*/pDespacho_Id, 
            int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pDeposito_Id, /*2*/pDespacho_Id, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkExistenciaDespaEliminar", parametros);
        }

        public static void Sumar(string /*0*/pProducto_Id, string /*1*/pDeposito_Id, string /*2*/pDespacho_Id, 
            decimal /*3*/pCantidad, int /*4*/pEmpresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProducto_Id, /*1*/pDeposito_Id, /*2*/pDespacho_Id, /*3*/pCantidad,
                /*4*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkExistenciaDespaSumar", parametros);
        }
    }
}
