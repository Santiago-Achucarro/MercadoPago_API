using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conBaseDistri
    {
        public static conBaseDistriDS Datos(string /*0*/pBase_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pBase_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conBaseDistriDatos", parametros);

            conBaseDistriDS dsTipado = new conBaseDistriDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName,
                dsTipado.grdconBaseCentro.TableName };

            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pBase_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pBase_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conBaseDistriEliminar", parametros);
        }

        public static int Guardar(string /*0*/pBase_Id, string /*1*/pBase_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pMedida_Id, bool /*5*/pInactivo, int /*6*/pUsuario_Id, bool /*7*/pPosteado, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pBase_Id, /*1*/pBase_Id_Nuevo,
                new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pMedida_Id, /*5*/pInactivo,
                new Generalidades.NullableInt(/*6*/pUsuario_Id), /*7*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("conBaseDistriGuardar", parametros));
        }
    }
}
