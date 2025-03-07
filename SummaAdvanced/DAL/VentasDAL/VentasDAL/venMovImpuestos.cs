using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;
using VentasDAL;

namespace VentasDAL
{
    public static class venMovImpuestos
    {
        public static venMovImpuestosDS Datos(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovImpuestosDatos", parametros);

            string[] camposTabla0 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovImpuestosDS dsTipado = new venMovImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovImpuestosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pconRenglon, string /*2*/pImpuesto_Id, 
            decimal /*3*/pPorcentaje, decimal /*4*/pBaseImponible, decimal /*5*/pImporte, decimal /*6*/pBaseImponibleMonedaNac, 
            string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pconRenglon, /*2*/pImpuesto_Id, /*3*/pPorcentaje, 
                /*4*/pBaseImponible, /*5*/pImporte, /*6*/pBaseImponibleMonedaNac };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovImpuestosGuardar", parametros);
        }
    }
}
