using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueConceptosPropValor
    {
        public static sueConceptosPropValorDS Datos(int /*0*/pConcepto_Id, int /*1*/pPropiedad, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pConcepto_Id, /*1*/pPropiedad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueConceptosPropValorDatos", parametros);

            sueConceptosPropValorDS dsTipado = new sueConceptosPropValorDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pConcepto_Id, int /*1*/pPropiedad, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pConcepto_Id, new Generalidades.NullableInt(/*1*/pPropiedad) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueConceptosPropValorEliminar", parametros);
        }

        public static void Guardar(int /*0*/pConcepto_Id, string /*1*/pPropiedad, bool /*2*/pSiNo, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pConcepto_Id, /*1*/pPropiedad, /*2*/pSiNo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueConceptosPropValorGuardar", parametros);
        }

    }
}
