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
    public class comProvCtasContrap
    {
        public static comProvCtasContrapDS Datos(long /*0*/pProveed_Id, string /*1*/pCuenta_Id, string /*2*/pCentro1_Id, string /*3*/pCentro2_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pCuenta_Id, /*2*/pCentro1_Id, /*3*/pCentro2_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comProvCtasContrapDatos", parametros);

            comProvCtasContrapDS dsTipado = new comProvCtasContrapDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pProveed_Id, string /*1*/pCuenta_Id, string /*2*/pCentro1_Id, string /*3*/pCentro2_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, new Generalidades.NullableString(/*1*/pCuenta_Id), new Generalidades.NullableString(/*2*/pCentro1_Id), new Generalidades.NullableString(/*3*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comProvCtasContrapEliminar", parametros);
        }

        public static void Insertar(long /*0*/pProveed_Id, string /*1*/pCuenta_Id, string /*2*/pCentro1_Id, string /*3*/pCentro2_Id, string /*4*/pDetalle, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pCuenta_Id, /*2*/pCentro1_Id, /*3*/pCentro2_Id, /*4*/pDetalle };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comProvCtasContrapInsertar", parametros);
        }




    }
}
