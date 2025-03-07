using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comLibrosColumnas
    {

        public static comLibrosColumnasDS Datos(int /*0*/pcomLibros, int /*1*/pColumna, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomLibros, new Generalidades.NullableInt(/*1*/pColumna) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comLibrosColumnasDatos", parametros);

            comLibrosColumnasDS dsTipado = new comLibrosColumnasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pcomLibros, int /*1*/pColumna, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomLibros, new Generalidades.NullableInt(/*1*/pColumna) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comLibrosColumnasEliminar", parametros);
        }

        public static void Guardar(int /*0*/pcomLibros, int /*1*/pColumna, string /*2*/pTitulo, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomLibros, /*1*/pColumna, /*2*/pTitulo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comLibrosColumnasGuardar", parametros);
        }




    }
}
