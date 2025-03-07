using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venLPTablaCuerpo
    {
        public static venLPTabCuerpoDS Datos(int /*0*/pTabla_Id, decimal /*1*/pHasta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venLPTabCuerpoDatos", parametros);

            venLPTabCuerpoDS dsTipado = new venLPTabCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pTabla_Id, decimal /*1*/pHasta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venLPTabCuerpoEliminar", parametros);
        }
        public static void Guardar(int /*0*/pTabla_Id, decimal /*1*/pHasta, decimal /*2*/pValor, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pHasta, /*2*/pValor };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venLPTabCuerpoGuardar", parametros);
        }


        public static venLPTabCuerpoValorDS Valor(int /*0*/pTabla_Id, decimal /*1*/pHasta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venLPTabCuerpoValor", parametros);

            venLPTabCuerpoValorDS dsTipado = new venLPTabCuerpoValorDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }






    }
}
