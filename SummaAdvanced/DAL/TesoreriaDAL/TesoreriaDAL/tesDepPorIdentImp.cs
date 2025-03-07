using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesDepPorIdentImp
    {

        public static tesDepoPorIdentImpDS Datos(long /*0*/ptesMovimientos, string /*1*/pImpuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableString(/*1*/pImpuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesDepoPorIdentImpDatos", parametros);

            tesDepoPorIdentImpDS dsTipado = new tesDepoPorIdentImpDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/ptesMovimientos, string /*1*/pImpuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableString(/*1*/pImpuesto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesDepoPorIdentImpEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesMovimientos, string /*1*/pImpuesto_Id, decimal /*2*/pBaseImponible, decimal /*3*/pImporte, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pImpuesto_Id, /*2*/pBaseImponible, /*3*/pImporte };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesDepoPorIdentImpGuardar", parametros);
        }


    }
}
