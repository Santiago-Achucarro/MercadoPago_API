using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using VentasCommon;
using interfaceDAAB;

namespace VentasDAL
{
  public  class venLibrosColumnas
    {

        public static venLibrosColumnasDS Datos(int /*0*/pvenLibros, int /*1*/pColumna, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenLibros, new Generalidades.NullableInt(/*1*/pColumna) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venLibrosColumnasDatos", parametros);

            venLibrosColumnasDS dsTipado = new venLibrosColumnasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pvenLibros, int /*1*/pColumna, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenLibros, new Generalidades.NullableInt(/*1*/pColumna) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venLibrosColumnasEliminar", parametros);
        }





        public static void Guardar(int /*0*/pvenLibros, int /*1*/pColumna, string /*2*/pTitulo, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenLibros, /*1*/pColumna, /*2*/pTitulo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venLibrosColumnasGuardar", parametros);
        }




    }
}
