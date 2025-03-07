using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCondFiscImp
    {
        public static venCondFiscImpDS Datos(string /*0*/pCondFisc_id, string /*1*/pImpuesto_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondFisc_id, /*1*/pImpuesto_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCondFiscImpDatos", parametros);

            venCondFiscImpDS dsTipado = new venCondFiscImpDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCondFisc_id, string /*1*/pImpuesto_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondFisc_id, new Generalidades.NullableString(/*1*/pImpuesto_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCondFiscImpEliminar", parametros);
        }

        public static void Insertar(int /*0*/pvenCondFiscal, string /*1*/Impuesto_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenCondFiscal, /*1*/Impuesto_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCondFiscImpInsertar", parametros);
        }


    }
}
