using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesGanCuerpo
    {
        public static tesGanCuerpoDS Datos(int /*0*/pTabla_Id, decimal /*1*/pHasta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesGanCuerpoDatos", parametros);

            tesGanCuerpoDS dsTipado = new tesGanCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pTabla_Id, decimal /*1*/pHasta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, new Generalidades.NullableDecimal(/*1*/pHasta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesGanCuerpoEliminar", parametros);
        }
        public static void Guardar(int /*0*/pTabla_Id, decimal /*1*/pHasta, decimal /*2*/pPorcentaje, decimal /*3*/pMinimo, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pHasta, /*2*/pPorcentaje, /*3*/pMinimo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesGanCuerpoGuardar", parametros);
        }
    }
}
