using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comRIPendAuto
    {
        public static comReqInternoPendAutoDS Datos(int /*0*/Empresa_Id, int /*1*/pUsuario, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/pUsuario };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comReqInternoPendAuto", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "comReqInterno", "SegmentoStr", "Proveed_Id", "RazonSocial", "Total" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "TipoPermiRI_Id", "DescripcionTipoPermiRI", "Observaciones", "Proveed_Id", "DescripcionProveedores" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed", "Producto_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed", "SubCategoria_Id", "DescripcionSubCategorias", "Detalle", "Categoria_Id", "DescripcionCategoria" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula", "genUsuarios" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            comReqInternoPendAutoDS dsTipado = new comReqInternoPendAutoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.RIPrincipal.TableName, dsTipado.RICuerpoArti.TableName, dsTipado.RICuerpoMemo.TableName, dsTipado.RIAutorizando.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }







        public static void Guardar(int /*0*/pComReqInterno, string /*1*/pEstado_Id, int /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pComReqInterno, /*1*/pEstado_Id, /*2*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comReqInternoCambiarEstado", parametros);
        }


    }
}
