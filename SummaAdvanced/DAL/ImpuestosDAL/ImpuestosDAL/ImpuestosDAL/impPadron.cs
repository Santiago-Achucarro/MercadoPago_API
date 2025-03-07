using ImpuestosCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ImpuestosDAL
{
    public class impPadron
    {
        public static impPadronDS Datos(string /*0*/pPadron_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPadron_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impPadronDatos", parametros);

            string[] camposTabla0 = { "ValorRetorno", "Empresa_Id", "PTodasEmpresas", "ColBusqueda", "ColBusquedaValor" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            impPadronDS dsTipado = new impPadronDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pPadron_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pPadron_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impPadronEliminar", parametros);
        }
        public static int Guardar(string /*0*/pPadron_Id, string /*1*/pPadron_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pEmpresa_Id, string /*4*/pTabla, string /*5*/pPeriodo, string /*6*/pColCuit, string /*7*/pColAnio, string /*8*/pColPeriodo, string /*9*/pColBusqueda, string /*10*/pColBusquedaValor, string /*11*/pColDevolucion, bool /*12*/pInactivo, bool /*13*/pPosteado, int /*14*/pUsuario_Id, string /*15*/pStoreProcedure, string /*16*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPadron_Id, /*1*/pPadron_Id_Nuevo, /*2*/pDescripcion, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pTabla, /*5*/pPeriodo, /*6*/pColCuit, /*7*/pColAnio, /*8*/pColPeriodo, new Generalidades.NullableString(/*9*/pColBusqueda), new Generalidades.NullableString(/*10*/pColBusquedaValor), /*11*/pColDevolucion, /*12*/pInactivo, /*13*/pPosteado, /*14*/pUsuario_Id, /*15*/pStoreProcedure };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

        
            return (int) oiDAAB.guardar("impPadronGuardar", parametros);
        }


        

        public static decimal Buscar(string /*0*/pPadron_Id, string /*1*/pCuit, short /*2*/pAnio, short /*3*/pPeriodo, 
            string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPadron_Id, /*1*/pCuit, /*2*/pAnio, /*3*/pPeriodo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((decimal)oiDAAB.guardar("impPadronBuscar", parametros));
        }

        public static Int32 EstaEn(string /*0*/pPadron_Id, string /*1*/pCuit, short /*2*/pAnio, short /*3*/pPeriodo, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPadron_Id, /*1*/pCuit, /*2*/pAnio, /*3*/pPeriodo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((Int32)oiDAAB.guardar("impPadronEstaEn", parametros));
        }
    }
}
