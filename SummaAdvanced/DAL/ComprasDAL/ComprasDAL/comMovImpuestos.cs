using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovImpuestos
    {
        public static comMovImpuestosDS Datos(long /*0*/pcomMovProv, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovImpuestosDatos", parametros);

            comMovImpuestosDS dsTipado = new comMovImpuestosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovImpuestosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pcomMovProv, int /*1*/pconRenglon, string /*2*/pImpuesto_Id, 
            decimal /*3*/pPorcentaje, decimal /*4*/pBase_Imponible, decimal /*5*/pImporte_Impuesto, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pconRenglon, /*2*/pImpuesto_Id, /*3*/pPorcentaje,
                /*4*/pBase_Imponible, /*5*/pImporte_Impuesto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovImpuestosGuardar", parametros);
        }
    }
}
