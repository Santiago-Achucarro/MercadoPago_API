using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCFDICobranzaRel
    {
        public static tesCFDICobranzaRelDS Datos(int /*0*/ptesCFDICobranza, int /*1*/ptesCFDICobranzaR, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCFDICobranza, new Generalidades.NullableInt(/*1*/ptesCFDICobranzaR) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCFDICobranzaRelDatos", parametros);

            tesCFDICobranzaRelDS dsTipado = new tesCFDICobranzaRelDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/ptesCFDICobranza, int /*1*/ptesCFDICobranzaR, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCFDICobranza, /*1*/ptesCFDICobranzaR };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesCFDICobranzaRelEliminar", parametros);
        }

        public static void Guardar(int /*0*/ptesCFDICobranza, int /*1*/ptesCFDICobranzaR, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCFDICobranza, /*1*/ptesCFDICobranzaR };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesCFDICobranzaRelGuardar", parametros);
        }



    }
}
