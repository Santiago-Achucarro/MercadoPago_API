using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueConvenio
    {
        public static sueConvenioDS Datos(string /*0*/pConvenio_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pConvenio_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueConvenioDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "PTodasEmpresas", "TablaVac_Id", "DescripcionVacacion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueConvenioDS dsTipado = new sueConvenioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pConvenio_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pConvenio_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueConvenioEliminar", parametros);
        }

        public static int Guardar(string /*0*/pConvenio_Id, string /*1*/pConvenio_Id_Nueva, string /*2*/pDescripcion, bool /*3*/pInactivo,
            bool /*4*/pPosteado, int /*5*/pUsuario_Id, int /*6*/pEmpresa_Id, string /*7*/pTablaVac_Id, bool /*8*/pSindicalizado, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pConvenio_Id, /*1*/pConvenio_Id_Nueva, /*2*/pDescripcion, /*3*/pInactivo, /*4*/pPosteado,
                new Generalidades.NullableInt(/*5*/pUsuario_Id), new Generalidades.NullableInt(/*6*/pEmpresa_Id), /*7*/pTablaVac_Id, /*8*/pSindicalizado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueConvenioGuardar", parametros);
        }

    }
}
