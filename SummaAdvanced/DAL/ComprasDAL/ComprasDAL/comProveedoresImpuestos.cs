using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comProveedoresImpuestos
    {
        public static comProveedoresImpuestosDS Datos(string /*0*/pProveed_Id, string /*1*/pImpuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pImpuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comProveedoresImpuestosDatos", parametros);

            comProveedoresImpuestosDS dsTipado = new comProveedoresImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pProveed_Id, string /*1*/pImpuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, new Generalidades.NullableString(/*1*/pImpuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comProveedoresImpuestosEliminar", parametros);
        }

        public static void Insertar(long /*0*/pProveed_Id, string /*1*/pImpuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pImpuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comProveedoresImpuestosInsertar", parametros);
        }


    }
}
