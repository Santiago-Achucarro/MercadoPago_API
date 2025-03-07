using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
 public   class comLibrosImpuestos
    {

        public static comLibrosImpuestosDS Datos(int /*0*/pcomLibros, int /*1*/pColumna, string /*2*/pImpuesto_Id, string /*3*/pTipoRenglon, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomLibros, new Generalidades.NullableInt(/*1*/pColumna), new Generalidades.NullableString(/*2*/pImpuesto_Id), new Generalidades.NullableString(/*3*/pTipoRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comLibrosImpuestosDatos", parametros);

            comLibrosImpuestosDS dsTipado = new comLibrosImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pcomLibros, int /*1*/pColumna, string /*2*/pImpuesto_Id, string /*3*/pTipoRenglon, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomLibros, new Generalidades.NullableInt(/*1*/pColumna), new Generalidades.NullableString(/*2*/pImpuesto_Id), new Generalidades.NullableString(/*3*/pTipoRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comLibrosImpuestosEliminar", parametros);
        }




        public static void Guardar(int /*0*/pcomLibros, int /*1*/pColumna, string /*2*/pImpuesto_Id, string /*3*/pTipoRenglon, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomLibros, /*1*/pColumna, /*2*/pImpuesto_Id, /*3*/pTipoRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comLibrosImpuestosGuardar", parametros);
        }



    }
}
