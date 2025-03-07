using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proProgramaCuerpo
    {
        public static proProgramasCuerpoDS Datos(int /*0*/pproProgramas, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproProgramas };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proProgramasCuerpoDatos", parametros);

            string[] camposTabla0 = { "Producto_Id", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proProgramasCuerpoDS dsTipado = new proProgramasCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pproProgramas, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproProgramas, new Generalidades.NullableInt(/*1*/pRenglon) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proProgramasCuerpoEliminar", parametros);
        }

        public static void Guardar(int /*0*/pproProgramas, int /*1*/pRenglon, string /*2*/pProducto_Id, decimal /*3*/pCantidad, string /*4*/pObservaciones, DateTime /*5*/pFechaNecesidad, bool /*6*/pConfirmado, string /*7*/pReceta_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproProgramas, /*1*/pRenglon, /*2*/pProducto_Id, /*3*/pCantidad, /*4*/pObservaciones, /*5*/pFechaNecesidad, /*6*/pConfirmado, /*7*/pReceta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proProgramasCuerpoGuardar", parametros);
        }

        public static proProgramasCuerpoDS DatosPend(int /*0*/pproProgramas,  DateTime pFechaDesde, DateTime pFechaHasta,  string pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproProgramas, pFechaDesde, pFechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proProgramasCuerpoPendDatos", parametros);

            string[] camposTabla0 = { "Producto_Id", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proProgramasCuerpoDS dsTipado = new proProgramasCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Confirrmar(int /*0*/pproProgramas, int /*1*/pRenglon, bool /*2*/pConfirmado, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproProgramas, /*1*/pRenglon, /*2*/pConfirmado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proProgramasCuerpoConfirmar", parametros);
        }


    }
}
