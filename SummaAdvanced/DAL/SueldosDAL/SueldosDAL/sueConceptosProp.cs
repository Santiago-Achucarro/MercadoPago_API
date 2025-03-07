using SueldosCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldosDAL
{
    public class sueConceptosProp
    {
        public static int Guardar(string /*0*/pPropiedad, string /*1*/pPropiedad_Nuevo, int /*2*/pOrden, string /*3*/pDescripcion, string /*4*/pAgrupamiento, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPropiedad, /*1*/pPropiedad_Nuevo, /*2*/pOrden, /*3*/pDescripcion, /*4*/pAgrupamiento };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("sueConceptosPropGuardar", parametros));
        }

        public static void Eliminar(string /*0*/pPropiedad, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pPropiedad) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueConceptosPropEliminar", parametros);
        }

        public static sueConceptosPropTodosDS DatosTodos(int pEmpresa_Id , string /*0*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueConceptosPropTodosDatos", parametros);

            sueConceptosPropTodosDS dsTipado = new sueConceptosPropTodosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Propiedades.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueConceptosPropValorTieneInfoDS TieneInfo(string /*0*/pPropiedad, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPropiedad };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueConceptosPropValorTieneInfo", parametros);

            sueConceptosPropValorTieneInfoDS dsTipado = new sueConceptosPropValorTieneInfoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
