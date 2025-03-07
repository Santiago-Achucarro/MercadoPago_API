using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;
namespace ProduccionDAL
{
    public class proMovCierreOrden
    {
        public static proMovCierreOrdenDS Datos(long /*0*/pproMovCierreOrden, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proMovCierreOrdenDatos", parametros);

            string[] camposTabla0 = { "proOrden", "Causa_Id", "DescripcionCausas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proMovCierreOrdenDS dsTipado = new proMovCierreOrdenDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pproMovCierreOrden, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proMovCierreOrdenEliminar", parametros);
        }

        public static void Guardar(long /*0*/pproMovCierreOrden, int /*1*/pproOrden, decimal /*2*/pCantidad, bool /*3*/pParcial, string /*4*/pCausa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, new Generalidades.NullableInt(/*1*/pproOrden), /*2*/pCantidad, /*3*/pParcial, /*4*/pCausa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proMovCierreOrdenGuardar", parametros);
        }


    }
}
