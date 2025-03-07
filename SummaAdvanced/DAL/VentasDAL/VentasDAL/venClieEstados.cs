using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venClieEstados
    {
        public static venClieEstadosDS Datos(string /*0*/pEstado_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEstado_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venClieEstadosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Cuenta_Id", "DescripcionCuentas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venClieEstadosDS dsTipado = new venClieEstadosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pEstado_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pEstado_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venClieEstadosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pEstado_Id, string /*1*/pEstado_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pCuenta_Id,
            bool /*5*/pReservado, bool /*6*/pImpideOperaciones, bool /*7*/pInactivo, int /*8*/pUsuario_Id, bool /*9*/pPosteado, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEstado_Id, /*1*/pEstado_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion,
                new Generalidades.NullableString(/*4*/pCuenta_Id), /*5*/pReservado, /*6*/pImpideOperaciones, /*7*/pInactivo, /*8*/pUsuario_Id,
                /*9*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("venClieEstadosGuardar", parametros));
        }

    }
}
